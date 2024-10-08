namespace Login
{
    partial class LandingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            lbl_showUser = new Label();
            panel1 = new Panel();
            roundbtn5 = new Roundbtn();
            label4 = new Label();
            exit_btn1 = new Roundbtn();
            label3 = new Label();
            btn_logout = new Roundbtn();
            label1 = new Label();
            label2 = new Label();
            roundbtn1 = new Roundbtn();
            roundbtn2 = new Roundbtn();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_showUser
            // 
            lbl_showUser.AutoSize = true;
            lbl_showUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_showUser.ForeColor = SystemColors.ControlLightLight;
            lbl_showUser.Location = new Point(511, 25);
            lbl_showUser.Name = "lbl_showUser";
            lbl_showUser.Size = new Size(37, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Client";
            lbl_showUser.Click += lbl_showUser_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(roundbtn5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(exit_btn1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(-1, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 60);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // roundbtn5
            // 
            roundbtn5.BackColor = Color.MidnightBlue;
            roundbtn5.FlatAppearance.BorderSize = 0;
            roundbtn5.FlatStyle = FlatStyle.Flat;
            roundbtn5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            roundbtn5.ForeColor = Color.White;
            roundbtn5.Location = new Point(574, 13);
            roundbtn5.Name = "roundbtn5";
            roundbtn5.Size = new Size(62, 39);
            roundbtn5.TabIndex = 39;
            roundbtn5.Text = "Update Profile";
            roundbtn5.UseVisualStyleBackColor = false;
            roundbtn5.Click += roundbtn5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(256, 25);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 8;
            label4.Text = "View Messages";
            label4.Click += label4_Click;
            // 
            // exit_btn1
            // 
            exit_btn1.BackColor = Color.MidnightBlue;
            exit_btn1.FlatAppearance.BorderSize = 0;
            exit_btn1.FlatStyle = FlatStyle.Flat;
            exit_btn1.ForeColor = Color.White;
            exit_btn1.Location = new Point(737, 12);
            exit_btn1.Name = "exit_btn1";
            exit_btn1.Size = new Size(42, 41);
            exit_btn1.TabIndex = 36;
            exit_btn1.Text = "X";
            exit_btn1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(158, 25);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 7;
            label3.Text = "Apply Form";
            label3.Click += label3_Click;
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
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(546, 92);
            label2.Name = "label2";
            label2.Size = new Size(262, 91);
            label2.TabIndex = 7;
            label2.Text = "Protecting What Matters Most  Your Safety, Our Priority.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // roundbtn1
            // 
            roundbtn1.BackColor = Color.MidnightBlue;
            roundbtn1.FlatAppearance.BorderSize = 0;
            roundbtn1.FlatStyle = FlatStyle.Flat;
            roundbtn1.ForeColor = Color.White;
            roundbtn1.Location = new Point(567, 223);
            roundbtn1.Name = "roundbtn1";
            roundbtn1.Size = new Size(203, 39);
            roundbtn1.TabIndex = 8;
            roundbtn1.Text = "View My Status";
            roundbtn1.UseVisualStyleBackColor = false;
            roundbtn1.Click += roundbtn1_Click;
            // 
            // roundbtn2
            // 
            roundbtn2.BackColor = Color.MidnightBlue;
            roundbtn2.FlatAppearance.BorderSize = 0;
            roundbtn2.FlatStyle = FlatStyle.Flat;
            roundbtn2.ForeColor = Color.White;
            roundbtn2.Location = new Point(567, 304);
            roundbtn2.Name = "roundbtn2";
            roundbtn2.Size = new Size(203, 39);
            roundbtn2.TabIndex = 9;
            roundbtn2.Text = "Download Claim Reports";
            roundbtn2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-93, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(roundbtn2);
            Controls.Add(roundbtn1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LandingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            Load += LandingPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_showUser;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Roundbtn roundbtn1;
        private Roundbtn roundbtn2;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Roundbtn exit_btn1;
        private Roundbtn btn_logout;
        private Roundbtn roundbtn5;
    }
}