using Git4PL.PLSqlDeveloper.IDECallBacks;
using Git4PL.Forms;
using Git4PL.Features.GitDiff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.PluginCommandsList
{
    class CommandShowGitDiffWindow : ICommand
    {
        public string Name { get; } = "Окно. GitDiff";

        public void Perform()
        {
            DbObjectText dbObject = Callbacks.GetDbObject<DbObjectText>();
            using (FormGitDiff formGitDif = new FormGitDiff(dbObject))
                formGitDif.ShowDialog();
        }
    }
}
