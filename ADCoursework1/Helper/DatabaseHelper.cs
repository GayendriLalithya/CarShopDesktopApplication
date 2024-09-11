using ADCoursework1.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Helper
{
    internal class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;

        // Get Connection Method
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Executes a non-query SQL command (INSERT, UPDATE, DELETE)
        public static void ExecuteNonQuery(string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = commandType;

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(connectionString)) // Use the correct variable name here
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery(); // This returns the number of rows affected
                }
            }
        }

        public static void ExecuteNonQuery(string sql, SqlParameter[] parameters, SqlTransaction transaction, SqlConnection connection)
        {
            using (var command = new SqlCommand(sql, connection, transaction))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.ExecuteNonQuery();
            }
        }


        // Executes a SQL command that returns a SqlDataReader (SELECT)
        public static SqlDataReader ExecuteReader(string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = commandType;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        // Executes a SQL command that returns a single value (e.g., COUNT, SUM)
        public static object ExecuteScalar(string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = commandType;

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        // Executes a SQL command that returns a DataTable (SELECT with multiple rows/columns)
        public static DataTable ExecuteDataTable(string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = commandType;

                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // For Tracking user
        public static string GetRoleForUser(string email)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT user_type FROM Users WHERE email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                var usertype = cmd.ExecuteScalar() as string; // Assume role is stored as a string
                return usertype;
            }
        }

        public static int GetUserId(string email)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT user_id FROM Users WHERE email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                var userId = (int)cmd.ExecuteScalar(); // Assume user_id is an integer
                return userId;
            }
        }
    }
}
