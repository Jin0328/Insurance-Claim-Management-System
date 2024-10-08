namespace Login
{
    partial class frmViewClaim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewClaim));
            label6 = new Label();
            label5 = new Label();
            signup_label = new Label();
            panel1 = new Panel();
            label3 = new Label();
            exit_btn1 = new Roundbtn();
            label4 = new Label();
            btn_logout = new Roundbtn();
            lbl_showUser = new Label();
            label2 = new Label();
            lbxClaimTitles = new ListBox();
            lbxDates = new ListBox();
            lbxClients = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(650, 122);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 22;
            label6.Text = "Client";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(425, 122);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 21;
            label5.Text = "Date";
            // 
            // signup_label
            // 
            signup_label.AutoSize = true;
            signup_label.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_label.Location = new Point(9, 68);
            signup_label.Name = "signup_label";
            signup_label.Size = new Size(204, 47);
            signup_label.TabIndex = 19;
            signup_label.Text = "View Claims";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(exit_btn1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 60);
            panel1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(189, 25);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 31;
            label3.Text = "View Messages";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
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
            // label4
            // 
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 8);
            label4.Name = "label4";
            label4.Size = new Size(126, 47);
            label4.TabIndex = 5;
            label4.Text = "Goosestep Insurance";
            label4.Click += label4_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.MidnightBlue;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(652, 13);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(62, 39);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // lbl_showUser
            // 
            lbl_showUser.AutoSize = true;
            lbl_showUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_showUser.ForeColor = SystemColors.ControlLightLight;
            lbl_showUser.Location = new Point(426, 25);
            lbl_showUser.Name = "lbl_showUser";
            lbl_showUser.Size = new Size(58, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 122);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 17;
            label2.Text = "Claim";
            // 
            // lbxClaimTitles
            // 
            lbxClaimTitles.FormattingEnabled = true;
            lbxClaimTitles.ItemHeight = 15;
            lbxClaimTitles.Location = new Point(14, 148);
            lbxClaimTitles.Margin = new Padding(1, 1, 1, 1);
            lbxClaimTitles.Name = "lbxClaimTitles";
            lbxClaimTitles.Size = new Size(362, 289);
            lbxClaimTitles.TabIndex = 23;
            lbxClaimTitles.SelectedIndexChanged += lbxClaimTitles_SelectedIndexChanged;
            // 
            // lbxDates
            // 
            lbxDates.FormattingEnabled = true;
            lbxDates.ItemHeight = 15;
            lbxDates.Location = new Point(425, 148);
            lbxDates.Margin = new Padding(1, 1, 1, 1);
            lbxDates.Name = "lbxDates";
            lbxDates.Size = new Size(190, 289);
            lbxDates.TabIndex = 24;
            // 
            // lbxClients
            // 
            lbxClients.FormattingEnabled = true;
            lbxClients.ItemHeight = 15;
            lbxClients.Location = new Point(650, 148);
            lbxClients.Margin = new Padding(1, 1, 1, 1);
            lbxClients.Name = "lbxClients";
            lbxClients.Size = new Size(126, 289);
            lbxClients.TabIndex = 25;
            // 
            // frmViewClaim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 465);
            Controls.Add(lbxClients);
            Controls.Add(lbxDates);
            Controls.Add(lbxClaimTitles);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(signup_label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmViewClaim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Claim";
            Load += frmViewClaim_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Label signup_label;
        private Panel panel1;
        private Label label3;
        private Roundbtn exit_btn1;
        private Label label4;
        private Roundbtn btn_logout;
        private Label lbl_showUser;
        private Label label2;
        private ListBox lbxClaimTitles;
        private ListBox lbxDates;
        private ListBox lbxClients;
    }
}