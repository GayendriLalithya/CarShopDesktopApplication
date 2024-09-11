using ADCoursework1.Entities;
using ADCoursework1.GUI.Forms;
using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ADCoursework1.GUI.Admin.Controller.Reports
{
    public partial class DailyIncomeReport : UserControl
    {
        public DailyIncomeReport()
        {
            InitializeComponent();
            LoadDailyIncomeData();
            LoadPieChartData();

            // Attach the ValueChanged event to the DateTimePicker
            DateTimePicker.ValueChanged += new EventHandler(DateTimePicker_ValueChanged);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadDailyIncomeData(); // Refresh the grid with new data based on the selected date
            LoadPieChartData();    // Refresh the PieChart with new data based on the selected date
        }


        private void LoadDailyIncomeData()
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = DateTimePicker.Value.Date;

            // Construct the SQL query to fetch daily income data
            string sql = @"
                        SELECT 
                            vw.item_name, 
                            vw.brand, 
                            vw.item_type, 
                            SUM(oi.quantity) AS sold_quantity
                        FROM 
                            Orders o
                            INNER JOIN OrderItem oi ON o.order_id = oi.order_id
                            INNER JOIN vw_ItemDetails vw ON oi.item_id = vw.item_id
                        WHERE 
                            o.status = 'Completed' AND 
                            CAST(o.order_date AS DATE) = @SelectedDate
                        GROUP BY 
                            vw.item_name, 
                            vw.brand, 
                            vw.item_type";

            // Create parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SelectedDate", selectedDate)
            };

            // Fetch data from the database
            DataTable dailyIncomeTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (dailyIncomeTable != null)
            {
                // Clear existing rows in the DataGridView
                DgvDailyIncome.Rows.Clear();

                // Bind the data to the DataGridView
                foreach (DataRow row in dailyIncomeTable.Rows)
                {
                    DgvDailyIncome.Rows.Add(
                        row["item_name"],
                        row["brand"],
                        row["item_type"],
                        row["sold_quantity"]
                    );
                }
            }
        }

        private void LoadPieChartData()
        {
            // Get the selected date from the DateTimePicker
            DateTime selectedDate = DateTimePicker.Value.Date;

            // Construct the SQL query to fetch data for the PieChart
            string sql = @"
                        SELECT 
                            vw.brand, 
                            SUM(oi.quantity) AS sold_quantity
                        FROM 
                            Orders o
                            INNER JOIN OrderItem oi ON o.order_id = oi.order_id
                            INNER JOIN vw_ItemDetails vw ON oi.item_id = vw.item_id
                        WHERE 
                            o.status = 'Completed' AND 
                            CAST(o.order_date AS DATE) = @SelectedDate
                        GROUP BY 
                            vw.brand";

            // Create parameters
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SelectedDate", selectedDate)
            };

            // Fetch data from the database
            DataTable pieChartData = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (pieChartData != null)
            {
                // Clear existing series in the PieChart
                PieChart.Series.Clear();

                // Create a new series for the PieChart
                var series = PieChart.Series.Add("Sold Quantity by Brand");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                // Populate the series with data
                foreach (DataRow row in pieChartData.Rows)
                {
                    series.Points.AddXY(row["brand"], row["sold_quantity"]);
                }

                // Optional: Add data labels to the PieChart
                series.IsValueShownAsLabel = true;
            }
        }

        private DataTable GetDailyIncomeData(string sql, SqlParameter[] parameters)
        {
            DataTable dailyIncomeTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            if (dailyIncomeTable == null)
            {
                Home.ShowAlert("No data found for the selected date.", Alert.AlertType.Warning);
                return new DataTable(); // Return an empty DataTable to avoid null reference issues
            }

            return dailyIncomeTable;
        }

        public string GenerateHtmlReport(DataTable dailyIncomeTable, Chart pieChart)
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
                            img {
                                display: block;
                                margin: 20px auto;
                                max-width: 100%;
                                height: auto;
                            }
                        </style>
                    </head>
                    <body>
                        <div class='container'>");

            // Add the report title
            htmlContent.Append("<h1>Daily Income Report</h1>");

            // Add the selected date
            htmlContent.Append($"<h4>Selected Date: {DateTimePicker.Value.ToString("MMMM dd, yyyy")}</h4>");

            // Add the overview text
            htmlContent.Append($"<p>{TbOverview.Text}</p>");

            // Save and add the PieChart image
            string pieChartImagePath = SavePieChartImage(pieChart, "DailyIncomeByBrand");
            htmlContent.Append("<h4>Daily Income By Brand</h4>");
            htmlContent.Append($"<img src='{pieChartImagePath}' alt='Daily Income By Brand' />");

            // Add the daily income data table
            htmlContent.Append("<table><tr><th>Item Name</th><th>Brand Name</th><th>Item Type</th><th>Sold Quantity</th></tr>");
            foreach (DataRow row in dailyIncomeTable.Rows)
            {
                htmlContent.Append("<tr>");
                htmlContent.Append($"<td>{row["item_name"]}</td>");
                htmlContent.Append($"<td>{row["brand"]}</td>");
                htmlContent.Append($"<td>{row["item_type"]}</td>");
                htmlContent.Append($"<td>{row["sold_quantity"]}</td>");
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
            // Define the SQL query and parameters
            string sql = @"
                        SELECT 
                            vw.item_name, 
                            vw.brand, 
                            vw.item_type, 
                            SUM(oi.quantity) AS sold_quantity
                        FROM 
                            Orders o
                            INNER JOIN OrderItem oi ON o.order_id = oi.order_id
                            INNER JOIN vw_ItemDetails vw ON oi.item_id = vw.item_id
                        WHERE 
                            o.status = 'Completed' AND 
                            CAST(o.order_date AS DATE) = @SelectedDate
                        GROUP BY 
                            vw.item_name, 
                            vw.brand, 
                            vw.item_type";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SelectedDate", DateTimePicker.Value.Date)
            };

            // Fetch the daily income data
            DataTable dailyIncomeTable = GetDailyIncomeData(sql, parameters);

            // Generate the report including the PieChart
            string htmlContent = GenerateHtmlReport(dailyIncomeTable, PieChart);

            // Save the HTML report to a file
            Report report = new Report();
            report.SaveDailyIncomeReport(htmlContent);

            Home.ShowAlert("Report generated successfully.", Alert.AlertType.Success);
        }

        private string SavePieChartImage(Chart pieChart, string imageName)
        {
            // Define the path to save the image
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Reports");
            Directory.CreateDirectory(folderPath); // Create the directory if it doesn't exist

            string imagePath = Path.Combine(folderPath, $"{imageName}.png");
            pieChart.SaveImage(imagePath, ChartImageFormat.Png);

            return imagePath;
        }

    }
}
