using ADCoursework1.Entities;
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

namespace ADCoursework1.GUI.Customer.Forms
{
    public partial class OrderDetails : Form
    {
        private int _orderId;

        // Constructor that takes an orderId parameter
        public OrderDetails(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            LoadOrderDetails(orderId);
            LoadTotalAmount(orderId);
            CheckOrderStatus(orderId);
        }

        private void LoadOrderDetails(int orderId)
        {
            // Construct the SQL query to fetch order details
            string sql = @"
                        SELECT 
                            oi.order_item_id,
                            i.item_type,
                            CASE 
                                WHEN i.item_type = 'car' THEN CONCAT(c.model, ' ', b.brand_name)
                                WHEN i.item_type = 'car part' THEN cp.car_part_name
                                ELSE 'Unknown'
                            END AS item_name,
                            b.brand_name,
                            oi.quantity,
                            oi.price
                        FROM 
                            OrderItem oi
                            INNER JOIN Item i ON oi.item_id = i.item_id
                            LEFT JOIN Car c ON i.item_id = c.item_id
                            LEFT JOIN CarPart cp ON i.item_id = cp.item_id
                            LEFT JOIN Brand b ON b.brand_id = COALESCE(c.brand_id, cp.brand_id)
                        WHERE 
                            oi.order_id = @OrderId";

            // Create parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@OrderId", orderId)
            };

            // Fetch data from the database
            DataTable orderDetailsTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (orderDetailsTable != null)  // Add null check
            {
                // Clear existing rows in the DataGridView
                DgvOrderDetails.Rows.Clear();

                // Bind the data to the DataGridView
                foreach (DataRow row in orderDetailsTable.Rows)
                {
                    DgvOrderDetails.Rows.Add(
                        row["item_type"],
                        row["item_name"],
                        row["brand_name"],
                        row["quantity"],
                        row["price"]
                    );
                }
            }
        }

        private void LoadTotalAmount(int orderId)
        {
            // SQL query to fetch the total price from the Orders table
            string sql = "SELECT total_price FROM Orders WHERE order_id = @OrderId";

            // Create parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", orderId)
            };

            // Execute the query and get the total price
            object result = DatabaseHelper.ExecuteScalar(sql, parameters);

            if (result != null && result != DBNull.Value)
            {
                decimal totalPrice = (decimal)result;

                // Set the label text to display the total price
                LblTotalAmount.Text = $" {totalPrice:C}"; // Format as currency
            }
            else
            {
                LblTotalAmount.Text = "N/A";
            }
        }

        private void CheckOrderStatus(int orderId)
        {
            // SQL query to fetch the order status from the Orders table
            string sql = "SELECT status FROM Orders WHERE order_id = @OrderId";

            // Create parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", orderId)
            };

            // Execute the query and get the order status
            object result = DatabaseHelper.ExecuteScalar(sql, parameters);

            if (result != null && result != DBNull.Value)
            {
                string orderStatus = result.ToString();

                // Enable or disable the Cancel Order button based on the status
                BtnCancelOrder.Enabled = orderStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                // If no status is found, disable the Cancel Order button
                BtnCancelOrder.Enabled = false;
            }
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            // Logic to cancel the order
            if (MessageBox.Show("Are you sure you want to cancel this order?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CancelOrder(_orderId);
            }
        }

        private void CancelOrder(int orderId)
        {
            // SQL query to update the order status to "Cancelled"
            string sql = "UPDATE Orders SET status = 'Cancelled' WHERE order_id = @OrderId";

            // Create parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", orderId)
            };

            // Execute the update command
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(sql, parameters);

            if (rowsAffected > 0)
            {
                Home.ShowAlert("Order has been cancelled successfully.", Alert.AlertType.Info);

                // Disable the Cancel Order button since the order is now cancelled
                BtnCancelOrder.Enabled = false;
            }
            else
            {
                Home.ShowAlert("Failed to cancel the order.", Alert.AlertType.Error);
            }
        }
    }
}
