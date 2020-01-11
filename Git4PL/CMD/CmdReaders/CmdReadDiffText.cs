using Git4PL.Features.GitDiff;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.CMD.CmdReaders
{
    class CmdReadDiffText : CMDReader<DiffText>
    {
        public CmdReadDiffText()
        {
            Result = new DiffText();
        }

        public override int ReadProcess(Process p)
        {
            string standard_output;
            int cnt = 0;
            while ((standard_output = p.StandardOutput.ReadLine()) != null)
            {
                cnt++;
                Result.AddLine(standard_output);
            }
            return cnt;
        }
    }
}
