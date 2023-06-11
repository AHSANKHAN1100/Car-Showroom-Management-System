using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Car_Showroom

{
    public partial class Login : Form
    {
        string pattren = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        string emailPattren = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
      
            AdminLogin al = new AdminLogin();
            al.setEmail(txtEmail.Text.ToString());
            al.setPassword(txtPassword.Text.ToString());
            al.admin();
            

        }
        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            UserLogin ul=new UserLogin();
            ul.setEmail(txtEmail.Text.ToString());
            ul.setPassword(txtPassword.Text.ToString());
            ul.user();

        }

        //Forget password form show
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget_Password forget_Password = new Forget_Password();
            forget_Password.Show();
            this.Hide();
        }

        //This is for email check
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtEmail.Text, emailPattren) == false)
            {
                txtEmail.Focus();
                errorProvider1.SetError(this.txtEmail, "Invalid Email !");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        //This is for password check 
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPassword.Text, pattren) == false)
            {

                errorProvider2.SetError(this.txtPassword, "Use Upper,lower,number and special charac");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        //Show password check box 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        //Show signup form 
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
            this.Hide();
        }
    }

    //UserLogin Class
    class UserLogin : Login
    {
        private string Email = "";
        private string Password = "";

        //public UserLogin(string email,string pass) 
        //{
        //    this.Email=email;
        //    this.Password = pass;
        //}

        public void setPassword(string _pass)
        {
            this.Password = _pass;
        }
        public string getPassword()
        {
            return Password;
        }
        public void setEmail(string _Email)
        {
            this.Email = _Email;
        }
        public string getEmail()
        {
            return Password;
        }

        public void user()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            string query = ("select * from UserTable where Email = @email and Password =@password");
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", this.Email);
            cmd.Parameters.AddWithValue("@password", this.Password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("You are successfully login", "Success", MessageBoxButtons.OK);
                CustomerBooking uh = new CustomerBooking();
                uh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your password is incorrect", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtEmail.Clear();
                txtEmail.Focus();

            }
            conn.Close();
        }

    }

    class AdminLogin : Login
    {
        private string Email = "";
        private string Password = "";

        //public AdminLogin(string email, string pass) : base()
        //{
        //    this.Email = email;
        //    this.Password = pass;
        //}
        public void setPassword(string _pass)
        {
            this.Password = _pass;
        }
        public string getPassword()
        {
            return Password;
        }
        public void setEmail(string _Email)
        {
            this.Email = _Email;
        }
        public string getEmail()
        {
            return Password;
        }

        public void admin()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            string query = ("select * from AdminTable where Email = @email and Password =@password");
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", this.Email);
            cmd.Parameters.AddWithValue("@password", this.Password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("You are successfully login","Success",MessageBoxButtons.OK);
                AdminHome h = new AdminHome();
                h.Show();
                this.Hide();
                Login l = new Login();
                l.Hide();
            }
            else
            {
                MessageBox.Show("Your password is incorrect","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtEmail.Clear();
                txtEmail.Focus();

            }
            conn.Close();
        }
    }
}