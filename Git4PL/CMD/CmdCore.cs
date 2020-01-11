using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.CMD
{
    abstract class CmdCore
    {
        protected readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        // Кол-во прочитанных строк
        private int CntRows;
        // Название процесса
        readonly string Name;
        // Исполняемая файл (прим git.exe)
        protected string FileName;
        // Аргументы для вызова
        protected string Args;

        // Класс который отвечает за интерпритацию результата консольной команды
        protected ICmdReader Reader;

        protected CmdCore(string _Name)
        {
            Name = _Name;
        }

        public void Run()
        {
            BeforeProcess();

            try
            {
                string ErrorMsg;
                using (Process p = GetNewProcces())
                {
                    p.Start();
                    CntRows = Reader.ReadProcess(p);
                    ErrorMsg = p.StandardError.ReadToEnd();
                    p.WaitForExit();
                }
                if (!string.IsNullOrEmpty(ErrorMsg))
                    throw new Git4PLException(ErrorMsg);
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"При выполнении процесса {Name} произошла ошибка: {ex.Message}");
                OnErrorOccurred();
                throw;
            }

            AfterProcess();
        }

        public T GetResult<T>() => Reader.GetResult<T>();

        protected virtual void BeforeProcess()
        {
            logger.Debug($"Запускаем процесс командной строки: {Name}");
        }
        protected virtual void AfterProcess()
        {
            logger.Debug($"Процесс завершен. Прочитано: {CntRows}");
        }
        protected virtual void OnErrorOccurred() { }

        private Process GetNewProcces()
        {
            logger.Trace("Создаём новый процесс");
            logger.Trace($"ProcessName={FileName}");
            logger.Trace($"Args={Args}");
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.StandardOutputEncoding = new UTF8Encoding();
            p.StartInfo.FileName = FileName;
            p.StartInfo.Arguments = Args;
            return p;
        }
    }
}
