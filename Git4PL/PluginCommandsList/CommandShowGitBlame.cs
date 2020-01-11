using Git4PL.PLSqlDeveloper.IDECallBacks;
using Git4PL.Forms;
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
    class CommandShowGitBlame : ICommand
    {
        public string Name { get; } = "Окно. GitBlame";

        private readonly bool MultiLines;

        public CommandShowGitBlame(bool _MultiLines)
        {
            MultiLines = _MultiLines;
        }

        public void Perform()
        {
            DbObject dbObj = Callbacks.GetDbObject<DbObject>();
            int PosYBeg = Callbacks.GetCurrentLine();
            int PosYEnd = PosYBeg;

            if (MultiLines)
            {
                using (FormBlameN fbn = new FormBlameN(CMD.CmdAPI.GetCurrentBranch(), dbObj.FullName, PosYBeg))
                    if (fbn.ShowDialog() == DialogResult.OK)
                    {
                        PosYBeg = fbn.numMin;
                        PosYEnd = fbn.numMax;
                    }
                    else
                        return;
            }

            string text = CMD.CmdAPI.GitBlame(dbObj.RepName, PosYBeg, PosYEnd);
            using (FormShowText fst = new FormShowText(text))
                fst.ShowDialog();
        }
    }
}
