using Git4PL.Features.Settings;
using Git4PL.PLSqlDeveloper.SQL;
using System;
using System.Text.RegularExpressions;

namespace Git4PL.Features.Task
{
    public class TaskInfo
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public string ID { get; protected set; }

        [SQL(ColumnName = "C1")]
        public string Title { get; protected set; }

        [SQL(ColumnName = "C2")]
        public string Description { get; protected set; }

        [SQL(ColumnName = "C3")]
        public string AssignedTo { get; protected set; }

        [SQL(ColumnName = "C4")]
        public string Status { get; protected set; }

        [SQL(ColumnName = "C5")]
        public DateTime DateBegin { get; set; }

        [SQL(ColumnName = "C6")]
        public DateTime DateEnd { get; protected set; }

        public TaskInfo()
        {

        }

        public virtual void Open()
        {
            logger.Trace("Открываем задачу: {0}", ID);
        }
    } 
}
