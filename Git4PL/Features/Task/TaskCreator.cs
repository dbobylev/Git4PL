using Git4PL.Features.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Git4PL.Features.Task
{
    public static class TaskCreator
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static TaskInfo Create(string taskString)
        {
            logger.Debug("Запрос на создание TaskInfo, строка: {0}", taskString);

            if (string.IsNullOrEmpty(taskString))
                return null;
            else if (IsWebTask(taskString))
                return new TaskInfoWEB(taskString);
            else if (IsDBTask(taskString))
                return new TaskInfoDB(taskString);
            throw new Git4PLException($"Не удалось распознать ID задачи в строке: {taskString}");
        }

        private static bool IsDBTask(string source)
        {
            Regex r = new Regex(Constants.Instance.PATTERN_ISDBTASK);
            return r.IsMatch(source);
        }

        private static bool IsWebTask(string source)
        {
            Regex r = new Regex(Constants.Instance.PATTERN_ISWEBTASK, RegexOptions.IgnoreCase);
            return r.IsMatch(source);
        }
    }
}
