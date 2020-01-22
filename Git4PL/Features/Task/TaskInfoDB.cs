using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Git4PL.Features.Settings;

namespace Git4PL.Features.Task
{
    class TaskInfoDB :TaskInfo
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private string DBTaskPath;

        private readonly string TaskRequestQuery = Constants.Instance.SQL_TASKDB;

        public TaskInfoDB(string taskIsn)
        {
            ID = taskIsn;
            string query = string.Format(TaskRequestQuery, taskIsn);
            if (PLSqlDeveloper.IDECallBacks.Callbacks.SQLQueryExecute(query, out List<TaskInfo> task, out string ErrorMsg))
            {
                if (task.Count == 1)
                {
                    SetTaskInfo(task[0]);
                    DBTaskPath = Path.Combine(PLSqlDeveloper.PluginBuilder.DBTASK_FOLDER_PATH, $"{ID}.{Constants.Instance.DBTASK_EXTENSION}");
                }
            }
            else
            {
                throw new Git4PLException($"Ошибка при выполнении SQL звпроса:\r\n{ErrorMsg}");
            }
        }

        public override void Open()
        {
            base.Open();
            logger.Trace("path={0}", DBTaskPath);
            if (!File.Exists(DBTaskPath))
                File.Create(DBTaskPath);
            Process.Start(DBTaskPath);
        }

        private void SetTaskInfo(TaskInfo t)
        {
            Title = t.Title;
            Description = t.Description;
            AssignedTo = t.AssignedTo;
            Status = t.Status;
            DateBegin = t.DateBegin;
            DateEnd = t.DateEnd;
        }
    }
}
