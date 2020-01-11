using Git4PL.PLSqlDeveloper.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.Features.Settings
{
    class DefineConstantsSet1 : Constants
    {
        SQLBuilder sb = new SQLBuilder();

        public DefineConstantsSet1()
        {
            SQL_FT = GetFTSql();
            SQL_TASKDB = GetTaskBDSql();
            DBTASK_EXTENSION = "dbtask";
        }

        private string GetFTSql()
        {
            sb.Reset();
            sb.AddSelectStatement("123",               "c1");
            sb.AddSelectStatement("'N123'",            "c2");
            sb.AddSelectStatement("'NOTE'",            "c3");
            sb.AddSelectStatement("'A'",               "c4");
            sb.AddSelectStatement("'N123'",            "c5");
            sb.AddSelectStatement("'FooBar'",          "c6");
            sb.AddSelectStatement("to_char(sysdate,'DD.MM.YYYY HH24:MI:SS')",  "c7");
            sb.AddFromStatement("dual");
            sb.AddWhereAndStatement("1=1 or '{0}'='x'");
            return sb.SQL;
        }

        private string GetTaskBDSql()
        {
            sb.Reset();
            sb.AddSelectStatement("'Task Name'",    "c1");
            sb.AddSelectStatement("'Task descr'",   "c2");
            sb.AddSelectStatement("'Task status'",  "c3");
            sb.AddSelectStatement("'Santa'",        "c4");
            sb.AddSelectStatement("sysdate-2",      "c5");
            sb.AddSelectStatement("sysdate",        "c6");
            sb.AddFromStatement("dual");
            sb.AddWhereAndStatement("{0}={0}");
            return sb.SQL;
        }
    }
}
