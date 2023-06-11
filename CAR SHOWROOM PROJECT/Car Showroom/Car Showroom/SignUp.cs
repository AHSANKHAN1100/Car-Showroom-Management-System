using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Car_Showroom
{
    public partial class SignUp : Form
    {
        string pattren = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        string emailPattren = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {




        }

        void addNameInCombo()
        {

        }

        //User sign up Button
        private void btnUserSignup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            try
            {
                string query = "insert into UserTable values(@username,@email,@pass);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                int a = cmd.ExecuteNonQuery();

                if (true)
                {
                    MessageBox.Show("You are successfully Registered", "Success", MessageBoxButtons.OK);
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }

  
        

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                txtName.Focus();
                Console.WriteLine(this.txtName + "Please Fill the Name");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

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
        private void ckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void linkBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        //Show password check box 
    }
}
