using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.CMD.CmdReaders
{
    class CmdReadBool : CMDReader<bool>
    {
        public override int ReadProcess(Process p)
        {
            Result = !string.IsNullOrEmpty(p.StandardOutput.ReadToEnd());
            return Result ? 1 : 0;
        }
    }
}
