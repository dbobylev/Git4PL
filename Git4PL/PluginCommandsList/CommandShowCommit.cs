using Git4PL.PLSqlDeveloper.IDECallBacks;
using Git4PL.Forms;
using Git4PL.Features.GitDiff;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Git4PL.PluginCommandsList
{
    class CommandShowCommit : ICommand
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public string Name { get; } = "Окно. ShowCommit";

        public void Perform()
        {
            // Сперва по blame определим необходимый коммит для выбора
            DbObject dbObj = Callbacks.GetDbObject<DbObject>();
            int PosY = Callbacks.GetCurrentLine();
            string text = CMD.CmdAPI.GitBlame(dbObj.RepName, PosY);
            if (string.IsNullOrEmpty(text))
                return;

            // Достаем sha коммита из записи
            string sha = text.Split()[0];

            // Сначала смотрим статистику коммита
            text = CMD.CmdAPI.GitShowCommit(sha, true);

            // Если строк меньше 1000 загружаем их для отображения
            if (RowsChanged(text) < 1000)
                text = CMD.CmdAPI.GitShowCommit(sha);

            using (FormShowText fst = new FormShowText(text))
                fst.ShowDialog();
        }

        private int RowsChanged(string commitInfo)
        {
            // Определяем количество измененных строчек 
            string pattern = @"file[s]? changed, (\d+)[^\d]*(\d+)?";
            Regex r = new Regex(pattern);
            var l = r.Matches(commitInfo);
            var x = l[0].Groups;
            int n = int.Parse(x[1].Value);
            if (!string.IsNullOrEmpty(x[2].Value))
                n += int.Parse(x[2].Value);
            logger.Trace($"GitShow commits have {n} lines");
            return n;
        }
    }
}
