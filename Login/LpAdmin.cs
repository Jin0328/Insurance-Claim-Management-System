using Microsoft.IdentityModel.Tokens;
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
    public partial class frmAdmin : Form
    {
        frmAdmin2 users;
        Blob myBlob;
        lbxMessages message;
        private string username_;
        Database myDatabase;
        public frmAdmin()
        {
            InitializeComponent();
        }
        /* public frmAdmin(string username)
        {
            username_ = username;
            InitializeComponent();
        } */
        public frmAdmin(Blob b, Database d)
        {
            myDatabase = d;
            myBlob = b;
            InitializeComponent();
        }
        public frmAdmin(Blob b, Database d, string username)
        {
            myDatabase = d;
            myBlob = b;
            username_ = username;
            InitializeComponent();
        }
        /*
        public frmAdmin(Blob b, string username)
        {
            // myDatabase = d;
            myBlob = b;
            username_ = username;
            InitializeComponent();
            
        } */

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            users = new frmAdmin2();
            users.Show();

            this.Hide();
        }

        private void btnShowFolders_Click(object sender, EventArgs e)
        {
            listviewAdminContainers.Clear();
            myBlob.ListBlobContainersAsync(listviewAdminContainers);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            ofdLpAdmin.ShowDialog();
            if (ofdLpAdmin.CheckFileExists)
            {
                string path = ofdLpAdmin.FileName;
                try
                {
                    myBlob.UploadFromFileAsync(path, "admin");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Path does not exists");
            }
        }

        private void btnShowFilesLpAdmin_Click(object sender, EventArgs e)
        {
            string container = txtLpAdminFolderName.Text;
            listviewLpAdminFiles.Clear();
            if (!container.IsNullOrEmpty())
            {
                myBlob.GetFiles(container, listviewLpAdminFiles);
            }
        }

        private void listviewAdminContainers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {


        }

        private void lblViewMessages_Click(object sender, EventArgs e)
        {
            message = new lbxMessages(username_, 1);
            message.Show();
        }
        private void btnLpAdminShowLogs_Click(object sender, EventArgs e)
        {
            listviewLpAdminLogs.Clear();
            myDatabase.GetLogs(listviewLpAdminLogs);
        }

    }
}
