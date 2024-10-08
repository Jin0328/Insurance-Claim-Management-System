namespace Login
{
    public partial class frmLogin : Form
    {
        dynamic welcome;
        Username_lbl signup;
        Database myDatabase = new Database();
        Blob myBlob = new Blob();
        public string loggedInUsername;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            welcome = new LandingPage();
            welcome.Show();

            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signup_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup = new Username_lbl();
            signup.Show();

            this.Hide();
        }

        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            username_txtbox.Text = "";
        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void login_rbtn_Click(object sender, EventArgs e)
        {
            enteringPerson butkus = new enteringPerson();
            butkus.Username = username_txtbox.Text;
            butkus.Password = password_txtbox.Text;

            string tableName_ = "UserAccount";
            try
            {
                if (myDatabase.QueryLogin(tableName_, ref butkus))
                {
                    loggedInUsername = butkus.Username;

                    if (butkus.Account_type == 1) // Admin
                    {
                        welcome = new frmAdmin(myBlob, myDatabase,loggedInUsername);
                    }
                    else if (butkus.Account_type == 0) // Client
                    {
                        welcome = new Main(myBlob, myDatabase, loggedInUsername);
                    }
                    else if (butkus.Account_type == 3) // Finance Manager
                    {
                        welcome = new frmFM(myBlob);
                    }
                    else if (butkus.Account_type == 2) // Claim Manager
                    {
                        welcome = new frmCM(myBlob,loggedInUsername);
                    }


                    
                    //frmProfile profileForm = new frmProfile(loggedInUsername);
                    welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed. Enter new login information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message);
            }
        }

        private void clear_btn2_Click(object sender, EventArgs e)
        {
            password_txtbox.Text = "";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            // Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void roundbtn4_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
