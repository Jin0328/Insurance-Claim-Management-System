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
    public partial class frmViewClaim : Form
    {
        Main main;
        lbxMessages message;
        frmClaimDetail detail;
        Database myDatabase = new Database();
        private bool firstClick = false;
        public frmViewClaim()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            main = new Main();
            main.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            message = new lbxMessages();
            message.Show();
            this.Hide();
        }

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            detail = new frmClaimDetail();
            detail.Show();

            this.Hide();
        }

        private void frmViewClaim_Load(object sender, EventArgs e)
        {
            

            List<string> dates = myDatabase.GetAllDates();
            lbxDates.DataSource = dates;

            List<string> users = myDatabase.GetAllUsersForClaim();
            lbxClients.DataSource = users;

            List<string> claims = myDatabase.GetAllClaims();
            lbxClaimTitles.DataSource = claims;



        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lbxClaimTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (firstClick)
            {
                if (MessageBox.Show("Would you like to view the claim details?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sender1 = lbxClaimTitles.SelectedItem.ToString();
                    string tableName_ = "Claim";
                    string claimText = myDatabase.GetClaimDetails(tableName_, sender1);
                    MessageBox.Show("Claim from: " + sender1 + "\n\nDetails: " + claimText);


                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                firstClick = true;
            }*/
        }
    }
}
