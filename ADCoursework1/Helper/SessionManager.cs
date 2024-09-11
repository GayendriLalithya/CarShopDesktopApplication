using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Helper
{
    public static class SessionManager
    {
        // Make the properties accessible by adding public accessors
        public static bool IsLoggedIn { get; private set; }
        public static string UserRole { get; private set; }
        public static int UserId { get; private set; }

        public static void PerformLogin(string username, string password)
        {
            // Assume credentials are validated and role is retrieved
            IsLoggedIn = true;
            UserRole = DatabaseHelper.GetRoleForUser(username); // Call the method to get the role
            UserId = DatabaseHelper.GetUserId(username); // Similarly, retrieve the user ID
        }

        // Add a method to log out and clear the session data
        public static void Logout()
        {
            IsLoggedIn = false;
            UserRole = null;
            UserId = 0;
        }

        // Public method to get CustomerId from UserId
        public static int GetCustomerIdFromUserId(int userId)
        {
            string sql = "SELECT customer_id FROM Customers WHERE user_id = @UserId";
            SqlParameter[] parameters = {
            new SqlParameter("@UserId", userId)
        };

            object result = DatabaseHelper.ExecuteScalar(sql, parameters);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }

            return -1; // Return -1 or throw an exception if CustomerId is not found
        }
    }
}
