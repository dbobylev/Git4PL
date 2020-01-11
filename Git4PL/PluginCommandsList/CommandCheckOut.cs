using Git4PL.PLSqlDeveloper.IDECallBacks;
using Git4PL.Features.GitDiff;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git4PL.PluginCommandsList
{
    class CommandCheckOut : ICommand
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public string Name { get; } = "Операция. CheckOut";

        private DbObjectText dbObject;
        private string ServerName;

        public CommandCheckOut(DbObjectText _dbObject = null, string _ServerName = null)
        {
            dbObject = _dbObject;
            ServerName = _ServerName;
        }

        public void Perform()
        {
            if (dbObject == null)
                dbObject = Callbacks.GetDbObject<DbObjectText>();
            else
                dbObject.DirectoriesChecks();

            if (ServerName == null)
                ServerName = Callbacks.GetDatabaseConnection();

            if (Warnings.IsServerUnexsepted(ServerName))
                return;

            string FilePath = dbObject.GetRawFilePath();
            logger.Debug("FilePath={0}", FilePath);

            string LocalText = File.ReadAllText(FilePath);

            PLSQLCodeFormatter.RemoveSlash(ref LocalText);

            Callbacks.SetText(LocalText);
            Callbacks.SetStatusMessage($"Объект БД загружен из: {FilePath}");
            logger.Info("Конец процесса Check Out");
        }
    }
}
