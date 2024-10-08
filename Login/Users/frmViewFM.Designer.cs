namespace Login
{
    partial class frmViewFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewFM));
            panel1 = new Panel();
            label6 = new Label();
            exit_btn1 = new Roundbtn();
            label1 = new Label();
            btn_logout = new Roundbtn();
            lbl_showUser = new Label();
            signup_label = new Label();
            btnCMInfo = new Roundbtn();
            btnClientInfo = new Roundbtn();
            listBoxFinanceManagers = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(exit_btn1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 60);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(176, 24);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 31;
            label6.Text = "View Messages";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // exit_btn1
            // 
            exit_btn1.BackColor = Color.MidnightBlue;
            exit_btn1.FlatAppearance.BorderSize = 0;
            exit_btn1.FlatStyle = FlatStyle.Flat;
            exit_btn1.ForeColor = Color.White;
            exit_btn1.Location = new Point(732, 11);
            exit_btn1.Name = "exit_btn1";
            exit_btn1.Size = new Size(42, 41);
            exit_btn1.TabIndex = 29;
            exit_btn1.Text = "X";
            exit_btn1.UseVisualStyleBackColor = false;
            exit_btn1.Click += exit_btn1_Click;
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
            // btn_logout
            // 
            btn_logout.BackColor = Color.MidnightBlue;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(638, 13);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(62, 39);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "logout";
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // lbl_showUser
            // 
            lbl_showUser.AutoSize = true;
            lbl_showUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_showUser.ForeColor = SystemColors.ControlLightLight;
            lbl_showUser.Location = new Point(405, 25);
            lbl_showUser.Name = "lbl_showUser";
            lbl_showUser.Size = new Size(98, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Finance Manager";
            // 
            // signup_label
            // 
            signup_label.AutoSize = true;
            signup_label.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_label.Location = new Point(23, 78);
            signup_label.Name = "signup_label";
            signup_label.Size = new Size(68, 47);
            signup_label.TabIndex = 20;
            signup_label.Text = "FM";
            // 
            // btnCMInfo
            // 
            btnCMInfo.BackColor = Color.SteelBlue;
            btnCMInfo.FlatAppearance.BorderSize = 0;
            btnCMInfo.FlatStyle = FlatStyle.Flat;
            btnCMInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCMInfo.ForeColor = Color.WhiteSmoke;
            btnCMInfo.Location = new Point(490, 74);
            btnCMInfo.Name = "btnCMInfo";
            btnCMInfo.Size = new Size(177, 48);
            btnCMInfo.TabIndex = 18;
            btnCMInfo.Text = "Claim Manager";
            btnCMInfo.UseVisualStyleBackColor = false;
            btnCMInfo.Click += btnCMInfo_Click;
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
            btnClientInfo.TabIndex = 17;
            btnClientInfo.Text = "Client";
            btnClientInfo.UseVisualStyleBackColor = false;
            btnClientInfo.Click += btnClientInfo_Click;
            // 
            // listBoxFinanceManagers
            // 
            listBoxFinanceManagers.FormattingEnabled = true;
            listBoxFinanceManagers.ItemHeight = 15;
            listBoxFinanceManagers.Location = new Point(82, 151);
            listBoxFinanceManagers.Margin = new Padding(1, 1, 1, 1);
            listBoxFinanceManagers.Name = "listBoxFinanceManagers";
            listBoxFinanceManagers.Size = new Size(625, 274);
            listBoxFinanceManagers.TabIndex = 21;
            listBoxFinanceManagers.SelectedIndexChanged += listBoxFinanceManagers_SelectedIndexChanged;
            // 
            // frmViewFM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxFinanceManagers);
            Controls.Add(signup_label);
            Controls.Add(btnCMInfo);
            Controls.Add(btnClientInfo);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmViewFM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FM";
            Load += frmViewFM_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Roundbtn exit_btn1;
        private Label label1;
        private Roundbtn btn_logout;
        private Label lbl_showUser;
        private Label signup_label;
        private Roundbtn btnCMInfo;
        private Roundbtn btnClientInfo;
        private ListBox listBoxFinanceManagers;
    }
}