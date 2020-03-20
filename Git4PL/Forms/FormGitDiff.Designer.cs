namespace Git4PL.Forms
{
    partial class FormGitDiff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGitDiff));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslBranchKey = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBranchValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslServerKey = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslServerValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslObjectKey = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslObjectValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPathKey = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPathValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonGoToLine = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.flPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslBranchKey,
            this.tsslBranchValue,
            this.tsslServerKey,
            this.tsslServerValue,
            this.tsslObjectKey,
            this.tsslObjectValue,
            this.tsslPathKey,
            this.tsslPathValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslBranchKey
            // 
            this.tsslBranchKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsslBranchKey.Image = global::Git4PL.Properties.Resources.arrow_branch_icon;
            this.tsslBranchKey.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tsslBranchKey.Name = "tsslBranchKey";
            this.tsslBranchKey.Size = new System.Drawing.Size(16, 17);
            // 
            // tsslBranchValue
            // 
            this.tsslBranchValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsslBranchValue.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.tsslBranchValue.Name = "tsslBranchValue";
            this.tsslBranchValue.Size = new System.Drawing.Size(118, 17);
            this.tsslBranchValue.Text = "toolStripStatusLabel1";
            this.tsslBranchValue.Click += new System.EventHandler(this.TsslBranchValue_Click);
            // 
            // tsslServerKey
            // 
            this.tsslServerKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsslServerKey.Image = global::Git4PL.Properties.Resources.database_red_icon;
            this.tsslServerKey.Margin = new System.Windows.Forms.Padding(15, 3, 0, 2);
            this.tsslServerKey.Name = "tsslServerKey";
            this.tsslServerKey.Size = new System.Drawing.Size(16, 17);
            // 
            // tsslServerValue
            // 
            this.tsslServerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsslServerValue.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.tsslServerValue.Name = "tsslServerValue";
            this.tsslServerValue.Size = new System.Drawing.Size(118, 17);
            this.tsslServerValue.Text = "toolStripStatusLabel1";
            // 
            // tsslObjectKey
            // 
            this.tsslObjectKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsslObjectKey.Image = global::Git4PL.Properties.Resources.sql;
            this.tsslObjectKey.Margin = new System.Windows.Forms.Padding(15, 3, 0, 2);
            this.tsslObjectKey.Name = "tsslObjectKey";
            this.tsslObjectKey.Size = new System.Drawing.Size(16, 17);
            // 
            // tsslObjectValue
            // 
            this.tsslObjectValue.BackColor = System.Drawing.SystemColors.Control;
            this.tsslObjectValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsslObjectValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsslObjectValue.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.tsslObjectValue.Name = "tsslObjectValue";
            this.tsslObjectValue.Size = new System.Drawing.Size(118, 17);
            this.tsslObjectValue.Text = "toolStripStatusLabel1";
            // 
            // tsslPathKey
            // 
            this.tsslPathKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsslPathKey.Image = global::Git4PL.Properties.Resources.Folder_icon;
            this.tsslPathKey.Margin = new System.Windows.Forms.Padding(15, 3, 0, 2);
            this.tsslPathKey.Name = "tsslPathKey";
            this.tsslPathKey.Size = new System.Drawing.Size(16, 17);
            // 
            // tsslPathValue
            // 
            this.tsslPathValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsslPathValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsslPathValue.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.tsslPathValue.Name = "tsslPathValue";
            this.tsslPathValue.Size = new System.Drawing.Size(118, 17);
            this.tsslPathValue.Text = "toolStripStatusLabel1";
            this.tsslPathValue.Click += new System.EventHandler(this.TsslPathValue_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flPanelButtons);
            this.panelMain.Controls.Add(this.rtbMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(984, 739);
            this.panelMain.TabIndex = 2;
            // 
            // flPanelButtons
            // 
            this.flPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flPanelButtons.AutoSize = true;
            this.flPanelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flPanelButtons.BackColor = System.Drawing.Color.White;
            this.flPanelButtons.Controls.Add(this.buttonHelp);
            this.flPanelButtons.Controls.Add(this.buttonGoToLine);
            this.flPanelButtons.Controls.Add(this.buttonCheckIn);
            this.flPanelButtons.Controls.Add(this.buttonCheckOut);
            this.flPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flPanelButtons.Location = new System.Drawing.Point(616, 707);
            this.flPanelButtons.Name = "flPanelButtons";
            this.flPanelButtons.Size = new System.Drawing.Size(345, 29);
            this.flPanelButtons.TabIndex = 1;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(267, 3);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // buttonGoToLine
            // 
            this.buttonGoToLine.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonGoToLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoToLine.Location = new System.Drawing.Point(179, 3);
            this.buttonGoToLine.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonGoToLine.Name = "buttonGoToLine";
            this.buttonGoToLine.Size = new System.Drawing.Size(75, 23);
            this.buttonGoToLine.TabIndex = 2;
            this.buttonGoToLine.Text = "GoToLine";
            this.buttonGoToLine.UseVisualStyleBackColor = false;
            this.buttonGoToLine.Click += new System.EventHandler(this.ButtonGoToLine_Click);
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckIn.Location = new System.Drawing.Point(91, 3);
            this.buttonCheckIn.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckIn.TabIndex = 1;
            this.buttonCheckIn.Text = "CheckIn";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.ButtonCheckIn_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckOut.Location = new System.Drawing.Point(3, 3);
            this.buttonCheckOut.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckOut.TabIndex = 0;
            this.buttonCheckOut.Text = "CheckOut";
            this.buttonCheckOut.UseVisualStyleBackColor = false;
            this.buttonCheckOut.Click += new System.EventHandler(this.ButtonCheckOut_Click);
            // 
            // rtbMain
            // 
            this.rtbMain.AutoWordSelection = true;
            this.rtbMain.BackColor = System.Drawing.Color.White;
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMain.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMain.Location = new System.Drawing.Point(0, 0);
            this.rtbMain.Margin = new System.Windows.Forms.Padding(10);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ReadOnly = true;
            this.rtbMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbMain.Size = new System.Drawing.Size(984, 739);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            this.rtbMain.Click += new System.EventHandler(this.RtbMain_Click);
            // 
            // FormGitDiff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormGitDiff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Git Diff";
            this.Load += new System.EventHandler(this.FormGitDiff_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslBranchKey;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flPanelButtons;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslServerKey;
        private System.Windows.Forms.ToolStripStatusLabel tsslObjectKey;
        private System.Windows.Forms.ToolStripStatusLabel tsslPathKey;
        private System.Windows.Forms.ToolStripStatusLabel tsslBranchValue;
        private System.Windows.Forms.ToolStripStatusLabel tsslServerValue;
        private System.Windows.Forms.ToolStripStatusLabel tsslObjectValue;
        private System.Windows.Forms.ToolStripStatusLabel tsslPathValue;
        private System.Windows.Forms.Button buttonGoToLine;
    }
}