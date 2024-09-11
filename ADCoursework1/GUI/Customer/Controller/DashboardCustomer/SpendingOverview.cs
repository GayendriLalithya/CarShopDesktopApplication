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
using System.Windows.Forms.DataVisualization.Charting;

namespace ADCoursework1.GUI.Customer.Controller.DashboardCustomer
{
    public partial class SpendingOverview : UserControl
    {
        private int _customerId;

        public SpendingOverview(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            LoadCustomerSpendingDonutChart(_customerId);
            LoadSpendingData();
        }

        private void LoadCustomerSpendingDonutChart(int customerId)
        {
            string sql = @"
                SELECT 
                    i.item_type,
                    SUM(oi.quantity * oi.price) AS total_spending
                FROM 
                    Orders o
                INNER JOIN 
                    OrderItem oi ON o.order_id = oi.order_id
                INNER JOIN 
                    Item i ON oi.item_id = i.item_id
                WHERE 
                    o.customer_id = @CustomerId
                    AND o.status = 'Completed'
                GROUP BY 
                    i.item_type";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerId", customerId)
            };

            DataTable spendingData = DatabaseHelper.ExecuteDataTable(sql, parameters);

            // Clear existing legends and add a new one with a specific name
            DonutChart.Legends.Clear();
            var legend = new Legend("Legend1");
            legend.Docking = Docking.Bottom;
            legend.Alignment = StringAlignment.Center;
            DonutChart.Legends.Add(legend);

            // Now when you create the series, set the Legend property to the correct legend name
            var series = new Series
            {
                Name = "Spending",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Doughnut,
                Legend = "Legend1"  // Make sure this matches the legend's name
            };

            DonutChart.Series.Add(series);

            // Add data points
            foreach (DataRow row in spendingData.Rows)
            {
                string itemType = row["item_type"].ToString();
                decimal totalSpending = Convert.ToDecimal(row["total_spending"]);

                // Add the point to the series
                series.Points.AddXY(itemType, totalSpending);
            }

            // Set chart titles and legends (optional)
            DonutChart.Titles.Clear();
            DonutChart.Titles.Add("Customer Spending Breakdown");
            DonutChart.Legends.Clear();
            DonutChart.Legends.Add(new Legend());  // Adds a legend with the default name "Legend1"
            DonutChart.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            DonutChart.Legends[0].Alignment = StringAlignment.Center;

            // Optional: Customize chart appearance
            DonutChart.Series[0]["PieLabelStyle"] = "Outside";
            DonutChart.Series[0].BorderWidth = 1;
        }

        // Stacked Column Chart code

        private void LoadSpendingData()
        {
            string sql = @"
                SELECT 
                    YEAR(order_date) AS Year,
                    MONTH(order_date) AS Month,
                    b.brand_name AS Brand,
                    SUM(oi.quantity * oi.price) AS TotalSpending
                FROM 
                    Orders o
                JOIN 
                    OrderItem oi ON o.order_id = oi.order_id
                JOIN 
                    vw_ItemDetails vw ON oi.item_id = vw.item_id
                JOIN 
                    Brand b ON vw.brand = b.brand_name
                WHERE 
                    o.customer_id = @CustomerId AND o.status = 'Completed'
                GROUP BY 
                    YEAR(order_date), MONTH(order_date), b.brand_name
                ORDER BY 
                    YEAR(order_date), MONTH(order_date);";

            int customerId = SessionManager.GetCustomerIdFromUserId(SessionManager.UserId);
            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId)
            };

            DataTable spendingTable = DatabaseHelper.ExecuteDataTable(sql, parameters);

            // Configure the chart
            ChartSales.Series.Clear();
            ChartSales.ChartAreas[0].AxisX.Title = "Month";
            ChartSales.ChartAreas[0].AxisY.Title = "Total Spending";
            ChartSales.ChartAreas[0].AxisX.Interval = 1;

            // Get distinct brands to create series for each brand
            var brands = spendingTable.AsEnumerable()
                                      .Select(row => row.Field<string>("Brand"))
                                      .Distinct();

            foreach (var brand in brands)
            {
                Series series = new Series(brand)
                {
                    ChartType = SeriesChartType.StackedColumn,
                    XValueType = ChartValueType.String
                };

                // Add data points to the series
                foreach (DataRow row in spendingTable.Rows)
                {
                    if (row.Field<string>("Brand") == brand)
                    {
                        string monthYear = $"{row.Field<int>("Month")}/{row.Field<int>("Year")}";
                        series.Points.AddXY(monthYear, row.Field<decimal>("TotalSpending"));
                    }
                }

                ChartSales.Series.Add(series);
            }

            // Optional: Customize the appearance of the chart
            ChartSales.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            ChartSales.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            ChartSales.Legends[0].Docking = Docking.Top;
        }
    }
}
