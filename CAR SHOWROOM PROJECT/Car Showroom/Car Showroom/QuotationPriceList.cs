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
    public partial class QuotationPriceList : Form
    {
        public QuotationPriceList()
        {
            InitializeComponent();
        }
        private void QuotationPriceList_Load(object sender, EventArgs e)
        {
        }


        //Get data from Data base Quotation prices table
        private void getAllDataFromDataBase()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            try
            {
                string query = "select * from QuotationPrices";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult con = MessageBox.Show("sure you want to delete all data", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (con == DialogResult.Yes)
            {
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "DELETE")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
                    conn.Open();
                    try
                    {
                        string model = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["modelColumn"].Value);
                        string query = "delete from QuotationPrices where Model=@model";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@model", model);
                        int a = cmd.ExecuteNonQuery();
                        if (true)
                        {
                            MessageBox.Show("This row has deleted", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Not delete");
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
            }

        }

        private void QuotationPriceList_Activated(object sender, EventArgs e)
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
