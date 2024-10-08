namespace Login
{
    partial class ClaimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimForm));
            signup_label = new Label();
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtLastName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtBoxStreetAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtZipCode = new TextBox();
            txtCountry = new TextBox();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            txtLocation = new TextBox();
            label9 = new Label();
            label10 = new Label();
            richTextBox1 = new RichTextBox();
            label11 = new Label();
            roundbtn2 = new Roundbtn();
            btnUploadClaimForm = new Button();
            exit_btn = new Roundbtn();
            label14 = new Label();
            panel1 = new Panel();
            txtUsername = new TextBox();
            ofdClaimForm = new OpenFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // signup_label
            // 
            signup_label.AutoSize = true;
            signup_label.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_label.Location = new Point(12, 70);
            signup_label.Name = "signup_label";
            signup_label.Size = new Size(330, 47);
            signup_label.TabIndex = 2;
            signup_label.Text = "Claim Request Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 125);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 3;
            label1.Text = "Claimant Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 163);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(18, 187);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 23);
            txtFirstName.TabIndex = 5;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(158, 163);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(297, 163);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 8;
            label4.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(297, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(158, 187);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 23);
            txtLastName.TabIndex = 11;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(516, 163);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 12;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 224);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 17;
            label6.Text = "Address";
            // 
            // txtBoxStreetAddress
            // 
            txtBoxStreetAddress.Location = new Point(18, 250);
            txtBoxStreetAddress.Name = "txtBoxStreetAddress";
            txtBoxStreetAddress.Size = new Size(619, 23);
            txtBoxStreetAddress.TabIndex = 18;
            txtBoxStreetAddress.Text = "Street Address";
            txtBoxStreetAddress.TextChanged += txtBoxStreetAddress_TextChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(18, 282);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(305, 23);
            txtCity.TabIndex = 19;
            txtCity.Text = "City";
            txtCity.TextChanged += txtCity_TextChanged;
            // 
            // txtState
            // 
            txtState.Location = new Point(332, 282);
            txtState.Name = "txtState";
            txtState.Size = new Size(305, 23);
            txtState.TabIndex = 20;
            txtState.Text = "State";
            txtState.TextChanged += txtState_TextChanged;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(18, 316);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(305, 23);
            txtZipCode.TabIndex = 21;
            txtZipCode.Text = "Postal/Zip Code";
            txtZipCode.TextChanged += txtZipCode_TextChanged;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(332, 316);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(305, 23);
            txtCountry.TabIndex = 22;
            txtCountry.Text = "Country";
            txtCountry.TextChanged += txtCountry_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 352);
            label7.Name = "label7";
            label7.Size = new Size(142, 25);
            label7.TabIndex = 23;
            label7.Text = "Incident Details";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(18, 407);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(305, 23);
            dateTimePicker2.TabIndex = 25;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 383);
            label8.Name = "label8";
            label8.Size = new Size(100, 17);
            label8.TabIndex = 24;
            label8.Text = "Date of Incident";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(332, 407);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(305, 23);
            txtLocation.TabIndex = 27;
            txtLocation.TextChanged += textBox8_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(332, 381);
            label9.Name = "label9";
            label9.Size = new Size(57, 17);
            label9.TabIndex = 26;
            label9.Text = "Location";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(18, 445);
            label10.Name = "label10";
            label10.Size = new Size(161, 17);
            label10.TabIndex = 28;
            label10.Text = "Description of the Incident";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(18, 468);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(619, 96);
            richTextBox1.TabIndex = 29;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(18, 579);
            label11.Name = "label11";
            label11.Size = new Size(157, 17);
            label11.TabIndex = 30;
            label11.Text = "Photos or Documentation";
            // 
            // roundbtn2
            // 
            roundbtn2.BackColor = Color.DarkBlue;
            roundbtn2.FlatAppearance.BorderSize = 0;
            roundbtn2.FlatStyle = FlatStyle.Flat;
            roundbtn2.ForeColor = Color.White;
            roundbtn2.Location = new Point(309, 636);
            roundbtn2.Name = "roundbtn2";
            roundbtn2.Size = new Size(125, 40);
            roundbtn2.TabIndex = 32;
            roundbtn2.Text = "Confirm";
            roundbtn2.UseVisualStyleBackColor = false;
            roundbtn2.Click += roundbtn2_Click;
            // 
            // btnUploadClaimForm
            // 
            btnUploadClaimForm.Location = new Point(18, 602);
            btnUploadClaimForm.Name = "btnUploadClaimForm";
            btnUploadClaimForm.Size = new Size(100, 23);
            btnUploadClaimForm.TabIndex = 33;
            btnUploadClaimForm.Text = "Upload";
            btnUploadClaimForm.UseVisualStyleBackColor = true;
            btnUploadClaimForm.Click += button1_Click;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.MidnightBlue;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.ForeColor = Color.White;
            exit_btn.Location = new Point(732, 7);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(42, 41);
            exit_btn.TabIndex = 35;
            exit_btn.Text = "X";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click_1;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(17, 5);
            label14.Name = "label14";
            label14.Size = new Size(126, 47);
            label14.TabIndex = 5;
            label14.Text = "Goosestep Insurance";
            label14.Click += label14_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(exit_btn);
            panel1.Controls.Add(label14);
            panel1.Location = new Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 57);
            panel1.TabIndex = 34;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(516, 188);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 23);
            txtUsername.TabIndex = 35;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // ofdClaimForm
            // 
            ofdClaimForm.FileName = "openFileDialog1";
            // 
            // ClaimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUsername);
            Controls.Add(panel1);
            Controls.Add(btnUploadClaimForm);
            Controls.Add(roundbtn2);
            Controls.Add(label11);
            Controls.Add(richTextBox1);
            Controls.Add(label10);
            Controls.Add(txtLocation);
            Controls.Add(label9);
            Controls.Add(dateTimePicker2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtCountry);
            Controls.Add(txtZipCode);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtBoxStreetAddress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signup_label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClaimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Claim Request Form";
            Load += ClaimForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signup_label;
        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox txtLastName;
        private Label label5;
        private Label label6;
        private TextBox txtBoxStreetAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtZipCode;
        private TextBox txtCountry;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private TextBox txtLocation;
        private Label label9;
        private Label label10;
        private RichTextBox richTextBox1;
        private Label label11;
        private Roundbtn roundbtn2;
        private Button btnUploadClaimForm;
        private Roundbtn exit_btn;
        private Label label14;
        private Panel panel1;
        private TextBox txtUsername;
        private OpenFileDialog ofdClaimForm;
    }
}