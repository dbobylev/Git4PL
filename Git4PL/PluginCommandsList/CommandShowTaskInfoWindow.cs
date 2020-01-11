using Git4PL.PLSqlDeveloper.IDECallBacks;
using Git4PL.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git4PL.Features.Task;

namespace Git4PL.PluginCommandsList
{
    class CommandShowTaskInfoWindow : ICommand
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public string Name { get; } = "Окно. TaskInfo";

        private string taskId;

        public CommandShowTaskInfoWindow(string _taskId)
        {
            taskId = _taskId;
        }

        public void Perform()
        {
            if (FormTaskInfo.IsOpen)
                return;
            TaskInfo ti =  TaskCreator.Create(taskId ?? Callbacks.GetSelectedText());

            if (ti == null)
                return;

            logger.Trace("Данные по задаче:");
            logger.Trace(string.Join("\r\n", new[] { ti.Description, ti.Title, ti.AssignedTo, ti.Status, ti.DateBegin.ToString(), ti.DateEnd.ToString() }));
            using (FormTaskInfo fti = new FormTaskInfo(ti))
                fti.ShowDialog();
        }
    }
}
