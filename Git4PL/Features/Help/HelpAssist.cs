using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Git4PL.PLSqlDeveloper;

namespace Git4PL
{
    /*
     * 1.   Справка chm вшита в dll плагина.
     * 2.   Файл справки chm должен быть сохранен на диске, чтобы была возможность его открыть. HelpAssist помогает с этим.
     * 3.   Если в справку были добавлены изменения, то необходимо поменять номер сборки плагина в AssemblyInfo.cs
     *      Что бы справка пересоздалась заново на той машине, где она уже использовалась.
     */
    public static class HelpAssist
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private const string HELPFILE_NAME = "Git4PLHelp";
        private const string HELPFILE_EXTENSION_NAME = "chm";

        private static readonly string HELPFILE_FULLPATH;

        static HelpAssist()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);

            // В имени справка присутствует номер сборки плагина. Это индетификатор последней версии справки chm.
            HELPFILE_FULLPATH = Path.Combine(PluginBuilder.GIT4PL_FOLDER_PATH, $"{HELPFILE_NAME}_{fvi.FileVersion.Replace('.', '_')}.{HELPFILE_EXTENSION_NAME}");
        }

        /// <summary>
        /// Получить путь расположения справки
        /// </summary>
        /// <returns></returns>
        public static string GetUrl()
        {
            // При изменении версии сборки справка будет пересоздаваться
            if (!File.Exists(HELPFILE_FULLPATH))
            {
                // Если справка отсутствует выгружаем её из dll в директорию плагина
                var data = Properties.Resources.Git4PL;
                using (var stream = new FileStream(HELPFILE_FULLPATH, FileMode.Create))
                {
                    stream.Write(data, 0, data.Count());
                    stream.Flush();
                }
                RemoveOldHelpFiles();
            }
            return HELPFILE_FULLPATH;
        }

        /// <summary>
        /// Удаляет старую версию справки. 
        /// В имени справка присутствует номер сборки плагина. Это индетификатор последней версии справки chm.
        /// </summary>
        private static void RemoveOldHelpFiles()
        {
            string[] files = Directory.GetFiles(PluginBuilder.GIT4PL_FOLDER_PATH, $"{HELPFILE_NAME}*.{HELPFILE_EXTENSION_NAME}", SearchOption.TopDirectoryOnly);
            foreach (string item in files.Where(x => x != HELPFILE_FULLPATH))
                File.Delete(item);
        }
    }
}
