using Git4PL.Features.GitDiff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git4PL.CMD.CmdRequests;

namespace Git4PL.CMD
{
    public static class CmdAPI
    {
        /// <summary>
        /// Выполнить консольную команду и вернуть результат
        /// </summary>
        /// <typeparam name="T">Тип ожидаемого результата</typeparam>
        /// <param name="process">Класс запроса CmdRequest</param>
        /// <returns></returns>
        private static T PerformProcess<T>(CmdCore process)
        {
            process.Run();
            return process.GetResult<T>();
        }

        /// <summary>
        /// Сравнение обекта PL/SQL Developer с версией в локальном репозитории git
        /// </summary>
        /// <param name="dbObj"></param>
        /// <returns></returns>
        public static DiffText GitDiff(DbObjectText dbObj)
        {
            return PerformProcess<DiffText>(new CMD_GitDiff(dbObj));
        }

        /// <summary>
        /// Получить название текущей ветки в локальном резпозитории git
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentBranch()
        {
            return PerformProcess<string>(new CMD_GitGetCurrentBranch());
        }

        /// <summary>
        /// Вернуть результат операции git blame для заданного файла, для заданных строк
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="beginLine"></param>
        /// <param name="endline"></param>
        /// <returns></returns>
        public static string GitBlame(string FileName, int beginLine, int endline = -1)
        {
            return PerformProcess<string>(new CMD_GitBlame(FileName, beginLine, endline));
        }

        /// <summary>
        /// Показать информацию о комите по его ключу
        /// </summary>
        /// <param name="sha">Ключ комита</param>
        /// <param name="shortstat">Показать только краткую статистику (используется для очень объемных комитов)</param>
        /// <returns></returns>
        public static string GitShowCommit(string sha, bool shortstat = false)
        {
            return PerformProcess<string>(new CMD_GitShowCommit(sha, shortstat));
        }

        /// <summary>
        /// Сравнить файл между версиями в двух указанных ветках репозитория
        /// </summary>
        /// <param name="SqlFile">Путь до файла в локальном репозитории git</param>
        /// <param name="branch1"></param>
        /// <param name="branch2"></param>
        /// <returns></returns>
        public static DiffText CompareTwoBranches(string SqlFile, string branch1, string branch2)
        {
            return PerformProcess<DiffText>(new CMD_GitCompareBranches(SqlFile, branch1, branch2));
        }

        /// <summary>
        /// Получить список файлов которые отличаются между версиями двух указанных веток
        /// </summary>
        /// <param name="branch1"></param>
        /// <param name="branch2"></param>
        /// <returns></returns>
        public static List<string> GetModifiedFiles(string branch1, string branch2)
        {
            return PerformProcess<List<string>>(new CMD_GitModifiedFiles(branch1, branch2));
        }

        /// <summary>
        /// Проверяем существует ли данная ветка в репозитории
        /// </summary>
        /// <param name="BranchName"></param>
        /// <returns></returns>
        public static bool VerifyBracch(string BranchName)
        {
            return PerformProcess<bool>(new CMD_Verify(BranchName));
        }
    }
}