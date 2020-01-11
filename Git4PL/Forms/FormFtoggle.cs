using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Git4PL.Features.FT;

namespace Git4PL.Forms
{
    public partial class FormFtoggle : Form
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public FormFtoggle(FTItem[] FtoggleItemList)
        {
            InitializeComponent();

            // Биндим данные к таблице
            BindingSource bs = new BindingSource();
            bs.AllowNew = false;
            bs.DataSource = new BindingList<FTItem>(FtoggleItemList);
            dgwMain.DataSource = bs;
        }

        private void FormFtoggle_Load(object sender, EventArgs e)
        {
            // Разукрашиваем ячейку со статусом
            foreach (DataGridViewRow row in dgwMain.Rows)
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell.OwningColumn.Name == "statusDataGridViewCheckBoxColumn")
                        cell.Style.BackColor = ((bool)cell.Value ? Color.Lime : Color.Red);

            // Размер окна в зависимости от количества найденных строк
            var height = 25;
            foreach (DataGridViewRow dr in dgwMain.Rows)
                height += dr.Height;

            dgwMain.Height = height;
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


        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
