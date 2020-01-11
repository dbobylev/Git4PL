using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.CMD
{
    abstract class CMDReader<T> : ICmdReader
    {
        protected T Result;

        public abstract int ReadProcess(Process p);

        public void EditReuslt(Func<T, T> func)
        {
            Result = func(Result);
        }

        public P GetResult<P>()
        {
            if (Result is P ans)
                return ans;
            return default;
        }
    }
}
