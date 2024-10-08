namespace Login
{
    partial class frmViewClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewClients));
            panel1 = new Panel();
            label4 = new Label();
            exit_btn = new Roundbtn();
            btn_logout = new Roundbtn();
            label1 = new Label();
            lbl_showUser = new Label();
            signup_label = new Label();
            btnFMInfo = new Roundbtn();
            btnCMInfo = new Roundbtn();
            listBoxClients = new ListBox();
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
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 60);
            panel1.TabIndex = 13;
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
            // 
            // signup_label
            // 
            signup_label.AutoSize = true;
            signup_label.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_label.Location = new Point(17, 74);
            signup_label.Name = "signup_label";
            signup_label.Size = new Size(123, 47);
            signup_label.TabIndex = 40;
            signup_label.Text = "Clients";
            // 
            // btnFMInfo
            // 
            btnFMInfo.BackColor = Color.SteelBlue;
            btnFMInfo.FlatAppearance.BorderSize = 0;
            btnFMInfo.FlatStyle = FlatStyle.Flat;
            btnFMInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFMInfo.ForeColor = Color.WhiteSmoke;
            btnFMInfo.Location = new Point(198, 74);
            btnFMInfo.Name = "btnFMInfo";
            btnFMInfo.Size = new Size(177, 48);
            btnFMInfo.TabIndex = 39;
            btnFMInfo.Text = "Finance Manager";
            btnFMInfo.UseVisualStyleBackColor = false;
            btnFMInfo.Click += btnFMInfo_Click;
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
            btnCMInfo.TabIndex = 38;
            btnCMInfo.Text = "Claim Manager";
            btnCMInfo.UseVisualStyleBackColor = false;
            btnCMInfo.Click += btnCMInfo_Click;
            // 
            // listBoxClients
            // 
            listBoxClients.FormattingEnabled = true;
            listBoxClients.ItemHeight = 15;
            listBoxClients.Location = new Point(82, 151);
            listBoxClients.Margin = new Padding(1, 1, 1, 1);
            listBoxClients.Name = "listBoxClients";
            listBoxClients.Size = new Size(625, 274);
            listBoxClients.TabIndex = 41;
            listBoxClients.SelectedIndexChanged += listBoxClients_SelectedIndexChanged;
            // 
            // frmViewClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxClients);
            Controls.Add(signup_label);
            Controls.Add(panel1);
            Controls.Add(btnFMInfo);
            Controls.Add(btnCMInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmViewClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            Load += frmViewClients_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Roundbtn exit_btn;
        private Roundbtn btn_logout;
        private Label label1;
        private Label lbl_showUser;
        private Label signup_label;
        private Roundbtn btnFMInfo;
        private Roundbtn btnCMInfo;
        private ListBox listBoxClients;
    }
}