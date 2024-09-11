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

namespace ADCoursework1.GUI.Customer.Controller
{
    public partial class ViewOrder : UserControl
    {
        public ViewOrder()
        {
            InitializeComponent();
            DataGridViewHelper.AddButtonsToOrderGrid(this, DgvOrders, "colBtnView");
            LoadCustomerOrders();
        }

        public void ReloadGrid()
        {
            LoadCustomerOrders();
        }

        private void LoadCustomerOrders()
        {
            // Remove all previously added buttons
            RemoveAllButtons();

            // Set the row height
            DgvOrders.RowTemplate.Height = 60;

            // Retrieve the customer ID using the logged-in user's ID
            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

            if (customerId <= 0)
            {
                Home.ShowAlert("Error: Unable to retrieve customer orders.", Alert.AlertType.Error);
                return;
            }

            // SQL query to select orders for the logged-in customer
            string sql = @"
                SELECT 
                    order_id AS 'Order ID', 
                    order_date AS 'Order Date', 
                    total_price AS 'Total Price', 
                    status AS 'Status' 
                FROM Orders 
                WHERE customer_id = @CustomerId";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId)
            };

            // Fetch data from the database
            DataTable orderTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (orderTable != null)  // Add null check
            {
                // Bind the data to the DataGridView
                DgvOrders.Rows.Clear(); // Clear existing rows

                foreach (DataRow row in orderTable.Rows)
                {
                    DgvOrders.Rows.Add(
                        row["Order ID"],
                        row["Order Date"],
                        row["Total Price"],
                        row["Status"],
                        ""  // Text for the View button
                    );
                }
            }

            // Add the buttons to the DataGridView after loading the rows
            DataGridViewHelper.AddButtonsToOrderGrid(this, DgvOrders, "colBtnView");
        }

        private void RemoveAllButtons()
        {
            var buttonsToRemove = DgvOrders.Controls.OfType<Guna.UI2.WinForms.Guna2Button>().ToList();
            foreach (var btn in buttonsToRemove)
            {
                DgvOrders.Controls.Remove(btn);
                btn.Dispose();
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = DateTimePicker.Value.Date;

            // Reload the grid with the filtered data
            LoadFilteredOrders(selectedDate);
        }

        private void LoadFilteredOrders(DateTime selectedDate)
        {
            // Remove all previously added buttons
            RemoveAllButtons();

            // Assuming you have a method to get the logged-in customer ID
            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);

            // Construct the SQL query to fetch orders for the selected date and customer ID
            string sql = @"
                        SELECT 
                            order_id, 
                            order_date, 
                            total_price, 
                            status 
                        FROM 
                            Orders 
                        WHERE 
                            customer_id = @CustomerId 
                            AND CAST(order_date AS DATE) = @OrderDate";

            // Create parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerId", customerId),
                new SqlParameter("@OrderDate", selectedDate)
            };

            // Fetch data from the database
            DataTable ordersTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (ordersTable != null)
            {
                // Clear existing rows in the DataGridView
                DgvOrders.Rows.Clear();

                // Bind the data to the DataGridView
                foreach (DataRow row in ordersTable.Rows)
                {
                    DgvOrders.Rows.Add(
                        row["order_id"],
                        row["order_date"],
                        row["total_price"],
                        row["status"]
                    );
                }
            }

            // Add the buttons to the DataGridView after loading the rows
            DataGridViewHelper.AddButtonsToOrderGrid(this, DgvOrders, "colBtnView");
        }
    }
}
