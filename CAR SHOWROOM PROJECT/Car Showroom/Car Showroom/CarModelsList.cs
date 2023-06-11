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
using System.Xml.Linq;

namespace Car_Showroom
{
    public partial class CarModelsList : Form
    {
        public CarModelsList()
        {
            InitializeComponent();

        }

        private void CarModelsList_Load(object sender, EventArgs e)
        {
        }

        public void getDataFromDataBase()
        {
            //Get Values from database and print in gridview

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            string query = "select * from CarModels";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //data delete
        if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "DELETE")
        {

                DialogResult con = MessageBox.Show("sure you want to delete all data", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (con == DialogResult.Yes)
                {
                    string model;
                    SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
                    model = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["modelColumn"].Value);
                    conn.Open();
                    string query = "delete from CarModels where Model = @model";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@model", model);

                    int a = cmd.ExecuteNonQuery();
                    if (true)
                    {
                        MessageBox.Show("Your car has deleted");
                    }
                    conn.Close();
                }
        }

            //data update

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "UPDATE")
            {
                string models, name, color;
                int id, price;

                // Get values from gridview Rows and asign in variables 

                id = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["idColumn"].Value);
                models = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["modelColumn"].Value);
                name = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nameColumn"].Value);
                color = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["colorColumn"].Value);
                price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["priceColumn"].Value);

                //Values pass in Update Form 

                ModelsUpdate mu = new ModelsUpdate(id, models, name, color, price);
                mu.Show();




            }

        }

        private void CarModelsList_Activated(object sender, EventArgs e)
        {
            getDataFromDataBase();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome a = new AdminHome();
            a.Show();
            this.Hide();
        }
    }
}

