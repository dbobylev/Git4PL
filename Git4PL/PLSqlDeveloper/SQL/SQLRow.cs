using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.PLSqlDeveloper.SQL
{
    public class SQLRow
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private object[] row;
        public SQLRow(object[] data)
        {
            row = data;
        }

        /// <summary>
        /// Конвертировать кортеж row в класс T
        /// Класс должен содержать property с атрибутом SQL(ColumnName=) для присвоения значения
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Headers"></param>
        /// <returns></returns>
        public T GetObj<T>(string[] Headers)
        {
            T obj = (T)Activator.CreateInstance(typeof(T));

            PropertyInfo[] pi = typeof(T).GetProperties();

            for (int i = 0; i < pi.Length; i++)
            {
                // Если свойство не содержит атрибут, идём дальше
                if (!pi[i].CustomAttributes.Any(x => x.AttributeType.Name == "SQLAttribute"))
                    continue;

                // Ищем название ожидаемой колонки SQL для этого свойства
                CustomAttributeData cd = pi[i].CustomAttributes.FirstOrDefault(x => x.AttributeType.Name == "SQLAttribute");
                string ColumnName = cd.NamedArguments[0].TypedValue.Value.ToString();

                // Ищем колонку в заголовках
                for (int j = 0; j < Headers.Length; j++)
                { 
                    if (ColumnName.ToUpper() == Headers[j])
                    {
                        // Здесь нужно добавить проверку типов, работа с датами и т.п.
                        if (pi[i].PropertyType == typeof(DateTime))
                            pi[i].SetValue(obj, DateTime.ParseExact(row[j].ToString(), "dd.MM.yyyy HH:mm:ss", null));
                        else
                            pi[i].SetValue(obj, row[j]);
                        break;
                    }
                }
            }
            return obj;
        }
    }
}
