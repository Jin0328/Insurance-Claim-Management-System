namespace Login
{
    partial class frmViewCM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCM));
            panel1 = new Panel();
            exit_btn = new Roundbtn();
            label3 = new Label();
            btn_logout = new Roundbtn();
            label1 = new Label();
            lbl_showUser = new Label();
            signup_label = new Label();
            btnFMInfo = new Roundbtn();
            btnClientInfo = new Roundbtn();
            listBoxClaimManager = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(exit_btn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 60);
            panel1.TabIndex = 17;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.MidnightBlue;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.ForeColor = Color.White;
            exit_btn.Location = new Point(735, 11);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(42, 41);
            exit_btn.TabIndex = 36;
            exit_btn.Text = "X";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(158, 25);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 7;
            label3.Text = "View Messages";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.MidnightBlue;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(655, 13);
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
            lbl_showUser.Location = new Point(412, 25);
            lbl_showUser.Name = "lbl_showUser";
            lbl_showUser.Size = new Size(87, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Claim Manager";
            // 
            // signup_label
            // 
            signup_label.AutoSize = true;
            signup_label.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_label.Location = new Point(23, 78);
            signup_label.Name = "signup_label";
            signup_label.Size = new Size(73, 47);
            signup_label.TabIndex = 21;
            signup_label.Text = "CM";
            // 
            // btnFMInfo
            // 
            btnFMInfo.BackColor = Color.SteelBlue;
            btnFMInfo.FlatAppearance.BorderSize = 0;
            btnFMInfo.FlatStyle = FlatStyle.Flat;
            btnFMInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFMInfo.ForeColor = Color.WhiteSmoke;
            btnFMInfo.Location = new Point(490, 74);
            btnFMInfo.Name = "btnFMInfo";
            btnFMInfo.Size = new Size(177, 48);
            btnFMInfo.TabIndex = 20;
            btnFMInfo.Text = "Finance Manager";
            btnFMInfo.UseVisualStyleBackColor = false;
            btnFMInfo.Click += btnFMInfo_Click;
            // 
            // btnClientInfo
            // 
            btnClientInfo.BackColor = Color.SteelBlue;
            btnClientInfo.FlatAppearance.BorderSize = 0;
            btnClientInfo.FlatStyle = FlatStyle.Flat;
            btnClientInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientInfo.ForeColor = Color.WhiteSmoke;
            btnClientInfo.Location = new Point(198, 74);
            btnClientInfo.Name = "btnClientInfo";
            btnClientInfo.Size = new Size(177, 48);
            btnClientInfo.TabIndex = 18;
            btnClientInfo.Text = "Client";
            btnClientInfo.UseVisualStyleBackColor = false;
            btnClientInfo.Click += btnClientInfo_Click;
            // 
            // listBoxClaimManager
            // 
            listBoxClaimManager.FormattingEnabled = true;
            listBoxClaimManager.ItemHeight = 15;
            listBoxClaimManager.Location = new Point(82, 151);
            listBoxClaimManager.Margin = new Padding(1, 1, 1, 1);
            listBoxClaimManager.Name = "listBoxClaimManager";
            listBoxClaimManager.Size = new Size(625, 274);
            listBoxClaimManager.TabIndex = 22;
            // 
            // frmViewCM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxClaimManager);
            Controls.Add(signup_label);
            Controls.Add(btnFMInfo);
            Controls.Add(btnClientInfo);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmViewCM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Claim Manager";
            Load += frmViewCM_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Roundbtn exit_btn;
        private Label label3;
        private Roundbtn btn_logout;
        private Label label1;
        private Label lbl_showUser;
        private Label signup_label;
        private Roundbtn btnFMInfo;
        private Roundbtn btnClientInfo;
        private ListBox listBoxClaimManager;
    }
}