using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git4PL.CMD.CmdReaders;

namespace Git4PL.CMD.CmdRequests
{
    class CMD_GitModifiedFiles : CmdBuilderGIT
    {
        public CMD_GitModifiedFiles(string branch1, string branch2) :base("Get Modified files")
        {
            Reader = new CmdReadListString();

            AddArgumentGitRepPath();
            AddArgument("diff");
            AddArgument("--name-status");
            AddArgument(branch1);
            AddArgument(branch2);
        }

        protected override void AfterProcess()
        {
            base.AfterProcess();

            (Reader as CmdReadListString).EditReuslt((x) => x.Select(i => i.Split()[1]).OrderBy(y=>y).ToList());
        }
    }
}
