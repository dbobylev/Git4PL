namespace Git4PL.Forms
{
    partial class FormBlameN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBlameN));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBranch = new System.Windows.Forms.TextBox();
            this.textBoxObjectName = new System.Windows.Forms.TextBox();
            this.textBoxBegin = new System.Windows.Forms.TextBox();
            this.textBoxEnd = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Plus10 = new System.Windows.Forms.Button();
            this.buttonBlame = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBranch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxObjectName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBegin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEnd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelButtons, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00066F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00067F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00067F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99801F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(263, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Конец";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ветка";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Объект";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начало";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBranch
            // 
            this.textBoxBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBranch.BackColor = System.Drawing.Color.White;
            this.textBoxBranch.Location = new System.Drawing.Point(63, 5);
            this.textBoxBranch.Name = "textBoxBranch";
            this.textBoxBranch.ReadOnly = true;
            this.textBoxBranch.Size = new System.Drawing.Size(111, 20);
            this.textBoxBranch.TabIndex = 3;
            // 
            // textBoxObjectName
            // 
            this.textBoxObjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxObjectName.BackColor = System.Drawing.Color.White;
            this.textBoxObjectName.Location = new System.Drawing.Point(63, 35);
            this.textBoxObjectName.Name = "textBoxObjectName";
            this.textBoxObjectName.ReadOnly = true;
            this.textBoxObjectName.Size = new System.Drawing.Size(111, 20);
            this.textBoxObjectName.TabIndex = 4;
            // 
            // textBoxBegin
            // 
            this.textBoxBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBegin.Location = new System.Drawing.Point(63, 65);
            this.textBoxBegin.Name = "textBoxBegin";
            this.textBoxBegin.Size = new System.Drawing.Size(111, 20);
            this.textBoxBegin.TabIndex = 5;
            this.textBoxBegin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberFilter_KeyPress);
            // 
            // textBoxEnd
            // 
            this.textBoxEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEnd.Location = new System.Drawing.Point(63, 96);
            this.textBoxEnd.Name = "textBoxEnd";
            this.textBoxEnd.Size = new System.Drawing.Size(111, 20);
            this.textBoxEnd.TabIndex = 7;
            this.textBoxEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberFilter_KeyPress);
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons.Controls.Add(this.button_Plus10);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonBlame);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonHelp);
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(177, 0);
            this.flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.tableLayoutPanel1.SetRowSpan(this.flowLayoutPanelButtons, 4);
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(81, 87);
            this.flowLayoutPanelButtons.TabIndex = 9;
            // 
            // button_Plus10
            // 
            this.button_Plus10.Location = new System.Drawing.Point(3, 3);
            this.button_Plus10.Name = "button_Plus10";
            this.button_Plus10.Size = new System.Drawing.Size(75, 23);
            this.button_Plus10.TabIndex = 8;
            this.button_Plus10.Text = "+10";
            this.button_Plus10.UseVisualStyleBackColor = true;
            this.button_Plus10.Click += new System.EventHandler(this.Button_Plus10_Click);
            // 
            // buttonBlame
            // 
            this.buttonBlame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBlame.Location = new System.Drawing.Point(3, 32);
            this.buttonBlame.Name = "buttonBlame";
            this.buttonBlame.Size = new System.Drawing.Size(75, 23);
            this.buttonBlame.TabIndex = 6;
            this.buttonBlame.Text = "Blame";
            this.buttonBlame.UseVisualStyleBackColor = true;
            this.buttonBlame.Click += new System.EventHandler(this.ButtonBlame_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(3, 61);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // FormBlameN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 123);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBlameN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blame";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBranch;
        private System.Windows.Forms.TextBox textBoxObjectName;
        private System.Windows.Forms.TextBox textBoxBegin;
        private System.Windows.Forms.Button buttonBlame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEnd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button button_Plus10;
    }
}