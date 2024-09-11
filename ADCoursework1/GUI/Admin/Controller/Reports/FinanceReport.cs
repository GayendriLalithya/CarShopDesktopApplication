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
    public partial class FinanceReport : UserControl
    {
        public FinanceReport()
        {
            InitializeComponent();
            LoadFinancialData();

            DateTimePicker.ValueChanged += new EventHandler(DateTimePicker_ValueChanged);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadFinancialData(); // Refresh the grid with new data based on the selected month and year
        }


        private void LoadFinancialData()
        {
            // Get the selected month and year from the DateTimePicker
            int selectedMonth = DateTimePicker.Value.Month;
            int selectedYear = DateTimePicker.Value.Year;

            // Construct the SQL query to fetch financial data
            string sql = @"
                SELECT 
                    vw.item_name, 
                    vw.brand, 
                    vw.item_type, 
                    SUM(oi.price * oi.quantity) AS total_income
                FROM 
                    Orders o
                    INNER JOIN OrderItem oi ON o.order_id = oi.order_id
                    INNER JOIN vw_ItemDetails vw ON oi.item_id = vw.item_id
                WHERE 
                    o.status = 'Completed' AND 
                    MONTH(o.order_date) = @Month AND 
                    YEAR(o.order_date) = @Year
                GROUP BY 
                    vw.item_name, 
                    vw.brand, 
                    vw.item_type";

            // Create parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Month", selectedMonth),
                new SqlParameter("@Year", selectedYear)
            };

            // Fetch data from the database
            DataTable financeTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (financeTable != null)  // Add null check
            {
                // Clear existing rows in the DataGridView
                DgvFinance.Rows.Clear();

                // Bind the data to the DataGridView
                foreach (DataRow row in financeTable.Rows)
                {
                    DgvFinance.Rows.Add(
                        row["item_name"],
                        row["brand"],
                        row["item_type"],
                        row["total_income"]
                    );
                }
            }
        }

        private DataTable GetFinanceData(string sql, SqlParameter[] parameters)
        {
            DataTable financeTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (financeTable == null)
            {
                Home.ShowAlert("No data found for the selected date.", Alert.AlertType.Warning);
                return new DataTable(); // Return an empty DataTable to avoid null reference issues
            }

            return financeTable;
        }

        public string GenerateHtmlReport(DataTable financeTable)
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
                                            h4 {
                                                text-align: left;
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
            htmlContent.Append("<h1>Financial Report</h1>");

            // Add the selected date
            htmlContent.Append($"<h4>Selected Date: {DateTimePicker.Value.ToString("MMMM yyyy")}</h4>");

            // Add the overview text
            htmlContent.Append($"<p>{TbOverview.Text}</p>");

            // Add the financial data table
            htmlContent.Append("<table><tr><th>Item Name</th><th>Brand Name</th><th>Item Type</th><th>Total Income</th></tr>");
            foreach (DataRow row in financeTable.Rows)
            {
                htmlContent.Append("<tr>");
                htmlContent.Append($"<td>{row["item_name"]}</td>");
                htmlContent.Append($"<td>{row["brand"]}</td>");
                htmlContent.Append($"<td>{row["item_type"]}</td>");
                htmlContent.Append($"<td>{row["total_income"]}</td>");
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

        private void BtnReport_Click_1(object sender, EventArgs e)
        {
            // Define the SQL query and parameters
            string sql = @"
                SELECT 
                    vw.item_name, 
                    vw.brand, 
                    vw.item_type, 
                    SUM(oi.price * oi.quantity) AS total_income
                FROM 
                    Orders o
                    INNER JOIN OrderItem oi ON o.order_id = oi.order_id
                    INNER JOIN vw_ItemDetails vw ON oi.item_id = vw.item_id
                WHERE 
                    o.status = 'Completed' AND 
                    MONTH(o.order_date) = @Month AND 
                    YEAR(o.order_date) = @Year
                GROUP BY 
                    vw.item_name, 
                    vw.brand, 
                    vw.item_type";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Month", DateTimePicker.Value.Month),
                new SqlParameter("@Year", DateTimePicker.Value.Year)
            };

            // Fetch the financial data
            DataTable financeTable = GetFinanceData(sql, parameters);

            // Generate the report
            string htmlContent = GenerateHtmlReport(financeTable);

            // Save the HTML report to a file
            Report report = new Report();
            report.SaveFinanceReport(htmlContent);

            Home.ShowAlert("Report generated successfully.", Alert.AlertType.Success);
        }
    }
}
