using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class lbxMessages : Form
    {
        LandingPage welcome;
        ClaimForm claimForm;
        private Dictionary<string, string> conversations;
        private int messageNumber = 1;
        Database myDatabase = new Database();
        private string username_ = "";
        private int accountType_;
        private bool firstClick = false;


        public lbxMessages(string username, int accountType)
        {
            InitializeComponent();
            username_ = username;
            accountType_ = accountType;

        }
        public lbxMessages()
        {
            InitializeComponent();

        }

        private void InitializeSendersList()
        {

        }

        private void LoadSenders()
        {

        }

        private void LbxSenders_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* string selectedSender = lbxSenders.SelectedItem.ToString();
             txtChat.Text = conversations[selectedSender];*/
        }

        private void InitializeChatControls()
        {
            /*txtChat.Multiline = true;
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.TextAlign = HorizontalAlignment.Right;

            btnSend.Click += BtnSend_Click;*/
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {

            string tableName_ = "Message";
            enteringMessage message = new enteringMessage();
            DateTime timestamp = DateTime.Now;

            message.messageBody = txtMessage.Text;
            message.messageRecipient = lbxSenders.SelectedItem.ToString();
            message.messageTime = timestamp;

            message.messageSender = username_;

            myDatabase.InsertMessageToTable(tableName_, message);
        }

        private void lbxSenders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMessageSend_Click(object sender, EventArgs e)
        {
            string tableName_ = "Message";


            enteringMessage message = new enteringMessage();
            DateTime timestamp = DateTime.Now;

            message.messageBody = txtMessage.Text;
            message.messageRecipient = lbxSenders.SelectedItem.ToString();
            message.messageTime = timestamp;
            message.messageSender = username_;

            MessageBox.Show("Username: " + username_);
            //MessageBox.Show("Username: " + username_);



            myDatabase.InsertMessageToTable(tableName_, message);


        }

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            claimForm = new ClaimForm();
            claimForm.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            welcome = new LandingPage();
            welcome.Show();

            this.Hide();
        }

        private void txtChat_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
            if (accountType_ == 0)
            {
                List<string> usernames = myDatabase.GetAllUsernameOfTypes(1, 2, 3);

                lbxSenders.DataSource = usernames;
            }
            else
            {
                List<string> usernames = myDatabase.GetAllUsernames();

                lbxSenders.DataSource = usernames;
            }

            List<string> messages = myDatabase.GetMessages(username_);

            lbxIncoming.DataSource = messages;

        }



        private void lbxSenders_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void lbxIncoming_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstClick)
            {
                if (MessageBox.Show("Would you like to view the message Details?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sender1 = lbxIncoming.SelectedItem.ToString();
                    string tableName_ = "Message";
                    string MessageText = myDatabase.GetMessageDetails(tableName_, username_, sender1);
                    MessageBox.Show("Sent from: " + sender1 + "\n\nMessage: " + MessageText);

                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                firstClick = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form logout = new frmLogin();
            logout.Show();
            this.Hide();
        }
    }
}
