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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCoursework1.GUI.Admin.Controller.Reports
{
    public partial class OrderQuantityStatus : UserControl
    {
        public OrderQuantityStatus()
        {
            InitializeComponent();
            LoadOrderQuantityData();
        }

        private void LoadOrderQuantityData()
        {
            // SQL query to fetch order quantity data
            string sql = @"
                        SELECT 
                            vw.item_name, 
                            vw.item_type, 
                            vw.brand, 
                            MIN(oi.quantity) AS min_quantity,
                            MAX(oi.quantity) AS max_quantity
                        FROM 
                            OrderItem oi
                        INNER JOIN 
                            vw_ItemDetails vw ON oi.item_id = vw.item_id
                        GROUP BY 
                            vw.item_name, 
                            vw.item_type, 
                            vw.brand;";

            // No parameters in this case, but you could add them if needed
            SqlParameter[] parameters = null;

            // Fetch the order quantity data
            DataTable orderQuantityTable = GetOrderQuantityData(sql, parameters);

            if (orderQuantityTable != null)
            {
                // Clear existing rows in the DataGridView
                DgvOrderQuantityStatus.Rows.Clear();

                // Bind the data to the DataGridView
                foreach (DataRow row in orderQuantityTable.Rows)
                {
                    DgvOrderQuantityStatus.Rows.Add(
                        row["item_name"],
                        row["item_type"],
                        row["brand"],
                        row["min_quantity"],
                        row["max_quantity"]
                    );
                }
            }
        }

        private DataTable GetOrderQuantityData(string sql, SqlParameter[] parameters)
        {
            DataTable orderQuantityTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (orderQuantityTable == null)
            {
                Home.ShowAlert("No order quantity data found.", Alert.AlertType.Warning);
                return new DataTable(); // Return an empty DataTable to avoid null reference issues
            }

            return orderQuantityTable;
        }

        public string GenerateOrderQuantityHtmlReport(DataTable orderQuantityTable)
        {
            StringBuilder htmlContent = new StringBuilder();

            // Add custom CSS for styling
            htmlContent.Append(@"<html>
                            <head>
                                 <style>
                                            body {
                                                font-family: Arial, sans-serif;
                                                background-color: #f8f9fa;
                                                margin: 0;
                                                padding: 40px;
                                                min-height: 100vh;
                                            }
                                            .container {
                                                max-width: 800px;
                                                margin: 20px auto;
                                                background-color: #ffffff;
                                                padding: 20px;
                                                border-radius: 8px;
                                                box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                                            }
                                            h1 {
                                                text-align: center;
                                                color: #000033;
                                                margin-top: 0;
                                            }
                                            p {
                                                text-align: left;
                                                color: #000033;
                                                margin-bottom: 20px;
                                            }
                                            table {
                                                width: 100%;
                                                border-collapse: collapse;
                                                margin-bottom: 20px;
                                            }
                                            table, th, td {
                                                border: 1px solid #dee2e6;
                                            }
                                            th, td {
                                                padding: 12px;
                                                text-align: left;
                                            }
                                            th {
                                                background-color: #0078D7;
                                                color: white;
                                            }
                                            tr:nth-child(even) {
                                                background-color: #f2f2f2;
                                            }
                                            tr:hover {
                                                background-color: #e9ecef;
                                            }
                                        </style>
                            </head>
                            <body>
                                <div class='container'>");

            // Add the report title
            htmlContent.Append("<h1>Order Quantity Status Report</h1>");

            // Add the order quantity data table
            htmlContent.Append("<table><tr><th>Item Name</th><th>Item Type</th><th>Brand Name</th><th>Minimum Order Quantity</th><th>Maximum Order Quantity</th></tr>");
            foreach (DataRow row in orderQuantityTable.Rows)
            {
                htmlContent.Append("<tr>");
                htmlContent.Append($"<td>{row["item_name"]}</td>");
                htmlContent.Append($"<td>{row["item_type"]}</td>");
                htmlContent.Append($"<td>{row["brand"]}</td>");
                htmlContent.Append($"<td>{row["min_quantity"]}</td>");
                htmlContent.Append($"<td>{row["max_quantity"]}</td>");
                htmlContent.Append("</tr>");
            }
            htmlContent.Append("</table>");

            // Closing HTML tags
            htmlContent.Append(@"
                                </div>
                            </body>
                            </html>");

            return htmlContent.ToString();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            // Define the SQL query and parameters for fetching order quantity data
            string sql = @"
                        SELECT 
                            vw.item_name, 
                            vw.item_type, 
                            vw.brand, 
                            MIN(oi.quantity) AS min_quantity,
                            MAX(oi.quantity) AS max_quantity
                        FROM 
                            OrderItem oi
                        INNER JOIN 
                            vw_ItemDetails vw ON oi.item_id = vw.item_id
                        GROUP BY 
                            vw.item_name, 
                            vw.item_type, 
                            vw.brand;";

            // No parameters in this case, but if needed, you could define them here
            SqlParameter[] parameters = null;

            // Generate the order quantity report
            DataTable orderQuantityTable = GetOrderQuantityData(sql, parameters);
            string htmlContent = GenerateOrderQuantityHtmlReport(orderQuantityTable);

            // Save the HTML report to a file
            Report report = new Report();
            report.SaveOrderStatusReport(htmlContent);

            Home.ShowAlert("Report generated successfully.", Alert.AlertType.Success);
        }
    }
}
