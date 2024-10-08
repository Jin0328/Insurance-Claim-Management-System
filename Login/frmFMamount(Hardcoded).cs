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
    public partial class frmFMamount : Form
    {
        frmFMclaim fmClaim;
        public frmFMamount()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed with Claim Acceptance and transfer amount details to the client?", "Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Status should be changed into Accepted
                fmClaim = new frmFMclaim();
                fmClaim.Show();

                this.Hide();
                //Files should be transfered to Finance Manager
            }
            else
            {

            }
        }
    }
}
