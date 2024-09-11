using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        // Method to place a new order
        public static int PlaceOrder(int customerId, List<OrderItem> orderItems, DateTime orderDate)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert the order into the Orders table with a placeholder total price (0)
                        var orderCommand = new SqlCommand(
                            "INSERT INTO Orders (customer_id, order_date, total_price, status) OUTPUT INSERTED.order_id VALUES (@CustomerId, @OrderDate, @TotalPrice, @Status)",
                            connection,
                            transaction
                        );
                        orderCommand.Parameters.AddWithValue("@CustomerId", customerId);
                        orderCommand.Parameters.AddWithValue("@OrderDate", orderDate);
                        orderCommand.Parameters.AddWithValue("@TotalPrice", 0m); // Placeholder, trigger will update it
                        orderCommand.Parameters.AddWithValue("@Status", "Pending");

                        int orderId = (int)orderCommand.ExecuteScalar();

                        foreach (var orderItem in orderItems)
                        {
                            // Retrieve the correct unit price from the Items table
                            decimal unitPrice = GetItemPrice(orderItem.ItemId);

                            // Calculate the total price for this OrderItem (unit price * quantity)
                            decimal itemTotalPrice = unitPrice * orderItem.Quantity;

                            // Insert into OrderItem table
                            var orderItemCommand = new SqlCommand(
                                "INSERT INTO OrderItem (order_id, item_id, quantity, price) VALUES (@OrderId, @ItemId, @Quantity, @Price)",
                                connection,
                                transaction
                            );
                            orderItemCommand.Parameters.AddWithValue("@OrderId", orderId);
                            orderItemCommand.Parameters.AddWithValue("@ItemId", orderItem.ItemId);
                            orderItemCommand.Parameters.AddWithValue("@Quantity", orderItem.Quantity);
                            orderItemCommand.Parameters.AddWithValue("@Price", itemTotalPrice);

                            orderItemCommand.ExecuteNonQuery();
                        }

                        // Commit the transaction
                        transaction.Commit();

                        return orderId;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private static decimal GetItemPrice(int itemId)
        {
            // Implement the logic to get the unit price from the vw_ItemPrices view
            using (var connection = DatabaseHelper.GetConnection())
            {
                var command = new SqlCommand("SELECT item_price FROM vw_ItemPrices WHERE item_id = @ItemId", connection);
                command.Parameters.AddWithValue("@ItemId", itemId);
                connection.Open();
                return (decimal)command.ExecuteScalar();
            }
        }

        public static decimal GetOrderTotalPrice(int orderId)
        {
            using (var connection = DatabaseHelper.GetConnection()) // Use GetConnection method
            {
                connection.Open();
                var command = new SqlCommand("SELECT total_price FROM Orders WHERE order_id = @OrderId", connection);
                command.Parameters.AddWithValue("@OrderId", orderId);
                return (decimal)command.ExecuteScalar();
            }
        }

        // Method to retrieve order details
        public static Order GetOrder(int orderId)
        {
            using (var connection = DatabaseHelper.GetConnection()) // Use GetConnection method
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Orders WHERE order_id = @OrderId", connection);
                command.Parameters.AddWithValue("@OrderId", orderId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Order
                        {
                            OrderId = (int)reader["order_id"],
                            CustomerId = (int)reader["customer_id"],
                            OrderDate = (DateTime)reader["order_date"],
                            TotalPrice = (decimal)reader["total_price"],
                            Status = reader["status"].ToString()
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static void MarkOrderAsCompleted(int orderId)
        {
            // Update the order status to 'Completed'
            string updateOrderSql = "UPDATE Orders SET status = 'Completed' WHERE order_id = @OrderId";
            SqlParameter[] orderParams = { new SqlParameter("@OrderId", orderId) };
            DatabaseHelper.ExecuteNonQuery(updateOrderSql, orderParams);

            // Get the customer ID associated with the order
            string getCustomerIdSql = "SELECT customer_id FROM Orders WHERE order_id = @OrderId";
            int customerId = (int)DatabaseHelper.ExecuteScalar(getCustomerIdSql, orderParams);

            // Update the customer's points
            SqlParameter[] pointParams = { new SqlParameter("@CustomerId", customerId) };
            DatabaseHelper.ExecuteNonQuery("UpdateCustomerPoints", pointParams, CommandType.StoredProcedure);
        }

    }
}
