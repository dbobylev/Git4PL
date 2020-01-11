using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git4PL.CMD.CmdReaders;

namespace Git4PL.CMD.CmdRequests
{
    class CMD_GitGetCurrentBranch : CmdBuilderGIT
    {
        public CMD_GitGetCurrentBranch() :base("Get current branch")
        {
            Reader = new CmdReadString();

            AddArgumentGitRepPath();
            AddArgument("rev-parse");
            AddArgument("--abbrev-ref HEAD");
        }

        protected override void AfterProcess()
        {
            base.AfterProcess();

            (Reader as CmdReadString).EditReuslt((x) => x.Replace("\n", string.Empty));
        }
    }
}
