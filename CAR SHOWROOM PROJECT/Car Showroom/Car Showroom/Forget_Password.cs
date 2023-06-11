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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Car_Showroom
{
    public partial class Forget_Password : Form
    {
        string pattren = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            try
            {
                string query = "update AdminTable set Password = @pass where Email = 'Ali12@gmail.com'";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (txtNewPassword.Text == txtConPassword.Text)
                {
                    if (txtConPassword.Text != "" && txtNewPassword.Text != "")
                    {
                        cmd.Parameters.AddWithValue("@pass", txtConPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your password has updated");
                        this.Hide();
                        Login login = new Login();
                        login.Show();

                    }

                    else
                    {
                        txtNewPassword.Focus();
                        MessageBox.Show("Fill the boxes", "EMPTY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    txtConPassword.Focus();
                    errorProvider3.SetError(txtConPassword, "your password is not same");
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

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtNewPassword.Text, pattren) == false)
            {

                errorProvider1.SetError(this.txtNewPassword, "Use Upper,lower,number and special charac");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtConPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtConPassword.Text, pattren) == false)
            {
                txtConPassword.Focus();
                errorProvider2.SetError(this.txtConPassword, "Use Upper,lower,number and special charac");
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
                txtNewPassword.UseSystemPasswordChar = true;
                txtConPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = false;
                txtConPassword.UseSystemPasswordChar = false;
            }
        }
        private void btnBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void linkBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
