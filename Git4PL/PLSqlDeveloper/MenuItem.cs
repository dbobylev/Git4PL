using System;
using System.Drawing;
using Git4PL.PLSqlDeveloper.IDECallBacks;

namespace Git4PL.PLSqlDeveloper
{
    class MenuItem
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private static int _indexCounter = 10;

        public int Index { get; private set; }
        public string MenuName { get; private set; }
        public string MenuTip { get; private set; }
        private Action Click { get; set; }
        public Bitmap Icon { get; private set; }
        public MenuItem(string menuName, string menuTip, Action click, Bitmap icon)
        {
            MenuName = menuName;
            Click = click;
            Icon = icon;
            Index = _indexCounter++;
            MenuTip = menuTip;
        }

        public void SetIcon(int pluginID)
        {
            Callbacks.CreateToolButton(pluginID, Index, MenuTip, null, Icon.GetHbitmap());
        }

        public void PerformClick()
        {
            logger.Debug("=============================================================");
            logger.Debug("Клик по меню {0}", MenuName);
            Click();
        }
    }
}
