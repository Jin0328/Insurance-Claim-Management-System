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
    public partial class frmCM : Form
    {
        frmViewClaim viewClaim;
        Blob myBlob;
        string username_;
        public frmCM()
        {
            InitializeComponent();
        }
        public frmCM(Blob b, string username)
        {
            myBlob = b;
            username_ = username;
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundbtn1_Click(object sender, EventArgs e)
        {
            viewClaim = new frmViewClaim();
            viewClaim.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form logout = new frmLogin();
            logout.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form message = new lbxMessages();
            message.Show();
            this.Hide();
        }

        private void roundbtn2_Click(object sender, EventArgs e)
        {
            Form clients = new frmViewClients();
            clients.Show();
            this.Hide();
        }
    }
}
