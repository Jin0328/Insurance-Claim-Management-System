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
    public partial class frmAdmin2 : Form
    {
        frmViewClients viewclients;
        frmViewCM viewCM;
        frmViewFM viewFM;
        frmAdmin admin;
        frmUserDetail userDetail;
        Database myDatabase = new Database();
        HelperFunctions helperFunctions = new HelperFunctions();

        public frmAdmin2()
        {
            InitializeComponent();

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClientInfo_Click(object sender, EventArgs e)
        {
            viewclients = new frmViewClients();
            viewclients.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {
            admin = new frmAdmin();
            admin.Show();

            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            userDetail = new frmUserDetail();
            userDetail.Show();
            this.Hide();
        }

        private void frmAdmin2_Load(object sender, EventArgs e)
        {
            List<string> usernames = myDatabase.GetAllUsernames();

            lbxAllUsers.DataSource = usernames;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            helperFunctions.Logout();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_showUser_Click(object sender, EventArgs e)
        {

        }
    }
}
