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
    public partial class frmClaimDetail2 : Form
    {
        frmCM cM;
        public frmClaimDetail2()
        {
            InitializeComponent();
        }

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            cM = new frmCM();
            cM.Show();

            this.Hide();
        }
    }
}
