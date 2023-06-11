using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Showroom
{
    public partial class CarModels : Form
    {
        public CarModels()
        {
            InitializeComponent();



        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            string md = Convert.ToString(txtModelName.Text.ToString());
            string name = Convert.ToString(txtCarName.Text.ToString());
            string color = Convert.ToString(txtColors.Text.ToString());
            int price = Convert.ToInt32(txtPrice.Text.ToString());
            models m = new models(md, name, color, price);
            m.saveData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome a = new AdminHome();
            a.Show();
            this.Hide();
        }

        private void txtSno_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarModels_Load(object sender, EventArgs e)
        {

        }
    }

    class models
    {

        public string model;
        public string carName;
        public string colors;
        public int price;

        public models(string _model, string _carName, string _colors, int _price)
        {

            this.model = _model;
            this.carName = _carName;
            this.colors = _colors;
            this.price = _price;

        }

        public void saveData()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            string query2 = "select * from CarModels WHERE Model = @modelname";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@modelname", model);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show(model + "Model Already Exist", "Failed");
            }
            else
            {
                conn.Close();
                string query = "insert into CarModels values(@model,@name,@color,@price)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@model", this.model);
                cmd.Parameters.AddWithValue("@name", this.carName);
                cmd.Parameters.AddWithValue("@color", this.colors);
                cmd.Parameters.AddWithValue("@price", this.price);
                conn.Open();
                cmd.ExecuteNonQuery();
                if (true)
                {
                    MessageBox.Show("Your data successfully saved", "Success");
                }
                else
                {
                    MessageBox.Show("not saved");
                }
                conn.Close();
            }
        }
    }
}
