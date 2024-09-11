namespace ADCoursework1.GUI.Admin.Controller.DashboardComponents
{
    partial class SalesManagementOverview
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PnlManageSales = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ChartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblManageSales = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PnlManageSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlManageSales
            // 
            this.PnlManageSales.BackColor = System.Drawing.Color.Transparent;
            this.PnlManageSales.Controls.Add(this.guna2HtmlLabel3);
            this.PnlManageSales.Controls.Add(this.guna2HtmlLabel2);
            this.PnlManageSales.Controls.Add(this.ChartSales);
            this.PnlManageSales.Controls.Add(this.LblManageSales);
            this.PnlManageSales.Controls.Add(this.PieChart);
            this.PnlManageSales.FillColor = System.Drawing.Color.White;
            this.PnlManageSales.Location = new System.Drawing.Point(8, 8);
            this.PnlManageSales.Name = "PnlManageSales";
            this.PnlManageSales.Radius = 5;
            this.PnlManageSales.ShadowColor = System.Drawing.SystemColors.Highlight;
            this.PnlManageSales.Size = new System.Drawing.Size(941, 396);
            this.PnlManageSales.TabIndex = 2;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(578, 337);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(111, 25);
            this.guna2HtmlLabel3.TabIndex = 25;
            this.guna2HtmlLabel3.Text = "Monthly Salse";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(96, 337);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(115, 25);
            this.guna2HtmlLabel2.TabIndex = 24;
            this.guna2HtmlLabel2.Text = "Salse By Brand";
            // 
            // ChartSales
            // 
            this.ChartSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ChartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartSales.Legends.Add(legend1);
            this.ChartSales.Location = new System.Drawing.Point(345, 79);
            this.ChartSales.Name = "ChartSales";
            this.ChartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChartSales.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.Gold};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.ChartSales.Series.Add(series1);
            this.ChartSales.Size = new System.Drawing.Size(577, 231);
            this.ChartSales.TabIndex = 1;
            this.ChartSales.Text = "chart2";
            // 
            // LblManageSales
            // 
            this.LblManageSales.BackColor = System.Drawing.Color.Transparent;
            this.LblManageSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManageSales.Location = new System.Drawing.Point(286, 32);
            this.LblManageSales.Name = "LblManageSales";
            this.LblManageSales.Size = new System.Drawing.Size(363, 30);
            this.LblManageSales.TabIndex = 23;
            this.LblManageSales.Text = "Monthly Salse Management Overview";
            // 
            // PieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PieChart.Legends.Add(legend2);
            this.PieChart.Location = new System.Drawing.Point(27, 79);
            this.PieChart.Name = "PieChart";
            this.PieChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.PieChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.Highlight,
        System.Drawing.Color.Tomato,
        System.Drawing.Color.Magenta,
        System.Drawing.Color.Gold,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.Blue,
        System.Drawing.Color.MediumVioletRed};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.PieChart.Series.Add(series2);
            this.PieChart.Size = new System.Drawing.Size(299, 231);
            this.PieChart.TabIndex = 0;
            this.PieChart.Text = "PieChart";
            // 
            // SalesManagementOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlManageSales);
            this.Name = "SalesManagementOverview";
            this.Size = new System.Drawing.Size(956, 411);
            this.PnlManageSales.ResumeLayout(false);
            this.PnlManageSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel PnlManageSales;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSales;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblManageSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
    }
}
