using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Username_lbl : Form
    {
        Database myDatabase = new Database();
        dynamic welcome;
        Blob myBlob = new Blob();
        public string loggedInUsername;

        string tablename = "UserAccount";
        public Username_lbl()
        {
            InitializeComponent();
        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void signup_rbtn_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtPassConf.Text)
            {
                MessageBox.Show("Passwords do not match. Please check again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                loggedInUsername=txtUsername.Text;
               // MessageBox.Show("Registration successful!", "Message", MessageBoxButtons.OK);
                //MessageBox.Show(user_combobox.Text);

                int accountVariable;
                if (user_combobox.Text == "Client")
                {
                    accountVariable = 0;
                }
                else if (user_combobox.Text == "Adiministrator")
                {
                    accountVariable = 1;
                }
                else if (user_combobox.Text == "Client Manager")
                {
                    accountVariable = 2;
                }
                else
                {
                    accountVariable = 3;
                }

                enteringPerson steve = new enteringPerson();
                steve.Username = txtUser.Text;
                steve.Password = txtPass.Text;
                steve.Account_type = accountVariable;
                steve.lastName=txtLastName.Text;
                steve.firstName=txtFirstName.Text;
                steve.dateofBirth = dateTimePicker1.Value;
                steve.email= txtEmail.Text;

                this.Hide();

                if (accountVariable == 0)
                {
                    welcome = new Main();
                    welcome.Show();
                }

                if (accountVariable == 1)
                {
                    welcome = new frmAdmin(myBlob, myDatabase, loggedInUsername);

                }

                //MessageBox.Show(txtUsername.Text);

                myDatabase.InsertPersonToLogin(tablename, steve);




            }
        }

        

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void exit_btn1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
