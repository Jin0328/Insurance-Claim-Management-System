namespace Login
{
    partial class frmClaimDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClaimDetail));
            panel1 = new Panel();
            label6 = new Label();
            exit_btn1 = new Roundbtn();
            label1 = new Label();
            btn_logout = new Roundbtn();
            lbl_showUser = new Label();
            label2 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnAccept = new Roundbtn();
            btnReject = new Roundbtn();
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
            panel1.Location = new Point(-2, -2);
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
            lbl_showUser.Size = new Size(58, 15);
            lbl_showUser.TabIndex = 0;
            lbl_showUser.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(354, 32);
            label2.TabIndex = 14;
            label2.Text = "Vehicle Collision Damage Claim";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 118);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 15;
            label8.Text = "2/14/2024, Indianapolis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 166);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 16;
            label3.Text = "Client : Emily Johnson";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 255);
            label4.Name = "label4";
            label4.Size = new Size(755, 186);
            label4.TabIndex = 17;
            label4.Text = resources.GetString("label4.Text");
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(17, 196);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 18;
            label5.Text = "Date of Birth : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(17, 217);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 19;
            label7.Text = "Address : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 441);
            label9.Name = "label9";
            label9.Size = new Size(195, 21);
            label9.TabIndex = 20;
            label9.Text = "Photos or Documentations";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(17, 471);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 21;
            label10.Text = "photo1.png";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.MidnightBlue;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(403, 506);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(182, 45);
            btnAccept.TabIndex = 22;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.MidnightBlue;
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(606, 506);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(182, 45);
            btnReject.TabIndex = 23;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // frmClaimDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReject);
            Controls.Add(btnAccept);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmClaimDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Claim Detail";
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
        private Label label2;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label10;
        private Roundbtn btnAccept;
        private Roundbtn btnReject;
    }
}