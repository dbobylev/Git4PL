using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.CMD.CmdReaders
{
    class CmdReadString : CMDReader<string>
    {
        public override int ReadProcess(Process p)
        {
            Result = p.StandardOutput.ReadToEnd();
            return string.IsNullOrEmpty(Result) ? 0 : 1;
        }
    }
}
