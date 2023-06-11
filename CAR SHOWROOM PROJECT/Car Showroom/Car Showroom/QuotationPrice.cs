using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Showroom
{
    public partial class QuotationPrice : Form
    {
        public QuotationPrice()
        {
            InitializeComponent();
            getItemsFromDataBase();
        }

        private void cmbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPriceFromDataBase();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveDataInDataBase();
        }

        //Get all models from database 
        public void getItemsFromDataBase()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            try
            {
                string query = "select * from CarModels";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string md = rdr.GetString(1);
                    cmbModels.Items.Add(md);
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

        //Get price from database of model
        public void getPriceFromDataBase()
        {
            int price;
            double sellTax, regisFee, docuFee;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            try
            {
                string query = "select Price from CarModels where Model = @modelname";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.SelectCommand.Parameters.AddWithValue("@modelname", cmbModels.SelectedItem.ToString());
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    price = Convert.ToInt32(dt.Rows[0]["Price"]);
                    txtPrice.Text = price.ToString();
                    sellTax = price * 7 / 100;
                    txtSellPrice.Text = sellTax.ToString();
                    regisFee = price * 1 / 100;
                    txtRegisFee.Text = regisFee.ToString();
                    docuFee = price * 1 / 100;
                    txtDocuFee.Text = docuFee.ToString();
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

        //Save All data in dataBase 
        public void saveDataInDataBase()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
            conn.Open();
            try
            {
                string query2 = "select * from QuotationPrices where Model = @model";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@model", cmbModels.SelectedItem.ToString());
                SqlDataReader dr = cmd2.ExecuteReader();
                if (dr.HasRows == false)
                {
                    conn.Close();
                    string query = "insert into QuotationPrices values(@model,@price,@selltax,@regisfee,@docufee)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@model", cmbModels.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text.ToString());
                    cmd.Parameters.AddWithValue("@selltax", txtSellPrice.Text.ToString());
                    cmd.Parameters.AddWithValue("@regisfee", txtRegisFee.Text.ToString());
                    cmd.Parameters.AddWithValue("@docufee", txtDocuFee.Text.ToString());
                    conn.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (true)
                    {
                        MessageBox.Show("Your data successfully saved", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Already Row");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome a = new AdminHome();
            a.Show();
            this.Hide();
        }
    }
}

