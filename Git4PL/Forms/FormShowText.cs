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
    public partial class FormShowText : Form
    {
        public FormShowText(string text)
        {
            InitializeComponent();
            int n = text.Count(x => x == '\n');
            Height = Math.Min(Height, n * 13 + 100);
            rtbMain.Text = text;
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
