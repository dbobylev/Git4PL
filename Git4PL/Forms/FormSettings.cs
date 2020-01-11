using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Git4PL.Forms
{
    public partial class FormSettings : Form
    {
        private bool NeedSavePassword = false;
        private bool IsLogLevelChange = false;

        public FormSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// Загрузка параметров в форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSettings_Load(object sender, EventArgs e)
        {
            comboBoxEncodingToSave.DataSource = CommonExtensions.GetTypeDescriptions(typeof(Features.GitDiff.EncodingToSaveType));
            comboBoxLogLevel.DataSource = CommonExtensions.GetTypeDescriptions(typeof(LogLevelType));

            textBoxRepositoryPath.Text              = Properties.Settings.Default.GitLocalRepository;
            comboBoxEncodingToSave.SelectedIndex    = Properties.Settings.Default.EncodingToSaveType;
            comboBoxLogLevel.SelectedIndex          = Properties.Settings.Default.LogLevel;
            checkBoxChangeCor.Checked               = Properties.Settings.Default.DiffChangeCor;
            checkBoxChangeName.Checked              = Properties.Settings.Default.DiffChangeName;
            checkBoxAddSchema.Checked               = Properties.Settings.Default.DiffAddSchema;
            checkBoxIgnpreSlash.Checked             = Properties.Settings.Default.DiffWorkWithSlash;
            checkBoxCRLF.Checked                    = Properties.Settings.Default.DiffCRLF;
            checkBoxWarningBranch.Checked           = Properties.Settings.Default.UnexpectedBranch;
            checkBoxWarningServer.Checked           = Properties.Settings.Default.UnexpectedServer;
            textBoxSNLogin.Text                     = Properties.Settings.Default.WebLogin;
            textBoxGitExePath.Text                  = Properties.Settings.Default.GetExePath;
            checkBoxIgnoreSpaceAtEol.Checked        = Properties.Settings.Default.IgnoreSpaceAtEOL;
            textBoxWarnIn.Text                      = Properties.Settings.Default.WarnInRegEx ?? Features.Settings.Constants.Instance.WARNIN_REGEX;
            textBoxWarnOut.Text                     = Properties.Settings.Default.WarnOutRegEx ?? Features.Settings.Constants.Instance.WARNOUT_REGEX;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.WebPassword) && !string.IsNullOrEmpty(Properties.Settings.Default.WebPasswordEntropy))
                textBoxSNPassword.Text = "000000"; // Устанавливаем любые символы, что бы показать что пароль установлен. (будут отображаться звездочки)
            NeedSavePassword = false;
        }

        /// <summary>
        /// Закрытие формы 
        /// Сохранение параметров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonApply_Click(object sender, EventArgs e)
        {
            if (!CheckFolderBeforeSave())
                return;

            Properties.Settings.Default.GitLocalRepository = textBoxRepositoryPath.Text;
            Properties.Settings.Default.EncodingToSaveType = comboBoxEncodingToSave.SelectedIndex;
            Properties.Settings.Default.LogLevel = comboBoxLogLevel.SelectedIndex;
            Properties.Settings.Default.DiffChangeCor = checkBoxChangeCor.Checked;
            Properties.Settings.Default.DiffChangeName = checkBoxChangeName.Checked;
            Properties.Settings.Default.DiffAddSchema = checkBoxAddSchema.Checked;
            Properties.Settings.Default.DiffWorkWithSlash = checkBoxIgnpreSlash.Checked;
            Properties.Settings.Default.DiffCRLF = checkBoxCRLF.Checked;
            Properties.Settings.Default.UnexpectedBranch = checkBoxWarningBranch.Checked;
            Properties.Settings.Default.UnexpectedServer = checkBoxWarningServer.Checked;
            Properties.Settings.Default.WebLogin = textBoxSNLogin.Text;
            Properties.Settings.Default.GetExePath = textBoxGitExePath.Text;
            Properties.Settings.Default.IgnoreSpaceAtEOL = checkBoxIgnoreSpaceAtEol.Checked;
            Properties.Settings.Default.WarnInRegEx = textBoxWarnIn.Text;
            Properties.Settings.Default.WarnOutRegEx = textBoxWarnOut.Text;

            if (NeedSavePassword)
                SavePassword();

            if (IsLogLevelChange)
                NlogAssist.SetLogLevel((LogLevelType)comboBoxLogLevel.SelectedIndex);

            Properties.Settings.Default.Save();

            Close();
        }

        /// <summary>
        /// Выбор пути локального репозитория Git
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectRepo_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBoxRepositoryPath.Text = fbd.SelectedPath;
                    Properties.Settings.Default.GitLocalRepository = fbd.SelectedPath;
                }
            }
        }

        /// <summary>
        /// Сохраняем пароль через ProtectedData
        /// В настройках будет хранится зашифрованный пароль [WebPassword] а так же соль [WebPasswordEntropy]
        /// Пароль + соль смогут расшифроваться только под учётной записью пользователя под которой были сохранены
        /// </summary>
        private void SavePassword()
        {
            if (textBoxSNPassword.Text.Length == 0)
            {
                Properties.Settings.Default.WebPasswordEntropy = null;
                Properties.Settings.Default.WebPassword = null;
                return;
            }

            byte[] plaintext = Encoding.UTF8.GetBytes(textBoxSNPassword.Text);

            byte[] entropy = new byte[20];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                rng.GetBytes(entropy);

            byte[] ciphertext = ProtectedData.Protect(plaintext, entropy, DataProtectionScope.CurrentUser);

            Properties.Settings.Default.WebPasswordEntropy = Convert.ToBase64String(entropy);
            Properties.Settings.Default.WebPassword = Convert.ToBase64String(ciphertext);
        }

        private void TextBoxWebPassword_TextChanged(object sender, EventArgs e)
        {
            NeedSavePassword = true;
        }

        private void TextBoxWebPassword_Click(object sender, EventArgs e)
        {
            // В поле пароля звездочки, подразумеваем что пользователь хочет их заменить на новый пароль, поэтому выделяем.
            (sender as TextBox).SelectAll();
            (sender as TextBox).Focus();
        }

        private void ComboBoxLogLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsLogLevelChange = true;
        }

        private void ButtonSelectGitExe_Click(object sender, EventArgs e)
        {
            string initFilePath = @"C:\";
            string DefaultGitFolder = @"C:\Program Files\Git";
            string DefaultGitFolder86 = @"C:\Program Files (x86)\Git";

            if (Directory.Exists(DefaultGitFolder))
                initFilePath = DefaultGitFolder;
            else if (Directory.Exists(DefaultGitFolder86))
                initFilePath = DefaultGitFolder86;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = initFilePath;
                openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    textBoxGitExePath.Text = openFileDialog.FileName;
            }

        }

        private bool CheckFolderBeforeSave()
        {
            if (!string.IsNullOrWhiteSpace(textBoxRepositoryPath.Text) && !Directory.Exists(textBoxRepositoryPath.Text))
            {
                MessageBox.Show($"Не найден путь: {textBoxRepositoryPath.Text}", "Ошибка", MessageBoxButtons.OK);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(textBoxGitExePath.Text) && !File.Exists(textBoxGitExePath.Text))
            {
                MessageBox.Show($"Не найден файл: {textBoxRepositoryPath.Text}", "Ошибка", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void CheckBoxWarningBranch_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWarnIn.Enabled = (sender as CheckBox).Checked;
        }

        private void CheckBoxWarningServer_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWarnOut.Enabled = (sender as CheckBox).Checked;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Help Calls

        private void ButtonHelpSettings_Click(object sender, EventArgs e)
        {
            PluginCommands.ShowHelp(this, "settings");
        }

        private void ButtonHelpWarnings_Click(object sender, EventArgs e)
        {
            PluginCommands.ShowHelp(this, "warnings");
        }

        private void ButtonHelpTaskInfo_Click(object sender, EventArgs e)
        {
            PluginCommands.ShowHelp(this, "taskinfo");
        }

        private void ButtonHelpLogs_Click(object sender, EventArgs e)
        {
            PluginCommands.ShowHelp(this, "logs");
        }

        private void ButtonHelpGitExe_Click(object sender, EventArgs e)
        {
            PluginCommands.ShowHelp(this, "gitexe");
        }

        private void ButtonHelpSetRep_Click(object sender, EventArgs e)
        {
            PluginCommands.ShowHelp(this, "GitDiff");
        }

        #endregion
    }
}
