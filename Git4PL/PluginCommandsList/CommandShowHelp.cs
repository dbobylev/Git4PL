using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git4PL.PluginCommandsList
{
    class CommandShowHelp : ICommand
    {
        public string Name { get; } = "Окно. Справка";

        private Control source;
        private string topic;

        public CommandShowHelp(Control _source, string _topic)
        {
            source = _source;
            topic = _topic;
        }

        public void Perform()
        {
           Help.ShowHelp(source, HelpAssist.GetUrl(), HelpNavigator.Topic, $"{topic}.htm");
        }
    }
}
