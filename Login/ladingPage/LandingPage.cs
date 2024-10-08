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
    public partial class LandingPage : Form
    {
        Main main;
        ClaimForm claimForm;
        lbxMessages message;
        frmAdmin admin;
        dynamic newform;
        private Stack<Form> historyStack = new Stack<Form>();
        frmProfile profile;
        HelperFunctions helperFunctions;
        frmStatus status;


        public LandingPage()
        {
            InitializeComponent();
            historyStack.Push(this);
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }

        private void LandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            main = new Main();
            main.Show();

            this.Hide();
        }

        private void lbl_showUser_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            claimForm = new ClaimForm();
            claimForm.Show();

            this.Hide();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void exit_btn1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roundbtn4_Click(object sender, EventArgs e)
        {
            if (historyStack.Count > 1)
            {
                Form previousForm = historyStack.Pop();
                previousForm.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            helperFunctions.Logout();
            this.Close();

        }

        private void roundbtn5_Click(object sender, EventArgs e)
        {
            /*profile = new frmProfile(loggedInUsername);
            profile.Show();

            this.Hide();*/
        }

        private void roundbtn1_Click(object sender, EventArgs e)
        {
            status = new frmStatus();
            status.Show();

            this.Hide();
        }
    }
}
