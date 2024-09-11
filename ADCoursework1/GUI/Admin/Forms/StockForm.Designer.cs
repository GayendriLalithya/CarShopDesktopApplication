namespace ADCoursework1.GUI.Admin.Forms
{
    partial class StockForm
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
            this.BorderlessFormStock = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PnlAddBrand = new Guna.UI2.WinForms.Guna2Panel();
            this.LblFormHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BtnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.LblItemType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblBrandName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblItemName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NmrcUpDwnQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.CmbItemType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TbItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.NmrcUpDwnLevel = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.LblRecLevel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlAddBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormStock
            // 
            this.BorderlessFormStock.ContainerControl = this;
            this.BorderlessFormStock.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormStock.TransparentWhileDrag = true;
            // 
            // PnlAddBrand
            // 
            this.PnlAddBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PnlAddBrand.Controls.Add(this.LblFormHeading);
            this.PnlAddBrand.Controls.Add(this.CtrlBoxClose);
            this.PnlAddBrand.Location = new System.Drawing.Point(0, 0);
            this.PnlAddBrand.Name = "PnlAddBrand";
            this.PnlAddBrand.Size = new System.Drawing.Size(645, 100);
            this.PnlAddBrand.TabIndex = 8;
            // 
            // LblFormHeading
            // 
            this.LblFormHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFormHeading.BackColor = System.Drawing.Color.Transparent;
            this.LblFormHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormHeading.ForeColor = System.Drawing.Color.White;
            this.LblFormHeading.Location = new System.Drawing.Point(209, 23);
            this.LblFormHeading.Name = "LblFormHeading";
            this.LblFormHeading.Size = new System.Drawing.Size(240, 47);
            this.LblFormHeading.TabIndex = 3;
            this.LblFormHeading.Text = "Add New Stock";
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
            this.CtrlBoxClose.Location = new System.Drawing.Point(587, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 2;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BorderRadius = 5;
            this.BtnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSubmit.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(146, 692);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(360, 36);
            this.BtnSubmit.TabIndex = 14;
            this.BtnSubmit.Text = "Insert Stock";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // LblItemType
            // 
            this.LblItemType.BackColor = System.Drawing.Color.Transparent;
            this.LblItemType.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemType.Location = new System.Drawing.Point(146, 169);
            this.LblItemType.Name = "LblItemType";
            this.LblItemType.Size = new System.Drawing.Size(83, 21);
            this.LblItemType.TabIndex = 16;
            this.LblItemType.Text = "Item Type";
            // 
            // TbDate
            // 
            this.TbDate.BorderRadius = 5;
            this.TbDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbDate.DefaultText = "";
            this.TbDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbDate.Location = new System.Drawing.Point(146, 443);
            this.TbDate.Name = "TbDate";
            this.TbDate.PasswordChar = '\0';
            this.TbDate.PlaceholderText = "";
            this.TbDate.SelectedText = "";
            this.TbDate.Size = new System.Drawing.Size(360, 36);
            this.TbDate.TabIndex = 19;
            // 
            // LblBrandName
            // 
            this.LblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.LblBrandName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrandName.Location = new System.Drawing.Point(146, 250);
            this.LblBrandName.Name = "LblBrandName";
            this.LblBrandName.Size = new System.Drawing.Size(106, 21);
            this.LblBrandName.TabIndex = 20;
            this.LblBrandName.Text = "Brand Name";
            // 
            // LblItemName
            // 
            this.LblItemName.BackColor = System.Drawing.Color.Transparent;
            this.LblItemName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemName.Location = new System.Drawing.Point(146, 330);
            this.LblItemName.Name = "LblItemName";
            this.LblItemName.Size = new System.Drawing.Size(95, 21);
            this.LblItemName.TabIndex = 21;
            this.LblItemName.Text = "Item Name";
            // 
            // LblDate
            // 
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(146, 416);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(41, 21);
            this.LblDate.TabIndex = 22;
            this.LblDate.Text = "Date";
            // 
            // LblQuantity
            // 
            this.LblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.LblQuantity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(146, 502);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(120, 21);
            this.LblQuantity.TabIndex = 23;
            this.LblQuantity.Text = "Stock Quantity";
            // 
            // NmrcUpDwnQuantity
            // 
            this.NmrcUpDwnQuantity.BackColor = System.Drawing.Color.Transparent;
            this.NmrcUpDwnQuantity.BorderRadius = 5;
            this.NmrcUpDwnQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NmrcUpDwnQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NmrcUpDwnQuantity.Location = new System.Drawing.Point(146, 529);
            this.NmrcUpDwnQuantity.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NmrcUpDwnQuantity.Name = "NmrcUpDwnQuantity";
            this.NmrcUpDwnQuantity.Size = new System.Drawing.Size(360, 36);
            this.NmrcUpDwnQuantity.TabIndex = 38;
            this.NmrcUpDwnQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NmrcUpDwnQuantity.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // CmbItemType
            // 
            this.CmbItemType.BackColor = System.Drawing.Color.Transparent;
            this.CmbItemType.BorderRadius = 5;
            this.CmbItemType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbItemType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbItemType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbItemType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbItemType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbItemType.ItemHeight = 30;
            this.CmbItemType.Location = new System.Drawing.Point(146, 196);
            this.CmbItemType.Name = "CmbItemType";
            this.CmbItemType.Size = new System.Drawing.Size(360, 36);
            this.CmbItemType.TabIndex = 46;
            // 
            // CmbBrand
            // 
            this.CmbBrand.BackColor = System.Drawing.Color.Transparent;
            this.CmbBrand.BorderRadius = 5;
            this.CmbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBrand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbBrand.ItemHeight = 30;
            this.CmbBrand.Location = new System.Drawing.Point(146, 277);
            this.CmbBrand.Name = "CmbBrand";
            this.CmbBrand.Size = new System.Drawing.Size(360, 36);
            this.CmbBrand.TabIndex = 47;
            // 
            // TbItemName
            // 
            this.TbItemName.BorderRadius = 5;
            this.TbItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbItemName.DefaultText = "";
            this.TbItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbItemName.Location = new System.Drawing.Point(146, 357);
            this.TbItemName.Name = "TbItemName";
            this.TbItemName.PasswordChar = '\0';
            this.TbItemName.PlaceholderText = "";
            this.TbItemName.SelectedText = "";
            this.TbItemName.Size = new System.Drawing.Size(360, 36);
            this.TbItemName.TabIndex = 49;
            // 
            // NmrcUpDwnLevel
            // 
            this.NmrcUpDwnLevel.BackColor = System.Drawing.Color.Transparent;
            this.NmrcUpDwnLevel.BorderRadius = 5;
            this.NmrcUpDwnLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NmrcUpDwnLevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NmrcUpDwnLevel.Location = new System.Drawing.Point(146, 620);
            this.NmrcUpDwnLevel.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NmrcUpDwnLevel.Name = "NmrcUpDwnLevel";
            this.NmrcUpDwnLevel.Size = new System.Drawing.Size(360, 36);
            this.NmrcUpDwnLevel.TabIndex = 50;
            this.NmrcUpDwnLevel.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NmrcUpDwnLevel.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // LblRecLevel
            // 
            this.LblRecLevel.BackColor = System.Drawing.Color.Transparent;
            this.LblRecLevel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecLevel.Location = new System.Drawing.Point(146, 593);
            this.LblRecLevel.Name = "LblRecLevel";
            this.LblRecLevel.Size = new System.Drawing.Size(110, 21);
            this.LblRecLevel.TabIndex = 51;
            this.LblRecLevel.Text = "Record Level";
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 776);
            this.Controls.Add(this.LblRecLevel);
            this.Controls.Add(this.NmrcUpDwnLevel);
            this.Controls.Add(this.TbItemName);
            this.Controls.Add(this.CmbBrand);
            this.Controls.Add(this.CmbItemType);
            this.Controls.Add(this.NmrcUpDwnQuantity);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblItemName);
            this.Controls.Add(this.LblBrandName);
            this.Controls.Add(this.TbDate);
            this.Controls.Add(this.LblItemType);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.PnlAddBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.PnlAddBrand.ResumeLayout(false);
            this.PnlAddBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormStock;
        private Guna.UI2.WinForms.Guna2Panel PnlAddBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFormHeading;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2Button BtnSubmit;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblItemType;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblItemName;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrandName;
        private Guna.UI2.WinForms.Guna2TextBox TbDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblQuantity;
        private Guna.UI2.WinForms.Guna2NumericUpDown NmrcUpDwnQuantity;
        private Guna.UI2.WinForms.Guna2ComboBox CmbBrand;
        private Guna.UI2.WinForms.Guna2ComboBox CmbItemType;
        private Guna.UI2.WinForms.Guna2TextBox TbItemName;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblRecLevel;
        private Guna.UI2.WinForms.Guna2NumericUpDown NmrcUpDwnLevel;
    }
}