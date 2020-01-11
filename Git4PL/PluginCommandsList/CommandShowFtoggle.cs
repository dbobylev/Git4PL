using Git4PL.PLSqlDeveloper.IDECallBacks;
using Git4PL.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git4PL.Features.FT;

namespace Git4PL.PluginCommandsList
{
    class CommandShowFtoggle : ICommand
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public string Name { get; } = "Окно. Иформация по FT";

        public void Perform()
        {
            string code = Callbacks.GetSelectedText();

            if (!string.IsNullOrEmpty(code) && code.Length < 20)
            {
                FTItem[] fi = FTCreator.GetFtoggleInfo(code);

                logger.Trace($"fm.GetFtoggleInfo(code).Count={fi.Count()}");

                using (FormFtoggle ff = new FormFtoggle(fi))
                    ff.ShowDialog();
            }
        }
    }
}
