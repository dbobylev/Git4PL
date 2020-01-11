using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git4PL.CMD.CmdReaders;

namespace Git4PL.CMD.CmdRequests
{
    class CMD_GitBlame : CmdBuilderGIT
    {
        public CMD_GitBlame(string fileName, int beginLine, int endline) :base("Git Blame")
        {
            Reader = new CmdReadString();

            AddArgumentGitRepPath();
            AddArgument("blame");
            AddArgument($" -L {beginLine},{endline}");
            AddArgument($"{fileName}");
        }
    }
}
