namespace ADCoursework1.GUI.Controller
{
    partial class ManageCarPart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAddCarPart = new Guna.UI2.WinForms.Guna2Button();
            this.TbSearchCarPart = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.LblFilterBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CmbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblFilterPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CmbPriceRange = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DgvCarParts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCarPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBtnUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRecover = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarParts)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddCarPart
            // 
            this.BtnAddCarPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddCarPart.BorderRadius = 5;
            this.BtnAddCarPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddCarPart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddCarPart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddCarPart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddCarPart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddCarPart.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddCarPart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCarPart.ForeColor = System.Drawing.Color.White;
            this.BtnAddCarPart.Image = global::ADCoursework1.Properties.Resources.add_white;
            this.BtnAddCarPart.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnAddCarPart.Location = new System.Drawing.Point(1440, 53);
            this.BtnAddCarPart.Name = "BtnAddCarPart";
            this.BtnAddCarPart.Size = new System.Drawing.Size(157, 47);
            this.BtnAddCarPart.TabIndex = 16;
            this.BtnAddCarPart.Text = "Add";
            this.BtnAddCarPart.Click += new System.EventHandler(this.BtnAddCarPart_Click);
            // 
            // TbSearchCarPart
            // 
            this.TbSearchCarPart.BorderRadius = 20;
            this.TbSearchCarPart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbSearchCarPart.DefaultText = "";
            this.TbSearchCarPart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbSearchCarPart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbSearchCarPart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchCarPart.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchCarPart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchCarPart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbSearchCarPart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchCarPart.IconRightOffset = new System.Drawing.Point(10, 0);
            this.TbSearchCarPart.Location = new System.Drawing.Point(35, 45);
            this.TbSearchCarPart.Name = "TbSearchCarPart";
            this.TbSearchCarPart.PasswordChar = '\0';
            this.TbSearchCarPart.PlaceholderText = "Search Car Parts Here...";
            this.TbSearchCarPart.SelectedText = "";
            this.TbSearchCarPart.Size = new System.Drawing.Size(712, 45);
            this.TbSearchCarPart.TabIndex = 19;
            this.TbSearchCarPart.TextOffset = new System.Drawing.Point(10, 0);
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
            this.BtnSearch.Location = new System.Drawing.Point(701, 45);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(47, 45);
            this.BtnSearch.TabIndex = 20;
            this.BtnSearch.UseTransparentBackground = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblFilterBrand
            // 
            this.LblFilterBrand.BackColor = System.Drawing.Color.Transparent;
            this.LblFilterBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilterBrand.Location = new System.Drawing.Point(35, 148);
            this.LblFilterBrand.Name = "LblFilterBrand";
            this.LblFilterBrand.Size = new System.Drawing.Size(123, 25);
            this.LblFilterBrand.TabIndex = 27;
            this.LblFilterBrand.Text = "Filter By Brand";
            // 
            // CmbBrand
            // 
            this.CmbBrand.BackColor = System.Drawing.Color.Transparent;
            this.CmbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBrand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbBrand.ItemHeight = 30;
            this.CmbBrand.Location = new System.Drawing.Point(174, 142);
            this.CmbBrand.Name = "CmbBrand";
            this.CmbBrand.Size = new System.Drawing.Size(262, 36);
            this.CmbBrand.TabIndex = 26;
            // 
            // LblFilterPrice
            // 
            this.LblFilterPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblFilterPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilterPrice.Location = new System.Drawing.Point(491, 148);
            this.LblFilterPrice.Name = "LblFilterPrice";
            this.LblFilterPrice.Size = new System.Drawing.Size(114, 25);
            this.LblFilterPrice.TabIndex = 25;
            this.LblFilterPrice.Text = "Filter By Price";
            // 
            // CmbPriceRange
            // 
            this.CmbPriceRange.BackColor = System.Drawing.Color.Transparent;
            this.CmbPriceRange.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbPriceRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPriceRange.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbPriceRange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbPriceRange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbPriceRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbPriceRange.ItemHeight = 30;
            this.CmbPriceRange.Location = new System.Drawing.Point(630, 142);
            this.CmbPriceRange.Name = "CmbPriceRange";
            this.CmbPriceRange.Size = new System.Drawing.Size(262, 36);
            this.CmbPriceRange.TabIndex = 24;
            // 
            // DgvCarParts
            // 
            this.DgvCarParts.AllowUserToAddRows = false;
            this.DgvCarParts.AllowUserToDeleteRows = false;
            this.DgvCarParts.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.DgvCarParts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvCarParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvCarParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCarParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvCarParts.ColumnHeadersHeight = 40;
            this.DgvCarParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarPartID,
            this.colCarPartName,
            this.colBrandName,
            this.colPartNo,
            this.colPartPrice,
            this.colPartImage,
            this.colBtnUpdate,
            this.colBtnDelete,
            this.colBtnView});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCarParts.DefaultCellStyle = dataGridViewCellStyle11;
            this.DgvCarParts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCarParts.Location = new System.Drawing.Point(35, 194);
            this.DgvCarParts.Name = "DgvCarParts";
            this.DgvCarParts.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCarParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvCarParts.RowHeadersVisible = false;
            this.DgvCarParts.RowHeadersWidth = 51;
            this.DgvCarParts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCarParts.RowTemplate.Height = 100;
            this.DgvCarParts.Size = new System.Drawing.Size(1562, 566);
            this.DgvCarParts.TabIndex = 29;
            this.DgvCarParts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCarParts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvCarParts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvCarParts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvCarParts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvCarParts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvCarParts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCarParts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvCarParts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvCarParts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCarParts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvCarParts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCarParts.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvCarParts.ThemeStyle.ReadOnly = true;
            this.DgvCarParts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCarParts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCarParts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCarParts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvCarParts.ThemeStyle.RowsStyle.Height = 100;
            this.DgvCarParts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCarParts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colCarPartID
            // 
            this.colCarPartID.HeaderText = "Car Part ID";
            this.colCarPartID.MinimumWidth = 6;
            this.colCarPartID.Name = "colCarPartID";
            this.colCarPartID.ReadOnly = true;
            // 
            // colCarPartName
            // 
            this.colCarPartName.HeaderText = "Car Part Name";
            this.colCarPartName.MinimumWidth = 6;
            this.colCarPartName.Name = "colCarPartName";
            this.colCarPartName.ReadOnly = true;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Brand Name";
            this.colBrandName.MinimumWidth = 6;
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            // 
            // colPartNo
            // 
            this.colPartNo.HeaderText = "Part Number";
            this.colPartNo.MinimumWidth = 6;
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.ReadOnly = true;
            // 
            // colPartPrice
            // 
            this.colPartPrice.HeaderText = "Part Price";
            this.colPartPrice.MinimumWidth = 6;
            this.colPartPrice.Name = "colPartPrice";
            this.colPartPrice.ReadOnly = true;
            // 
            // colPartImage
            // 
            this.colPartImage.HeaderText = "Car Part Image";
            this.colPartImage.MinimumWidth = 6;
            this.colPartImage.Name = "colPartImage";
            this.colPartImage.ReadOnly = true;
            this.colPartImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPartImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colBtnUpdate
            // 
            this.colBtnUpdate.HeaderText = "Update";
            this.colBtnUpdate.MinimumWidth = 6;
            this.colBtnUpdate.Name = "colBtnUpdate";
            this.colBtnUpdate.ReadOnly = true;
            this.colBtnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBtnUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBtnDelete
            // 
            this.colBtnDelete.HeaderText = "Delete";
            this.colBtnDelete.MinimumWidth = 6;
            this.colBtnDelete.Name = "colBtnDelete";
            this.colBtnDelete.ReadOnly = true;
            this.colBtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.BorderRadius = 5;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = global::ADCoursework1.Properties.Resources.refresh;
            this.BtnRefresh.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnRefresh.Location = new System.Drawing.Point(1530, 142);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(67, 47);
            this.BtnRefresh.TabIndex = 30;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnRecover
            // 
            this.BtnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRecover.BorderRadius = 5;
            this.BtnRecover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecover.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRecover.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRecover.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRecover.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRecover.FillColor = System.Drawing.Color.Navy;
            this.BtnRecover.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecover.ForeColor = System.Drawing.Color.White;
            this.BtnRecover.Image = global::ADCoursework1.Properties.Resources.recover;
            this.BtnRecover.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnRecover.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnRecover.Location = new System.Drawing.Point(1266, 53);
            this.BtnRecover.Name = "BtnRecover";
            this.BtnRecover.Size = new System.Drawing.Size(157, 47);
            this.BtnRecover.TabIndex = 31;
            this.BtnRecover.Text = "Recover";
            this.BtnRecover.Click += new System.EventHandler(this.BtnRecover_Click);
            // 
            // ManageCarPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRecover);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DgvCarParts);
            this.Controls.Add(this.LblFilterBrand);
            this.Controls.Add(this.CmbBrand);
            this.Controls.Add(this.LblFilterPrice);
            this.Controls.Add(this.CmbPriceRange);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbSearchCarPart);
            this.Controls.Add(this.BtnAddCarPart);
            this.Name = "ManageCarPart";
            this.Size = new System.Drawing.Size(1644, 857);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCarParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnAddCarPart;
        private Guna.UI2.WinForms.Guna2TextBox TbSearchCarPart;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFilterBrand;
        private Guna.UI2.WinForms.Guna2ComboBox CmbBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFilterPrice;
        private Guna.UI2.WinForms.Guna2ComboBox CmbPriceRange;
        private Guna.UI2.WinForms.Guna2DataGridView DgvCarParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartPrice;
        private System.Windows.Forms.DataGridViewImageColumn colPartImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnView;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
        private Guna.UI2.WinForms.Guna2Button BtnRecover;
    }
}
