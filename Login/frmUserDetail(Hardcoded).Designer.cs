namespace Login
{
    partial class frmUserDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDetail));
            panel1 = new Panel();
            exit_btn = new Roundbtn();
            label3 = new Label();
            btn_logout = new Roundbtn();
            label1 = new Label();
            lbl_showUser = new Label();
            label7 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            roundPanel2 = new RoundPanel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            roundPanel1 = new RoundPanel();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label13 = new Label();
            panel1.SuspendLayout();
            roundPanel2.SuspendLayout();
            roundPanel1.SuspendLayout();
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
            panel1.Location = new Point(-3, -1);
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
            lbl_showUser.Location = new Point(464, 25);
            lbl_showUser.Name = "lbl_showUser";
            lbl_showUser.Size = new Size(58, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Welcome";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 106);
            label7.Name = "label7";
            label7.Size = new Size(168, 32);
            label7.TabIndex = 19;
            label7.Text = "Emily Johnson";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 143);
            label2.Name = "label2";
            label2.Size = new Size(192, 21);
            label2.TabIndex = 20;
            label2.Text = "Date of Birth : 04/21/2000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 174);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 21;
            label4.Text = "Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 202);
            label5.Name = "label5";
            label5.Size = new Size(175, 21);
            label5.TabIndex = 22;
            label5.Text = "Mobile : (317)123-4567";
            // 
            // roundPanel2
            // 
            roundPanel2.BackColor = SystemColors.GradientInactiveCaption;
            roundPanel2.Controls.Add(label10);
            roundPanel2.Controls.Add(label11);
            roundPanel2.Controls.Add(label12);
            roundPanel2.CornerRadius = 20;
            roundPanel2.Location = new Point(249, 183);
            roundPanel2.Name = "roundPanel2";
            roundPanel2.Size = new Size(539, 55);
            roundPanel2.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(432, 17);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 15;
            label10.Text = "Rejected";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(311, 17);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 14;
            label11.Text = "3/05/2024";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(10, 17);
            label12.Name = "label12";
            label12.Size = new Size(276, 20);
            label12.TabIndex = 13;
            label12.Text = "Medical Expenses Reimbursement Claim";
            // 
            // roundPanel1
            // 
            roundPanel1.BackColor = SystemColors.GradientInactiveCaption;
            roundPanel1.Controls.Add(label9);
            roundPanel1.Controls.Add(label8);
            roundPanel1.Controls.Add(label6);
            roundPanel1.CornerRadius = 20;
            roundPanel1.Location = new Point(249, 106);
            roundPanel1.Name = "roundPanel1";
            roundPanel1.Size = new Size(539, 55);
            roundPanel1.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MediumBlue;
            label9.Location = new Point(432, 17);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 15;
            label9.Text = "Approved";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(311, 17);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 14;
            label8.Text = "2/14/2024";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 17);
            label6.Name = "label6";
            label6.Size = new Size(220, 20);
            label6.TabIndex = 13;
            label6.Text = "Vehicle Collision Damage Claim";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(19, 226);
            label13.Name = "label13";
            label13.Size = new Size(210, 21);
            label13.TabIndex = 25;
            label13.Text = "Email : EJohnson@butler.edu";
            // 
            // frmUserDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(roundPanel2);
            Controls.Add(roundPanel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUserDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundPanel2.ResumeLayout(false);
            roundPanel2.PerformLayout();
            roundPanel1.ResumeLayout(false);
            roundPanel1.PerformLayout();
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
        private Label label7;
        private Label label2;
        private Label label4;
        private Label label5;
        private RoundPanel roundPanel2;
        private Label label10;
        private Label label11;
        private Label label12;
        private RoundPanel roundPanel1;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label13;
    }
}