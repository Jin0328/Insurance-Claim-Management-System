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
    public partial class frmViewCM : Form
    {
        frmViewClients viewClients;
        frmViewCM viewCM;
        frmViewFM viewFM;
        frmAdmin admin;
        Database myDatabase = new Database();
        HelperFunctions helperFunctions = new HelperFunctions();
        public frmViewCM()
        {
            InitializeComponent();
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

        private void frmViewCM_Load(object sender, EventArgs e)
        {
            List<string> usernames = myDatabase.GetAllUsernameOfType(2);

            listBoxClaimManager.DataSource = usernames;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

            helperFunctions.Logout();
            this.Close();
        }
        private void listBoxClaimManager_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*string selectedUsername = listBoxClaimManager.SelectedItem.ToString();

            MessageBox.Show("Selected username: " + selectedUsername, "Username Selected");*/
        }

        
    }
}
