using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace HTQLGPLX
{
    internal class ConnectDB
    {
        private string server = "cnpmhutech.database.windows.net";
        private string database = "cnpm";
        private string username = "phuc";
        private string password = "@hutech123";

        private SqlConnection conn;
        public SqlConnection GetConnection()
        {
            return conn;
        }

        public ConnectDB()
        {
            string connString = "Server=" + server + ";Database=" + database + ";User Id=" + username + ";Password=" + password + ";";
            conn = new SqlConnection(connString);
        }

        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
