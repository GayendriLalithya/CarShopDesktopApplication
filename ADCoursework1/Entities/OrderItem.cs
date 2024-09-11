using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCoursework1.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Method to retrieve all items in a specific order
        public static List<OrderItem> GetOrderItems(int orderId)
        {
            var orderItems = new List<OrderItem>();

            using (var connection = DatabaseHelper.GetConnection()) // Use GetConnection method
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM OrderItem WHERE order_id = @OrderId", connection);
                command.Parameters.AddWithValue("@OrderId", orderId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orderItems.Add(new OrderItem
                        {
                            OrderItemId = (int)reader["order_item_id"],
                            OrderId = (int)reader["order_id"],
                            ItemId = (int)reader["item_id"],
                            Quantity = (int)reader["quantity"],
                            Price = (decimal)reader["price"]
                        });
                    }
                }
            }

            return orderItems;
        }
    }
}
