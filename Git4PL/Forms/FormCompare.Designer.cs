namespace Git4PL.Forms
{
    partial class FormCompare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompare));
            this.buttonCompare = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbBranch1 = new System.Windows.Forms.ComboBox();
            this.cbBranch2 = new System.Windows.Forms.ComboBox();
            this.buttonBranchList = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(335, 3);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 3;
            this.buttonCompare.Text = "Сравнить";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.ButtonCompare_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.rtbMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxFiles, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 761);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // rtbMain
            // 
            this.rtbMain.BackColor = System.Drawing.Color.White;
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMain.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMain.Location = new System.Drawing.Point(3, 3);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbMain.Size = new System.Drawing.Size(728, 719);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbBranch1);
            this.flowLayoutPanel1.Controls.Add(this.cbBranch2);
            this.flowLayoutPanel1.Controls.Add(this.buttonCompare);
            this.flowLayoutPanel1.Controls.Add(this.buttonBranchList);
            this.flowLayoutPanel1.Controls.Add(this.buttonClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 729);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(728, 29);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // cbBranch1
            // 
            this.cbBranch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbBranch1.DisplayMember = "Value";
            this.cbBranch1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBranch1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBranch1.FormattingEnabled = true;
            this.cbBranch1.Location = new System.Drawing.Point(3, 4);
            this.cbBranch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.cbBranch1.Name = "cbBranch1";
            this.cbBranch1.Size = new System.Drawing.Size(160, 21);
            this.cbBranch1.TabIndex = 6;
            this.cbBranch1.Tag = 1;
            // 
            // cbBranch2
            // 
            this.cbBranch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbBranch2.DisplayMember = "Value";
            this.cbBranch2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranch2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBranch2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBranch2.FormattingEnabled = true;
            this.cbBranch2.Location = new System.Drawing.Point(169, 4);
            this.cbBranch2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.cbBranch2.Name = "cbBranch2";
            this.cbBranch2.Size = new System.Drawing.Size(160, 21);
            this.cbBranch2.TabIndex = 7;
            this.cbBranch2.Tag = 2;
            // 
            // buttonBranchList
            // 
            this.buttonBranchList.Location = new System.Drawing.Point(416, 3);
            this.buttonBranchList.Name = "buttonBranchList";
            this.buttonBranchList.Size = new System.Drawing.Size(75, 23);
            this.buttonBranchList.TabIndex = 5;
            this.buttonBranchList.Text = "Ветки";
            this.buttonBranchList.UseVisualStyleBackColor = true;
            this.buttonBranchList.Click += new System.EventHandler(this.ButtonBranchList_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(497, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(737, 3);
            this.listBoxFiles.Name = "listBoxFiles";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxFiles, 2);
            this.listBoxFiles.Size = new System.Drawing.Size(244, 755);
            this.listBoxFiles.TabIndex = 7;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.ListBoxFiles_SelectedIndexChanged);
            // 
            // FormCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(398, 297);
            this.Name = "FormCompare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCompare_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonBranchList;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbBranch1;
        private System.Windows.Forms.ComboBox cbBranch2;
        private System.Windows.Forms.ListBox listBoxFiles;
    }
}