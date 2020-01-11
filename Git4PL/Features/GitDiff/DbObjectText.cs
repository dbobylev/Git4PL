using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Git4PL.Features.GitDiff
{
    /// <summary>
    ///  Характеристики объекта БД ассоциированного с файлом в локальном репозитории git
    ///  + текст объекта БД
    /// </summary>
    public class DbObjectText : DbObject
    {
        protected string _text;
        public string Text { get => _text; set => _text = value; }
        protected bool UTF8HaveBOM { get; set; }

        public DbObjectText(DbObject dbObj, string text) : base(dbObj)
        {
            logger.Debug($"Создаём объект DbObjectText. text.length={text.Length}");

            DirectoriesChecks();

            Text = text;

            PLSQLCodeFormatter formatter = new PLSQLCodeFormatter(GetRawFilePath());
            formatter.UpdateBeginOfText(ref _text, Schema, Name);
            formatter.UpdateLastLines(ref _text);

            // 2019-08-08 Меняем реализацию на доп параметр git diff - --ignore-cr-at-eol
            //formatter.UpdateNewLines(ref _text);

            UTF8HaveBOM = formatter.IsBom();
            logger.Trace("UTF8HaveBOM={0}", UTF8HaveBOM.ToString());

            logger.Trace($"Конец конструктора DbObjectText");
        }

        public Encoding GetSaveEncoding()
        {
            Encoding EncodingToSave;

            switch ((EncodingToSaveType)Properties.Settings.Default.EncodingToSaveType)
            {
                case EncodingToSaveType.UTF8: EncodingToSave = new UTF8Encoding(false); break;
                case EncodingToSaveType.UTF8_BOM: EncodingToSave = new UTF8Encoding(true); break;
                case EncodingToSaveType.DontChange: EncodingToSave = new UTF8Encoding(UTF8HaveBOM); break;
                default: EncodingToSave = new UTF8Encoding(false); break;
            }
            return EncodingToSave;
        }
    }
}
