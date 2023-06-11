using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Showroom
{
    public partial class CustomerBooking : Form
    {
        public CustomerBooking()
        {
            InitializeComponent();
            getModelFromDataBase();
        }
        private void CustomerBooking_Load(object sender, EventArgs e)
        {
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.ToString();
            string mobileno = txtMobileNo.Text.ToString();
            string pay = txtPayMethod.Text.ToString();
            int amount = Convert.ToInt32(txtAmount.Text.ToString());
            string model = cmbAvModels.SelectedItem.ToString();
            string color = txtColor.Text.ToString();
            CustomerDetail c = new CustomerDetail();
            c._CustomerName = name;
            c._MobileNo = mobileno;
            c._PaymentMethod = pay;
            c._Amount = amount;
            c.model = model;
            c.color = color;
            c.saveData();
        }

        private void cmbAvModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            getColorColumnFromDataBase();
            getPriceColumnFromDataBase();
        }

        //Get all models from car models table
        public void getModelFromDataBase()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            try
            {
                string query = ("select * from CarModels");
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string s = dr.GetString(1);
                    cmbAvModels.Items.Add(s);
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

        //Get color of selected index of car models
        public void getColorColumnFromDataBase()
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");

            try
            {
                string query = "select Color from CarModels where Model = @modelname";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.Parameters.AddWithValue("@modelname", cmbAvModels.SelectedItem.ToString());
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string color = Convert.ToString(dt.Rows[0]["Color"]);
                    txtAvColors.Text = color.ToString();

                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Get price from selected index of car models
        public void getPriceColumnFromDataBase()
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");

            try
            {
                string query = "select Price from CarModels where Model = @modelname";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.Parameters.AddWithValue("@modelname", cmbAvModels.SelectedItem.ToString());
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string price = Convert.ToString(dt.Rows[0]["Price"]);
                    txtAmount.Text = price.ToString();

                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }

    class CustomerDetail : CustomerBooking
    {
        public string model = "";
        public string color = "";
        private string CustomerName = "";
        private string MobileNo = "";
        private string PaymentMethod = "";
        private int Amount;

        public string _CustomerName { get { return CustomerName; } set { CustomerName = value; } }
        public string _MobileNo { get { return MobileNo; } set { MobileNo = value; } }
        public string _PaymentMethod { get { return PaymentMethod; } set { PaymentMethod = value; } }

        public int _Amount { get { return Amount; } set { Amount = value; } }

        public void saveData()
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            try
            {
                string query = "insert into CustomerDetails values(@model,@color,@name,@mobileNo,@paymethod,@amount,@time)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@color", color);
                cmd.Parameters.AddWithValue("@name", _CustomerName);
                cmd.Parameters.AddWithValue("@mobileNo", _MobileNo);
                cmd.Parameters.AddWithValue("@paymethod", _PaymentMethod);
                cmd.Parameters.AddWithValue("@amount", _Amount);
                cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
                int a = cmd.ExecuteNonQuery();
                if (true)
                {
                    MessageBox.Show("Your car has booked","Success",MessageBoxButtons.OK);
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
