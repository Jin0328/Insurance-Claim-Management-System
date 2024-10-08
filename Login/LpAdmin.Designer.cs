namespace Login
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            panel1 = new Panel();
            lblViewMessages = new Label();
            exit_btn = new Roundbtn();
            btn_logout = new Roundbtn();
            label1 = new Label();
            lbl_showUser = new Label();
            pictureBox1 = new PictureBox();
            btnViewUser = new Roundbtn();
            label2 = new Label();
            btnUploadFile = new Roundbtn();
            btnShowFolders = new Roundbtn();
            ofdLpAdmin = new OpenFileDialog();
            btnShowFilesLpAdmin = new Roundbtn();
            listviewAdminContainers = new ListView();
            columnFolder = new ColumnHeader();
            lblContainerHeading = new Label();
            lblLpAdminLogsHeading = new Label();
            listviewLpAdminLogs = new ListView();
            columnHeader1 = new ColumnHeader();
            btnLpAdminShowLogs = new Roundbtn();
            listviewLpAdminFiles = new ListView();
            columnHeader2 = new ColumnHeader();
            lblLpAdminFiles = new Label();
            txtLpAdminFolderName = new TextBox();
            lblLpAdminChooseContainer = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lblViewMessages);
            panel1.Controls.Add(exit_btn);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(-1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 60);
            panel1.TabIndex = 11;
            // 
            // lblViewMessages
            // 
            lblViewMessages.AutoSize = true;
            lblViewMessages.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblViewMessages.ForeColor = SystemColors.ControlLightLight;
            lblViewMessages.Location = new Point(163, 25);
            lblViewMessages.Name = "lblViewMessages";
            lblViewMessages.Size = new Size(87, 15);
            lblViewMessages.TabIndex = 8;
            lblViewMessages.Text = "View Messages";
            lblViewMessages.Click += lblViewMessages_Click;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.MidnightBlue;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.ForeColor = Color.White;
            exit_btn.Location = new Point(736, 12);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(42, 41);
            exit_btn.TabIndex = 36;
            exit_btn.Text = "X";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.MidnightBlue;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(656, 14);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(62, 39);
            btn_logout.TabIndex = 35;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(126, 47);
            label1.TabIndex = 5;
            label1.Text = "Goosestep Insurance";
            // 
            // lbl_showUser
            // 
            lbl_showUser.AutoSize = true;
            lbl_showUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_showUser.ForeColor = SystemColors.ControlLightLight;
            lbl_showUser.Location = new Point(456, 26);
            lbl_showUser.Name = "lbl_showUser";
            lbl_showUser.Size = new Size(58, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-93, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(635, 399);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnViewUser
            // 
            btnViewUser.BackColor = Color.MidnightBlue;
            btnViewUser.FlatAppearance.BorderSize = 0;
            btnViewUser.FlatStyle = FlatStyle.Flat;
            btnViewUser.ForeColor = Color.White;
            btnViewUser.Location = new Point(571, 225);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(199, 43);
            btnViewUser.TabIndex = 13;
            btnViewUser.Text = "View User";
            btnViewUser.UseVisualStyleBackColor = false;
            btnViewUser.Click += btnViewUser_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(546, 51);
            label2.Name = "label2";
            label2.Size = new Size(262, 60);
            label2.TabIndex = 12;
            label2.Text = "Protecting What Matters Most  Your Safety, Our Priority.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // btnUploadFile
            // 
            btnUploadFile.BackColor = Color.MidnightBlue;
            btnUploadFile.FlatAppearance.BorderSize = 0;
            btnUploadFile.FlatStyle = FlatStyle.Flat;
            btnUploadFile.ForeColor = Color.White;
            btnUploadFile.Location = new Point(571, 335);
            btnUploadFile.Name = "btnUploadFile";
            btnUploadFile.Size = new Size(199, 43);
            btnUploadFile.TabIndex = 16;
            btnUploadFile.Text = "Upload File";
            btnUploadFile.UseVisualStyleBackColor = false;
            btnUploadFile.Click += btnUploadFile_Click;
            // 
            // btnShowFolders
            // 
            btnShowFolders.BackColor = Color.MidnightBlue;
            btnShowFolders.FlatAppearance.BorderSize = 0;
            btnShowFolders.FlatStyle = FlatStyle.Flat;
            btnShowFolders.ForeColor = Color.White;
            btnShowFolders.Location = new Point(571, 170);
            btnShowFolders.Margin = new Padding(1);
            btnShowFolders.Name = "btnShowFolders";
            btnShowFolders.Size = new Size(199, 43);
            btnShowFolders.TabIndex = 17;
            btnShowFolders.Text = "Show Folders";
            btnShowFolders.UseVisualStyleBackColor = false;
            btnShowFolders.Click += btnShowFolders_Click;
            // 
            // btnShowFilesLpAdmin
            // 
            btnShowFilesLpAdmin.BackColor = Color.MidnightBlue;
            btnShowFilesLpAdmin.FlatAppearance.BorderSize = 0;
            btnShowFilesLpAdmin.FlatStyle = FlatStyle.Flat;
            btnShowFilesLpAdmin.ForeColor = Color.White;
            btnShowFilesLpAdmin.Location = new Point(571, 280);
            btnShowFilesLpAdmin.Margin = new Padding(1);
            btnShowFilesLpAdmin.Name = "btnShowFilesLpAdmin";
            btnShowFilesLpAdmin.Size = new Size(199, 43);
            btnShowFilesLpAdmin.TabIndex = 18;
            btnShowFilesLpAdmin.Text = "Show Files";
            btnShowFilesLpAdmin.UseVisualStyleBackColor = false;
            btnShowFilesLpAdmin.Click += btnShowFilesLpAdmin_Click;
            // 
            // listviewAdminContainers
            // 
            listviewAdminContainers.Columns.AddRange(new ColumnHeader[] { columnFolder });
            listviewAdminContainers.Location = new Point(10, 92);
            listviewAdminContainers.Name = "listviewAdminContainers";
            listviewAdminContainers.Size = new Size(233, 97);
            listviewAdminContainers.TabIndex = 19;
            listviewAdminContainers.UseCompatibleStateImageBehavior = false;
            listviewAdminContainers.View = View.List;
            listviewAdminContainers.SelectedIndexChanged += listviewAdminContainers_SelectedIndexChanged;
            // 
            // columnFolder
            // 
            columnFolder.Text = "Containers";
            columnFolder.Width = 400;
            // 
            // lblContainerHeading
            // 
            lblContainerHeading.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContainerHeading.ForeColor = SystemColors.ControlText;
            lblContainerHeading.Location = new Point(10, 63);
            lblContainerHeading.Name = "lblContainerHeading";
            lblContainerHeading.Size = new Size(233, 26);
            lblContainerHeading.TabIndex = 20;
            lblContainerHeading.Text = "Folders";
            lblContainerHeading.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLpAdminLogsHeading
            // 
            lblLpAdminLogsHeading.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLpAdminLogsHeading.ForeColor = SystemColors.ControlText;
            lblLpAdminLogsHeading.Location = new Point(10, 238);
            lblLpAdminLogsHeading.Margin = new Padding(1, 0, 1, 0);
            lblLpAdminLogsHeading.Name = "lblLpAdminLogsHeading";
            lblLpAdminLogsHeading.Size = new Size(197, 26);
            lblLpAdminLogsHeading.TabIndex = 22;
            lblLpAdminLogsHeading.Text = "Logs";
            lblLpAdminLogsHeading.TextAlign = ContentAlignment.TopCenter;
            // 
            // listviewLpAdminLogs
            // 
            listviewLpAdminLogs.Alignment = ListViewAlignment.Left;
            listviewLpAdminLogs.AutoArrange = false;
            listviewLpAdminLogs.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listviewLpAdminLogs.Location = new Point(10, 265);
            listviewLpAdminLogs.Margin = new Padding(1);
            listviewLpAdminLogs.Name = "listviewLpAdminLogs";
            listviewLpAdminLogs.ShowGroups = false;
            listviewLpAdminLogs.Size = new Size(472, 100);
            listviewLpAdminLogs.TabIndex = 21;
            listviewLpAdminLogs.UseCompatibleStateImageBehavior = false;
            listviewLpAdminLogs.View = View.List;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Header";
            columnHeader1.Width = 500;
            // 
            // btnLpAdminShowLogs
            // 
            btnLpAdminShowLogs.BackColor = Color.MidnightBlue;
            btnLpAdminShowLogs.FlatAppearance.BorderSize = 0;
            btnLpAdminShowLogs.FlatStyle = FlatStyle.Flat;
            btnLpAdminShowLogs.ForeColor = Color.White;
            btnLpAdminShowLogs.Location = new Point(571, 115);
            btnLpAdminShowLogs.Margin = new Padding(1);
            btnLpAdminShowLogs.Name = "btnLpAdminShowLogs";
            btnLpAdminShowLogs.Size = new Size(199, 43);
            btnLpAdminShowLogs.TabIndex = 23;
            btnLpAdminShowLogs.Text = "Show Logs";
            btnLpAdminShowLogs.UseVisualStyleBackColor = false;
            btnLpAdminShowLogs.Click += btnLpAdminShowLogs_Click;
            // 
            // listviewLpAdminFiles
            // 
            listviewLpAdminFiles.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            listviewLpAdminFiles.Location = new Point(249, 93);
            listviewLpAdminFiles.Name = "listviewLpAdminFiles";
            listviewLpAdminFiles.Size = new Size(233, 97);
            listviewLpAdminFiles.TabIndex = 24;
            listviewLpAdminFiles.UseCompatibleStateImageBehavior = false;
            listviewLpAdminFiles.View = View.List;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Containers";
            columnHeader2.Width = 400;
            // 
            // lblLpAdminFiles
            // 
            lblLpAdminFiles.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLpAdminFiles.ForeColor = SystemColors.ControlText;
            lblLpAdminFiles.Location = new Point(249, 63);
            lblLpAdminFiles.Name = "lblLpAdminFiles";
            lblLpAdminFiles.Size = new Size(233, 26);
            lblLpAdminFiles.TabIndex = 25;
            lblLpAdminFiles.Text = "Files";
            lblLpAdminFiles.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtLpAdminFolderName
            // 
            txtLpAdminFolderName.Location = new Point(10, 195);
            txtLpAdminFolderName.Name = "txtLpAdminFolderName";
            txtLpAdminFolderName.Size = new Size(233, 23);
            txtLpAdminFolderName.TabIndex = 26;
            // 
            // lblLpAdminChooseContainer
            // 
            lblLpAdminChooseContainer.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLpAdminChooseContainer.ForeColor = SystemColors.ControlText;
            lblLpAdminChooseContainer.Location = new Point(249, 195);
            lblLpAdminChooseContainer.Margin = new Padding(1, 0, 1, 0);
            lblLpAdminChooseContainer.Name = "lblLpAdminChooseContainer";
            lblLpAdminChooseContainer.Size = new Size(233, 23);
            lblLpAdminChooseContainer.TabIndex = 27;
            lblLpAdminChooseContainer.Text = "<- Choose which folder to view";
            lblLpAdminChooseContainer.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 434);
            Controls.Add(lblLpAdminChooseContainer);
            Controls.Add(txtLpAdminFolderName);
            Controls.Add(lblLpAdminFiles);
            Controls.Add(listviewLpAdminFiles);
            Controls.Add(btnLpAdminShowLogs);
            Controls.Add(lblLpAdminLogsHeading);
            Controls.Add(listviewLpAdminLogs);
            Controls.Add(lblContainerHeading);
            Controls.Add(listviewAdminContainers);
            Controls.Add(btnShowFilesLpAdmin);
            Controls.Add(btnShowFolders);
            Controls.Add(btnUploadFile);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnViewUser);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblViewMessages;
        private Label label1;
        private Label lbl_showUser;
        private PictureBox pictureBox1;
        private Roundbtn btnViewUser;
        private Label label2;
        private Roundbtn roundbtn4;
        private Roundbtn roundbtn3;
        private Roundbtn exit_btn;
        private Roundbtn btn_logout;
        private Roundbtn btnUploadFile;
        private Roundbtn btnShowFolders;
        private OpenFileDialog ofdLpAdmin;
        private Roundbtn btnShowFilesLpAdmin;
        private ListView listviewAdminContainers;
        private ColumnHeader columnFolder;
        private Label lblContainerHeading;
        private Label lblLpAdminLogsHeading;
        private ListView listviewLpAdminLogs;
        private Roundbtn btnLpAdminShowLogs;
        private ColumnHeader columnHeader1;
        private ListView listviewLpAdminFiles;
        private ColumnHeader columnHeader2;
        private Label lblLpAdminFiles;
        private TextBox txtLpAdminFolderName;
        private Label lblLpAdminChooseContainer;
    }
}