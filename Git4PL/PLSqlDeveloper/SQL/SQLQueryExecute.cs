using Git4PL.PLSqlDeveloper.IDECallBacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.PLSqlDeveloper.SQL
{
    /// <summary>
    /// Класс для выполнения запроса SQL на стороне PL/SQL Developer
    /// </summary>
    /// <typeparam name="T">Тив в котором мы сохраним результат select-а</typeparam>
    class SQLQueryExecute<T> where T:new()
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private string query;

        public SQLQueryExecute(string _query)
        {
            query = _query;
        }

        /// <summary>
        /// Запустить выполнение запроса SQL 
        /// </summary>
        /// <param name="ans">Результирующий ответ упакованный в тип Т</param>
        /// <param name="ErrorMsg"></param>
        /// <returns></returns>
        public bool RunSQLSelectQuery(out List<T> ans, out string ErrorMsg)
        {
            ans = new List<T>();

            // Выполняем запрос
            if (!GetResult(out SQLResult result, out string[] Headers, out ErrorMsg))
                return false;

            // Парсим ответ в лист ожидаемого типа T
            foreach (SQLRow row in result)
                ans.Add(row.GetObj<T>(Headers));

            return true;
        }

        private bool GetResult(out SQLResult result, out string[] Headers, out string ErrorMsg)
        {
            result = new SQLResult();
            Headers = null;

            if (!RunExecuteQuery(out ErrorMsg))
                return false;

            // Делегаты для работы с PL/SQL Developer
            SQL_FieldName SQL_FieldNameCallback = Callbacks.GetDelegate<SQL_FieldName>();
            SQL_Eof SQL_EofCallback = Callbacks.GetDelegate<SQL_Eof>();
            SQL_Field SQL_FieldCallback = Callbacks.GetDelegate<SQL_Field>();
            SQL_Next SQL_NextCallback = Callbacks.GetDelegate<SQL_Next>();

            int fieldCount = GetFieldCount();

            // Чтение заголовков
            Headers = new string[fieldCount];
            for (int i = 0; i < fieldCount; i++)
                Headers[i] = SQL_FieldNameCallback(i);

            // Чтение данных
            while (!SQL_EofCallback())
            {
                object[] row = new object[fieldCount];
                for (int i = 0; i < fieldCount; i++)
                {
                    row[i] = SQL_FieldCallback(i);
                }
                result.AddRow(new SQLRow(row));
                SQL_NextCallback();
            }
            return true;
        }

        private bool RunExecuteQuery(out string ErrorMsg)
        {
            ErrorMsg = string.Empty;

            logger.Debug("Запрос выполнеия SQL на сервере. sql: {0}", query);
            int SqlAns = Callbacks.GetDelegate<SQL_Execute>()?.Invoke(query) ?? -1;
            logger.Trace($"SqlAns={SqlAns}");

            if (SqlAns == -1)
                throw new Git4PLException("Не удалось вызвать callback - SQL_Execute");
            else if (SqlAns != 0)
            {
                string error = Callbacks.GetDelegate<SQL_ErrorMessage>()?.Invoke();
                logger.Error("Ошибка при выполнении запроса: {0}", error);
                ErrorMsg = $"Error: ORA-{SqlAns}\r\n{error}";
                return false;
            }
            return true;
        }

        private int GetFieldCount()
        {
            int fieldCount = Callbacks.GetDelegate<SQL_FieldCount>()?.Invoke() ?? 0;
            logger.Trace("fieldCount={0}", fieldCount);
            return fieldCount;
        }
    }
}
