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

namespace ADCoursework1.GUI.Admin.Forms
{
    public partial class OrderForm : Form
    {
        private int _orderId;

        public OrderForm(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            LoadOrderDetails(orderId);
            LoadTotalAmount(orderId);
            LoadOrderStatus(orderId);
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

        private void LoadOrderStatus(int orderId)
        {
            // SQL query to fetch the current status of the order
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

                // Set the combo box value to the current order status
                CmbUpdateStatus.SelectedItem = orderStatus;
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Get the selected status from the combo box
            string selectedStatus = CmbUpdateStatus.SelectedItem.ToString();

            // SQL query to update the order status
            string sql = "UPDATE Orders SET status = @Status WHERE order_id = @OrderId";

            // Create parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Status", selectedStatus),
                new SqlParameter("@OrderId", _orderId)
            };

            // Execute the update command
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(sql, parameters);

            if (rowsAffected > 0)
            {
                // Call the stored procedure to update the customer's points
                int customerId = GetCustomerIdByOrderId(_orderId);
                SqlParameter[] procParams = new SqlParameter[]
                {
                    new SqlParameter("@CustomerId", customerId)
                };
                DatabaseHelper.ExecuteNonQuery("usp_UpdateCustomerPoints", procParams, CommandType.StoredProcedure);

                Home.ShowAlert("Order status and customer points updated successfully.", Alert.AlertType.Success);
            }
            else
            {
                Home.ShowAlert("Failed to update order status.", Alert.AlertType.Error);
            }
        }

        private int GetCustomerIdByOrderId(int orderId)
        {
            string sql = "SELECT customer_id FROM Orders WHERE order_id = @OrderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@OrderId", orderId)
            };

            object result = DatabaseHelper.ExecuteScalar(sql, parameters);
            return Convert.ToInt32(result);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Confirm deletion
            if (MessageBox.Show("Are you sure you want to delete this order and all associated items?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var connection = DatabaseHelper.GetConnection())
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // SQL query to delete the order items
                            string deleteOrderItemsSql = "DELETE FROM OrderItem WHERE order_id = @OrderId";

                            // Create parameters for the order items deletion
                            SqlParameter[] orderItemParameters = new SqlParameter[]
                            {
                new SqlParameter("@OrderId", _orderId)
                            };

                            // Execute the delete command for order items
                            var deleteOrderItemsCommand = new SqlCommand(deleteOrderItemsSql, connection, transaction);
                            deleteOrderItemsCommand.Parameters.AddRange(orderItemParameters);
                            deleteOrderItemsCommand.ExecuteNonQuery();

                            // SQL query to delete the order
                            string deleteOrderSql = "DELETE FROM Orders WHERE order_id = @OrderId";

                            // Create a new SqlParameter for the order deletion
                            SqlParameter[] orderParameters = new SqlParameter[]
                            {
                new SqlParameter("@OrderId", _orderId)
                            };

                            // Execute the delete command for the order
                            var deleteOrderCommand = new SqlCommand(deleteOrderSql, connection, transaction);
                            deleteOrderCommand.Parameters.AddRange(orderParameters);
                            int rowsAffected = deleteOrderCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Commit the transaction
                                transaction.Commit();

                                Home.ShowAlert("Order and associated items deleted successfully.", Alert.AlertType.Success);
                                this.Close(); // Close the form after deletion
                            }
                            else
                            {
                                throw new Exception("Failed to delete the order.");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction in case of an error
                            transaction.Rollback();
                            Home.ShowAlert($"Error: {ex.Message}", Alert.AlertType.Error);
                        }
                    }
                }
            }
        }
    }
}
