namespace ADCoursework1.GUI.Customer.Controller.DashboardCustomer
{
    partial class OrderDetailsOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlOrder = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.DgvOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.colOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlOrder
            // 
            this.PnlOrder.BackColor = System.Drawing.Color.Transparent;
            this.PnlOrder.Controls.Add(this.DgvOrder);
            this.PnlOrder.Controls.Add(this.guna2HtmlLabel12);
            this.PnlOrder.FillColor = System.Drawing.Color.White;
            this.PnlOrder.Location = new System.Drawing.Point(13, 13);
            this.PnlOrder.Name = "PnlOrder";
            this.PnlOrder.Radius = 5;
            this.PnlOrder.ShadowColor = System.Drawing.SystemColors.Highlight;
            this.PnlOrder.Size = new System.Drawing.Size(1037, 357);
            this.PnlOrder.TabIndex = 30;
            // 
            // DgvOrder
            // 
            this.DgvOrder.AllowUserToAddRows = false;
            this.DgvOrder.AllowUserToDeleteRows = false;
            this.DgvOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DgvOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvOrder.ColumnHeadersHeight = 40;
            this.DgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderID,
            this.colOrderDate,
            this.colTotal,
            this.colStatus});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvOrder.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvOrder.Location = new System.Drawing.Point(35, 63);
            this.DgvOrder.Name = "DgvOrder";
            this.DgvOrder.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvOrder.RowHeadersVisible = false;
            this.DgvOrder.RowHeadersWidth = 51;
            this.DgvOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvOrder.RowTemplate.Height = 100;
            this.DgvOrder.Size = new System.Drawing.Size(952, 268);
            this.DgvOrder.TabIndex = 25;
            this.DgvOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvOrder.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvOrder.ThemeStyle.ReadOnly = true;
            this.DgvOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvOrder.ThemeStyle.RowsStyle.Height = 100;
            this.DgvOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(402, 20);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(224, 30);
            this.guna2HtmlLabel12.TabIndex = 22;
            this.guna2HtmlLabel12.Text = "Order Details Overview";
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
            // colTotal
            // 
            this.colTotal.HeaderText = "TotalPrice";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // OrderDetailsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlOrder);
            this.Name = "OrderDetailsOverview";
            this.Size = new System.Drawing.Size(1062, 381);
            this.PnlOrder.ResumeLayout(false);
            this.PnlOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel PnlOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2DataGridView DgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
