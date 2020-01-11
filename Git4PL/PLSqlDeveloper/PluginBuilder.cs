using System;
using System.IO;
using System.Windows.Forms;
using Git4PL.Features.Task;
using Git4PL.PLSqlDeveloper.IDECallBacks;

namespace Git4PL.PLSqlDeveloper
{
    class PluginBuilder
    {
        private const string GIT4PL_FOLDER_NAME = "Git4PL";
        private const string DBTASK_FOLDER_NAME = "DbTask";
        private const string LOGS_FOLDER_NAME = "Logs";

        public static readonly string GIT4PL_FOLDER_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), GIT4PL_FOLDER_NAME);
        public static readonly string LOGS_FOLDER_PATH = Path.Combine(GIT4PL_FOLDER_PATH, LOGS_FOLDER_NAME);
        public static readonly string DBTASK_FOLDER_PATH = Path.Combine(GIT4PL_FOLDER_PATH, DBTASK_FOLDER_NAME);

        public string GetPluginName { get; } = "Git4PL";
        public string GetAboutInfo { get; } = "Плагин для работы с Git";
        public int PluginID { get; set; }
        public MenuBuilder Menu { get; private set; }

        public PluginBuilder()
        {
            try
            {
                CheckDirectories();
                RemoveOldLogs();
                RemoveTasks(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        public void InitializeMenu()
        {
            Menu = new MenuBuilder(Callbacks.Version());
        }

        public void SetIcons()
        {
            Menu.SetIcons(PluginID);
        }

        private void CheckDirectories()
        {
            if (!Directory.Exists(GIT4PL_FOLDER_PATH))
                Directory.CreateDirectory(GIT4PL_FOLDER_PATH);
            if (!Directory.Exists(LOGS_FOLDER_PATH))
                Directory.CreateDirectory(LOGS_FOLDER_PATH);
            if (!Directory.Exists(DBTASK_FOLDER_PATH))
                Directory.CreateDirectory(DBTASK_FOLDER_PATH);
        }
        private void RemoveOldLogs()
        {
            string[] files = Directory.GetFiles(LOGS_FOLDER_PATH);

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                if (fi.CreationTime < DateTime.Now.AddDays(-7))
                    fi.Delete();
            }
        }
        private void RemoveTasks()
        {
            string[] files = Directory.GetFiles(DBTASK_FOLDER_PATH);

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                if (fi.Extension.TrimStart('.').ToUpper() == Features.Settings.Constants.Instance.DBTASK_EXTENSION.ToUpper())
                {
                    fi.Delete();
                }
            }
        }
    }
}
