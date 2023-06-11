using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Car_Showroom
{
    internal class Connection
    {

        public Connection()
        {
          SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N7LJ5NQ\\SQLEXPRESS;Initial Catalog=\"Car Showroom Project\";Integrated Security=True");
        }

        //public SqlConnection connect()
        //{
        //    conn.Open();
        //    return conn;
        //}

    }
}
