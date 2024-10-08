namespace Login
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btn_logout = new Roundbtn();
            lbl_showUser = new Label();
            panel1 = new Panel();
            btnUpdate = new Roundbtn();
            exit_btn = new Roundbtn();
            label2 = new Label();
            btnClientSeeStatus = new Roundbtn();
            listviewClientStatus = new ListView();
            columnHeader1 = new ColumnHeader();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-68, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(611, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(256, 23);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 8;
            label4.Text = "View Messages";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(158, 23);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 7;
            label3.Text = "Apply Form";
            label3.Click += label3_Click;
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
            label1.Click += label1_Click;
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
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_login_Click;
            // 
            // lbl_showUser
            // 
            lbl_showUser.AutoSize = true;
            lbl_showUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lbl_showUser.ForeColor = SystemColors.ControlLightLight;
            lbl_showUser.Location = new Point(486, 23);
            lbl_showUser.Name = "lbl_showUser";
            lbl_showUser.Size = new Size(58, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(exit_btn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 57);
            panel1.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MidnightBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(564, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(62, 39);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += roundbtn5_Click;
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
            exit_btn.Click += exit_btn1_Click_1;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(542, 92);
            label2.Name = "label2";
            label2.Size = new Size(262, 91);
            label2.TabIndex = 8;
            label2.Text = "Protecting What Matters Most  Your Safety, Our Priority.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClientSeeStatus
            // 
            btnClientSeeStatus.BackColor = Color.MidnightBlue;
            btnClientSeeStatus.FlatAppearance.BorderSize = 0;
            btnClientSeeStatus.FlatStyle = FlatStyle.Flat;
            btnClientSeeStatus.ForeColor = Color.White;
            btnClientSeeStatus.Location = new Point(570, 256);
            btnClientSeeStatus.Name = "btnClientSeeStatus";
            btnClientSeeStatus.Size = new Size(203, 39);
            btnClientSeeStatus.TabIndex = 11;
            btnClientSeeStatus.Text = "See Claim Status";
            btnClientSeeStatus.UseVisualStyleBackColor = false;
            btnClientSeeStatus.Click += btnClientSeeStatus_Click;
            // 
            // listviewClientStatus
            // 
            listviewClientStatus.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listviewClientStatus.Location = new Point(28, 110);
            listviewClientStatus.Name = "listviewClientStatus";
            listviewClientStatus.Size = new Size(465, 125);
            listviewClientStatus.TabIndex = 12;
            listviewClientStatus.UseCompatibleStateImageBehavior = false;
            listviewClientStatus.View = View.List;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 400;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(27, 74);
            label5.Name = "label5";
            label5.Size = new Size(466, 33);
            label5.TabIndex = 13;
            label5.Text = "Application Status";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(listviewClientStatus);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnClientSeeStatus);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Roundbtn btn_logout;
        private Label lbl_showUser;
        private Panel panel1;
        private Label label2;
        private Roundbtn btnClientSeeStatus;
        private Roundbtn exit_btn;
        private Roundbtn btnUpdate;
        private ListView listviewClientStatus;
        private ColumnHeader columnHeader1;
        private Label label5;
    }
}