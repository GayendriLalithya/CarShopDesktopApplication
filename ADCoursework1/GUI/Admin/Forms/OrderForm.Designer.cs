namespace ADCoursework1.GUI.Admin.Forms
{
    partial class OrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BorderlessFormOrderDetails = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PnlManageOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.LblFormHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DgvOrderDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTotalAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblTotalPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CmbUpdateStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblUpdateStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.PnlManageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormOrderDetails
            // 
            this.BorderlessFormOrderDetails.ContainerControl = this;
            this.BorderlessFormOrderDetails.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormOrderDetails.TransparentWhileDrag = true;
            // 
            // PnlManageOrder
            // 
            this.PnlManageOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlManageOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PnlManageOrder.Controls.Add(this.LblFormHeading);
            this.PnlManageOrder.Controls.Add(this.CtrlBoxClose);
            this.PnlManageOrder.Location = new System.Drawing.Point(0, 0);
            this.PnlManageOrder.Name = "PnlManageOrder";
            this.PnlManageOrder.Size = new System.Drawing.Size(1265, 100);
            this.PnlManageOrder.TabIndex = 9;
            // 
            // LblFormHeading
            // 
            this.LblFormHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFormHeading.BackColor = System.Drawing.Color.Transparent;
            this.LblFormHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormHeading.ForeColor = System.Drawing.Color.White;
            this.LblFormHeading.Location = new System.Drawing.Point(452, 23);
            this.LblFormHeading.Name = "LblFormHeading";
            this.LblFormHeading.Size = new System.Drawing.Size(342, 47);
            this.LblFormHeading.TabIndex = 3;
            this.LblFormHeading.Text = "Manage Order Details";
            // 
            // CtrlBoxClose
            // 
            this.CtrlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlBoxClose.BorderRadius = 5;
            this.CtrlBoxClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.CtrlBoxClose.CustomIconSize = 15F;
            this.CtrlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.CtrlBoxClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.CtrlBoxClose.HoverState.IconColor = System.Drawing.Color.White;
            this.CtrlBoxClose.IconColor = System.Drawing.Color.White;
            this.CtrlBoxClose.Location = new System.Drawing.Point(1207, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 2;
            // 
            // DgvOrderDetails
            // 
            this.DgvOrderDetails.AllowUserToAddRows = false;
            this.DgvOrderDetails.AllowUserToDeleteRows = false;
            this.DgvOrderDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvOrderDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvOrderDetails.ColumnHeadersHeight = 40;
            this.DgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemType,
            this.colName,
            this.colBrand,
            this.colQuantity,
            this.colPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvOrderDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvOrderDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvOrderDetails.Location = new System.Drawing.Point(33, 182);
            this.DgvOrderDetails.Name = "DgvOrderDetails";
            this.DgvOrderDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvOrderDetails.RowHeadersVisible = false;
            this.DgvOrderDetails.RowHeadersWidth = 51;
            this.DgvOrderDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvOrderDetails.RowTemplate.Height = 100;
            this.DgvOrderDetails.Size = new System.Drawing.Size(1190, 504);
            this.DgvOrderDetails.TabIndex = 18;
            this.DgvOrderDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvOrderDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvOrderDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvOrderDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvOrderDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvOrderDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvOrderDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvOrderDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvOrderDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvOrderDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvOrderDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvOrderDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvOrderDetails.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvOrderDetails.ThemeStyle.ReadOnly = true;
            this.DgvOrderDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvOrderDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvOrderDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvOrderDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvOrderDetails.ThemeStyle.RowsStyle.Height = 100;
            this.DgvOrderDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvOrderDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colItemType
            // 
            this.colItemType.HeaderText = "Item Type";
            this.colItemType.MinimumWidth = 6;
            this.colItemType.Name = "colItemType";
            this.colItemType.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colBrand
            // 
            this.colBrand.HeaderText = "Brand";
            this.colBrand.MinimumWidth = 6;
            this.colBrand.Name = "colBrand";
            this.colBrand.ReadOnly = true;
            this.colBrand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmount.Location = new System.Drawing.Point(1093, 705);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(67, 21);
            this.LblTotalAmount.TabIndex = 21;
            this.LblTotalAmount.Text = "Amount";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPrice.Location = new System.Drawing.Point(812, 705);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(203, 21);
            this.LblTotalPrice.TabIndex = 20;
            this.LblTotalPrice.Text = "Total Price of the Order =";
            // 
            // CmbUpdateStatus
            // 
            this.CmbUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.CmbUpdateStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbUpdateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUpdateStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbUpdateStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbUpdateStatus.ItemHeight = 30;
            this.CmbUpdateStatus.Items.AddRange(new object[] {
            "Pending",
            "Completed",
            "Cancelled"});
            this.CmbUpdateStatus.Location = new System.Drawing.Point(219, 123);
            this.CmbUpdateStatus.Name = "CmbUpdateStatus";
            this.CmbUpdateStatus.Size = new System.Drawing.Size(560, 36);
            this.CmbUpdateStatus.TabIndex = 22;
            // 
            // LblUpdateStatus
            // 
            this.LblUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblUpdateStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpdateStatus.Location = new System.Drawing.Point(70, 131);
            this.LblUpdateStatus.Name = "LblUpdateStatus";
            this.LblUpdateStatus.Size = new System.Drawing.Size(112, 21);
            this.LblUpdateStatus.TabIndex = 23;
            this.LblUpdateStatus.Text = "Update Status";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BorderRadius = 5;
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.FillColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(1053, 123);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(170, 36);
            this.BtnDelete.TabIndex = 24;
            this.BtnDelete.Text = "Delete Order";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BorderRadius = 5;
            this.BtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdate.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(845, 123);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(170, 36);
            this.BtnUpdate.TabIndex = 41;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 749);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblUpdateStatus);
            this.Controls.Add(this.CmbUpdateStatus);
            this.Controls.Add(this.LblTotalAmount);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.DgvOrderDetails);
            this.Controls.Add(this.PnlManageOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.PnlManageOrder.ResumeLayout(false);
            this.PnlManageOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormOrderDetails;
        private Guna.UI2.WinForms.Guna2Panel PnlManageOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFormHeading;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2DataGridView DgvOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTotalAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTotalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblUpdateStatus;
        private Guna.UI2.WinForms.Guna2ComboBox CmbUpdateStatus;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private Guna.UI2.WinForms.Guna2Button BtnUpdate;
    }
}