using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Git4PL.CMD.CmdReaders;

namespace Git4PL.CMD.CmdRequests
{
    class CMD_GitCompareBranches : CmdBuilderGIT
    {
        public CMD_GitCompareBranches(string SqlFile, string branch1, string branch2) :base("Compare branches")
        {
            Reader = new CmdReadDiffText();

            AddArgumentGitRepPath();
            AddArgument("diff");
            AddArgument(branch1);
            AddArgument(branch2);
            AddArgument("--");
            AddArgument($"\"{SqlFile}\"");
            AddArgumentCrAtEol();
            AddArgumentSpaceAtEol();
        }
    }
}
