namespace ADCoursework1.GUI.Admin.Controller
{
    partial class ManageOrder
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
            this.DgvOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.TbSearchOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvOrders
            // 
            this.DgvOrders.AllowUserToAddRows = false;
            this.DgvOrders.AllowUserToDeleteRows = false;
            this.DgvOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvOrders.ColumnHeadersHeight = 40;
            this.DgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderID,
            this.colCustomer,
            this.colOrderDate,
            this.colTotalPrice,
            this.colStatus,
            this.colBtnView});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvOrders.Location = new System.Drawing.Point(35, 168);
            this.DgvOrders.Name = "DgvOrders";
            this.DgvOrders.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvOrders.RowHeadersVisible = false;
            this.DgvOrders.RowHeadersWidth = 51;
            this.DgvOrders.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvOrders.RowTemplate.Height = 100;
            this.DgvOrders.Size = new System.Drawing.Size(1492, 576);
            this.DgvOrders.TabIndex = 17;
            this.DgvOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvOrders.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvOrders.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvOrders.ThemeStyle.ReadOnly = true;
            this.DgvOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvOrders.ThemeStyle.RowsStyle.Height = 100;
            this.DgvOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colOrderID
            // 
            this.colOrderID.HeaderText = "Order ID";
            this.colOrderID.MinimumWidth = 6;
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.ReadOnly = true;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colOrderDate
            // 
            this.colOrderDate.HeaderText = "Order Date";
            this.colOrderDate.MinimumWidth = 6;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            this.colOrderDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.HeaderText = "Total Price";
            this.colTotalPrice.MinimumWidth = 6;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            this.colTotalPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTotalPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBtnView
            // 
            this.colBtnView.HeaderText = "View";
            this.colBtnView.MinimumWidth = 6;
            this.colBtnView.Name = "colBtnView";
            this.colBtnView.ReadOnly = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BorderRadius = 23;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSearch.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Image = global::ADCoursework1.Properties.Resources.search_white;
            this.BtnSearch.Location = new System.Drawing.Point(701, 48);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(47, 45);
            this.BtnSearch.TabIndex = 22;
            this.BtnSearch.UseTransparentBackground = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TbSearchOrder
            // 
            this.TbSearchOrder.BorderRadius = 20;
            this.TbSearchOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbSearchOrder.DefaultText = "";
            this.TbSearchOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbSearchOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbSearchOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbSearchOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchOrder.IconRightOffset = new System.Drawing.Point(10, 0);
            this.TbSearchOrder.Location = new System.Drawing.Point(35, 48);
            this.TbSearchOrder.Name = "TbSearchOrder";
            this.TbSearchOrder.PasswordChar = '\0';
            this.TbSearchOrder.PlaceholderText = "Search Here...";
            this.TbSearchOrder.SelectedText = "";
            this.TbSearchOrder.Size = new System.Drawing.Size(712, 45);
            this.TbSearchOrder.TabIndex = 21;
            this.TbSearchOrder.TextOffset = new System.Drawing.Point(10, 0);
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
            this.DateTimePicker.Location = new System.Drawing.Point(1153, 63);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(275, 36);
            this.DateTimePicker.TabIndex = 28;
            this.DateTimePicker.Value = new System.DateTime(2024, 8, 25, 21, 29, 28, 922);
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // LblDate
            // 
            this.LblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(1024, 69);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(94, 25);
            this.LblDate.TabIndex = 29;
            this.LblDate.Text = "Select Date";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.BorderRadius = 5;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRefresh.FillColor = System.Drawing.Color.Navy;
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = global::ADCoursework1.Properties.Resources.refresh;
            this.BtnRefresh.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnRefresh.Location = new System.Drawing.Point(1460, 57);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(67, 47);
            this.BtnRefresh.TabIndex = 30;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbSearchOrder);
            this.Controls.Add(this.DgvOrders);
            this.Name = "ManageOrder";
            this.Size = new System.Drawing.Size(1644, 857);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnView;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2TextBox TbSearchOrder;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDate;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
    }
}
