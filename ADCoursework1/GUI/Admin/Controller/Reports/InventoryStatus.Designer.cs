namespace ADCoursework1.GUI.Admin.Controller.Reports
{
    partial class InventoryStatus
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
            this.LblInventory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblOverview = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbOverview = new Guna.UI2.WinForms.Guna2TextBox();
            this.DgvInventory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnReport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInventory
            // 
            this.LblInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblInventory.BackColor = System.Drawing.Color.Transparent;
            this.LblInventory.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInventory.Location = new System.Drawing.Point(689, 27);
            this.LblInventory.Name = "LblInventory";
            this.LblInventory.Size = new System.Drawing.Size(255, 41);
            this.LblInventory.TabIndex = 9;
            this.LblInventory.Text = "Inventory Status";
            this.LblInventory.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
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
            // DgvInventory
            // 
            this.DgvInventory.AllowUserToAddRows = false;
            this.DgvInventory.AllowUserToDeleteRows = false;
            this.DgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvInventory.ColumnHeadersHeight = 40;
            this.DgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colItemType,
            this.colBrandName,
            this.colQuantity,
            this.colReorderLevel});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInventory.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvInventory.Location = new System.Drawing.Point(72, 255);
            this.DgvInventory.Name = "DgvInventory";
            this.DgvInventory.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvInventory.RowHeadersVisible = false;
            this.DgvInventory.RowHeadersWidth = 51;
            this.DgvInventory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInventory.RowTemplate.Height = 100;
            this.DgvInventory.Size = new System.Drawing.Size(1492, 429);
            this.DgvInventory.TabIndex = 50;
            this.DgvInventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvInventory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvInventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvInventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvInventory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvInventory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvInventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvInventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvInventory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvInventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvInventory.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvInventory.ThemeStyle.ReadOnly = true;
            this.DgvInventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvInventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvInventory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvInventory.ThemeStyle.RowsStyle.Height = 100;
            this.DgvInventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvInventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colItemType
            // 
            this.colItemType.HeaderText = "Item Type";
            this.colItemType.MinimumWidth = 6;
            this.colItemType.Name = "colItemType";
            this.colItemType.ReadOnly = true;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Brand Name";
            this.colBrandName.MinimumWidth = 6;
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colReorderLevel
            // 
            this.colReorderLevel.HeaderText = "Re-Order Level";
            this.colReorderLevel.MinimumWidth = 6;
            this.colReorderLevel.Name = "colReorderLevel";
            this.colReorderLevel.ReadOnly = true;
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
            // InventoryStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.DgvInventory);
            this.Controls.Add(this.LblOverview);
            this.Controls.Add(this.TbOverview);
            this.Controls.Add(this.LblInventory);
            this.Name = "InventoryStatus";
            this.Size = new System.Drawing.Size(1636, 799);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LblInventory;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblOverview;
        private Guna.UI2.WinForms.Guna2TextBox TbOverview;
        private Guna.UI2.WinForms.Guna2DataGridView DgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReorderLevel;
        private Guna.UI2.WinForms.Guna2Button BtnReport;
    }
}
