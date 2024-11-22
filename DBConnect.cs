using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    public class DBConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        private string con;
        public string myconnection()
        {
            con = @"Data Source=DESKTOP-OVKLF8O\SQLEXPRESS;Initial Catalog=DBPOSALE;Integrated Security=True;Encrypt=False;Connect Timeout=30";
            return con;
        }
        public DataTable getTable(string query)
        {
            cn.ConnectionString = myconnection();
            cmd = new SqlCommand(query , cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();  
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
