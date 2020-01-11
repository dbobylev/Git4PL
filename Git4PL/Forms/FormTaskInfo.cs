using System;
using System.Windows.Forms;
using Git4PL.Features.Task;
using Git4PL;

namespace Git4PL.Forms
{
    public partial class FormTaskInfo : Form
    {
        public static bool IsOpen = false;
        private TaskInfo Task;

        public FormTaskInfo(TaskInfo task)
        {
            IsOpen = true;
            InitializeComponent();
            this.Task = task;
            BindTaskToForm();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BindTaskToForm()
        {
            taskInfoBindingSource.DataSource = Task;
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

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            Task.Open();
            this.Close();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            PluginCommands.ShowHelp(this, "taskinfo");
        }

        private void FormTaskInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsOpen = false;
        }
    }
}
