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
    public partial class frmFMclaim : Form
    {
        public frmFMclaim()
        {
            InitializeComponent();
        } 

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
