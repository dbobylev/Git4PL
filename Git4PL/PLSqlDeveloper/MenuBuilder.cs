using System.Collections.Generic;
using System.Linq;

namespace Git4PL.PLSqlDeveloper
{
    class MenuBuilder
    {
        private readonly List<MenuItem> MenuItems = new List<MenuItem>();
        private string TabName { get; set; }
        private string GroupName { get; set; }
        private int? GroupIndex { get; set; }
        private bool IsRibbonMenu { get; set; }
        private string GroupIndexStr
        {
            get
            {
                if (GroupIndex != null) return $" [groupindex={GroupIndex}]";
                else return "";
            }
        }

        public MenuBuilder(int plsqlDeveloperVersion)
        {
            IsRibbonMenu = plsqlDeveloperVersion >= 1200;
            TabName = "Tools";
            GroupName = "Git4PL";
            GroupIndex = 2;

            MenuItems = new List<MenuItem>
            {
                new MenuItem("Git Diff"  ,"Git Diff"  , () => PluginCommands.ShowGitDiffWindow()      , Properties.Resources.diskette),
                new MenuItem("CheckOut"  ,"CheckOut"  , () => PluginCommands.CheckOut(null, null)     , Properties.Resources.Stock_Index_Down_icon),
                new MenuItem("CheckIn"   ,"CheckIn"   , () => PluginCommands.CheckIn(null, null)      , Properties.Resources.Stock_Index_Up_icon),
                new MenuItem("FToggle"   ,"FToggle"   , () => PluginCommands.ShowFtoggle()            , Properties.Resources.gear),
                new MenuItem("Blame"     ,"Blame"     , () => PluginCommands.GitBlame(true)           , Properties.Resources.trumpet),
                new MenuItem("Show"      ,"Show"      , () => PluginCommands.ShowCommit()             , Properties.Resources.zoom),
                new MenuItem("TaskInfo"  ,"TaskInfo"  , () => PluginCommands.ShowTaskInfoWindow(null) , Properties.Resources.Business_info_icon),
                new MenuItem("Настройки" ,"Настройки" , () => PluginCommands.ShowSettingsWindow()     , Properties.Resources.settings),
                new MenuItem("Помощь"    ,"Помощь"    , () => PluginCommands.ShowHelp(null, "index")  , Properties.Resources.Categories_system_help_icon),
                new MenuItem("Сравнить"  ,"Сравнить"  , () => PluginCommands.ShowCompareBranches()    , Properties.Resources.browser)
            };
        }

        public string CreateMenuItem(int index) 
        {
            if (IsRibbonMenu && index == 1) return $"TAB={TabName}";
            if (IsRibbonMenu && index == 2) return $"GROUP={GroupName}{GroupIndexStr}";

            MenuItem item = MenuItems.FirstOrDefault(x => x.Index == index);
            if (item != null)
            {
                if (IsRibbonMenu)
                    return $"ITEM={item.MenuName}";
                else
                    return $"{TabName} / {item.MenuName}";
            }
            return null;
        }

        public void MenuClick(int index)
        {
            MenuItem item = MenuItems.FirstOrDefault(x => x.Index == index);
            if (item != null)
                item.PerformClick();
        }

        public void SetIcons(int pluginID)
        {
            MenuItems.ForEach(x => x.SetIcon(pluginID));
        }
    }
}
