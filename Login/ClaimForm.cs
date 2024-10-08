using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ClaimForm : Form
    {
        private string claimLocation_, claimDescription_;
        private string date_;
        private string claimFiler_ = "";
        private string claimStatus_ = "pending";
        private string streetAddress_, city_, country_, state_;
        private string zipCode_;


        dynamic welcome;

        Database myDatabase = new Database();
        string tablename = "Claim";
        string tableName2 = "UserInfo";
        Blob myBlob;
        private Stack<Form> historyStack = new Stack<Form>();
        Main main;
        string username_;

        public ClaimForm()
        {
            InitializeComponent();
            historyStack.Push(this);
        }
        public ClaimForm(Blob b, string username)
        {
            myBlob = b;
            username_ = username;
            InitializeComponent();
            historyStack.Push(this);
        }
        public ClaimForm(Database d, Blob b)
        {
            myBlob = b;
            myDatabase = d;
            InitializeComponent();
            historyStack.Push(this);
        }

        private void ClaimForm_Load(object sender, EventArgs e)
        {

        }

        private void roundbtn4_Click(object sender, EventArgs e)
        {
            if (historyStack.Count > 1)
            {
                Form previousForm = historyStack.Pop();
                previousForm.Show();
                this.Hide();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            main = new Main();
            main.Show();

            this.Hide();

        }

        private void roundbtn2_Click(object sender, EventArgs e)
        {
            enteringClaim scottie = new enteringClaim();


            scottie.claimLocation = claimLocation_;
            scottie.claimFiler = username_;
            scottie.claimStatus = claimStatus_;
            scottie.claimDate = date_;
            scottie.claimLocation = claimLocation_;
            scottie.claimDescription = claimDescription_;


            myDatabase.InsertClaimToTable(tablename, scottie);

            int nextForm = 0;

            if (nextForm == 1) // Admin
            {
                welcome = new frmAdmin(myBlob,myDatabase);
            }
            else if (nextForm == 0) // Client
            {
                welcome = new Main(myBlob, myDatabase);
            }
            else if (nextForm == 3) // Finance Manager
            {
                welcome = new frmFM(myBlob);
            }
            else if (nextForm == 2) // Claim Manager
            {
                welcome = new frmCM();
            }



            userInfo userDetails = new userInfo();

            userDetails.streetAddress = streetAddress_;
            //userDetails.state = state_;
            userDetails.zipCode = zipCode_;
            userDetails.city = city_;
            userDetails.country = country_;

            string tablename2 = "userInfo";

            myDatabase.InsertUserInfo(tablename2, userDetails);

            welcome.Show();
            this.Hide();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            claimDescription_ = richTextBox1.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            claimLocation_ = txtLocation.Text;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            updateClaimFiler();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            updateClaimFiler();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            date_ = dateTimePicker2.Value.ToShortDateString();
        }

        private void updateClaimFiler()
        {
            //claimFiler_ = txtFirstName.Text + " " + txtLastName.Text;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            claimFiler_ = txtUsername.Text;
        }



        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            country_ = txtCountry.Text;
        }

        private void txtBoxStreetAddress_TextChanged(object sender, EventArgs e)
        {
            streetAddress_ = txtBoxStreetAddress.Text;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            city_ = txtCity.Text;
        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {
            zipCode_ = txtZipCode.Text;
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            state_ = txtState.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdClaimForm.ShowDialog();
            if (ofdClaimForm.CheckFileExists)
            {
                string path = ofdClaimForm.FileName;
                try
                {
                    myBlob.UploadFromFileAsync(path, "client");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Path does not exists");
            }
        }
    }
}
