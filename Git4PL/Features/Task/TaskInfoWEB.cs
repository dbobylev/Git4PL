using System;
using System.Globalization;
using Git4PL.Features.Settings;

namespace Git4PL.Features.Task
{
    public class TaskInfoWEB : TaskInfo
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private string SysID;
        private WebTaskType WebTaskType;
        private WebTaskRequest WebTaskAPI;
        private WebTaskContract TaskContract;

        public TaskInfoWEB(string WebTaskID)
        {
            ID = WebTaskID;
            WebTaskType = GetType(ID);
            WebTaskAPI = new WebTaskRequest(ID, WebTaskType);
            TaskContract  = WebTaskAPI.GetWebTask();
            FillInfo(TaskContract);
        }

        public override void Open()
        {
            base.Open();
            string url = string.Format(Constants.Instance.URL_OPENWEBTASK, WebTaskRequest.GetWebTableName(WebTaskType), SysID);
            logger.Debug("url={0}", url);
            System.Diagnostics.Process.Start(url);
        }

        private WebTaskType GetType(string number)
        {
            if (number.ToUpper().Contains(Constants.Instance.PATTERN_WEBTASKTYPE1))
                return WebTaskType.Type1;
            else if (number.ToUpper().Contains(Constants.Instance.PATTERN_WEBTASKTYPE2))
                return WebTaskType.Type2;

            logger.Warn("Неопределен тип задачи: {0}", number);
            return WebTaskType.Type1;
        }

        private void FillInfo(WebTaskContract webTask)
        {
            CultureInfo ci = new CultureInfo("ru-RU");

            Title = webTask.short_description;
            Description = webTask.description;
            if (webTask.assigned_to != null)
                AssignedTo = webTask.assigned_to.display_value;
            Status = webTask.state;
            SysID = webTask.sys_id;

            DateTime tmpDate;
            if (DateTime.TryParse(webTask.opened_at, ci, DateTimeStyles.None, out tmpDate))
                DateBegin = tmpDate;
            if (DateTime.TryParse(webTask.end_date, ci, DateTimeStyles.None, out tmpDate))
                DateEnd = tmpDate;
        }
    }
}