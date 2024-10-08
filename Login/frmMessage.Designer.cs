namespace Login
{
    partial class lbxMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbxMessages));
            lbxSenders = new ListBox();
            txtMessage = new TextBox();
            btnMessageSend = new Roundbtn();
            signup_label = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            exit_btn1 = new Roundbtn();
            btn_login = new Roundbtn();
            lbl_showUser = new Label();
            panel2 = new Panel();
            lbxIncoming = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbxSenders
            // 
            lbxSenders.FormattingEnabled = true;
            lbxSenders.ItemHeight = 15;
            lbxSenders.Location = new Point(10, 112);
            lbxSenders.Name = "lbxSenders";
            lbxSenders.Size = new Size(162, 319);
            lbxSenders.TabIndex = 0;
            lbxSenders.SelectedIndexChanged += lbxSenders_SelectedIndexChanged_1;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(182, 384);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(442, 45);
            txtMessage.TabIndex = 2;
            // 
            // btnMessageSend
            // 
            btnMessageSend.BackColor = Color.DarkBlue;
            btnMessageSend.FlatAppearance.BorderSize = 0;
            btnMessageSend.FlatStyle = FlatStyle.Flat;
            btnMessageSend.ForeColor = Color.White;
            btnMessageSend.Location = new Point(635, 385);
            btnMessageSend.Name = "btnMessageSend";
            btnMessageSend.Size = new Size(145, 40);
            btnMessageSend.TabIndex = 3;
            btnMessageSend.Text = "Send";
            btnMessageSend.UseVisualStyleBackColor = false;
            btnMessageSend.Click += btnMessageSend_Click;
            // 
            // signup_label
            // 
            signup_label.AutoSize = true;
            signup_label.Font = new Font("Segoe UI", 25F);
            signup_label.Location = new Point(8, 59);
            signup_label.Name = "signup_label";
            signup_label.Size = new Size(152, 46);
            signup_label.TabIndex = 18;
            signup_label.Text = "Message";
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
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(exit_btn1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(lbl_showUser);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 57);
            panel1.TabIndex = 19;
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
            // btn_login
            // 
            btn_login.BackColor = Color.MidnightBlue;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(640, 9);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(62, 39);
            btn_login.TabIndex = 3;
            btn_login.Text = "Logout";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lbxIncoming);
            panel2.Location = new Point(182, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 254);
            panel2.TabIndex = 20;
            // 
            // lbxIncoming
            // 
            lbxIncoming.FormattingEnabled = true;
            lbxIncoming.ItemHeight = 15;
            lbxIncoming.Location = new Point(0, 0);
            lbxIncoming.Margin = new Padding(1, 1, 1, 1);
            lbxIncoming.Name = "lbxIncoming";
            lbxIncoming.Size = new Size(600, 244);
            lbxIncoming.TabIndex = 36;
            lbxIncoming.SelectedIndexChanged += lbxIncoming_SelectedIndexChanged;
            // 
            // lbxMessages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 457);
            Controls.Add(panel1);
            Controls.Add(signup_label);
            Controls.Add(btnMessageSend);
            Controls.Add(txtMessage);
            Controls.Add(lbxSenders);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "lbxMessages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Message";
            Load += frmMessage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxSenders;
        private TextBox txtMessage;
        private Roundbtn btnMessageSend;
        private Label signup_label;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Roundbtn exit_btn1;
        private Roundbtn btn_login;
        private Label lbl_showUser;
        private Panel panel2;
        private ListBox lbxIncoming;
    }
}