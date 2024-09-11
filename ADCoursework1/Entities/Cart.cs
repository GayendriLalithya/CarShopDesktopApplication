using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ADCoursework1.Entities
{
    internal class Cart
    {
        public int CartId { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }

        // Method to Add or Update an Item in the Cart
        public void AddToCart()
        {
            string storedProcedure = "usp_AddOrUpdateCartItem";
            SqlParameter[] cartParams =
            {
                new SqlParameter("@CustomerId", this.CustomerId),
                new SqlParameter("@ItemId", this.ItemId),
                new SqlParameter("@Quantity", this.Quantity)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, cartParams, CommandType.StoredProcedure);
        }


        // Remove item from cart
        public static void RemoveFromCart(int customerId, int itemId)
        {
            string storedProcedure = "usp_RemoveCartItem";
            SqlParameter[] cartParams =
            {
                new SqlParameter("@CustomerId", customerId),
                new SqlParameter("@ItemId", itemId)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, cartParams, CommandType.StoredProcedure);
        }

        public static void RemoveFromCartByCartId(int cartId)
        {
            string storedProcedure = "usp_RemoveCartItemByCartId";
            SqlParameter[] cartParams =
            {
                new SqlParameter("@CartId", cartId)
            };

            DatabaseHelper.ExecuteNonQuery(storedProcedure, cartParams, CommandType.StoredProcedure);
        }

        public static int GetCartItemCount(int customerId)
        {
            int itemCount = 0;

            if (customerId > 0)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;
                string storedProcedure = "usp_CountCartItemsByCustomerId";

                SqlParameter[] parameters = {
                    new SqlParameter("@CustomerId", customerId)
                };

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters);

                        object result = cmd.ExecuteScalar();
                        itemCount = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                    }
                }
            }

            return itemCount;
        }

        public static void UpdateCartQuantity(int cartId, int quantity)
        {
            // SQL query to update the cart quantity
            string sql = "UPDATE Cart SET quantity = @Quantity WHERE cart_id = @CartId";

            // Define the parameters for the SQL query
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CartId", cartId),
                new SqlParameter("@Quantity", quantity)
            };

            // Execute the query using the DatabaseHelper's ExecuteNonQuery method
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public static void ClearCart(int customerId)
        {
            string sql = "DELETE FROM Cart WHERE customer_id = @CustomerId";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId)
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}
