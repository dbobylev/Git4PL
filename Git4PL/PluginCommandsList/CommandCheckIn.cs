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
    class CommandCheckIn : ICommand
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public string Name { get; } = "Операция. Check In";

        DbObjectText dbObject;
        string branchName;

        public CommandCheckIn(DbObjectText _dbObject = null, string _branchName = null)
        {
            dbObject = _dbObject;
            branchName = _branchName;
        }

        public void Perform()
        {
            if (dbObject == null)
                dbObject = Callbacks.GetDbObject<DbObjectText>();
            else
                dbObject.DirectoriesChecks();

            if (branchName == null)
                branchName = CMD.CmdAPI.GetCurrentBranch();

            if (Warnings.IsBranchUnexsepted(branchName))
                return;

            string FilePath = dbObject.GetRawFilePath();
            logger.Debug("FilePath={0}", FilePath);

            File.WriteAllText(FilePath, dbObject.Text, dbObject.GetSaveEncoding());
            Callbacks.SetStatusMessage($"Объект БД сохранён в: {FilePath}");
            logger.Info("Конец процесса Check In");
        }
    }
}
