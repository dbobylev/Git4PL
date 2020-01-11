using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Git4PL.Features.GitDiff
{
    /// <summary>
    /// Работа с текстом объекта БД
    /// </summary>
    class PLSQLCodeFormatter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private string GitText { get; set; }
        private string GitFilePath { get; set; }

        public PLSQLCodeFormatter(string remoteFilePath)
        {
            logger.Trace("Загружаем текст из репозитория GIT");
            GitText = File.ReadAllText(remoteFilePath);
            GitFilePath = remoteFilePath;
            logger.Trace("Текст загружен text.length={0}", GitText.Length);
        }

        public void UpdateBeginOfText(ref string SourceText, string Schema, string Name)
        {
            // cor - create or replace block
            bool DiffChangeCor = Properties.Settings.Default.DiffChangeCor;
            bool DiffChangeName = Properties.Settings.Default.DiffChangeName;
            bool DiffAddSchema = Properties.Settings.Default.DiffAddSchema;

            if (!(DiffChangeCor || DiffChangeName || DiffAddSchema))
                return;

            logger.Trace("Начинаем UpdateBeginOfText");
            logger.Trace("ChangeCor={0}", DiffChangeCor.ToString());
            logger.Trace("ChangeName={0}", DiffChangeName.ToString());
            logger.Trace("DiffAddSchema={0}", DiffAddSchema.ToString());

            string pattern = @"^(?<cor>create or replace[\n\r\s]+\w+[\n\r\s]+(body[\n\r\s]+)?)(?<name>[""]?(" + Schema + @")?[""]?\.?[""]?" + Name + @"[""]?)";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            Match GitMatch = regex.Match(GitText, 0, Math.Min(200, GitText.Length));
            if (!(GitMatch.Groups["cor"].Success && GitMatch.Groups["name"].Success))
            {
                logger.Warn("Не удалось найти совпадение регулярного выраженя в Git файле. pattern={0}", pattern);
                logger.Trace("Конец UpdateBeginOfText");
                return;
            }

            string GitCor = GitMatch.Groups["cor"].Value;
            logger.Trace("GitCor={0}", GitCor);
            string GitName = GitMatch.Groups["name"].Value;
            logger.Trace("GitName={0}", GitName);

            Match dbMatch = regex.Match(SourceText, 0, Math.Min(200, SourceText.Length));
            if (!(dbMatch.Groups["cor"].Success && dbMatch.Groups["name"].Success))
            {
                logger.Warn("Не удалось найти совпадение регулярного выраженя в тексте объекта БД. pattern={0}", pattern);
                logger.Trace("Конец UpdateBeginOfText");
                return;
            }

            Group dbNameGroup = dbMatch.Groups["name"];
            string dbCor = dbMatch.Groups["cor"].Value;
            logger.Trace("dbCor={0}", dbCor);
            string dbName = dbNameGroup.Value;
            logger.Trace("dbName={0}", dbName);

            string textAfterName = SourceText.Substring(dbNameGroup.Index + dbNameGroup.Length);

            string FinalName = DiffChangeName ? GitName : dbName;
            if (DiffAddSchema && !FinalName.Contains('.'))
            {
                logger.Trace("Не найден префикс схемы у объекта БД");
                FinalName = $"{Schema}.{FinalName}";
                logger.Trace("Схема добавлена, FinalName={0}", FinalName);
            }

            logger.Trace("Обновляем тект объекта БД");
            SourceText = $"{(DiffChangeCor ? GitCor : dbCor)}{FinalName}{textAfterName}";

            logger.Trace("Конец UpdateBeginOfText");
        }

        public void UpdateLastLines(ref string SourceText)
        {
            if (!Properties.Settings.Default.DiffWorkWithSlash)
                return;

            logger.Trace("Начинаем UpdateLastLines");
            string pattern = @"[^\*](?<end>[\r\n\s/]+)$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            Match GitMatch = regex.Match(GitText, GitText.Length - Math.Min(100, GitText.Length));
            if (!GitMatch.Groups["end"].Success)
            {
                logger.Warn("Не удалось найти совпадение регулярного выраженя в Git файле. pattern={0}", pattern);
                logger.Trace("Конец UpdateLastLines");
                return;
            }

            string GitEnd = GitMatch.Groups["end"].Value;
            logger.Trace("GitEnd(bytes)={0}", string.Join(",", GitEnd.Select(x => (int)x)));

            Match dbMatch = regex.Match(SourceText, SourceText.Length - Math.Min(100, SourceText.Length));
            if (!dbMatch.Groups["end"].Success)
            {
                logger.Warn("Не удалось найти совпадение регулярного выраженя в тексте объекта БД. pattern={0}", pattern);
                logger.Trace("Конец UpdateLastLines");
                return;
            }
            string dbEnd = dbMatch.Groups["end"].Value;
            logger.Trace("dbEnd(bytes)={0}", string.Join(",", dbEnd.Select(x => (int)x)));

            string TextBeforeEnd = SourceText.Substring(0, dbMatch.Groups["end"].Index);
            logger.Trace("Обновляем тект объекта БД");
            SourceText = $"{TextBeforeEnd}{GitEnd}";
            logger.Trace("Конец UpdateLastLines");
        }

        public void UpdateNewLines(ref string SourceText)
        {
            if (!Properties.Settings.Default.DiffCRLF)
                return;

            logger.Trace("Начало UpdateNewLines");
            string patternR = @"^[^\n]+[^\r][\n]";
            string patternRN = @"^[^\n]+[\r][\n]";
            Regex regexR = new Regex(patternR);
            Regex regexRN = new Regex(patternRN);

            if (regexRN.IsMatch(GitText))
            {
                logger.Trace("В файле Git используется перенос строк CR-LF");
            }
            else if (regexR.IsMatch(GitText))
            {
                logger.Warn("В файле Git используется перенос LF");
                logger.Trace("Заменяем все переносы строк текста с CR-LF на LF");
                SourceText = SourceText.Replace("\r\n", "\n");
            }
            else
            {
                logger.Warn("Не удалось распознать формат переноса строк в файле Git");
            }
            logger.Trace("Конец UpdateNewLines");
        }

        public bool IsBom()
        {
            var bom = new byte[4];
            using (var file = new FileStream(GitFilePath, FileMode.Open, FileAccess.Read))
                file.Read(bom, 0, 4);
            return bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf;
        }

        /// <summary>
        /// Удаляем все символы переноса, пробела и слеша включительно, с конца файла, пока не встретим слеш
        /// </summary>
        /// <param name="SourceText"></param>
        public static void RemoveSlash(ref string SourceText)
        {
            if (!Properties.Settings.Default.DiffWorkWithSlash)
                return;
            logger.Trace("Начинаем RemoveSlash");
            int cnt = 0;
            for (int i = SourceText.Length - 1; i > 0; i--)
            {
                char ch = SourceText[i];
                if (ch == '\r' || ch == '\n' || ch == ' ')
                {
                    cnt++;
                    continue;
                }
                else if (ch == '/')
                {
                    if (SourceText[i - 1] == '*')
                        break;
                    cnt++;
                    logger.Trace("Символ '/' найден. Будет удалено n={0} символов с конца файла", cnt);
                    SourceText = SourceText.Remove(SourceText.Length - cnt);
                    break;
                }
                break;
            }
            logger.Trace("Конец RemoveSlash");
        }

        /// <summary>
        /// Есть ли в название типа объекта слово body
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool HasBodyWord(string text)
        {
            string pattern = @"create or replace[\n\r\s]+\w+[\n\r\s]+body";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            logger.Trace("Проверка на наличие body в название типа, паттерн: {0}", pattern);
            bool hasBody = regex.IsMatch(text);
            logger.Trace("HasBodyWord={0}", hasBody);
            return hasBody;
        }
    }
}

