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
    public partial class frmProfile : Form
    {
        Main main;
        HelperFunctions helperFunctions = new HelperFunctions();
        private string loggedInUsername;
        Database myDatabase = new Database();
        public frmProfile(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            enteringPerson person = new enteringPerson();
            person.Username = loggedInUsername;
            person.Password = txtOldPassword.Text;
            string tableName = "UserAccount";
            if (txtBoxPassword.Text == txtPasswordConf.Text)
            {

                if (myDatabase.QueryLogin(tableName, ref person))
                {
                    person.Password = txtPasswordConf.Text;
                    person.email = txtEmail.Text;
                    person.Username = loggedInUsername;
                    person.lastName = txtLastName.Text;
                    person.firstName = txtFirstName.Text;
                    person.dateofBirth = dateTimePicker11.Value;

                    myDatabase.UpdateUserDetails(person);




                    MessageBox.Show("Saved", "Message", MessageBoxButtons.OK);
                    main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter a valid password for that username");
                }
            }
            else
            {
                MessageBox.Show("The passwords are not matching");
            }


        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            helperFunctions.Logout();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            lblUsername.Text = loggedInUsername;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form messages = new lbxMessages();
            messages.Show();
            this.Hide();
        }

        private void exit_btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
