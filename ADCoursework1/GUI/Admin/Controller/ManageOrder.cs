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

namespace ADCoursework1.GUI.Admin.Controller
{
    public partial class ManageOrder : UserControl
    {
        public ManageOrder()
        {
            InitializeComponent();
            LoadOrders();
            DataGridViewHelper.AddViewAllOrdersButton(this, DgvOrders, "colBtnView");
        }

        public void ReloadGrid()
        {
            LoadOrders();
        }

        private void LoadOrders(string searchOrder = "", DateTime? filterDate = null)
        {
            // Remove all previously added buttons
            RemoveAllButtons();

            // Set the row height
            DgvOrders.RowTemplate.Height = 60;

            // Base SQL query to select orders along with the customer's first and last name
            string sql = @"
                        SELECT 
                            o.order_id AS 'Order ID', 
                            CONCAT(u.first_name, ' ', u.last_name) AS 'Customer',
                            o.order_date AS 'Order Date', 
                            o.total_price AS 'Total Price', 
                            o.status AS 'Status' 
                        FROM 
                            Orders o
                            INNER JOIN Customers c ON o.customer_id = c.customer_id
                            INNER JOIN Users u ON c.user_id = u.user_id
                        WHERE 1=1"; // Placeholder for additional conditions

            // List to hold SQL parameters
            List<SqlParameter> parameters = new List<SqlParameter>();

            // If a search term is provided, add a WHERE clause and parameters
            if (!string.IsNullOrEmpty(searchOrder))
            {
                sql += " AND (LOWER(CONCAT(u.first_name, ' ', u.last_name)) LIKE LOWER(@SearchOrder) OR LOWER(u.contact_no) LIKE LOWER(@SearchOrder))";
                parameters.Add(new SqlParameter("@SearchOrder", "%" + searchOrder.ToLower() + "%"));
            }

            // If a filter date is provided, add a WHERE clause and parameters
            if (filterDate.HasValue)
            {
                sql += " AND CAST(o.order_date AS DATE) = @FilterDate";
                parameters.Add(new SqlParameter("@FilterDate", filterDate.Value));
            }

            // Fetch data from the database
            DataTable orderTable = DatabaseHelper.ExecuteDataTable(sql, parameters.ToArray());

            if (orderTable != null)  // Add null check
            {
                // Bind the data to the DataGridView
                DgvOrders.Rows.Clear(); // Clear existing rows

                foreach (DataRow row in orderTable.Rows)
                {
                    DgvOrders.Rows.Add(
                        row["Order ID"],
                        row["Customer"],
                        row["Order Date"],
                        row["Total Price"],
                        row["Status"],
                        ""  // Text for the View button
                    );
                }
            }

            // Add the buttons to the DataGridView after loading the rows
            DataGridViewHelper.AddViewAllOrdersButton(this, DgvOrders, "colBtnView");
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchOrder = TbSearchOrder.Text.Trim();

            // Reload the grid with the search term
            LoadOrders(searchOrder);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = DateTimePicker.Value.Date;

            // Reload the grid with the filtered data
            LoadOrders(filterDate: selectedDate);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ReloadGrid();
            TbSearchOrder.Clear();
        }
    }
}
