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
    public partial class frmViewFM : Form
    {
        frmViewClients viewClients;
        frmViewCM viewCM;
        frmViewFM viewFM;
        frmAdmin admin;
        Database myDatabase = new Database();
        HelperFunctions helperFunctions = new HelperFunctions();
        public frmViewFM()
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

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            admin = new frmAdmin();
            admin.Show();

            this.Hide();
        }

        private void frmViewFM_Load(object sender, EventArgs e)
        {
            List<string> usernames = myDatabase.GetAllUsernameOfType(3);

            listBoxFinanceManagers.DataSource = usernames;
        }

        private void listBoxFinanceManagers_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string selectedUsername = listBoxFinanceManagers.SelectedItem.ToString();

            MessageBox.Show("Selected username: " + selectedUsername, "Username Selected");*/
        }
    }
}
