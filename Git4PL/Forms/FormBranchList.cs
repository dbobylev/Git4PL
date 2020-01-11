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
    public partial class FormBranchList : Form
    {
        private BranchesList branches;

        public FormBranchList(BranchesList bl = null)
        {
            InitializeComponent();

            if (bl is null)
                bl = new BranchesList();
            branches = bl;
            dgvMain.DataSource = branches.list;
        }

        private void ButtonDeleteRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in dgvMain.SelectedCells)
            {
                if (item.RowIndex < branches.list.Count)
                  branches.list.RemoveAt(item.RowIndex);
            }
        }

        private void FormBranchList_FormClosing(object sender, FormClosingEventArgs e)
        {
            branches.Save();
            DialogResult = DialogResult.OK;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
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

    }
}
