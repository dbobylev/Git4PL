using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Git4PL.PLSqlDeveloper;

namespace Git4PL
{
    public enum LogLevelType
    {
        [Description("Логирование отключено")]
        Disable = 0,
        [Description("Trace")]
        Trace = 1,
        [Description("Debug")]
        Debug = 2,
        [Description("Info")]
        Info = 3,
        [Description("Warn")]
        Warn = 4,
        [Description("Error")]
        Error = 5,
        [Description("Fatal")]
        Fatal = 6
    }

    public static class NlogAssist
    {
        private const string LOGGER_FILE_TARGET_NAME = "FileTarget";
        private const string LOGGER_DEBUGER_TARGET_NAME = "DebugerTarget";

        public static void InitializeNlog()
        {
            string path = Path.Combine(PluginBuilder.LOGS_FOLDER_PATH, FileNameCreator());
            var config = new NLog.Config.LoggingConfiguration();

            // Target - запись в файл
            var fileTarget = new NLog.Targets.FileTarget(LOGGER_FILE_TARGET_NAME)
            {
                FileName = path,
                Layout = "${longdate} | ${uppercase:${level}} | ${logger}: ${message} ${exception}",
            };
            AddTarger(fileTarget, config);

#if DEBUG
            // Target - запись в dubug window VS
            var debugerTarget = new NLog.Targets.DebuggerTarget(LOGGER_DEBUGER_TARGET_NAME)
            {
                Layout = "${uppercase:${level}} | ${logger}: ${message} ${exception}"
            };
            AddTarger(debugerTarget, config);
#endif
            NLog.LogManager.Configuration = config;
            SetLogLevel((LogLevelType)Properties.Settings.Default.LogLevel);
        }

        private static void AddTarger(NLog.Targets.Target target, NLog.Config.LoggingConfiguration config)
        {
            config.AddTarget(target);
            var loggingRule = new NLog.Config.LoggingRule("*", target);
            loggingRule.SetLoggingLevels(NLog.LogLevel.Trace, NLog.LogLevel.Fatal);
            config.LoggingRules.Add(loggingRule);
        }

        public static void SetLogLevel(LogLevelType loglevelType)
        {
            for (int i = 0; i < NLog.LogManager.Configuration.LoggingRules.Count; i++)
                NLog.LogManager.Configuration.LoggingRules[i].DisableLoggingForLevels(NLog.LogLevel.Trace, NLog.LogLevel.Fatal);
            try
            {
                NLog.LogLevel ll;
                switch (loglevelType)
                {
                    case LogLevelType.Disable:
                        NLog.LogManager.ReconfigExistingLoggers();
                        return;
                    case LogLevelType.Trace:
                        ll = NLog.LogLevel.Trace;
                        break;
                    case LogLevelType.Debug:
                        ll = NLog.LogLevel.Debug;
                        break;
                    case LogLevelType.Info:
                        ll = NLog.LogLevel.Info;
                        break;
                    case LogLevelType.Warn:
                        ll = NLog.LogLevel.Warn;
                        break;
                    case LogLevelType.Error:
                        ll = NLog.LogLevel.Error;
                        break;
                    case LogLevelType.Fatal:
                        ll = NLog.LogLevel.Fatal;
                        break;
                    default:
                        return;
                }
                for (int i = 0; i < NLog.LogManager.Configuration.LoggingRules.Count; i++)
                {
                    NLog.LogManager.Configuration.LoggingRules[i].EnableLoggingForLevels(ll, NLog.LogLevel.Fatal);
                    NLog.LogManager.ReconfigExistingLoggers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static string FileNameCreator()
        {
            return $"{DateTime.Now.ToString("yyyy-MM-dd_HH-mm")}_log.txt";
        }
    }
}
