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
    class CommandShowCompareBranches : ICommand
    {
        public string Name { get; } = "Окно. CompareBranches";

        public void Perform()
        {
            DbObject dbObj = null;
            if (Callbacks.GetWindowType() == 3)
                dbObj = Callbacks.GetDbObject<DbObject>();

            using (FormCompare fc = new FormCompare(dbObj))
                fc.ShowDialog();
        }
    }
}
