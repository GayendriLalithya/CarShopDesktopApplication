namespace ADCoursework1.GUI.Customer.Controller.DashboardCustomer
{
    partial class SpendingOverview
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
            this.PnlCustomer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ChartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DonutChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LblSpending = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonutChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCustomer
            // 
            this.PnlCustomer.BackColor = System.Drawing.Color.Transparent;
            this.PnlCustomer.Controls.Add(this.guna2HtmlLabel9);
            this.PnlCustomer.Controls.Add(this.guna2HtmlLabel8);
            this.PnlCustomer.Controls.Add(this.ChartSales);
            this.PnlCustomer.Controls.Add(this.DonutChart);
            this.PnlCustomer.Controls.Add(this.LblSpending);
            this.PnlCustomer.FillColor = System.Drawing.Color.White;
            this.PnlCustomer.Location = new System.Drawing.Point(12, 13);
            this.PnlCustomer.Name = "PnlCustomer";
            this.PnlCustomer.Radius = 5;
            this.PnlCustomer.ShadowColor = System.Drawing.SystemColors.Highlight;
            this.PnlCustomer.Size = new System.Drawing.Size(1081, 382);
            this.PnlCustomer.TabIndex = 28;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(675, 339);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(115, 25);
            this.guna2HtmlLabel9.TabIndex = 26;
            this.guna2HtmlLabel9.Text = "Salse By Brand";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(105, 339);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(181, 25);
            this.guna2HtmlLabel8.TabIndex = 25;
            this.guna2HtmlLabel8.Text = "Spendings By Category";
            // 
            // ChartSales
            // 
            this.ChartSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ChartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartSales.Legends.Add(legend1);
            this.ChartSales.Location = new System.Drawing.Point(425, 56);
            this.ChartSales.Name = "ChartSales";
            this.ChartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChartSales.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.Gold};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartSales.Series.Add(series1);
            this.ChartSales.Size = new System.Drawing.Size(627, 265);
            this.ChartSales.TabIndex = 24;
            this.ChartSales.Text = "chart2";
            // 
            // DonutChart
            // 
            chartArea2.Name = "ChartArea1";
            this.DonutChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DonutChart.Legends.Add(legend2);
            this.DonutChart.Location = new System.Drawing.Point(54, 56);
            this.DonutChart.Name = "DonutChart";
            this.DonutChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.DonutChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.Highlight,
        System.Drawing.Color.Tomato,
        System.Drawing.Color.Magenta,
        System.Drawing.Color.Gold,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.Blue,
        System.Drawing.Color.MediumVioletRed};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.DonutChart.Series.Add(series2);
            this.DonutChart.Size = new System.Drawing.Size(349, 265);
            this.DonutChart.TabIndex = 23;
            this.DonutChart.Text = "DonutChart";
            // 
            // LblSpending
            // 
            this.LblSpending.BackColor = System.Drawing.Color.Transparent;
            this.LblSpending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSpending.Location = new System.Drawing.Point(390, 20);
            this.LblSpending.Name = "LblSpending";
            this.LblSpending.Size = new System.Drawing.Size(241, 30);
            this.LblSpending.TabIndex = 22;
            this.LblSpending.Text = "Total Spending Overview";
            // 
            // SpendingOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlCustomer);
            this.Name = "SpendingOverview";
            this.Size = new System.Drawing.Size(1104, 405);
            this.PnlCustomer.ResumeLayout(false);
            this.PnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonutChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel PnlCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart DonutChart;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblSpending;
    }
}
