namespace Login
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            panel1 = new Panel();
            roundbtn4 = new Roundbtn();
            roundbtn3 = new Roundbtn();
            exit_btn1 = new Roundbtn();
            lblProfileMessages = new Label();
            lblProfilesApplyClaim = new Label();
            label1 = new Label();
            btn_logout = new Roundbtn();
            lbl_showUser = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtOldPassword = new TextBox();
            label8 = new Label();
            txtBoxPassword = new TextBox();
            label9 = new Label();
            txtPasswordConf = new TextBox();
            label10 = new Label();
            btnSave = new Roundbtn();
            dateTimePicker11 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            lblUsername = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(roundbtn4);
            panel1.Controls.Add(roundbtn3);
            panel1.Controls.Add(exit_btn1);
            panel1.Controls.Add(lblProfileMessages);
            panel1.Controls.Add(lblProfilesApplyClaim);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 57);
            panel1.TabIndex = 8;
            // 
            // roundbtn4
            // 
            roundbtn4.BackColor = Color.MidnightBlue;
            roundbtn4.FlatAppearance.BorderSize = 0;
            roundbtn4.FlatStyle = FlatStyle.Flat;
            roundbtn4.ForeColor = Color.White;
            roundbtn4.Location = new Point(706, 8);
            roundbtn4.Name = "roundbtn4";
            roundbtn4.Size = new Size(42, 41);
            roundbtn4.TabIndex = 37;
            roundbtn4.Text = "<";
            roundbtn4.UseVisualStyleBackColor = false;
            // 
            // roundbtn3
            // 
            roundbtn3.BackColor = Color.MidnightBlue;
            roundbtn3.FlatAppearance.BorderSize = 0;
            roundbtn3.FlatStyle = FlatStyle.Flat;
            roundbtn3.ForeColor = Color.White;
            roundbtn3.Location = new Point(762, 8);
            roundbtn3.Name = "roundbtn3";
            roundbtn3.Size = new Size(42, 41);
            roundbtn3.TabIndex = 36;
            roundbtn3.Text = ">";
            roundbtn3.UseVisualStyleBackColor = false;
            // 
            // exit_btn1
            // 
            exit_btn1.BackColor = Color.MidnightBlue;
            exit_btn1.FlatAppearance.BorderSize = 0;
            exit_btn1.FlatStyle = FlatStyle.Flat;
            exit_btn1.ForeColor = Color.White;
            exit_btn1.Location = new Point(732, 8);
            exit_btn1.Name = "exit_btn1";
            exit_btn1.Size = new Size(42, 41);
            exit_btn1.TabIndex = 35;
            exit_btn1.Text = "X";
            exit_btn1.UseVisualStyleBackColor = false;
            exit_btn1.Click += exit_btn1_Click;
            // 
            // lblProfileMessages
            // 
            lblProfileMessages.AutoSize = true;
            lblProfileMessages.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblProfileMessages.ForeColor = SystemColors.ControlLightLight;
            lblProfileMessages.Location = new Point(256, 23);
            lblProfileMessages.Name = "lblProfileMessages";
            lblProfileMessages.Size = new Size(87, 15);
            lblProfileMessages.TabIndex = 8;
            lblProfileMessages.Text = "View Messages";
            lblProfileMessages.Click += label4_Click;
            // 
            // lblProfilesApplyClaim
            // 
            lblProfilesApplyClaim.AutoSize = true;
            lblProfilesApplyClaim.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblProfilesApplyClaim.ForeColor = SystemColors.ControlLightLight;
            lblProfilesApplyClaim.Location = new Point(158, 23);
            lblProfilesApplyClaim.Name = "lblProfilesApplyClaim";
            lblProfilesApplyClaim.Size = new Size(71, 15);
            lblProfilesApplyClaim.TabIndex = 7;
            lblProfilesApplyClaim.Text = "Apply Claim";
            lblProfilesApplyClaim.Click += label3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(126, 47);
            label1.TabIndex = 5;
            label1.Text = "Goosestep Insurance";
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.MidnightBlue;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(640, 9);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(62, 39);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // lbl_showUser
            // 
            lbl_showUser.AutoSize = true;
            lbl_showUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_showUser.ForeColor = SystemColors.ControlLightLight;
            lbl_showUser.Location = new Point(486, 23);
            lbl_showUser.Name = "lbl_showUser";
            lbl_showUser.Size = new Size(37, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(186, 154);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 18;
            label2.Text = "First Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(303, 156);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 23);
            txtFirstName.TabIndex = 19;
            txtFirstName.TextChanged += textBox1_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(303, 198);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(175, 23);
            txtLastName.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(186, 196);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 20;
            label5.Text = "Last Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(188, 240);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 22;
            label6.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(303, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 23);
            txtEmail.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(188, 288);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 24;
            label7.Text = "Birthday :";
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(621, 156);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(175, 23);
            txtOldPassword.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(477, 154);
            label8.Name = "label8";
            label8.Size = new Size(135, 25);
            label8.TabIndex = 26;
            label8.Text = "Old Password :";
            label8.Click += label8_Click;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(621, 196);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(175, 23);
            txtBoxPassword.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(477, 193);
            label9.Name = "label9";
            label9.Size = new Size(143, 25);
            label9.TabIndex = 28;
            label9.Text = "New Password :";
            // 
            // txtPasswordConf
            // 
            txtPasswordConf.Location = new Point(621, 243);
            txtPasswordConf.Name = "txtPasswordConf";
            txtPasswordConf.PasswordChar = '*';
            txtPasswordConf.Size = new Size(175, 23);
            txtPasswordConf.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(495, 229);
            label10.Name = "label10";
            label10.Size = new Size(100, 50);
            label10.TabIndex = 30;
            label10.Text = "Confirm \r\nPassword :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(337, 354);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker11
            // 
            dateTimePicker11.Location = new Point(303, 291);
            dateTimePicker11.Name = "dateTimePicker11";
            dateTimePicker11.Size = new Size(175, 23);
            dateTimePicker11.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(186, 113);
            label11.Name = "label11";
            label11.Size = new Size(106, 25);
            label11.TabIndex = 34;
            label11.Text = "Username :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(303, 120);
            lblUsername.Margin = new Padding(1, 0, 1, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 15);
            lblUsername.TabIndex = 35;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 423);
            Controls.Add(lblUsername);
            Controls.Add(label11);
            Controls.Add(dateTimePicker11);
            Controls.Add(btnSave);
            Controls.Add(txtPasswordConf);
            Controls.Add(label10);
            Controls.Add(txtBoxPassword);
            Controls.Add(label9);
            Controls.Add(txtOldPassword);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProfile";
            Text = "Profile";
            Load += frmProfile_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Roundbtn roundbtn4;
        private Roundbtn roundbtn3;
        private Roundbtn exit_btn1;
        private Label lblProfileMessages;
        private Label lblProfilesApplyClaim;
        private Label label1;
        private Roundbtn btn_logout;
        private Label lbl_showUser;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label5;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtOldPassword;
        private Label label8;
        private TextBox txtBoxPassword;
        private Label label9;
        private TextBox txtPasswordConf;
        private Label label10;
        private Roundbtn btnSave;
        private DateTimePicker dateTimePicker11;
        private PictureBox pictureBox1;
        private Label label11;
        private Label lblUsername;
    }
}