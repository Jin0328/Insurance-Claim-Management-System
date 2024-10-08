namespace Login
{
    partial class frmFMamount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFMamount));
            panel1 = new Panel();
            label6 = new Label();
            exit_btn = new Roundbtn();
            label1 = new Label();
            btn_logout = new Roundbtn();
            lbl_showUser = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            btnTransfer = new Roundbtn();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(exit_btn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 60);
            panel1.TabIndex = 14;
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
            // exit_btn
            // 
            exit_btn.BackColor = Color.MidnightBlue;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.ForeColor = Color.White;
            exit_btn.Location = new Point(732, 11);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(42, 41);
            exit_btn.TabIndex = 29;
            exit_btn.Text = "X";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(18, 205);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 33;
            label7.Text = "Address : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(18, 184);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 32;
            label5.Text = "Date of Birth : ";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 243);
            label4.Name = "label4";
            label4.Size = new Size(755, 186);
            label4.TabIndex = 31;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 154);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 30;
            label3.Text = "Client : Emily Johnson";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 106);
            label8.Name = "label8";
            label8.Size = new Size(165, 20);
            label8.TabIndex = 29;
            label8.Text = "2/14/2024, Indianapolis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 68);
            label2.Name = "label2";
            label2.Size = new Size(354, 32);
            label2.TabIndex = 28;
            label2.Text = "Vehicle Collision Damage Claim";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MediumBlue;
            label11.Location = new Point(673, 443);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 34;
            label11.Text = "Approved";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 496);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 53);
            textBox1.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(75, 512);
            label9.Name = "label9";
            label9.Size = new Size(121, 21);
            label9.TabIndex = 36;
            label9.Text = "Amount Detail : ";
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.MidnightBlue;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Location = new Point(591, 498);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(182, 45);
            btnTransfer.TabIndex = 37;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // frmFMamount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTransfer);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmFMamount";
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
        private Roundbtn exit_btn;
        private Label label1;
        private Roundbtn btn_logout;
        private Label lbl_showUser;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label2;
        private Label label11;
        private TextBox textBox1;
        private Label label9;
        private Roundbtn btnTransfer;
    }
}