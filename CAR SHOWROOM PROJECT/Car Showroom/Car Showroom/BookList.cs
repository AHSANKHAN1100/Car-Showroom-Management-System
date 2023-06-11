using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Showroom
{
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }
        private void BookList_Load(object sender, EventArgs e)
        {
        }

        public void getAllDataFromDataBase()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            try
            {
                string query = "select * from CustomerDetails";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
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
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult con = MessageBox.Show("sure you want to delete all data", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (con == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
                conn.Open();
                try
                {
                    string query = "delete from CustomerDetails";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int a = cmd.ExecuteNonQuery();
                    if (true)
                    {
                        MessageBox.Show("Your data succusssfully delete");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally { conn.Close(); }
            }
        }

        private void BookList_Activated(object sender, EventArgs e)
        {
            getAllDataFromDataBase();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome a = new AdminHome();
            a.Show();
            this.Hide();
        }
    }
}
