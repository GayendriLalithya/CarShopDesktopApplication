namespace ADCoursework1.GUI.Admin.Controller.Reports
{
    partial class FinanceReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblFinance = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblOverview = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbOverview = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblMonth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DgvFinance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnReport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFinance)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFinance
            // 
            this.LblFinance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFinance.BackColor = System.Drawing.Color.Transparent;
            this.LblFinance.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinance.Location = new System.Drawing.Point(676, 27);
            this.LblFinance.Name = "LblFinance";
            this.LblFinance.Size = new System.Drawing.Size(261, 41);
            this.LblFinance.TabIndex = 8;
            this.LblFinance.Text = "Financial Report";
            this.LblFinance.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblOverview
            // 
            this.LblOverview.BackColor = System.Drawing.Color.Transparent;
            this.LblOverview.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOverview.Location = new System.Drawing.Point(72, 120);
            this.LblOverview.Name = "LblOverview";
            this.LblOverview.Size = new System.Drawing.Size(139, 21);
            this.LblOverview.TabIndex = 10;
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
            this.TbOverview.TabIndex = 9;
            // 
            // LblMonth
            // 
            this.LblMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMonth.BackColor = System.Drawing.Color.Transparent;
            this.LblMonth.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonth.Location = new System.Drawing.Point(1113, 107);
            this.LblMonth.Name = "LblMonth";
            this.LblMonth.Size = new System.Drawing.Size(53, 21);
            this.LblMonth.TabIndex = 47;
            this.LblMonth.Text = "Month";
            // 
            // DgvFinance
            // 
            this.DgvFinance.AllowUserToAddRows = false;
            this.DgvFinance.AllowUserToDeleteRows = false;
            this.DgvFinance.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvFinance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFinance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvFinance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFinance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvFinance.ColumnHeadersHeight = 40;
            this.DgvFinance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colBrandName,
            this.colItemType,
            this.colIncome});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvFinance.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvFinance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvFinance.Location = new System.Drawing.Point(72, 255);
            this.DgvFinance.Name = "DgvFinance";
            this.DgvFinance.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFinance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvFinance.RowHeadersVisible = false;
            this.DgvFinance.RowHeadersWidth = 51;
            this.DgvFinance.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvFinance.RowTemplate.Height = 100;
            this.DgvFinance.Size = new System.Drawing.Size(1492, 429);
            this.DgvFinance.TabIndex = 49;
            this.DgvFinance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvFinance.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvFinance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvFinance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvFinance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvFinance.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvFinance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvFinance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvFinance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvFinance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvFinance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvFinance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvFinance.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvFinance.ThemeStyle.ReadOnly = true;
            this.DgvFinance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvFinance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvFinance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvFinance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvFinance.ThemeStyle.RowsStyle.Height = 100;
            this.DgvFinance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvFinance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // colIncome
            // 
            this.colIncome.HeaderText = "Total Income";
            this.colIncome.MinimumWidth = 6;
            this.colIncome.Name = "colIncome";
            this.colIncome.ReadOnly = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker.BorderRadius = 5;
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.CustomFormat = "MM/yyyy";
            this.DateTimePicker.FillColor = System.Drawing.Color.Lavender;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(1200, 98);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(364, 36);
            this.DateTimePicker.TabIndex = 50;
            this.DateTimePicker.Value = new System.DateTime(2024, 9, 24, 23, 59, 59, 0);
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
            this.BtnReport.TabIndex = 51;
            this.BtnReport.Text = "Generate Report";
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click_1);
            // 
            // FinanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.DgvFinance);
            this.Controls.Add(this.LblMonth);
            this.Controls.Add(this.LblOverview);
            this.Controls.Add(this.TbOverview);
            this.Controls.Add(this.LblFinance);
            this.Name = "FinanceReport";
            this.Size = new System.Drawing.Size(1636, 799);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFinance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LblFinance;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblOverview;
        private Guna.UI2.WinForms.Guna2TextBox TbOverview;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblMonth;
        private Guna.UI2.WinForms.Guna2DataGridView DgvFinance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncome;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2Button BtnReport;
    }
}
