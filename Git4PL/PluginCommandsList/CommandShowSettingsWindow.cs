using Git4PL.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.PluginCommandsList
{
    class CommandShowSettingsWindow : ICommand
    {
        public string Name { get; } = "Окно. Настройки";

        public void Perform()
        {
            using (FormSettings fs = new FormSettings())
                fs.ShowDialog();
        }
    }
}
