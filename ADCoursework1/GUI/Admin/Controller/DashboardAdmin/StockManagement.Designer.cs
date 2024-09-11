namespace ADCoursework1.GUI.Admin.Controller.DashboardComponents
{
    partial class StockManagement
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
            this.PnlStockManagement = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.LblStock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DgvStockOverview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlStockManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlStockManagement
            // 
            this.PnlStockManagement.BackColor = System.Drawing.Color.Transparent;
            this.PnlStockManagement.Controls.Add(this.LblStock);
            this.PnlStockManagement.Controls.Add(this.DgvStockOverview);
            this.PnlStockManagement.FillColor = System.Drawing.Color.White;
            this.PnlStockManagement.Location = new System.Drawing.Point(6, 8);
            this.PnlStockManagement.Name = "PnlStockManagement";
            this.PnlStockManagement.Radius = 5;
            this.PnlStockManagement.ShadowColor = System.Drawing.SystemColors.HotTrack;
            this.PnlStockManagement.Size = new System.Drawing.Size(548, 377);
            this.PnlStockManagement.TabIndex = 1;
            // 
            // LblStock
            // 
            this.LblStock.BackColor = System.Drawing.Color.Transparent;
            this.LblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.Location = new System.Drawing.Point(130, 17);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(281, 30);
            this.LblStock.TabIndex = 22;
            this.LblStock.Text = "Stock Management Overview";
            // 
            // DgvStockOverview
            // 
            this.DgvStockOverview.AllowUserToAddRows = false;
            this.DgvStockOverview.AllowUserToDeleteRows = false;
            this.DgvStockOverview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvStockOverview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvStockOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvStockOverview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStockOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvStockOverview.ColumnHeadersHeight = 40;
            this.DgvStockOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colItemName,
            this.colStockQuantity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStockOverview.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvStockOverview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvStockOverview.Location = new System.Drawing.Point(28, 61);
            this.DgvStockOverview.Name = "DgvStockOverview";
            this.DgvStockOverview.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStockOverview.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvStockOverview.RowHeadersVisible = false;
            this.DgvStockOverview.RowHeadersWidth = 51;
            this.DgvStockOverview.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvStockOverview.RowTemplate.Height = 100;
            this.DgvStockOverview.Size = new System.Drawing.Size(495, 296);
            this.DgvStockOverview.TabIndex = 17;
            this.DgvStockOverview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvStockOverview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvStockOverview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvStockOverview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvStockOverview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvStockOverview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvStockOverview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvStockOverview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvStockOverview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvStockOverview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvStockOverview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvStockOverview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvStockOverview.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvStockOverview.ThemeStyle.ReadOnly = true;
            this.DgvStockOverview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvStockOverview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvStockOverview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvStockOverview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvStockOverview.ThemeStyle.RowsStyle.Height = 100;
            this.DgvStockOverview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvStockOverview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colStockQuantity
            // 
            this.colStockQuantity.HeaderText = "Stock Quantity";
            this.colStockQuantity.MinimumWidth = 6;
            this.colStockQuantity.Name = "colStockQuantity";
            this.colStockQuantity.ReadOnly = true;
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlStockManagement);
            this.Name = "StockManagement";
            this.Size = new System.Drawing.Size(559, 391);
            this.PnlStockManagement.ResumeLayout(false);
            this.PnlStockManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStockOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel PnlStockManagement;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblStock;
        private Guna.UI2.WinForms.Guna2DataGridView DgvStockOverview;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockQuantity;
    }
}
