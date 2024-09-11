namespace ADCoursework1.GUI.Admin.Controller.Reports
{
    partial class DailyIncomeReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblDailyIncome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblOverview = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbOverview = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblIncomeByCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DgvDailyIncome = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnReport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDailyIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDailyIncome
            // 
            this.LblDailyIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDailyIncome.BackColor = System.Drawing.Color.Transparent;
            this.LblDailyIncome.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDailyIncome.Location = new System.Drawing.Point(666, 27);
            this.LblDailyIncome.Name = "LblDailyIncome";
            this.LblDailyIncome.Size = new System.Drawing.Size(328, 41);
            this.LblDailyIncome.TabIndex = 9;
            this.LblDailyIncome.Text = "Daily Income Report";
            this.LblDailyIncome.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblOverview
            // 
            this.LblOverview.BackColor = System.Drawing.Color.Transparent;
            this.LblOverview.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOverview.Location = new System.Drawing.Point(72, 120);
            this.LblOverview.Name = "LblOverview";
            this.LblOverview.Size = new System.Drawing.Size(139, 21);
            this.LblOverview.TabIndex = 12;
            this.LblOverview.Text = "Report Overview";
            // 
            // TbOverview
            // 
            this.TbOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbOverview.BorderRadius = 5;
            this.TbOverview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbOverview.DefaultText = "";
            this.TbOverview.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbOverview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbOverview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbOverview.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbOverview.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbOverview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbOverview.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbOverview.Location = new System.Drawing.Point(72, 147);
            this.TbOverview.Multiline = true;
            this.TbOverview.Name = "TbOverview";
            this.TbOverview.PasswordChar = '\0';
            this.TbOverview.PlaceholderText = "";
            this.TbOverview.SelectedText = "";
            this.TbOverview.Size = new System.Drawing.Size(1492, 87);
            this.TbOverview.TabIndex = 11;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker.BorderRadius = 5;
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.FillColor = System.Drawing.Color.Lavender;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.Location = new System.Drawing.Point(1200, 98);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(364, 36);
            this.DateTimePicker.TabIndex = 29;
            this.DateTimePicker.Value = new System.DateTime(2024, 8, 25, 21, 29, 28, 922);
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(1113, 107);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(41, 21);
            this.LblDate.TabIndex = 48;
            this.LblDate.Text = "Date";
            // 
            // LblIncomeByCategory
            // 
            this.LblIncomeByCategory.BackColor = System.Drawing.Color.Transparent;
            this.LblIncomeByCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIncomeByCategory.Location = new System.Drawing.Point(72, 260);
            this.LblIncomeByCategory.Name = "LblIncomeByCategory";
            this.LblIncomeByCategory.Size = new System.Drawing.Size(190, 21);
            this.LblIncomeByCategory.TabIndex = 49;
            this.LblIncomeByCategory.Text = "Daily Income By Brand";
            // 
            // PieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PieChart.Legends.Add(legend2);
            this.PieChart.Location = new System.Drawing.Point(72, 293);
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
            this.PieChart.Size = new System.Drawing.Size(400, 393);
            this.PieChart.TabIndex = 50;
            this.PieChart.Text = "PieChart";
            // 
            // DgvDailyIncome
            // 
            this.DgvDailyIncome.AllowUserToAddRows = false;
            this.DgvDailyIncome.AllowUserToDeleteRows = false;
            this.DgvDailyIncome.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DgvDailyIncome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDailyIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvDailyIncome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDailyIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvDailyIncome.ColumnHeadersHeight = 40;
            this.DgvDailyIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colBrandName,
            this.colItemType,
            this.colQuantity});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDailyIncome.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgvDailyIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDailyIncome.Location = new System.Drawing.Point(510, 260);
            this.DgvDailyIncome.Name = "DgvDailyIncome";
            this.DgvDailyIncome.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDailyIncome.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvDailyIncome.RowHeadersVisible = false;
            this.DgvDailyIncome.RowHeadersWidth = 51;
            this.DgvDailyIncome.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDailyIncome.RowTemplate.Height = 100;
            this.DgvDailyIncome.Size = new System.Drawing.Size(1054, 426);
            this.DgvDailyIncome.TabIndex = 51;
            this.DgvDailyIncome.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvDailyIncome.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvDailyIncome.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvDailyIncome.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvDailyIncome.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvDailyIncome.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvDailyIncome.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDailyIncome.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvDailyIncome.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvDailyIncome.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDailyIncome.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvDailyIncome.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDailyIncome.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvDailyIncome.ThemeStyle.ReadOnly = true;
            this.DgvDailyIncome.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvDailyIncome.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvDailyIncome.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDailyIncome.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvDailyIncome.ThemeStyle.RowsStyle.Height = 100;
            this.DgvDailyIncome.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDailyIncome.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Brand Name";
            this.colBrandName.MinimumWidth = 6;
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            // 
            // colItemType
            // 
            this.colItemType.HeaderText = "Item Type";
            this.colItemType.MinimumWidth = 6;
            this.colItemType.Name = "colItemType";
            this.colItemType.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Sold Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReport.BorderRadius = 5;
            this.BtnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(1346, 717);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(218, 36);
            this.BtnReport.TabIndex = 52;
            this.BtnReport.Text = "Generate Report";
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // DailyIncomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.DgvDailyIncome);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.LblIncomeByCategory);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.LblOverview);
            this.Controls.Add(this.TbOverview);
            this.Controls.Add(this.LblDailyIncome);
            this.Name = "DailyIncomeReport";
            this.Size = new System.Drawing.Size(1636, 799);
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDailyIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LblDailyIncome;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblOverview;
        private Guna.UI2.WinForms.Guna2TextBox TbOverview;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblIncomeByCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private Guna.UI2.WinForms.Guna2DataGridView DgvDailyIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private Guna.UI2.WinForms.Guna2Button BtnReport;
    }
}
