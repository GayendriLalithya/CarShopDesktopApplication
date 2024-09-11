namespace ADCoursework1.GUI.Controller
{
    partial class ManageBrand
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
            this.TbSearchBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.DgvBrands = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colBrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBtnUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRecover = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddBrand = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // TbSearchBrand
            // 
            this.TbSearchBrand.BorderRadius = 20;
            this.TbSearchBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbSearchBrand.DefaultText = "";
            this.TbSearchBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbSearchBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbSearchBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbSearchBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchBrand.IconRightOffset = new System.Drawing.Point(10, 0);
            this.TbSearchBrand.Location = new System.Drawing.Point(35, 45);
            this.TbSearchBrand.Name = "TbSearchBrand";
            this.TbSearchBrand.PasswordChar = '\0';
            this.TbSearchBrand.PlaceholderText = "Search Brand Here...";
            this.TbSearchBrand.SelectedText = "";
            this.TbSearchBrand.Size = new System.Drawing.Size(692, 45);
            this.TbSearchBrand.TabIndex = 5;
            this.TbSearchBrand.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // DgvBrands
            // 
            this.DgvBrands.AllowUserToAddRows = false;
            this.DgvBrands.AllowUserToDeleteRows = false;
            this.DgvBrands.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.DgvBrands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvBrands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvBrands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvBrands.ColumnHeadersHeight = 40;
            this.DgvBrands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBrandID,
            this.colBrandName,
            this.colBrandImage,
            this.colBtnUpdate,
            this.colBtnDelete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBrands.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgvBrands.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvBrands.Location = new System.Drawing.Point(35, 168);
            this.DgvBrands.Name = "DgvBrands";
            this.DgvBrands.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBrands.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvBrands.RowHeadersVisible = false;
            this.DgvBrands.RowHeadersWidth = 51;
            this.DgvBrands.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvBrands.RowTemplate.Height = 100;
            this.DgvBrands.Size = new System.Drawing.Size(1563, 576);
            this.DgvBrands.TabIndex = 16;
            this.DgvBrands.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvBrands.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvBrands.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvBrands.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvBrands.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvBrands.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvBrands.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvBrands.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvBrands.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvBrands.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvBrands.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvBrands.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvBrands.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvBrands.ThemeStyle.ReadOnly = true;
            this.DgvBrands.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvBrands.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvBrands.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvBrands.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvBrands.ThemeStyle.RowsStyle.Height = 100;
            this.DgvBrands.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvBrands.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colBrandID
            // 
            this.colBrandID.HeaderText = "Brand ID";
            this.colBrandID.MinimumWidth = 6;
            this.colBrandID.Name = "colBrandID";
            this.colBrandID.ReadOnly = true;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Brand Name";
            this.colBrandName.MinimumWidth = 6;
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            // 
            // colBrandImage
            // 
            this.colBrandImage.HeaderText = "Brand Image";
            this.colBrandImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colBrandImage.MinimumWidth = 6;
            this.colBrandImage.Name = "colBrandImage";
            this.colBrandImage.ReadOnly = true;
            this.colBrandImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBrandImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.BtnRecover.Location = new System.Drawing.Point(1264, 53);
            this.BtnRecover.Name = "BtnRecover";
            this.BtnRecover.Size = new System.Drawing.Size(157, 47);
            this.BtnRecover.TabIndex = 26;
            this.BtnRecover.Text = "Recover";
            this.BtnRecover.Click += new System.EventHandler(this.BtnRecover_Click);
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
            this.BtnRefresh.Location = new System.Drawing.Point(1531, 115);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(67, 47);
            this.BtnRefresh.TabIndex = 17;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
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
            this.BtnSearch.TabIndex = 15;
            this.BtnSearch.UseTransparentBackground = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAddBrand
            // 
            this.BtnAddBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddBrand.BorderRadius = 5;
            this.BtnAddBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddBrand.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddBrand.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddBrand.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBrand.ForeColor = System.Drawing.Color.White;
            this.BtnAddBrand.Image = global::ADCoursework1.Properties.Resources.add_white;
            this.BtnAddBrand.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnAddBrand.Location = new System.Drawing.Point(1441, 53);
            this.BtnAddBrand.Name = "BtnAddBrand";
            this.BtnAddBrand.Size = new System.Drawing.Size(157, 47);
            this.BtnAddBrand.TabIndex = 6;
            this.BtnAddBrand.Text = "Add";
            this.BtnAddBrand.Click += new System.EventHandler(this.BtnAddBrand_Click);
            // 
            // ManageBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRecover);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DgvBrands);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnAddBrand);
            this.Controls.Add(this.TbSearchBrand);
            this.Name = "ManageBrand";
            this.Size = new System.Drawing.Size(1644, 857);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBrands)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox TbSearchBrand;
        private Guna.UI2.WinForms.Guna2Button BtnAddBrand;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2DataGridView DgvBrands;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewImageColumn colBrandImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnDelete;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
        private Guna.UI2.WinForms.Guna2Button BtnRecover;
    }
}
