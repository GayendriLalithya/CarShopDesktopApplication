namespace ADCoursework1.GUI.Forms
{
    partial class CarForm
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
            this.BorderlessFormCar = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.LblFormHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PnlAddCar = new Guna.UI2.WinForms.Guna2Panel();
            this.LblModel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CmbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblBrandName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.BtnChoose = new Guna.UI2.WinForms.Guna2Button();
            this.LblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NmrcUpDwnYear = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.LblYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblCarImage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PicBoxCar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.PnlAddCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormCar
            // 
            this.BorderlessFormCar.ContainerControl = this;
            this.BorderlessFormCar.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormCar.TransparentWhileDrag = true;
            // 
            // LblFormHeading
            // 
            this.LblFormHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFormHeading.BackColor = System.Drawing.Color.Transparent;
            this.LblFormHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormHeading.ForeColor = System.Drawing.Color.White;
            this.LblFormHeading.Location = new System.Drawing.Point(364, 24);
            this.LblFormHeading.Name = "LblFormHeading";
            this.LblFormHeading.Size = new System.Drawing.Size(206, 47);
            this.LblFormHeading.TabIndex = 3;
            this.LblFormHeading.Text = "Add New Car";
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
            this.CtrlBoxClose.Location = new System.Drawing.Point(882, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 2;
            // 
            // PnlAddCar
            // 
            this.PnlAddCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PnlAddCar.Controls.Add(this.LblFormHeading);
            this.PnlAddCar.Controls.Add(this.CtrlBoxClose);
            this.PnlAddCar.Location = new System.Drawing.Point(0, 0);
            this.PnlAddCar.Name = "PnlAddCar";
            this.PnlAddCar.Size = new System.Drawing.Size(940, 100);
            this.PnlAddCar.TabIndex = 34;
            // 
            // LblModel
            // 
            this.LblModel.BackColor = System.Drawing.Color.Transparent;
            this.LblModel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModel.Location = new System.Drawing.Point(65, 238);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(55, 21);
            this.LblModel.TabIndex = 46;
            this.LblModel.Text = "Model";
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
            this.CmbBrand.Location = new System.Drawing.Point(65, 177);
            this.CmbBrand.Name = "CmbBrand";
            this.CmbBrand.Size = new System.Drawing.Size(360, 36);
            this.CmbBrand.TabIndex = 45;
            // 
            // LblBrandName
            // 
            this.LblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.LblBrandName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrandName.Location = new System.Drawing.Point(65, 150);
            this.LblBrandName.Name = "LblBrandName";
            this.LblBrandName.Size = new System.Drawing.Size(106, 21);
            this.LblBrandName.TabIndex = 44;
            this.LblBrandName.Text = "Brand Name";
            // 
            // TbModel
            // 
            this.TbModel.BorderRadius = 5;
            this.TbModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbModel.DefaultText = "";
            this.TbModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbModel.Location = new System.Drawing.Point(65, 265);
            this.TbModel.Name = "TbModel";
            this.TbModel.PasswordChar = '\0';
            this.TbModel.PlaceholderText = "";
            this.TbModel.SelectedText = "";
            this.TbModel.Size = new System.Drawing.Size(360, 36);
            this.TbModel.TabIndex = 43;
            // 
            // BtnRemove
            // 
            this.BtnRemove.BorderRadius = 5;
            this.BtnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRemove.FillColor = System.Drawing.Color.Red;
            this.BtnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.Location = new System.Drawing.Point(701, 557);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(170, 36);
            this.BtnRemove.TabIndex = 41;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnChoose
            // 
            this.BtnChoose.BorderRadius = 5;
            this.BtnChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnChoose.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnChoose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnChoose.ForeColor = System.Drawing.Color.White;
            this.BtnChoose.Location = new System.Drawing.Point(511, 557);
            this.BtnChoose.Name = "BtnChoose";
            this.BtnChoose.Size = new System.Drawing.Size(170, 36);
            this.BtnChoose.TabIndex = 40;
            this.BtnChoose.Text = "Choose";
            this.BtnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // LblPrice
            // 
            this.LblPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(65, 420);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(44, 21);
            this.LblPrice.TabIndex = 38;
            this.LblPrice.Text = "Price";
            // 
            // NmrcUpDwnYear
            // 
            this.NmrcUpDwnYear.BackColor = System.Drawing.Color.Transparent;
            this.NmrcUpDwnYear.BorderRadius = 5;
            this.NmrcUpDwnYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NmrcUpDwnYear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NmrcUpDwnYear.Location = new System.Drawing.Point(65, 352);
            this.NmrcUpDwnYear.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NmrcUpDwnYear.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NmrcUpDwnYear.Name = "NmrcUpDwnYear";
            this.NmrcUpDwnYear.Size = new System.Drawing.Size(360, 36);
            this.NmrcUpDwnYear.TabIndex = 37;
            this.NmrcUpDwnYear.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NmrcUpDwnYear.UpDownButtonForeColor = System.Drawing.Color.White;
            this.NmrcUpDwnYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // LblYear
            // 
            this.LblYear.BackColor = System.Drawing.Color.Transparent;
            this.LblYear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYear.Location = new System.Drawing.Point(65, 325);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(41, 21);
            this.LblYear.TabIndex = 36;
            this.LblYear.Text = "Year";
            // 
            // TbPrice
            // 
            this.TbPrice.BorderRadius = 5;
            this.TbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbPrice.DefaultText = "";
            this.TbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPrice.Location = new System.Drawing.Point(65, 447);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.PasswordChar = '\0';
            this.TbPrice.PlaceholderText = "";
            this.TbPrice.SelectedText = "";
            this.TbPrice.Size = new System.Drawing.Size(360, 36);
            this.TbPrice.TabIndex = 35;
            // 
            // TbDescription
            // 
            this.TbDescription.BorderRadius = 5;
            this.TbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbDescription.DefaultText = "";
            this.TbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbDescription.Location = new System.Drawing.Point(65, 532);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.PasswordChar = '\0';
            this.TbDescription.PlaceholderText = "";
            this.TbDescription.SelectedText = "";
            this.TbDescription.Size = new System.Drawing.Size(360, 134);
            this.TbDescription.TabIndex = 47;
            // 
            // LblDescription
            // 
            this.LblDescription.BackColor = System.Drawing.Color.Transparent;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(65, 505);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(94, 21);
            this.LblDescription.TabIndex = 48;
            this.LblDescription.Text = "Description";
            // 
            // LblCarImage
            // 
            this.LblCarImage.BackColor = System.Drawing.Color.Transparent;
            this.LblCarImage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarImage.Location = new System.Drawing.Point(511, 150);
            this.LblCarImage.Name = "LblCarImage";
            this.LblCarImage.Size = new System.Drawing.Size(91, 21);
            this.LblCarImage.TabIndex = 50;
            this.LblCarImage.Text = "Car Image";
            // 
            // PicBoxCar
            // 
            this.PicBoxCar.ErrorImage = global::ADCoursework1.Properties.Resources.white;
            this.PicBoxCar.ImageRotate = 0F;
            this.PicBoxCar.Location = new System.Drawing.Point(511, 177);
            this.PicBoxCar.Name = "PicBoxCar";
            this.PicBoxCar.Size = new System.Drawing.Size(360, 360);
            this.PicBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxCar.TabIndex = 39;
            this.PicBoxCar.TabStop = false;
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
            this.BtnSubmit.Location = new System.Drawing.Point(511, 630);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(360, 36);
            this.BtnSubmit.TabIndex = 51;
            this.BtnSubmit.Text = "Insert Car";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 748);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.LblCarImage);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.CmbBrand);
            this.Controls.Add(this.LblBrandName);
            this.Controls.Add(this.TbModel);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnChoose);
            this.Controls.Add(this.PicBoxCar);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.NmrcUpDwnYear);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.PnlAddCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCar";
            this.PnlAddCar.ResumeLayout(false);
            this.PnlAddCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormCar;
        private Guna.UI2.WinForms.Guna2Panel PnlAddCar;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFormHeading;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblModel;
        private Guna.UI2.WinForms.Guna2ComboBox CmbBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrandName;
        private Guna.UI2.WinForms.Guna2TextBox TbModel;
        private Guna.UI2.WinForms.Guna2Button BtnRemove;
        private Guna.UI2.WinForms.Guna2Button BtnChoose;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxCar;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown NmrcUpDwnYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblYear;
        private Guna.UI2.WinForms.Guna2TextBox TbPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDescription;
        private Guna.UI2.WinForms.Guna2TextBox TbDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCarImage;
        private Guna.UI2.WinForms.Guna2Button BtnSubmit;
    }
}