using Git4PL.CMD.CmdReaders;
using Git4PL.Features.GitDiff;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.CMD.CmdRequests
{
    class CMD_GitDiff : CmdBuilderGIT
    {
        readonly DbObjectText dbObj;
        private string tmpPath;

        public CMD_GitDiff(DbObjectText _dbObj):base("Git diff")
        {
            Reader = new CmdReadDiffText();
            dbObj = _dbObj;
        }

        private void DeleteTempFile()
        {
            if (File.Exists(tmpPath))
              File.Delete(tmpPath);
            logger.Debug($"Временный файл удалён. path: {tmpPath}");
        }

        protected override void BeforeProcess()
        {
            tmpPath = $"{dbObj.GetRawFilePath()}.tmp";

            logger.Debug($"Создаём временный файл. path: {tmpPath}");
            File.WriteAllText(tmpPath, dbObj.Text, dbObj.GetSaveEncoding());
            logger.Debug("Временный файл создан");

            AddArgument("diff");
            AddArgumentCrAtEol();
            AddArgumentSpaceAtEol();
            AddArgument("--no-index");
            AddArgument($"\"{dbObj.GetRawFilePath()}\"");
            AddArgument($"\"{tmpPath}\"");

            base.BeforeProcess();
        }
        protected override void AfterProcess()
        {
            base.AfterProcess();

            DeleteTempFile();
        }
        protected override void OnErrorOccurred()
        {
            base.OnErrorOccurred();

            DeleteTempFile();
        }
    }
}
