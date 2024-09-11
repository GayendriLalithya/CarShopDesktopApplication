namespace ADCoursework1.GUI.Admin.Controller
{
    partial class ManageInventory
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
            this.DgvInventory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colStockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAddInventory = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.TbSearchItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvInventory
            // 
            this.DgvInventory.AllowUserToAddRows = false;
            this.DgvInventory.AllowUserToDeleteRows = false;
            this.DgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvInventory.ColumnHeadersHeight = 40;
            this.DgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockID,
            this.colItemType,
            this.colBrand,
            this.colItemName,
            this.colDate,
            this.colQuantity,
            this.colBtnUpdate,
            this.colBtnDelete,
            this.colBtnView});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInventory.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvInventory.Location = new System.Drawing.Point(39, 140);
            this.DgvInventory.Name = "DgvInventory";
            this.DgvInventory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvInventory.RowHeadersVisible = false;
            this.DgvInventory.RowHeadersWidth = 51;
            this.DgvInventory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvInventory.RowTemplate.Height = 100;
            this.DgvInventory.Size = new System.Drawing.Size(1564, 576);
            this.DgvInventory.TabIndex = 17;
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
            // colStockID
            // 
            this.colStockID.HeaderText = "Stock ID";
            this.colStockID.MinimumWidth = 6;
            this.colStockID.Name = "colStockID";
            this.colStockID.ReadOnly = true;
            // 
            // colItemType
            // 
            this.colItemType.HeaderText = "ItemType";
            this.colItemType.MinimumWidth = 6;
            this.colItemType.Name = "colItemType";
            this.colItemType.ReadOnly = true;
            // 
            // colBrand
            // 
            this.colBrand.HeaderText = "Brand";
            this.colBrand.MinimumWidth = 6;
            this.colBrand.Name = "colBrand";
            this.colBrand.ReadOnly = true;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            this.colItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBtnUpdate
            // 
            this.colBtnUpdate.HeaderText = "Update";
            this.colBtnUpdate.MinimumWidth = 6;
            this.colBtnUpdate.Name = "colBtnUpdate";
            this.colBtnUpdate.ReadOnly = true;
            // 
            // colBtnDelete
            // 
            this.colBtnDelete.HeaderText = "Delete";
            this.colBtnDelete.MinimumWidth = 6;
            this.colBtnDelete.Name = "colBtnDelete";
            this.colBtnDelete.ReadOnly = true;
            // 
            // colBtnView
            // 
            this.colBtnView.HeaderText = "View";
            this.colBtnView.MinimumWidth = 6;
            this.colBtnView.Name = "colBtnView";
            this.colBtnView.ReadOnly = true;
            // 
            // BtnAddInventory
            // 
            this.BtnAddInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddInventory.BorderRadius = 5;
            this.BtnAddInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddInventory.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddInventory.ForeColor = System.Drawing.Color.White;
            this.BtnAddInventory.Image = global::ADCoursework1.Properties.Resources.add_white;
            this.BtnAddInventory.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnAddInventory.Location = new System.Drawing.Point(1437, 30);
            this.BtnAddInventory.Name = "BtnAddInventory";
            this.BtnAddInventory.Size = new System.Drawing.Size(157, 47);
            this.BtnAddInventory.TabIndex = 18;
            this.BtnAddInventory.Text = "Add";
            this.BtnAddInventory.Click += new System.EventHandler(this.BtnAddInventory_Click);
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
            this.BtnSearch.Location = new System.Drawing.Point(686, 32);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(47, 45);
            this.BtnSearch.TabIndex = 20;
            this.BtnSearch.UseTransparentBackground = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TbSearchItem
            // 
            this.TbSearchItem.BorderRadius = 20;
            this.TbSearchItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbSearchItem.DefaultText = "";
            this.TbSearchItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbSearchItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbSearchItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbSearchItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchItem.IconRightOffset = new System.Drawing.Point(10, 0);
            this.TbSearchItem.Location = new System.Drawing.Point(39, 32);
            this.TbSearchItem.Name = "TbSearchItem";
            this.TbSearchItem.PasswordChar = '\0';
            this.TbSearchItem.PlaceholderText = "Search Items Here...";
            this.TbSearchItem.SelectedText = "";
            this.TbSearchItem.Size = new System.Drawing.Size(692, 45);
            this.TbSearchItem.TabIndex = 19;
            this.TbSearchItem.TextOffset = new System.Drawing.Point(10, 0);
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
            this.BtnRefresh.Location = new System.Drawing.Point(1354, 30);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(67, 47);
            this.BtnRefresh.TabIndex = 21;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbSearchItem);
            this.Controls.Add(this.BtnAddInventory);
            this.Controls.Add(this.DgvInventory);
            this.Name = "ManageInventory";
            this.Size = new System.Drawing.Size(1644, 857);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DgvInventory;
        private Guna.UI2.WinForms.Guna2Button BtnAddInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnView;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2TextBox TbSearchItem;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
    }
}
