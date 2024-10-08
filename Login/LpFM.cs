using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmFM : Form
    {
        frmViewClaim viewClaim;
        Blob myBlob;
        public frmFM()
        {
            InitializeComponent();
        }
        public frmFM(Blob b)
        {
            myBlob = b;
            InitializeComponent();
        }

        private void btnViewClaim_Click(object sender, EventArgs e)
        {
            viewClaim = new frmViewClaim();
            viewClaim.Show();

            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form message = new lbxMessages();
            message.Show();
            this.Hide();
        }

        private void frmFM_Load(object sender, EventArgs e)
        {

        }

        private void btnViewClients_Click(object sender, EventArgs e)
        {
            Form client = new frmViewClients();
            client.Show();
            this.Hide();
        }
    }
}
