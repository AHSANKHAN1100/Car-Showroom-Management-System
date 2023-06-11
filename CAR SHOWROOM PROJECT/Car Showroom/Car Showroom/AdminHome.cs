using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Showroom
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnCarModels_Click(object sender, EventArgs e)
        {
            CarModels cm = new CarModels();
            cm.Show();
            this.Hide();
        }

        private void linkCarModelList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarModelsList c = new CarModelsList();
            c.Show();
            this.Hide();
        }

        private void btnQuotationPrices_Click(object sender, EventArgs e)
        {
            QuotationPrice q = new QuotationPrice();
            q.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void linkPricesList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuotationPriceList q = new QuotationPriceList();
            q.Show();
            this.Hide();
        }

        private void btnBookList_Click(object sender, EventArgs e)
        {
            BookList b = new BookList();
            b.Show();
            this.Hide();
        }
    }




}
