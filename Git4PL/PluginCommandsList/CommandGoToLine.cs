using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git4PL.PLSqlDeveloper.IDECallBacks;

namespace Git4PL.PluginCommandsList
{
    class CommandGoToLine : ICommand
    {
        public string Name => "Команда GoToLine";
        private int LineNum;

        public CommandGoToLine(int lineNum)
        {
            LineNum = lineNum;
        }

        public void Perform()
        {
            Callbacks.GoToLine(LineNum);
        }
    }
}
