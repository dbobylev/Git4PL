using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git4PL.CMD
{
    abstract class CmdBuilderGIT :CmdCore
    {
        private const string DefaultGitExePath = "git.exe";

        public CmdBuilderGIT(string _Name) :base(_Name)
        {
            FileName = GetGitExePath();
        }

        private static string GetGitExePath()
        {
            string PathFromSettings = Properties.Settings.Default.GetExePath;
            if (string.IsNullOrEmpty(PathFromSettings))
                return DefaultGitExePath;
            else
                return PathFromSettings;
        }

        protected void AddArgument(string text)
        {
            if (string.IsNullOrEmpty(Args))
                Args = text;
            else
                Args += $" {text}";
        }

        protected void AddArgumentCrAtEol()
        {
            if (Properties.Settings.Default.DiffCRLF)
                AddArgument("--ignore-cr-at-eol");
        }

        protected void AddArgumentSpaceAtEol()
        {
            if (Properties.Settings.Default.IgnoreSpaceAtEOL)
                AddArgument("--ignore-space-at-eol");
        }

        protected void AddArgumentGitRepPath()
        {
            AddArgument($"-C \"{Properties.Settings.Default.GitLocalRepository}\"");
        }
    }
}
