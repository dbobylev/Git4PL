using Git4PL.CMD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.Features.Compare
{
    public class BranchesList
    {
        public BindingList<StringValue> list { get; private set; }
        public int SelectedBranchIndex1;
        public int SelectedBranchIndex2;

        public BranchesList()
        {
            Load();
            SetBranchIndex();
        }

        private void Load()
        {
            list = new BindingList<StringValue>();
            string strBranches = Properties.Settings.Default.BranchesList;
            if (string.IsNullOrEmpty(strBranches))
                return;

            List<string> NotFoundBranches = new List<string>();
            foreach (string item in strBranches.Split(';'))
                // Если ветка уже не существует, будет ошибка при обращении к ней в GIT командах, поэтому не загружаем их
                if (CmdAPI.VerifyBracch(item))
                    list.Add(new StringValue(item));
                else
                    NotFoundBranches.Add(item);

            if (NotFoundBranches.Count > 0)
            {
                PluginCommands.ShowMessageBox("Некоторые сохраненные ветки не найдены в репозитории git и были удалены из настроек плагина.\r\n" +
                    string.Join("\r\n", NotFoundBranches));
                Save();
            }
        }

        public void Save()
        {
            Properties.Settings.Default.BranchesList = string.Join(";", list.Select(x => x.Value));
            Properties.Settings.Default.Save();
            SetBranchIndex();
        }

        private void SetBranchIndex()
        {
            SelectedBranchIndex1 = Math.Min(list.Count - 1, Properties.Settings.Default.BranchSelectedIndex1);
            SelectedBranchIndex2 = Math.Min(list.Count - 1, Properties.Settings.Default.BranchSelectedIndex2);
        }
    }
}
