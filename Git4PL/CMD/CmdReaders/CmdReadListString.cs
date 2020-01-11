using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.CMD.CmdReaders
{
    class CmdReadListString : CMDReader<List<string>>
    {
        public CmdReadListString()
        {
            Result = new List<string>();
        }

        public override int ReadProcess(Process p)
        {
            string standard_output;
            int cnt = 0;
            while ((standard_output = p.StandardOutput.ReadLine()) != null)
            {
                cnt++;
                Result.Add(standard_output);
            }
            return cnt;
        }
    }
}
