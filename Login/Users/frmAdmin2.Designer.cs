namespace Login
{
    partial class frmAdmin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin2));
            panel1 = new Panel();
            label4 = new Label();
            exit_btn = new Roundbtn();
            btn_logout = new Roundbtn();
            label1 = new Label();
            lbl_showUser = new Label();
            btnClientInfo = new Roundbtn();
            btnCMInfo = new Roundbtn();
            btnFMInfo = new Roundbtn();
            signup_label = new Label();
            listBoxUsers = new ListBox();
            lbxAllUsers = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(exit_btn);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 60);
            panel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(161, 25);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 8;
            label4.Text = "View Messages";
            label4.Click += label4_Click;
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
            btn_logout.Text = "logout";
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
            label1.Click += label1_Click;
            // 
            // lbl_showUser
            // 
            lbl_showUser.AutoSize = true;
            lbl_showUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_showUser.ForeColor = SystemColors.ControlLightLight;
            lbl_showUser.Location = new Point(454, 26);
            lbl_showUser.Name = "lbl_showUser";
            lbl_showUser.Size = new Size(43, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Admin";
            lbl_showUser.Click += lbl_showUser_Click;
            // 
            // btnClientInfo
            // 
            btnClientInfo.BackColor = Color.SteelBlue;
            btnClientInfo.FlatAppearance.BorderSize = 0;
            btnClientInfo.FlatStyle = FlatStyle.Flat;
            btnClientInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientInfo.ForeColor = Color.WhiteSmoke;
            btnClientInfo.Location = new Point(188, 79);
            btnClientInfo.Name = "btnClientInfo";
            btnClientInfo.Size = new Size(177, 48);
            btnClientInfo.TabIndex = 13;
            btnClientInfo.Text = "Client";
            btnClientInfo.UseVisualStyleBackColor = false;
            btnClientInfo.Click += btnClientInfo_Click;
            // 
            // btnCMInfo
            // 
            btnCMInfo.BackColor = Color.SteelBlue;
            btnCMInfo.FlatAppearance.BorderSize = 0;
            btnCMInfo.FlatStyle = FlatStyle.Flat;
            btnCMInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCMInfo.ForeColor = Color.WhiteSmoke;
            btnCMInfo.Location = new Point(395, 79);
            btnCMInfo.Name = "btnCMInfo";
            btnCMInfo.Size = new Size(177, 48);
            btnCMInfo.TabIndex = 14;
            btnCMInfo.Text = "Claim Manager";
            btnCMInfo.UseVisualStyleBackColor = false;
            btnCMInfo.Click += btnCMInfo_Click;
            // 
            // btnFMInfo
            // 
            btnFMInfo.BackColor = Color.SteelBlue;
            btnFMInfo.FlatAppearance.BorderSize = 0;
            btnFMInfo.FlatStyle = FlatStyle.Flat;
            btnFMInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFMInfo.ForeColor = Color.WhiteSmoke;
            btnFMInfo.Location = new Point(599, 79);
            btnFMInfo.Name = "btnFMInfo";
            btnFMInfo.Size = new Size(177, 48);
            btnFMInfo.TabIndex = 15;
            btnFMInfo.Text = "Finance Manager";
            btnFMInfo.UseVisualStyleBackColor = false;
            btnFMInfo.Click += btnFMInfo_Click;
            // 
            // signup_label
            // 
            signup_label.AutoSize = true;
            signup_label.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_label.Location = new Point(12, 79);
            signup_label.Name = "signup_label";
            signup_label.Size = new Size(104, 47);
            signup_label.TabIndex = 16;
            signup_label.Text = "Users";
            // 
            // listBoxUsers
            // 
            listBoxUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(82, 151);
            listBoxUsers.Margin = new Padding(1, 1, 1, 1);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(219, 154);
            listBoxUsers.TabIndex = 17;
            // 
            // lbxAllUsers
            // 
            lbxAllUsers.FormattingEnabled = true;
            lbxAllUsers.ItemHeight = 15;
            lbxAllUsers.Location = new Point(63, 151);
            lbxAllUsers.Margin = new Padding(1, 1, 1, 1);
            lbxAllUsers.Name = "lbxAllUsers";
            lbxAllUsers.Size = new Size(701, 274);
            lbxAllUsers.TabIndex = 18;
            // 
            // frmAdmin2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 463);
            Controls.Add(lbxAllUsers);
            Controls.Add(listBoxUsers);
            Controls.Add(signup_label);
            Controls.Add(btnFMInfo);
            Controls.Add(btnCMInfo);
            Controls.Add(btnClientInfo);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdmin2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += frmAdmin2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Roundbtn roundbtn4;
        private Roundbtn roundbtn3;
        private Label label4;
        private Roundbtn exit_btn;
        private Roundbtn btn_logout;
        private Label label1;
        private Label lbl_showUser;
        private Roundbtn btnClientInfo;
        private Roundbtn btnCMInfo;
        private Roundbtn btnFMInfo;
        private Label signup_label;
        private ListBox listBoxUsers;
        private ListBox lbxAllUsers;
    }
}