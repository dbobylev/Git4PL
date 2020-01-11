using System;
using System.Drawing;
using System.Windows.Forms;
using Git4PL.PLSqlDeveloper.IDECallBacks;
using Git4PL.Features.GitDiff;

namespace Git4PL.Forms
{
    public partial class FormGitDiff : Form
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        readonly DbObjectText dbObject;

        public FormGitDiff(DbObjectText dbObject)
        {
            InitializeComponent();

            this.dbObject = dbObject;

            FillStatusBar();
            FillRtb();

            // Без этого окно GitDiff спрячется на заднем фоне PL/SQL Developer-а
            this.Activate();
        }

        private void ButtonCheckIn_Click(object sender, EventArgs e)
        {
            PluginCommands.CheckIn(dbObject, tsslBranchValue.Text);
            Close();
        }

        private void ButtonCheckOut_Click(object sender, EventArgs e)
        {
            PluginCommands.CheckOut(dbObject, tsslServerValue.Text);
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TsslPathValue_Click(object sender, EventArgs e)
        {
            string path = dbObject.GetRawFilePath();
            Clipboard.SetText(path);
            Callbacks.SetStatusMessage(string.Format("Путь {0} скопирован в буфер обмена", path));
        }

        private void FillStatusBar()
        {
            tsslObjectValue.Text = dbObject.FullName;
            tsslPathValue.Text = dbObject.GetRawFilePath();
            tsslServerValue.Text = Callbacks.GetDatabaseConnection();
            tsslBranchValue.Text = CMD.CmdAPI.GetCurrentBranch();
            ColorUnexseptedValues();
        }

        private void FillRtb()
        {
            DiffText text = CMD.CmdAPI.GitDiff(dbObject);
            while (text.MoveNext())
            {
                rtbMain.SelectionStart = rtbMain.TextLength;
                rtbMain.SelectionLength = 0;
                DiffLine dl = text.CurrentDiffLine;
                rtbMain.SelectionColor = dl.ColorText;
                rtbMain.SelectionBackColor = dl.ColorBack;
                rtbMain.AppendText(text.GetCurrentLine);
            }
            if (rtbMain.Text.Length == 0)
                rtbMain.Text = "< Изменения отсутствуют >";
        }

        private void ColorUnexseptedValues()
        {
            Action<ToolStripStatusLabel> SetGreenColor = (x) => {
                x.BackColor = Color.LightGreen;
                x.ForeColor = Color.FromArgb(30, 30, 30);
            };

            Action<ToolStripStatusLabel> SetRedColor = (x) =>
            {
                x.Font = new Font(tsslBranchValue.Font, FontStyle.Bold | FontStyle.Underline);
                x.BackColor = Color.Red;
                x.ForeColor = Color.White;
            };

            if (Properties.Settings.Default.UnexpectedBranch)
            {
                if (Warnings.IsBranchUnexsepted(tsslBranchValue.Text, true))
                    SetRedColor(tsslBranchValue);
                else
                    SetGreenColor(tsslBranchValue);
            }

            if (Properties.Settings.Default.UnexpectedServer)
            {
                if (Warnings.IsServerUnexsepted(tsslServerValue.Text, true))
                    SetRedColor(tsslServerValue);
                else
                    SetGreenColor(tsslServerValue);
            }
        }
        
        private void FormGitDiff_Load(object sender, EventArgs e)
        {
            // Для мониторов с низким разрешением проверяем что бы окно не вываливалось за границы экрана
            if (Width > SystemInformation.VirtualScreen.Width - 150)
            {
                Width = SystemInformation.VirtualScreen.Width - 150;
            }
            if (Height > SystemInformation.VirtualScreen.Height - 150)
            {
                Height = SystemInformation.VirtualScreen.Height - 150;
            }
            CenterToScreen();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            PluginCommands.ShowHelp(this, "gitdiffwindow");
        }

        private void TsslBranchValue_Click(object sender, EventArgs e)
        {
            PluginCommands.ShowTaskInfoWindow(tsslBranchValue.Text);
        }
    }
}


