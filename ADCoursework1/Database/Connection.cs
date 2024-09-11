using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Database
{
    internal class Connection
    {
        private SqlConnection conn;

        public Connection()
        {
            // Initialize the connection with the DB using the connection Query
            conn = new SqlConnection("Data Source=HP-15S\\SQLEXPRESS;Initial Catalog=CarDealershipDB;Integrated Security=True");
        }

        // Open connection method
        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // Close connection method
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;

        // Get Connection Method
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
