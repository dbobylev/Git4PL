using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git4PL.CMD.CmdReaders;

namespace Git4PL.CMD.CmdRequests
{
    class CMD_Verify: CmdBuilderGIT
    {
        public CMD_Verify(string BranchName) : base("CMD Verify")
        {
            Reader = new CmdReadBool();

            AddArgumentGitRepPath();
            AddArgument("rev-parse");
            AddArgument("--verify");
            AddArgument("--quiet");
            AddArgument(BranchName);
        }
    }
}
