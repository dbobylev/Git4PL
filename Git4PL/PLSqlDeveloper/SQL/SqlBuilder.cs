using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.PLSqlDeveloper.SQL
{
    /// <summary>
    /// построение _простых_ запросов
    /// </summary>
    class SQLBuilder
    {
        public string SQL { get; private set; }

        private bool HasSelect = false;
        private bool HasFrom = false;
        private bool HasWhere = false;

        public SQLBuilder()
        {

        }

        public void AddSelectStatement(string column, string alias)
        {
            if (HasFrom || HasWhere)
                RaiseError();

            if (HasSelect)
                SQL += $", {column} {alias}";
            else
            {
                SQL = $"select {column} {alias}";
                HasSelect = true;
            }
        }
        public void AddFromStatement(string table, string alias = "")
        {
            if (!HasSelect || HasWhere)
                RaiseError();

            if (HasFrom)
                SQL += $", {table} {alias}";
            else
            {
                SQL += $" from {table} {alias}";
                HasFrom = true;
            }
        }
        public void AddWhereAndStatement(string whereclause)
        {
            if (!(HasSelect && HasFrom))
                RaiseError();

            if (HasWhere)
                SQL += $" and ({whereclause})";
            else
            {
                SQL += $" where ({whereclause})";
                HasWhere = true;
            }
        }

        public void Reset()
        {
            HasWhere = false;
            HasSelect = false;
            HasFrom = false;
            SQL = string.Empty;
        }

        private void RaiseError()
        {
            throw new Exception("Неправильная последовательность составления SQL запроса");
        }
    }
}
