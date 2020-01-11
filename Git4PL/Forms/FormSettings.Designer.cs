namespace Git4PL.Forms
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.textBoxRepositoryPath = new System.Windows.Forms.TextBox();
            this.buttonSelectRepo = new System.Windows.Forms.Button();
            this.checkBoxChangeCor = new System.Windows.Forms.CheckBox();
            this.checkBoxChangeName = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnpreSlash = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEncodingToSave = new System.Windows.Forms.ComboBox();
            this.checkBoxWarningBranch = new System.Windows.Forms.CheckBox();
            this.checkBoxWarningServer = new System.Windows.Forms.CheckBox();
            this.buttonHelpTaskInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxWarnIn = new System.Windows.Forms.TextBox();
            this.textBoxWarnOut = new System.Windows.Forms.TextBox();
            this.textBoxGitExePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonHelpSettings = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonHelpWarnings = new System.Windows.Forms.Button();
            this.textBoxSNLogin = new System.Windows.Forms.TextBox();
            this.textBoxSNPassword = new System.Windows.Forms.TextBox();
            this.label9_line = new System.Windows.Forms.Label();
            this.label11_line = new System.Windows.Forms.Label();
            this.label12_line = new System.Windows.Forms.Label();
            this.label13_line = new System.Windows.Forms.Label();
            this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
            this.buttonHelpLogs = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15_line = new System.Windows.Forms.Label();
            this.checkBoxAddSchema = new System.Windows.Forms.CheckBox();
            this.checkBoxCRLF = new System.Windows.Forms.CheckBox();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.label6_line = new System.Windows.Forms.Label();
            this.checkBoxIgnoreSpaceAtEol = new System.Windows.Forms.CheckBox();
            this.buttonSelectGitExe = new System.Windows.Forms.Button();
            this.buttonHelpSetRep = new System.Windows.Forms.Button();
            this.buttonHelpGitExe = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRepositoryPath
            // 
            this.textBoxRepositoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxRepositoryPath, 2);
            this.textBoxRepositoryPath.Location = new System.Drawing.Point(133, 5);
            this.textBoxRepositoryPath.MinimumSize = new System.Drawing.Size(4, 4);
            this.textBoxRepositoryPath.Name = "textBoxRepositoryPath";
            this.textBoxRepositoryPath.Size = new System.Drawing.Size(237, 20);
            this.textBoxRepositoryPath.TabIndex = 0;
            // 
            // buttonSelectRepo
            // 
            this.buttonSelectRepo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectRepo.Location = new System.Drawing.Point(376, 3);
            this.buttonSelectRepo.Name = "buttonSelectRepo";
            this.buttonSelectRepo.Size = new System.Drawing.Size(29, 23);
            this.buttonSelectRepo.TabIndex = 1;
            this.buttonSelectRepo.Text = "...";
            this.buttonSelectRepo.UseVisualStyleBackColor = true;
            this.buttonSelectRepo.Click += new System.EventHandler(this.ButtonSelectRepo_Click);
            // 
            // checkBoxChangeCor
            // 
            this.checkBoxChangeCor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxChangeCor.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxChangeCor, 3);
            this.checkBoxChangeCor.Location = new System.Drawing.Point(133, 38);
            this.checkBoxChangeCor.Name = "checkBoxChangeCor";
            this.checkBoxChangeCor.Size = new System.Drawing.Size(268, 17);
            this.checkBoxChangeCor.TabIndex = 0;
            this.checkBoxChangeCor.Text = "Игнорировать изменения до названия объекта\r\n";
            this.checkBoxChangeCor.UseVisualStyleBackColor = true;
            // 
            // checkBoxChangeName
            // 
            this.checkBoxChangeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxChangeName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxChangeName, 3);
            this.checkBoxChangeName.Location = new System.Drawing.Point(133, 68);
            this.checkBoxChangeName.Name = "checkBoxChangeName";
            this.checkBoxChangeName.Size = new System.Drawing.Size(221, 17);
            this.checkBoxChangeName.TabIndex = 1;
            this.checkBoxChangeName.Text = "Сохранять название объекта как в Git";
            this.checkBoxChangeName.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnpreSlash
            // 
            this.checkBoxIgnpreSlash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxIgnpreSlash.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxIgnpreSlash, 3);
            this.checkBoxIgnpreSlash.Location = new System.Drawing.Point(133, 128);
            this.checkBoxIgnpreSlash.Name = "checkBoxIgnpreSlash";
            this.checkBoxIgnpreSlash.Size = new System.Drawing.Size(189, 17);
            this.checkBoxIgnpreSlash.TabIndex = 2;
            this.checkBoxIgnpreSlash.Text = "Обрабатывать \'/\' в конце файла";
            this.checkBoxIgnpreSlash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кодировка CheckIn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxEncodingToSave
            // 
            this.comboBoxEncodingToSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxEncodingToSave, 3);
            this.comboBoxEncodingToSave.FormattingEnabled = true;
            this.comboBoxEncodingToSave.Location = new System.Drawing.Point(133, 216);
            this.comboBoxEncodingToSave.Name = "comboBoxEncodingToSave";
            this.comboBoxEncodingToSave.Size = new System.Drawing.Size(272, 21);
            this.comboBoxEncodingToSave.TabIndex = 1;
            // 
            // checkBoxWarningBranch
            // 
            this.checkBoxWarningBranch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxWarningBranch.AutoSize = true;
            this.checkBoxWarningBranch.Location = new System.Drawing.Point(133, 250);
            this.checkBoxWarningBranch.Name = "checkBoxWarningBranch";
            this.checkBoxWarningBranch.Size = new System.Drawing.Size(66, 17);
            this.checkBoxWarningBranch.TabIndex = 3;
            this.checkBoxWarningBranch.Text = "CheckIn";
            this.checkBoxWarningBranch.UseVisualStyleBackColor = true;
            this.checkBoxWarningBranch.CheckedChanged += new System.EventHandler(this.CheckBoxWarningBranch_CheckedChanged);
            // 
            // checkBoxWarningServer
            // 
            this.checkBoxWarningServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxWarningServer.AutoSize = true;
            this.checkBoxWarningServer.Location = new System.Drawing.Point(133, 280);
            this.checkBoxWarningServer.Name = "checkBoxWarningServer";
            this.checkBoxWarningServer.Size = new System.Drawing.Size(74, 17);
            this.checkBoxWarningServer.TabIndex = 4;
            this.checkBoxWarningServer.Text = "CheckOut";
            this.checkBoxWarningServer.UseVisualStyleBackColor = true;
            this.checkBoxWarningServer.CheckedChanged += new System.EventHandler(this.CheckBoxWarningServer_CheckedChanged);
            // 
            // buttonHelpTaskInfo
            // 
            this.buttonHelpTaskInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHelpTaskInfo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelpTaskInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelpTaskInfo.Location = new System.Drawing.Point(413, 324);
            this.buttonHelpTaskInfo.Name = "buttonHelpTaskInfo";
            this.tableLayoutPanel1.SetRowSpan(this.buttonHelpTaskInfo, 2);
            this.buttonHelpTaskInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonHelpTaskInfo.TabIndex = 5;
            this.buttonHelpTaskInfo.Text = "Помощь";
            this.buttonHelpTaskInfo.UseVisualStyleBackColor = true;
            this.buttonHelpTaskInfo.Click += new System.EventHandler(this.ButtonHelpTaskInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "SN Логин:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "SN Пароль:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxWarnIn, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.textBoxWarnOut, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGitExePath, 1, 18);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRepositoryPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxChangeCor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxChangeName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxIgnpreSlash, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonHelpSettings, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxEncodingToSave, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.buttonHelpWarnings, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSNLogin, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSNPassword, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.label9_line, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11_line, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label12_line, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label13_line, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.buttonHelpTaskInfo, 4, 13);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxLogLevel, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.buttonHelpLogs, 4, 16);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.label15_line, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAddSchema, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxCRLF, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ButtonApply, 0, 20);
            this.tableLayoutPanel1.Controls.Add(this.label6_line, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxIgnoreSpaceAtEol, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxWarningBranch, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxWarningServer, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectGitExe, 3, 18);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectRepo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonHelpSetRep, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonHelpGitExe, 4, 18);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 21;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666928F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.664525F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.664177F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.66893F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.66893F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667529F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667529F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.664914F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667248F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.664987F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 463);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textBoxWarnIn
            // 
            this.textBoxWarnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxWarnIn, 2);
            this.textBoxWarnIn.Location = new System.Drawing.Point(213, 249);
            this.textBoxWarnIn.Name = "textBoxWarnIn";
            this.textBoxWarnIn.Size = new System.Drawing.Size(192, 20);
            this.textBoxWarnIn.TabIndex = 4;
            // 
            // textBoxWarnOut
            // 
            this.textBoxWarnOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxWarnOut, 2);
            this.textBoxWarnOut.Location = new System.Drawing.Point(213, 279);
            this.textBoxWarnOut.Name = "textBoxWarnOut";
            this.textBoxWarnOut.Size = new System.Drawing.Size(192, 20);
            this.textBoxWarnOut.TabIndex = 5;
            // 
            // textBoxGitExePath
            // 
            this.textBoxGitExePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxGitExePath, 2);
            this.textBoxGitExePath.Location = new System.Drawing.Point(133, 405);
            this.textBoxGitExePath.MinimumSize = new System.Drawing.Size(4, 4);
            this.textBoxGitExePath.Name = "textBoxGitExePath";
            this.textBoxGitExePath.Size = new System.Drawing.Size(237, 20);
            this.textBoxGitExePath.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 403);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Расположение git.exe";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Репозиторий Git:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.tableLayoutPanel1.SetRowSpan(this.label5, 6);
            this.label5.Size = new System.Drawing.Size(124, 174);
            this.label5.TabIndex = 9;
            this.label5.Text = "Git Diff:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonHelpSettings
            // 
            this.buttonHelpSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHelpSettings.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelpSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelpSettings.Location = new System.Drawing.Point(413, 125);
            this.buttonHelpSettings.Name = "buttonHelpSettings";
            this.tableLayoutPanel1.SetRowSpan(this.buttonHelpSettings, 7);
            this.buttonHelpSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonHelpSettings.TabIndex = 8;
            this.buttonHelpSettings.Text = "Помощь";
            this.buttonHelpSettings.UseVisualStyleBackColor = true;
            this.buttonHelpSettings.Click += new System.EventHandler(this.ButtonHelpSettings_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Предупреждение:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 277);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "Предупреждение:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonHelpWarnings
            // 
            this.buttonHelpWarnings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHelpWarnings.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelpWarnings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelpWarnings.Location = new System.Drawing.Point(413, 262);
            this.buttonHelpWarnings.Name = "buttonHelpWarnings";
            this.tableLayoutPanel1.SetRowSpan(this.buttonHelpWarnings, 2);
            this.buttonHelpWarnings.Size = new System.Drawing.Size(75, 23);
            this.buttonHelpWarnings.TabIndex = 6;
            this.buttonHelpWarnings.Text = "Помощь";
            this.buttonHelpWarnings.UseVisualStyleBackColor = true;
            this.buttonHelpWarnings.Click += new System.EventHandler(this.ButtonHelpWarnings_Click);
            // 
            // textBoxSNLogin
            // 
            this.textBoxSNLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxSNLogin, 3);
            this.textBoxSNLogin.Location = new System.Drawing.Point(133, 311);
            this.textBoxSNLogin.Name = "textBoxSNLogin";
            this.textBoxSNLogin.Size = new System.Drawing.Size(272, 20);
            this.textBoxSNLogin.TabIndex = 16;
            // 
            // textBoxSNPassword
            // 
            this.textBoxSNPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxSNPassword, 3);
            this.textBoxSNPassword.Location = new System.Drawing.Point(133, 341);
            this.textBoxSNPassword.Name = "textBoxSNPassword";
            this.textBoxSNPassword.PasswordChar = '*';
            this.textBoxSNPassword.Size = new System.Drawing.Size(272, 20);
            this.textBoxSNPassword.TabIndex = 17;
            this.textBoxSNPassword.UseSystemPasswordChar = true;
            this.textBoxSNPassword.Click += new System.EventHandler(this.TextBoxWebPassword_Click);
            this.textBoxSNPassword.TextChanged += new System.EventHandler(this.TextBoxWebPassword_TextChanged);
            // 
            // label9_line
            // 
            this.label9_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label9_line, 5);
            this.label9_line.Location = new System.Drawing.Point(3, 30);
            this.label9_line.Name = "label9_line";
            this.label9_line.Size = new System.Drawing.Size(488, 2);
            this.label9_line.TabIndex = 18;
            // 
            // label11_line
            // 
            this.label11_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label11_line, 5);
            this.label11_line.Location = new System.Drawing.Point(3, 242);
            this.label11_line.Name = "label11_line";
            this.label11_line.Size = new System.Drawing.Size(488, 2);
            this.label11_line.TabIndex = 19;
            // 
            // label12_line
            // 
            this.label12_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label12_line, 5);
            this.label12_line.Location = new System.Drawing.Point(3, 304);
            this.label12_line.Name = "label12_line";
            this.label12_line.Size = new System.Drawing.Size(488, 2);
            this.label12_line.TabIndex = 20;
            // 
            // label13_line
            // 
            this.label13_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label13_line, 5);
            this.label13_line.Location = new System.Drawing.Point(3, 366);
            this.label13_line.Name = "label13_line";
            this.label13_line.Size = new System.Drawing.Size(488, 2);
            this.label13_line.TabIndex = 21;
            // 
            // comboBoxLogLevel
            // 
            this.comboBoxLogLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxLogLevel, 3);
            this.comboBoxLogLevel.FormattingEnabled = true;
            this.comboBoxLogLevel.Location = new System.Drawing.Point(133, 372);
            this.comboBoxLogLevel.Name = "comboBoxLogLevel";
            this.comboBoxLogLevel.Size = new System.Drawing.Size(272, 21);
            this.comboBoxLogLevel.TabIndex = 22;
            this.comboBoxLogLevel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLogLevel_SelectedIndexChanged);
            // 
            // buttonHelpLogs
            // 
            this.buttonHelpLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHelpLogs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelpLogs.Location = new System.Drawing.Point(413, 371);
            this.buttonHelpLogs.Name = "buttonHelpLogs";
            this.buttonHelpLogs.Size = new System.Drawing.Size(75, 23);
            this.buttonHelpLogs.TabIndex = 23;
            this.buttonHelpLogs.Text = "Помощь";
            this.buttonHelpLogs.UseVisualStyleBackColor = true;
            this.buttonHelpLogs.Click += new System.EventHandler(this.ButtonHelpLogs_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 371);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "Уровень логирования:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15_line
            // 
            this.label15_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label15_line, 5);
            this.label15_line.Location = new System.Drawing.Point(3, 398);
            this.label15_line.Name = "label15_line";
            this.label15_line.Size = new System.Drawing.Size(488, 2);
            this.label15_line.TabIndex = 25;
            // 
            // checkBoxAddSchema
            // 
            this.checkBoxAddSchema.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAddSchema.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxAddSchema, 3);
            this.checkBoxAddSchema.Location = new System.Drawing.Point(133, 98);
            this.checkBoxAddSchema.Name = "checkBoxAddSchema";
            this.checkBoxAddSchema.Size = new System.Drawing.Size(272, 17);
            this.checkBoxAddSchema.TabIndex = 26;
            this.checkBoxAddSchema.Text = "Добавлять префикс схемы к названию объекта";
            this.checkBoxAddSchema.UseVisualStyleBackColor = true;
            // 
            // checkBoxCRLF
            // 
            this.checkBoxCRLF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCRLF.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxCRLF, 3);
            this.checkBoxCRLF.Location = new System.Drawing.Point(133, 158);
            this.checkBoxCRLF.Name = "checkBoxCRLF";
            this.checkBoxCRLF.Size = new System.Drawing.Size(196, 17);
            this.checkBoxCRLF.TabIndex = 27;
            this.checkBoxCRLF.Text = "Обрабатывать перенос строк \'LF\'";
            this.checkBoxCRLF.UseVisualStyleBackColor = true;
            // 
            // ButtonApply
            // 
            this.ButtonApply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.ButtonApply, 5);
            this.ButtonApply.Location = new System.Drawing.Point(209, 436);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(75, 23);
            this.ButtonApply.TabIndex = 15;
            this.ButtonApply.Text = "Применить";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // label6_line
            // 
            this.label6_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label6_line, 5);
            this.label6_line.Location = new System.Drawing.Point(3, 430);
            this.label6_line.Name = "label6_line";
            this.label6_line.Size = new System.Drawing.Size(488, 2);
            this.label6_line.TabIndex = 28;
            // 
            // checkBoxIgnoreSpaceAtEol
            // 
            this.checkBoxIgnoreSpaceAtEol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxIgnoreSpaceAtEol.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxIgnoreSpaceAtEol, 3);
            this.checkBoxIgnoreSpaceAtEol.Location = new System.Drawing.Point(133, 188);
            this.checkBoxIgnoreSpaceAtEol.Name = "checkBoxIgnoreSpaceAtEol";
            this.checkBoxIgnoreSpaceAtEol.Size = new System.Drawing.Size(234, 17);
            this.checkBoxIgnoreSpaceAtEol.TabIndex = 32;
            this.checkBoxIgnoreSpaceAtEol.Text = "Игн. изменеия в пробелах в конце строк";
            this.checkBoxIgnoreSpaceAtEol.UseVisualStyleBackColor = true;
            // 
            // buttonSelectGitExe
            // 
            this.buttonSelectGitExe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectGitExe.Location = new System.Drawing.Point(376, 403);
            this.buttonSelectGitExe.Name = "buttonSelectGitExe";
            this.buttonSelectGitExe.Size = new System.Drawing.Size(29, 23);
            this.buttonSelectGitExe.TabIndex = 31;
            this.buttonSelectGitExe.Text = "...";
            this.buttonSelectGitExe.UseVisualStyleBackColor = true;
            this.buttonSelectGitExe.Click += new System.EventHandler(this.ButtonSelectGitExe_Click);
            // 
            // buttonHelpSetRep
            // 
            this.buttonHelpSetRep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHelpSetRep.Location = new System.Drawing.Point(413, 3);
            this.buttonHelpSetRep.Name = "buttonHelpSetRep";
            this.buttonHelpSetRep.Size = new System.Drawing.Size(75, 23);
            this.buttonHelpSetRep.TabIndex = 33;
            this.buttonHelpSetRep.Text = "Помощь";
            this.buttonHelpSetRep.UseVisualStyleBackColor = true;
            this.buttonHelpSetRep.Click += new System.EventHandler(this.ButtonHelpSetRep_Click);
            // 
            // buttonHelpGitExe
            // 
            this.buttonHelpGitExe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHelpGitExe.Location = new System.Drawing.Point(413, 403);
            this.buttonHelpGitExe.Name = "buttonHelpGitExe";
            this.buttonHelpGitExe.Size = new System.Drawing.Size(75, 23);
            this.buttonHelpGitExe.TabIndex = 34;
            this.buttonHelpGitExe.Text = "Помощь";
            this.buttonHelpGitExe.UseVisualStyleBackColor = true;
            this.buttonHelpGitExe.Click += new System.EventHandler(this.ButtonHelpGitExe_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRepositoryPath;
        private System.Windows.Forms.Button buttonSelectRepo;
        private System.Windows.Forms.CheckBox checkBoxChangeCor;
        private System.Windows.Forms.CheckBox checkBoxChangeName;
        private System.Windows.Forms.CheckBox checkBoxIgnpreSlash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEncodingToSave;
        private System.Windows.Forms.CheckBox checkBoxWarningBranch;
        private System.Windows.Forms.CheckBox checkBoxWarningServer;
        private System.Windows.Forms.Button buttonHelpTaskInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonHelpWarnings;
        private System.Windows.Forms.Button buttonHelpSettings;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.TextBox textBoxSNLogin;
        private System.Windows.Forms.TextBox textBoxSNPassword;
        private System.Windows.Forms.Label label9_line;
        private System.Windows.Forms.Label label11_line;
        private System.Windows.Forms.Label label12_line;
        private System.Windows.Forms.Label label13_line;
        private System.Windows.Forms.ComboBox comboBoxLogLevel;
        private System.Windows.Forms.Button buttonHelpLogs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15_line;
        private System.Windows.Forms.CheckBox checkBoxAddSchema;
        private System.Windows.Forms.CheckBox checkBoxCRLF;
        private System.Windows.Forms.Button buttonSelectGitExe;
        private System.Windows.Forms.TextBox textBoxGitExePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label6_line;
        private System.Windows.Forms.CheckBox checkBoxIgnoreSpaceAtEol;
        private System.Windows.Forms.TextBox textBoxWarnIn;
        private System.Windows.Forms.TextBox textBoxWarnOut;
        private System.Windows.Forms.Button buttonHelpSetRep;
        private System.Windows.Forms.Button buttonHelpGitExe;
    }
}