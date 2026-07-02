using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace S26Week8DisconnectedModel
{
    public class Data
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        }

        public DataTable GetAllProducts()
        {
            SqlConnection conn = new SqlConnection(GetConnectionString());

            string query = "select ProductID, ProductName, UnitPrice, UnitsInStock from Products";
            SqlDataAdapter adp = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();

            adp.Fill(ds, "Products");

            return ds.Tables["Products"]!;
        }
    }
}
