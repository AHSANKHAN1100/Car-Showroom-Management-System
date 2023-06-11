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
    public partial class ModelsUpdate : Form
    {
        string model, name, color;
        int id, price;
        public ModelsUpdate(int id,string model, string name, string color, int price)
        {
            InitializeComponent();
            this.id = id;
            this.model = model;
            this.name = name;
            this.color = color;
            this.price = price;
        }

        //Constructor overloading
        public ModelsUpdate(int id,string name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
        }
      

        private void ModelsUpdate_Load(object sender, EventArgs e)
        {
            //Values print in text boxes


            txtModel.Text = model;
            txtName.Text = name;
            txtColor.Text = color;
            txtPrice.Text = price.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            model = txtModel.Text;
            name = txtName.Text;
            color = txtColor.Text;
            price = Convert.ToInt32(txtPrice.Text.ToString());
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            string query = "update CarModels set Model=@model , Name=@name,Color=@color,Price=@price where Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@color", color);
            cmd.Parameters.AddWithValue("@price", price);

            cmd.ExecuteNonQuery();
            if (true)
            {
                MessageBox.Show("Data succussfully updated");
                this.Hide();
            }
            conn.Close();
        }

    }
}
