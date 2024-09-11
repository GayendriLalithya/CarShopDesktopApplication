namespace ADCoursework1.GUI.Customer.Controller
{
    partial class ViewOrder
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
            this.DateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DgvOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.BorderRadius = 5;
            this.DateTimePicker.Checked = true;
            this.DateTimePicker.FillColor = System.Drawing.Color.Lavender;
            this.DateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePicker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker.Location = new System.Drawing.Point(226, 44);
            this.DateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(275, 36);
            this.DateTimePicker.TabIndex = 26;
            this.DateTimePicker.Value = new System.DateTime(2024, 8, 25, 21, 29, 28, 922);
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // LblDate
            // 
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(91, 50);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(94, 25);
            this.LblDate.TabIndex = 27;
            this.LblDate.Text = "Select Date";
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
            this.DgvOrders.Location = new System.Drawing.Point(44, 112);
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
            this.DgvOrders.Size = new System.Drawing.Size(1549, 662);
            this.DgvOrders.TabIndex = 16;
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
            // colOrderDate
            // 
            this.colOrderDate.HeaderText = "Order Date";
            this.colOrderDate.MinimumWidth = 6;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.HeaderText = "Total Price";
            this.colTotalPrice.MinimumWidth = 6;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            this.colTotalPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.colBtnView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBtnView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.DgvOrders);
            this.Controls.Add(this.LblDate);
            this.Name = "ViewOrder";
            this.Size = new System.Drawing.Size(1644, 857);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDate;
        private Guna.UI2.WinForms.Guna2DataGridView DgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnView;
    }
}
