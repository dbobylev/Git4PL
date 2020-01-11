using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.PLSqlDeveloper.SQL
{
    [AttributeUsage(AttributeTargets.Property)]
    class SQLAttribute : Attribute
    {
        public string ColumnName { get; set; }
    }
}
