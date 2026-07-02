using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace S26Week8DisconnectedModel
{
    public class Crud
    {
        private SqlConnection _conn;
        private SqlDataAdapter _adp;
        private SqlCommandBuilder _cmdBuilder;
        private DataSet _ds;
        private DataTable _tbl;

        public Crud()
        {
            _conn = new SqlConnection(Data.GetConnectionString());
            _ds = new DataSet();
        }

        private void InitProducts()
        {
            string query = "select ProductID, ProductName, UnitPrice, UnitsInStock from Products";

            _adp = new SqlDataAdapter(query, _conn);
            _adp.Fill(_ds, "Products");

            _tbl = _ds.Tables["Products"]!;


        }
    }
}
