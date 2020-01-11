using Git4PL.Features.GitDiff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Git4PL.Features.Compare;

namespace Git4PL.Forms
{
    public partial class FormCompare : Form
    {
        string SQLFile;
        BranchesList branches;

        public FormCompare(DbObject dbObj)
        {
            InitializeComponent();
            if (dbObj != null)
                SQLFile = dbObj.RepName;

            LoadBranches();
            FillFilesList(SQLFile);
        }

        private void FillRtb()
        {
            rtbMain.Clear();
            DiffText text = CMD.CmdAPI.CompareTwoBranches(SQLFile, cbBranch2.SelectedItem.ToString(), cbBranch1.SelectedItem.ToString());
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

        private void ButtonCompare_Click(object sender, EventArgs e)
        {
            rtbMain.Clear();
            FillFilesList(SQLFile);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape || keyData == Keys.Enter)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ButtonBranchList_Click(object sender, EventArgs e)
        {
            SaveCBIndex();
            Forms.FormBranchList bl = new FormBranchList();
            DialogResult res = bl.ShowDialog();
            if (res == DialogResult.OK)
                LoadBranches();
        }

        private void LoadBranches()
        {
            branches = new BranchesList();

            cbBranch1.BindingContext = new BindingContext();
            cbBranch1.DataSource = branches.list;

            cbBranch2.BindingContext = new BindingContext();
            cbBranch2.DataSource = branches.list;

            cbBranch1.SelectedIndex = branches.SelectedBranchIndex1;
            cbBranch2.SelectedIndex = branches.SelectedBranchIndex2;
        }

        private void SaveCBIndex()
        {
            Properties.Settings.Default.BranchSelectedIndex1 = cbBranch1.SelectedIndex;
            Properties.Settings.Default.BranchSelectedIndex2 = cbBranch2.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void FormCompare_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCBIndex();
        }

        private void FillFilesList(string SqlFile = null)
        {
            if (cbBranch1.SelectedIndex == -1 || cbBranch2.SelectedIndex == -1)
            {
                rtbMain.Text = "Укажите ветки для сравнения";
            }
            else
            {
                List<string> files = CMD.CmdAPI.GetModifiedFiles(cbBranch1.SelectedItem.ToString(), cbBranch2.SelectedItem.ToString());
                if (SqlFile != null)
                {
                    files.RemoveAll(x => x == SqlFile);
                    files.Insert(0, SqlFile);
                    listBoxFiles.DataSource = files;
                    listBoxFiles.SelectedIndex = 0;
                }
                else
                    listBoxFiles.DataSource = files;
            }
        }

        private void ListBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLFile = (sender as ListBox).SelectedItem.ToString() ;
            FillRtb();
        }
    }
}
