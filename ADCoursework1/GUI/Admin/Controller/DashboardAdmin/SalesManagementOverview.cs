using ADCoursework1.GUI.Forms;
using ADCoursework1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ADCoursework1.GUI.Admin.Controller.DashboardComponents
{
    public partial class SalesManagementOverview : UserControl
    {
        public SalesManagementOverview()
        {
            InitializeComponent();
            LoadSalesByBrand();
            LoadMonthlySalesOverview();
        }

        // Load pie Chart Data
        private void LoadSalesByBrand()
        {
            string sql = @"
                        SELECT 
                            b.brand_name,
                            SUM(oi.price * oi.quantity) AS total_income
                        FROM 
                            OrderItem oi
                        INNER JOIN 
                            Orders o ON oi.order_id = o.order_id
                        INNER JOIN 
                            vw_ItemDetails v ON oi.item_id = v.item_id
                        INNER JOIN 
                            Brand b ON v.brand = b.brand_name
                        WHERE 
                            o.status = 'Completed'
                        GROUP BY 
                            b.brand_name
                        ORDER BY 
                            total_income DESC;";

            DataTable incomeData = DatabaseHelper.ExecuteDataTable(sql, null);

            if (incomeData != null && incomeData.Rows.Count > 0)
            {
                // Clear previous data if any
                PieChart.Series.Clear();
                PieChart.Titles.Clear();
                PieChart.Titles.Add("Total Income by Brand");

                // Create a new series and set its chart type to Pie
                Series series = new Series
                {
                    Name = "Income",
                    IsValueShownAsLabel = true,
                    ChartType = SeriesChartType.Pie
                };

                // Add data points to the series
                foreach (DataRow row in incomeData.Rows)
                {
                    string brandName = row["brand_name"].ToString();
                    decimal income = Convert.ToDecimal(row["total_income"]);
                    series.Points.AddXY(brandName, income);
                }

                // Add the series to the chart
                PieChart.Series.Add(series);

                // Optionally, format the pie chart slices with different colors, if required
                int pointIndex = 0;
                foreach (DataPoint point in series.Points)
                {
                    point.Color = GetColorByIndex(pointIndex); // Custom method to assign colors
                    pointIndex++;
                }
            }
            else
            {
                Home.ShowAlert("No data available for the selected criteria.", Alert.AlertType.Success);
            }
        }

        // Example method to assign different colors to pie chart slices
        private Color GetColorByIndex(int index)
        {
            Color[] colors = new Color[]
            {
        Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Purple, Color.Orange
            };
            return colors[index % colors.Length];
        }


        // Load Range column Chat Data

        private void LoadMonthlySalesOverview()
        {
            // Clear existing chart data
            ChartSales.Series.Clear();
            ChartSales.ChartAreas.Clear();

            // Create chart area and set axis titles
            ChartArea chartArea = new ChartArea("MonthlySales");
            chartArea.AxisX.Title = "Month";
            chartArea.AxisY.Title = "Income";
            chartArea.AxisX.Interval = 1; // Show each month on X-axis
            ChartSales.ChartAreas.Add(chartArea);

            // SQL query to get sales data
            string sql = @"
                SELECT 
                    b.brand_name,
                    YEAR(o.order_date) AS Year,
                    MONTH(o.order_date) AS Month,
                    SUM(oi.price * oi.quantity) AS total_income
                FROM 
                    Orders o
                INNER JOIN 
                    OrderItem oi ON o.order_id = oi.order_id
                INNER JOIN 
                    vw_ItemDetails v ON oi.item_id = v.item_id
                INNER JOIN 
                    Brand b ON v.brand = b.brand_name
                WHERE 
                    o.status = 'Completed'
                GROUP BY 
                    b.brand_name, YEAR(o.order_date), MONTH(o.order_date)
                ORDER BY 
                    Year, Month;";

            DataTable salesData = DatabaseHelper.ExecuteDataTable(sql, null);

            // Group data by brand and plot each brand as a separate series
            var groupedData = salesData.AsEnumerable()
                                       .GroupBy(row => row["brand_name"].ToString());

            foreach (var group in groupedData)
            {
                string brandName = group.Key;
                Series series = new Series(brandName);

                // Set the chart type to RangeColumn
                series.ChartType = SeriesChartType.RangeColumn;
                series.BorderWidth = 2;

                foreach (var row in group)
                {
                    int year = Convert.ToInt32(row["Year"]);
                    int month = Convert.ToInt32(row["Month"]);
                    decimal income = Convert.ToDecimal(row["total_income"]);

                    // Convert year and month to DateTime and use it for X-axis
                    DateTime date = new DateTime(year, month, 1);

                    // Add X-Y values for RangeColumn chart
                    series.Points.AddXY(date, income);  // Only one Y-value (income) is used for RangeColumn
                }

                ChartSales.Series.Add(series);
            }
        }
    }
}
