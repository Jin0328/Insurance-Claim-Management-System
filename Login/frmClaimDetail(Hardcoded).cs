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
    public partial class frmClaimDetail : Form
    {
        frmUserDetail userDetail;
        frmClaimDetail2 claimDetail2;
        public frmClaimDetail()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            userDetail = new frmUserDetail();
            userDetail.Show();

            this.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed with Claim Acceptance and transfer files to FM?", "Claim Acceptance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Status should be changed into Accepted
                claimDetail2 = new frmClaimDetail2();
                claimDetail2.Show();

                this.Hide();
                //Files should be transfered to Finance Manager
            }
            else
            {

            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed with Claim Rejection?", "Claim Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Status should be changed into Rejected

            }
            else
            {

            }
        }

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
