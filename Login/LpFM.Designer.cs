namespace Login
{
    partial class frmFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFM));
            exit_btn1 = new Roundbtn();
            label1 = new Label();
            btn_logout = new Roundbtn();
            lbl_showUser = new Label();
            panel1 = new Panel();
            btnViewMessages = new Label();
            pictureBox1 = new PictureBox();
            btnViewClients = new Roundbtn();
            btnViewClaim = new Roundbtn();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // lbl_showUser
            // 
            lbl_showUser.AutoSize = true;
            lbl_showUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_showUser.ForeColor = SystemColors.ControlLightLight;
            lbl_showUser.Location = new Point(405, 25);
            lbl_showUser.Name = "lbl_showUser";
            lbl_showUser.Size = new Size(58, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnViewMessages);
            panel1.Controls.Add(exit_btn1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 60);
            panel1.TabIndex = 11;
            // 
            // btnViewMessages
            // 
            btnViewMessages.AutoSize = true;
            btnViewMessages.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnViewMessages.ForeColor = SystemColors.ControlLightLight;
            btnViewMessages.Location = new Point(176, 24);
            btnViewMessages.Name = "btnViewMessages";
            btnViewMessages.Size = new Size(87, 15);
            btnViewMessages.TabIndex = 31;
            btnViewMessages.Text = "View Messages";
            btnViewMessages.TextAlign = ContentAlignment.TopCenter;
            btnViewMessages.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-91, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnViewClients
            // 
            btnViewClients.BackColor = Color.MidnightBlue;
            btnViewClients.FlatAppearance.BorderSize = 0;
            btnViewClients.FlatStyle = FlatStyle.Flat;
            btnViewClients.ForeColor = Color.White;
            btnViewClients.Location = new Point(569, 305);
            btnViewClients.Name = "btnViewClients";
            btnViewClients.Size = new Size(203, 39);
            btnViewClients.TabIndex = 14;
            btnViewClients.Text = "View Clients";
            btnViewClients.UseVisualStyleBackColor = false;
            btnViewClients.Click += btnViewClients_Click;
            // 
            // btnViewClaim
            // 
            btnViewClaim.BackColor = Color.MidnightBlue;
            btnViewClaim.FlatAppearance.BorderSize = 0;
            btnViewClaim.FlatStyle = FlatStyle.Flat;
            btnViewClaim.ForeColor = Color.White;
            btnViewClaim.Location = new Point(569, 224);
            btnViewClaim.Name = "btnViewClaim";
            btnViewClaim.Size = new Size(203, 39);
            btnViewClaim.TabIndex = 13;
            btnViewClaim.Text = "View Claims";
            btnViewClaim.UseVisualStyleBackColor = false;
            btnViewClaim.Click += btnViewClaim_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(548, 93);
            label2.Name = "label2";
            label2.Size = new Size(262, 91);
            label2.TabIndex = 12;
            label2.Text = "Protecting What Matters Most  Your Safety, Our Priority.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmFM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 448);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnViewClients);
            Controls.Add(btnViewClaim);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmFM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finance Manager";
            Load += frmFM_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Roundbtn exit_btn1;
        private Label label1;
        private Roundbtn btn_logout;
        private Label lbl_showUser;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Roundbtn btnViewClients;
        private Roundbtn btnViewClaim;
        private Label label2;
        private Label btnViewMessages;
    }
}