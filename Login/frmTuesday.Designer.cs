namespace Login
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            login_label = new Label();
            username_label = new Label();
            label1 = new Label();
            password_label = new Label();
            username_txtbox = new TextBox();
            password_txtbox = new TextBox();
            label2 = new Label();
            signup_linklabel = new LinkLabel();
            clearbtn = new Button();
            login_rbtn = new Roundbtn();
            clear_btn2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            exit_btn = new Roundbtn();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Segoe UI", 30F);
            login_label.Location = new Point(434, 108);
            login_label.Name = "login_label";
            login_label.Size = new Size(133, 54);
            login_label.TabIndex = 0;
            login_label.Text = "Log in";
            login_label.Click += login_label_Click;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Segoe UI", 10F);
            username_label.Location = new Point(443, 185);
            username_label.Name = "username_label";
            username_label.Size = new Size(103, 19);
            username_label.TabIndex = 1;
            username_label.Text = "Your Username";
            username_label.Click += username_label_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(443, 241);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI", 10F);
            password_label.Location = new Point(443, 260);
            password_label.Name = "password_label";
            password_label.Size = new Size(99, 19);
            password_label.TabIndex = 3;
            password_label.Text = "Your Password";
            // 
            // username_txtbox
            // 
            username_txtbox.Location = new Point(443, 207);
            username_txtbox.Name = "username_txtbox";
            username_txtbox.Size = new Size(256, 23);
            username_txtbox.TabIndex = 4;
            username_txtbox.TextChanged += username_txtbox_TextChanged;
            // 
            // password_txtbox
            // 
            password_txtbox.Location = new Point(443, 282);
            password_txtbox.Name = "password_txtbox";
            password_txtbox.PasswordChar = '*';
            password_txtbox.Size = new Size(256, 23);
            password_txtbox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(493, 375);
            label2.Name = "label2";
            label2.Size = new Size(112, 13);
            label2.TabIndex = 9;
            label2.Text = "Don't have account?";
            // 
            // signup_linklabel
            // 
            signup_linklabel.AutoSize = true;
            signup_linklabel.Font = new Font("Segoe UI", 8F);
            signup_linklabel.LinkColor = Color.Black;
            signup_linklabel.Location = new Point(602, 375);
            signup_linklabel.Name = "signup_linklabel";
            signup_linklabel.Size = new Size(47, 13);
            signup_linklabel.TabIndex = 11;
            signup_linklabel.TabStop = true;
            signup_linklabel.Text = "Sign up";
            signup_linklabel.LinkClicked += signup_linklabel_LinkClicked;
            // 
            // clearbtn
            // 
            clearbtn.Location = new Point(705, 207);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(46, 23);
            clearbtn.TabIndex = 12;
            clearbtn.Text = "clear";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // login_rbtn
            // 
            login_rbtn.BackColor = Color.MidnightBlue;
            login_rbtn.FlatAppearance.BorderSize = 0;
            login_rbtn.FlatStyle = FlatStyle.Flat;
            login_rbtn.Font = new Font("Segoe UI", 15F);
            login_rbtn.ForeColor = Color.White;
            login_rbtn.Location = new Point(493, 324);
            login_rbtn.Name = "login_rbtn";
            login_rbtn.Size = new Size(156, 40);
            login_rbtn.TabIndex = 13;
            login_rbtn.Text = "Log in";
            login_rbtn.UseVisualStyleBackColor = false;
            login_rbtn.Click += login_rbtn_Click;
            // 
            // clear_btn2
            // 
            clear_btn2.Location = new Point(705, 282);
            clear_btn2.Name = "clear_btn2";
            clear_btn2.Size = new Size(46, 23);
            clear_btn2.TabIndex = 14;
            clear_btn2.Text = "clear";
            clear_btn2.UseVisualStyleBackColor = true;
            clear_btn2.Click += clear_btn2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-292, -77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(674, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(exit_btn);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 57);
            panel1.TabIndex = 20;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.MidnightBlue;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.ForeColor = Color.White;
            exit_btn.Location = new Point(732, 8);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(42, 41);
            exit_btn.TabIndex = 35;
            exit_btn.Text = "X";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click_1;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 6);
            label5.Name = "label5";
            label5.Size = new Size(126, 47);
            label5.TabIndex = 5;
            label5.Text = "Goosestep Insurance";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(clear_btn2);
            Controls.Add(login_rbtn);
            Controls.Add(clearbtn);
            Controls.Add(signup_linklabel);
            Controls.Add(label2);
            Controls.Add(password_txtbox);
            Controls.Add(username_txtbox);
            Controls.Add(password_label);
            Controls.Add(label1);
            Controls.Add(username_label);
            Controls.Add(login_label);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login_label;
        private Label username_label;
        private Label label1;
        private Label password_label;
        private TextBox username_txtbox;
        private TextBox password_txtbox;
        private Label label2;
        private LinkLabel signup_linklabel;
        private Button clearbtn;
        private Roundbtn login_rbtn;
        private Button clear_btn2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Roundbtn roundbtn4;
        private Roundbtn roundbtn3;
        private Roundbtn exit_btn;
        private Label label5;
    }
}
