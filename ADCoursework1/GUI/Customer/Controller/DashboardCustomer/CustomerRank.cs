using ADCoursework1.GUI.Forms;
using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Customer.Controller.DashboardCustomer
{
    public partial class CustomerRank : UserControl
    {
        public CustomerRank()
        {
            InitializeComponent();
            LoadCustomerRankDetails();
        }

        private void LoadCustomerRankDetails()
        {
            if (!SessionManager.IsLoggedIn || SessionManager.UserRole != "Customer")
            {
                MessageBox.Show("Access Denied. You must be logged in as a customer.");
                return;
            }

            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

            // Set Rank
            LblRank.Text = GetCustomerRank(customerId).ToString();

            // Set Total Spendings
            LblTotalSpendings.Text = GetTotalSpendings(customerId).ToString("C");

            // Set Total Points
            LblTotalPoints.Text = GetTotalPoints(customerId).ToString();
        }

        private int GetCustomerRank(int customerId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"
                    SELECT COUNT(*) + 1 AS Rank
                    FROM Customers
                    WHERE points > (SELECT points FROM Customers WHERE customer_id = @CustomerId)";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        private decimal GetTotalSpendings(int customerId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = @"
                    SELECT SUM(total_price)
                    FROM Orders
                    WHERE customer_id = @CustomerId AND status = 'Completed'";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        private int GetTotalPoints(int customerId)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                string sql = "SELECT points FROM Customers WHERE customer_id = @CustomerId";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
