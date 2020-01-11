using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Git4PL.PLSqlDeveloper.IDECallBacks;
using Git4PL.PLSqlDeveloper.SQL;

namespace Git4PL.Features.FT
{
    public static class FTCreator
    {
        private static readonly string MainQuery;

        static FTCreator()
        {
            MainQuery = Settings.Constants.Instance.SQL_FT;
        }

        public static FTItem[] GetFtoggleInfo(string code)
        {
            string query = string.Format(MainQuery, code);

            if (!Callbacks.SQLQueryExecute(query, out List<FTItem> result, out string ErrorMsg))
                throw new Git4PLException($"Ошибка при выполнении SQL звпроса:\r\n{ErrorMsg}");
            return result.ToArray();
        }
    }
}
