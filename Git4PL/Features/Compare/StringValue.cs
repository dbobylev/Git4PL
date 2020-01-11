using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.Features.Compare
{
    public class StringValue
    {
        public string Value { get; set; }

        public StringValue(string s)
        {
            Value = s;
        }
        public StringValue()
        {

        }

        public override string ToString()
        {
            return Value;
        }
    }
}
