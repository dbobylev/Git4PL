using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git4PL.Forms
{
    public partial class FormBlameN : Form
    {
        public int numMin { get; private set; }
        public int numMax { get; private set; }

        public FormBlameN(string branch, string objName, int posY)
        {
            InitializeComponent();
            textBoxBranch.Text = branch;
            textBoxObjectName.Text = objName;
            textBoxBegin.Text = Math.Max(1, posY - 10).ToString();
            textBoxEnd.Text = (posY + 10).ToString();
        }

        private void ButtonBlame_Click(object sender, EventArgs e)
        {
            numMin = int.Parse(textBoxBegin.Text);
            numMax = int.Parse(textBoxEnd.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox_NumberFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                ButtonBlame_Click(this, new EventArgs());
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            PluginCommands.ShowHelp(this, "blame");
        }

        private void Button_Plus10_Click(object sender, EventArgs e)
        {
            textBoxBegin.Text = Math.Max(1, int.Parse(textBoxBegin.Text) - 10).ToString();
            textBoxEnd.Text = (int.Parse(textBoxEnd.Text) + 10).ToString();
        }
    }
}
