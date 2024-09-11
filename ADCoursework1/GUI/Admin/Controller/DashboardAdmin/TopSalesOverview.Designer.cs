namespace ADCoursework1.GUI.Admin.Controller.DashboardComponents
{
    partial class TopSalesOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlTopSale = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.DgvPartIncome = new Guna.UI2.WinForms.Guna2DataGridView();
            this.LblTopSale = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DgvCarIncome = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colPartBrandImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlTopSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPartIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTopSale
            // 
            this.PnlTopSale.BackColor = System.Drawing.Color.Transparent;
            this.PnlTopSale.Controls.Add(this.DgvPartIncome);
            this.PnlTopSale.Controls.Add(this.LblTopSale);
            this.PnlTopSale.Controls.Add(this.DgvCarIncome);
            this.PnlTopSale.FillColor = System.Drawing.Color.White;
            this.PnlTopSale.Location = new System.Drawing.Point(3, 7);
            this.PnlTopSale.Name = "PnlTopSale";
            this.PnlTopSale.Radius = 5;
            this.PnlTopSale.ShadowColor = System.Drawing.SystemColors.Highlight;
            this.PnlTopSale.Size = new System.Drawing.Size(1000, 377);
            this.PnlTopSale.TabIndex = 3;
            // 
            // DgvPartIncome
            // 
            this.DgvPartIncome.AllowUserToAddRows = false;
            this.DgvPartIncome.AllowUserToDeleteRows = false;
            this.DgvPartIncome.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvPartIncome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPartIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvPartIncome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPartIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPartIncome.ColumnHeadersHeight = 40;
            this.DgvPartIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPartBrandImage,
            this.colPartName,
            this.colPartIncome});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPartIncome.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPartIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvPartIncome.Location = new System.Drawing.Point(510, 61);
            this.DgvPartIncome.Name = "DgvPartIncome";
            this.DgvPartIncome.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPartIncome.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvPartIncome.RowHeadersVisible = false;
            this.DgvPartIncome.RowHeadersWidth = 51;
            this.DgvPartIncome.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvPartIncome.RowTemplate.Height = 100;
            this.DgvPartIncome.Size = new System.Drawing.Size(459, 296);
            this.DgvPartIncome.TabIndex = 24;
            this.DgvPartIncome.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvPartIncome.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvPartIncome.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvPartIncome.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvPartIncome.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvPartIncome.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvPartIncome.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvPartIncome.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvPartIncome.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvPartIncome.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvPartIncome.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvPartIncome.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvPartIncome.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvPartIncome.ThemeStyle.ReadOnly = true;
            this.DgvPartIncome.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvPartIncome.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvPartIncome.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvPartIncome.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvPartIncome.ThemeStyle.RowsStyle.Height = 100;
            this.DgvPartIncome.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvPartIncome.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // LblTopSale
            // 
            this.LblTopSale.BackColor = System.Drawing.Color.Transparent;
            this.LblTopSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTopSale.Location = new System.Drawing.Point(360, 16);
            this.LblTopSale.Name = "LblTopSale";
            this.LblTopSale.Size = new System.Drawing.Size(299, 30);
            this.LblTopSale.TabIndex = 22;
            this.LblTopSale.Text = "Monthly Top Sellings Overview";
            // 
            // DgvCarIncome
            // 
            this.DgvCarIncome.AllowUserToAddRows = false;
            this.DgvCarIncome.AllowUserToDeleteRows = false;
            this.DgvCarIncome.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DgvCarIncome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCarIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvCarIncome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCarIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvCarIncome.ColumnHeadersHeight = 40;
            this.DgvCarIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBrandImage,
            this.colCarName,
            this.colCarIncome});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCarIncome.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgvCarIncome.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCarIncome.Location = new System.Drawing.Point(36, 61);
            this.DgvCarIncome.Name = "DgvCarIncome";
            this.DgvCarIncome.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCarIncome.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvCarIncome.RowHeadersVisible = false;
            this.DgvCarIncome.RowHeadersWidth = 51;
            this.DgvCarIncome.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCarIncome.RowTemplate.Height = 100;
            this.DgvCarIncome.Size = new System.Drawing.Size(452, 296);
            this.DgvCarIncome.TabIndex = 17;
            this.DgvCarIncome.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCarIncome.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvCarIncome.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvCarIncome.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvCarIncome.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvCarIncome.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvCarIncome.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCarIncome.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvCarIncome.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvCarIncome.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCarIncome.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvCarIncome.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCarIncome.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvCarIncome.ThemeStyle.ReadOnly = true;
            this.DgvCarIncome.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCarIncome.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCarIncome.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCarIncome.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvCarIncome.ThemeStyle.RowsStyle.Height = 100;
            this.DgvCarIncome.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCarIncome.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colPartBrandImage
            // 
            this.colPartBrandImage.HeaderText = "Brand";
            this.colPartBrandImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colPartBrandImage.MinimumWidth = 6;
            this.colPartBrandImage.Name = "colPartBrandImage";
            this.colPartBrandImage.ReadOnly = true;
            // 
            // colPartName
            // 
            this.colPartName.HeaderText = "Car Part Name";
            this.colPartName.MinimumWidth = 6;
            this.colPartName.Name = "colPartName";
            this.colPartName.ReadOnly = true;
            // 
            // colPartIncome
            // 
            this.colPartIncome.HeaderText = "Income";
            this.colPartIncome.MinimumWidth = 6;
            this.colPartIncome.Name = "colPartIncome";
            this.colPartIncome.ReadOnly = true;
            // 
            // colBrandImage
            // 
            this.colBrandImage.HeaderText = "Brand";
            this.colBrandImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colBrandImage.MinimumWidth = 6;
            this.colBrandImage.Name = "colBrandImage";
            this.colBrandImage.ReadOnly = true;
            // 
            // colCarName
            // 
            this.colCarName.HeaderText = "Car Name";
            this.colCarName.MinimumWidth = 6;
            this.colCarName.Name = "colCarName";
            this.colCarName.ReadOnly = true;
            // 
            // colCarIncome
            // 
            this.colCarIncome.HeaderText = "Income";
            this.colCarIncome.MinimumWidth = 6;
            this.colCarIncome.Name = "colCarIncome";
            this.colCarIncome.ReadOnly = true;
            // 
            // TopSalesOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlTopSale);
            this.Name = "TopSalesOverview";
            this.Size = new System.Drawing.Size(1008, 391);
            this.PnlTopSale.ResumeLayout(false);
            this.PnlTopSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPartIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel PnlTopSale;
        private Guna.UI2.WinForms.Guna2DataGridView DgvPartIncome;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTopSale;
        private Guna.UI2.WinForms.Guna2DataGridView DgvCarIncome;
        private System.Windows.Forms.DataGridViewImageColumn colPartBrandImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartIncome;
        private System.Windows.Forms.DataGridViewImageColumn colBrandImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarIncome;
    }
}
