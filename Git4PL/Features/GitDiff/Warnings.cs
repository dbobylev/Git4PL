using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Git4PL.Features.GitDiff
{
    public static class Warnings
    {
        public static bool IsBranchUnexsepted(string BranchName, bool SilentMode = false)
        {
            if (Properties.Settings.Default.UnexpectedBranch)
            {
                string RegexInPattern = Properties.Settings.Default.WarnInRegEx;
                Regex regex = new Regex(RegexInPattern);
                if (!regex.IsMatch(BranchName))
                {
                    if (SilentMode)
                        return true;
                    DialogResult result = MessageBox.Show($"Внимание! Вы работаете с веткой: {BranchName}. Продолжить?"
                        , $"Название ветки не прошло проверку", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.No)
                        return true;
                }
            }
            return false;
        }

        public static bool IsServerUnexsepted(string ServerName, bool SilentMode = false)
        {
            if (Properties.Settings.Default.UnexpectedServer)
            {
                string RegexOutPattern = Properties.Settings.Default.WarnOutRegEx;
                Regex regex = new Regex(RegexOutPattern, RegexOptions.IgnoreCase);
                if (!regex.IsMatch(ServerName))
                {
                    if (SilentMode)
                        return true;
                    DialogResult result = MessageBox.Show($"Внимание! Вы собираетесь изменить текст объекта на сервере: {ServerName}. Продолжить?"
                        , $"Название сервера не прошло проверку", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.No)
                        return true;
                }
            }
            return false;
        }
    }
}
