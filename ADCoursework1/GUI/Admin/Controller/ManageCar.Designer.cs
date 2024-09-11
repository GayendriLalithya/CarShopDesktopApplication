namespace ADCoursework1.GUI.Controller
{
    partial class ManageCar
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
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddCar = new Guna.UI2.WinForms.Guna2Button();
            this.TbSearchCar = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbPriceRange = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblFilterPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblFilterYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CmbYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblFilterBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CmbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DgvCars = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBtnUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRecover = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCars)).BeginInit();
            this.SuspendLayout();
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
            this.BtnSearch.Location = new System.Drawing.Point(682, 45);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(47, 45);
            this.BtnSearch.TabIndex = 14;
            this.BtnSearch.UseTransparentBackground = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAddCar
            // 
            this.BtnAddCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddCar.BorderRadius = 5;
            this.BtnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddCar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddCar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddCar.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddCar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCar.ForeColor = System.Drawing.Color.White;
            this.BtnAddCar.Image = global::ADCoursework1.Properties.Resources.add_white;
            this.BtnAddCar.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnAddCar.Location = new System.Drawing.Point(1440, 53);
            this.BtnAddCar.Name = "BtnAddCar";
            this.BtnAddCar.Size = new System.Drawing.Size(157, 47);
            this.BtnAddCar.TabIndex = 13;
            this.BtnAddCar.Text = "Add";
            this.BtnAddCar.Click += new System.EventHandler(this.BtnAddCar_Click);
            // 
            // TbSearchCar
            // 
            this.TbSearchCar.BorderRadius = 20;
            this.TbSearchCar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbSearchCar.DefaultText = "";
            this.TbSearchCar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbSearchCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbSearchCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchCar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchCar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbSearchCar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchCar.IconRightOffset = new System.Drawing.Point(10, 0);
            this.TbSearchCar.Location = new System.Drawing.Point(35, 45);
            this.TbSearchCar.Name = "TbSearchCar";
            this.TbSearchCar.PasswordChar = '\0';
            this.TbSearchCar.PlaceholderText = "Search Cars Here...";
            this.TbSearchCar.SelectedText = "";
            this.TbSearchCar.Size = new System.Drawing.Size(692, 45);
            this.TbSearchCar.TabIndex = 12;
            this.TbSearchCar.TextOffset = new System.Drawing.Point(10, 0);
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
            this.CmbPriceRange.Location = new System.Drawing.Point(1089, 142);
            this.CmbPriceRange.Name = "CmbPriceRange";
            this.CmbPriceRange.Size = new System.Drawing.Size(262, 36);
            this.CmbPriceRange.TabIndex = 18;
            // 
            // LblFilterPrice
            // 
            this.LblFilterPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblFilterPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilterPrice.Location = new System.Drawing.Point(950, 148);
            this.LblFilterPrice.Name = "LblFilterPrice";
            this.LblFilterPrice.Size = new System.Drawing.Size(114, 25);
            this.LblFilterPrice.TabIndex = 19;
            this.LblFilterPrice.Text = "Filter By Price";
            // 
            // LblFilterYear
            // 
            this.LblFilterYear.BackColor = System.Drawing.Color.Transparent;
            this.LblFilterYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilterYear.Location = new System.Drawing.Point(491, 148);
            this.LblFilterYear.Name = "LblFilterYear";
            this.LblFilterYear.Size = new System.Drawing.Size(110, 25);
            this.LblFilterYear.TabIndex = 21;
            this.LblFilterYear.Text = "Filter By Year";
            // 
            // CmbYear
            // 
            this.CmbYear.BackColor = System.Drawing.Color.Transparent;
            this.CmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbYear.ItemHeight = 30;
            this.CmbYear.Location = new System.Drawing.Point(630, 142);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(262, 36);
            this.CmbYear.TabIndex = 20;
            // 
            // LblFilterBrand
            // 
            this.LblFilterBrand.BackColor = System.Drawing.Color.Transparent;
            this.LblFilterBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilterBrand.Location = new System.Drawing.Point(35, 148);
            this.LblFilterBrand.Name = "LblFilterBrand";
            this.LblFilterBrand.Size = new System.Drawing.Size(123, 25);
            this.LblFilterBrand.TabIndex = 23;
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
            this.CmbBrand.TabIndex = 22;
            // 
            // DgvCars
            // 
            this.DgvCars.AllowUserToAddRows = false;
            this.DgvCars.AllowUserToDeleteRows = false;
            this.DgvCars.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.DgvCars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvCars.ColumnHeadersHeight = 40;
            this.DgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarID,
            this.colBrandName,
            this.colModel,
            this.colYear,
            this.colPrice,
            this.colCarImage,
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
            this.DgvCars.DefaultCellStyle = dataGridViewCellStyle11;
            this.DgvCars.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCars.Location = new System.Drawing.Point(35, 194);
            this.DgvCars.Name = "DgvCars";
            this.DgvCars.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DgvCars.RowHeadersVisible = false;
            this.DgvCars.RowHeadersWidth = 51;
            this.DgvCars.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCars.RowTemplate.Height = 100;
            this.DgvCars.Size = new System.Drawing.Size(1549, 566);
            this.DgvCars.TabIndex = 24;
            this.DgvCars.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCars.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvCars.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvCars.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvCars.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvCars.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvCars.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCars.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvCars.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvCars.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCars.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvCars.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCars.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvCars.ThemeStyle.ReadOnly = true;
            this.DgvCars.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCars.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCars.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCars.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvCars.ThemeStyle.RowsStyle.Height = 100;
            this.DgvCars.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCars.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colCarID
            // 
            this.colCarID.HeaderText = "Car ID";
            this.colCarID.MinimumWidth = 6;
            this.colCarID.Name = "colCarID";
            this.colCarID.ReadOnly = true;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Brand Name";
            this.colBrandName.MinimumWidth = 6;
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            // 
            // colModel
            // 
            this.colModel.HeaderText = "Model";
            this.colModel.MinimumWidth = 6;
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Year";
            this.colYear.MinimumWidth = 6;
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colCarImage
            // 
            this.colCarImage.HeaderText = "Car Image";
            this.colCarImage.MinimumWidth = 6;
            this.colCarImage.Name = "colCarImage";
            this.colCarImage.ReadOnly = true;
            this.colCarImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCarImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.BtnRefresh.Location = new System.Drawing.Point(1517, 141);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(67, 47);
            this.BtnRefresh.TabIndex = 25;
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
            this.BtnRecover.Location = new System.Drawing.Point(1265, 53);
            this.BtnRecover.Name = "BtnRecover";
            this.BtnRecover.Size = new System.Drawing.Size(157, 47);
            this.BtnRecover.TabIndex = 27;
            this.BtnRecover.Text = "Recover";
            this.BtnRecover.Click += new System.EventHandler(this.BtnRecover_Click);
            // 
            // ManageCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRecover);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DgvCars);
            this.Controls.Add(this.LblFilterBrand);
            this.Controls.Add(this.CmbBrand);
            this.Controls.Add(this.LblFilterYear);
            this.Controls.Add(this.CmbYear);
            this.Controls.Add(this.LblFilterPrice);
            this.Controls.Add(this.CmbPriceRange);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnAddCar);
            this.Controls.Add(this.TbSearchCar);
            this.Name = "ManageCar";
            this.Size = new System.Drawing.Size(1644, 857);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2Button BtnAddCar;
        private Guna.UI2.WinForms.Guna2TextBox TbSearchCar;
        private Guna.UI2.WinForms.Guna2ComboBox CmbPriceRange;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFilterPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFilterYear;
        private Guna.UI2.WinForms.Guna2ComboBox CmbYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFilterBrand;
        private Guna.UI2.WinForms.Guna2ComboBox CmbBrand;
        private Guna.UI2.WinForms.Guna2DataGridView DgvCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewImageColumn colCarImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnView;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
        private Guna.UI2.WinForms.Guna2Button BtnRecover;
    }
}
