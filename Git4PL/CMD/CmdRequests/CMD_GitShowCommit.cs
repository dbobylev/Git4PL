using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git4PL.CMD.CmdReaders;

namespace Git4PL.CMD.CmdRequests
{
    class CMD_GitShowCommit : CmdBuilderGIT
    {
        public CMD_GitShowCommit(string sha, bool shortstat) : base("Git show commit")
        {
            Reader = new CmdReadString();

            AddArgumentGitRepPath();
            AddArgument("show");
            if (shortstat)
                AddArgument("--shortstat");
            AddArgument(sha);
        }
    }
}