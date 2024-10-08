using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Login
{
    public partial class Main : Form
    {
        frmLogin login;
        Main main;
        ClaimForm claimForm;
        lbxMessages message;
        frmStatus status;
        Blob myBlob;
        frmProfile profile;
        private string username_;
        Database myDatabase;

        public Main()
        {
            InitializeComponent();
        }
        public Main(Blob b, string username)
        {
            myBlob = b;
            username_ = username;
            InitializeComponent();
        }
        public Main(Blob b, Database d, string username)
        {
            myBlob = b;
            username_ = username;
            myDatabase = d;
            InitializeComponent();
        }
        public Main(Blob b, Database d)
        {
            myBlob = b;
            myDatabase = d;
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login = new frmLogin();
            login.Show();

            this.Hide();
        }

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            main = new Main();
            main.Show();

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            claimForm = new ClaimForm(myDatabase, myBlob);
            claimForm.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            message = new lbxMessages(username_, 0);
            message.Show();

            this.Hide();
        }

        private void exit_btn1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void roundbtn5_Click(object sender, EventArgs e)
        {
            profile = new frmProfile(username_);
            profile.Show();

            this.Hide();
        }

        private void btnClientSeeStatus_Click(object sender, EventArgs e)
        {
            listviewClientStatus.Clear();
            myDatabase.GetStatus(username_,listviewClientStatus);   
        }
    }
}
