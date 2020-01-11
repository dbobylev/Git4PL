using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Git4PL.PluginCommandsList;
using Git4PL.Features.GitDiff;

namespace Git4PL
{
    public static class PluginCommands
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private static void Run(ICommand command)
        {
            try
            {
                logger.Info($"Выполняем команду: {command.Name}");
                command.Perform();
                logger.Info($"Конец выполнения: {command.Name}");
            }
            catch(Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        public static void ShowErrorMessage(Exception ex)
        {
            string msg = ex.Message;
            logger.Error(msg);
            logger.Error(ex.StackTrace);
            MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowGitDiffWindow()
        {
            Run(new CommandShowGitDiffWindow());
        }

        public static void ShowSettingsWindow()
        {
            Run(new CommandShowSettingsWindow());
        }

        public static void ShowFtoggle()
        {
            Run(new CommandShowFtoggle());
        }

        public static void CheckOut(DbObjectText dbObject = null, string ServerName = null)
        {
            Run(new CommandCheckOut(dbObject, ServerName));
        }

        public static void CheckIn(DbObjectText dbObject = null, string branchName = null)
        {
            Run(new CommandCheckIn(dbObject, branchName));
        }

        public static void ShowTaskInfoWindow(string taskid)
        {
            Run(new CommandShowTaskInfoWindow(taskid));
        }

        public static void ShowHelp(Control source, string topic)
        {
            Run(new CommandShowHelp(source, topic));
        }

        public static void ShowCommit()
        {
            Run(new CommandShowCommit());
        }

        public static void GitBlame(bool MultiLines = false)
        {
            Run(new CommandShowGitBlame(MultiLines));
        }

        public static void ShowCompareBranches()
        {
            Run(new CommandShowCompareBranches());
        }

        public static void ShowMessageBox(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
