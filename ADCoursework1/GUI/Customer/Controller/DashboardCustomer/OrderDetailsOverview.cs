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
    public partial class OrderDetailsOverview : UserControl
    {
        public OrderDetailsOverview()
        {
            InitializeComponent();
            LoadOrderData();

        }

        private void LoadOrderData()
        {
            // SQL to fetch orders sorted by status from 'Pending' to 'Completed'
            string sql = @"
                        SELECT 
                            order_id AS OrderID,
                            order_date AS OrderDate,
                            total_price AS TotalPrice,
                            status AS Status
                        FROM 
                            Orders
                        WHERE 
                            customer_id = @CustomerId
                        ORDER BY 
                            CASE 
                                WHEN status = 'Pending' THEN 1
                                WHEN status = 'Cancelled' THEN 2
                                WHEN status = 'Completed' THEN 3
                            END ASC, 
                            order_date DESC;
                    ";

            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);
            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId)
            };

            DataTable orderTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            // Clear existing rows if any
            DgvOrder.Rows.Clear();

            // Set the row height
            DgvOrder.RowTemplate.Height = 60;

            foreach (DataRow row in orderTable.Rows)
            {
                int rowIndex = DgvOrder.Rows.Add(
                    row["OrderID"].ToString(),
                    Convert.ToDateTime(row["OrderDate"]).ToString("MM/dd/yyyy"),
                    Convert.ToDecimal(row["TotalPrice"]).ToString("C"),
                    row["Status"].ToString()
                );

                // Apply color based on the status
                DataGridViewRow gridViewRow = DgvOrder.Rows[rowIndex];
                string status = row["Status"].ToString();

                switch (status)
                {
                    case "Pending":
                        gridViewRow.Cells["colStatus"].Style.ForeColor = Color.Yellow;
                        break;
                    case "Cancelled":
                        gridViewRow.Cells["colStatus"].Style.ForeColor = Color.Red;
                        break;
                    case "Completed":
                        gridViewRow.Cells["colStatus"].Style.ForeColor = Color.Green;
                        break;
                }
            }
        }
    }
}
