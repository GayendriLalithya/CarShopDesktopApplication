using ADCoursework1.Entities;
using ADCoursework1.GUI.Customer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Helper
{
    public static class CartHelper
    {
        // Retrieves the list of cart items for a given customer ID
        public static List<CartItem> GetCartItems(int customerId)
        {
            // Initialize an empty list to store the cart items
            List<CartItem> cartItems = new List<CartItem>();

            // Establish a connection to the database using DatabaseHelper
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open(); // Open the database connection

                // SQL query to fetch cart details for the specified customer ID
                string sql = @"
                SELECT cart_id, item_id, quantity, price
                FROM vw_CartDetails
                WHERE customer_id = @CustomerId";

                // Define the SQL parameter to prevent SQL injection
                SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId)
            };

                // Create a SqlCommand object to execute the query
                using (var command = new SqlCommand(sql, connection))
                {
                    // Add the customer ID parameter to the query
                    command.Parameters.AddRange(parameters);

                    // Execute the query and process the results
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new CartItem object and populate it with data from the database
                            CartItem cartItem = new CartItem
                            {
                                CartId = (int)reader["cart_id"],
                                ItemId = (int)reader["item_id"],
                                Quantity = (int)reader["quantity"],
                                ItemPrice = (decimal)reader["price"]
                            };
                            // Add the populated CartItem object to the list
                            cartItems.Add(cartItem);
                        }
                    }
                }
            }
            // Return the list of cart items
            return cartItems;
        }

        // Clears all cart items for a given customer ID
        public static void ClearCart(int customerId)
        {
            // Establish a connection to the database
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open(); // Open the connection

                // SQL query to delete all items from the Cart table for the given customer ID
                string sql = "DELETE FROM Cart WHERE customer_id = @CustomerId";

                // Define the parameter to prevent SQL injection
                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerId", customerId)
                };

                // Create and execute the delete command
                using (var command = new SqlCommand(sql, connection))
                {
                    // Add the customer ID parameter
                    command.Parameters.AddRange(parameters);
                    // Execute the command to delete the cart items
                    command.ExecuteNonQuery();
                }
            }
        }

        // Redirects the customer to the cart page in the customer dashboard
        public static void RedirectToCartPage()
        {
            // Retrieve the customer ID based on the current user session
            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

            // Create an instance of the CustomerDashboard form, passing the customer ID
            CustomerDashboard customerDashboard = new CustomerDashboard(customerId);

            // Show the CustomerDashboard form
            customerDashboard.Show();

            // Automatically select the cart tab in the dashboard
            customerDashboard.SelectTab("TbPageCart");
        }

        // Redirects the customer to the orders page in the customer dashboard
        public static void RedirectCustomerToViewOrders()
        {
            // Retrieve the customer ID based on the current user session
            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

            // Create an instance of the CustomerDashboard form, passing the customer ID
            CustomerDashboard customerDashboard = new CustomerDashboard(customerId);

            // Show the CustomerDashboard form
            customerDashboard.Show();

            // Automatically select the orders tab in the dashboard
            customerDashboard.SelectTab("TbPageOrder"); 
        }
    }
}
