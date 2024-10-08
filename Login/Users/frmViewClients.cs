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
    public partial class frmViewClients : Form
    {
        frmViewClients viewClients;
        frmViewCM viewCM;
        frmViewFM viewFM;
        frmAdmin admin;
        HelperFunctions helperFunctions = new HelperFunctions();
        Database myDatabase = new Database();
        public frmViewClients()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            admin = new frmAdmin();
            admin.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Would you like to register this person as a Claim Manager?", "Register as CM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to register this person as a Claim Manager?", "Register as CM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to register this person as a Claim Manager?", "Register as CM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to register this person as a Finance Manager?", "Register as FM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to register this person as a Finance Manager?", "Register as FM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to register this person as a Finance Manager?", "Register as FM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void btnClientInfo_Click(object sender, EventArgs e)
        {
            viewClients = new frmViewClients();
            viewClients.Show();

            this.Hide();
        }

        private void btnCMInfo_Click(object sender, EventArgs e)
        {
            viewCM = new frmViewCM();
            viewCM.Show();

            this.Hide();
        }

        private void btnFMInfo_Click(object sender, EventArgs e)
        {
            viewFM = new frmViewFM();
            viewFM.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            helperFunctions.Logout();
            this.Close();
        }

        private void frmViewClients_Load(object sender, EventArgs e)
        {
            List<string> usernames = myDatabase.GetAllUsernameOfType(0);

            listBoxClients.DataSource = usernames;
        }

        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*if (listBoxClients.DataSource != null && listBoxClients.DataSource.GetType() == typeof(List<string>))
            {
                         
                    string selectedUsername = listBoxClients.SelectedItem.ToString();

                    MessageBox.Show("Selected username: " + selectedUsername, "Username Selected");
                
            }*/

        }
    }
}
