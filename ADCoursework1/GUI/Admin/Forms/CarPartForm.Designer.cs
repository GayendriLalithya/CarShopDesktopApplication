namespace ADCoursework1.GUI.Forms
{
    partial class CarPartForm
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
            this.BorderlessFormCarPart = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BtnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.BtnChoose = new Guna.UI2.WinForms.Guna2Button();
            this.PicBoxCarPart = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LblPartPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbPartPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblCarPartName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CmbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblBrandName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbCarPart = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblFormHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PnlAddCarPart = new Guna.UI2.WinForms.Guna2Panel();
            this.LblPartNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbPartNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblCarPartImage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCarPart)).BeginInit();
            this.PnlAddCarPart.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessFormCarPart
            // 
            this.BorderlessFormCarPart.ContainerControl = this;
            this.BorderlessFormCarPart.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormCarPart.TransparentWhileDrag = true;
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
            this.BtnSubmit.Location = new System.Drawing.Point(511, 635);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(360, 36);
            this.BtnSubmit.TabIndex = 28;
            this.BtnSubmit.Text = "Insert Car Part";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
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
            this.BtnRemove.Location = new System.Drawing.Point(701, 568);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(170, 36);
            this.BtnRemove.TabIndex = 27;
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
            this.BtnChoose.Location = new System.Drawing.Point(511, 568);
            this.BtnChoose.Name = "BtnChoose";
            this.BtnChoose.Size = new System.Drawing.Size(170, 36);
            this.BtnChoose.TabIndex = 26;
            this.BtnChoose.Text = "Choose";
            this.BtnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // PicBoxCarPart
            // 
            this.PicBoxCarPart.ErrorImage = global::ADCoursework1.Properties.Resources.white;
            this.PicBoxCarPart.ImageRotate = 0F;
            this.PicBoxCarPart.Location = new System.Drawing.Point(511, 188);
            this.PicBoxCarPart.Name = "PicBoxCarPart";
            this.PicBoxCarPart.Size = new System.Drawing.Size(360, 360);
            this.PicBoxCarPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxCarPart.TabIndex = 25;
            this.PicBoxCarPart.TabStop = false;
            // 
            // LblPartPrice
            // 
            this.LblPartPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblPartPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPartPrice.Location = new System.Drawing.Point(65, 416);
            this.LblPartPrice.Name = "LblPartPrice";
            this.LblPartPrice.Size = new System.Drawing.Size(79, 21);
            this.LblPartPrice.TabIndex = 24;
            this.LblPartPrice.Text = "Part Price";
            // 
            // TbPartPrice
            // 
            this.TbPartPrice.BorderRadius = 5;
            this.TbPartPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbPartPrice.DefaultText = "";
            this.TbPartPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbPartPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbPartPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPartPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPartPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPartPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbPartPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPartPrice.Location = new System.Drawing.Point(65, 443);
            this.TbPartPrice.Name = "TbPartPrice";
            this.TbPartPrice.PasswordChar = '\0';
            this.TbPartPrice.PlaceholderText = "";
            this.TbPartPrice.SelectedText = "";
            this.TbPartPrice.Size = new System.Drawing.Size(360, 36);
            this.TbPartPrice.TabIndex = 21;
            // 
            // LblCarPartName
            // 
            this.LblCarPartName.BackColor = System.Drawing.Color.Transparent;
            this.LblCarPartName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarPartName.Location = new System.Drawing.Point(65, 157);
            this.LblCarPartName.Name = "LblCarPartName";
            this.LblCarPartName.Size = new System.Drawing.Size(123, 21);
            this.LblCarPartName.TabIndex = 32;
            this.LblCarPartName.Text = "Car Part Name";
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
            this.CmbBrand.Location = new System.Drawing.Point(65, 272);
            this.CmbBrand.Name = "CmbBrand";
            this.CmbBrand.Size = new System.Drawing.Size(360, 36);
            this.CmbBrand.TabIndex = 31;
            // 
            // LblBrandName
            // 
            this.LblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.LblBrandName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrandName.Location = new System.Drawing.Point(65, 245);
            this.LblBrandName.Name = "LblBrandName";
            this.LblBrandName.Size = new System.Drawing.Size(106, 21);
            this.LblBrandName.TabIndex = 30;
            this.LblBrandName.Text = "Brand Name";
            // 
            // TbCarPart
            // 
            this.TbCarPart.BorderRadius = 5;
            this.TbCarPart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbCarPart.DefaultText = "";
            this.TbCarPart.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbCarPart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbCarPart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbCarPart.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbCarPart.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbCarPart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbCarPart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbCarPart.Location = new System.Drawing.Point(65, 184);
            this.TbCarPart.Name = "TbCarPart";
            this.TbCarPart.PasswordChar = '\0';
            this.TbCarPart.PlaceholderText = "";
            this.TbCarPart.SelectedText = "";
            this.TbCarPart.Size = new System.Drawing.Size(360, 36);
            this.TbCarPart.TabIndex = 29;
            // 
            // LblFormHeading
            // 
            this.LblFormHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFormHeading.BackColor = System.Drawing.Color.Transparent;
            this.LblFormHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormHeading.ForeColor = System.Drawing.Color.White;
            this.LblFormHeading.Location = new System.Drawing.Point(335, 24);
            this.LblFormHeading.Name = "LblFormHeading";
            this.LblFormHeading.Size = new System.Drawing.Size(279, 47);
            this.LblFormHeading.TabIndex = 3;
            this.LblFormHeading.Text = "Add New Car Part";
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
            this.CtrlBoxClose.Location = new System.Drawing.Point(881, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 2;
            // 
            // PnlAddCarPart
            // 
            this.PnlAddCarPart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlAddCarPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PnlAddCarPart.Controls.Add(this.LblFormHeading);
            this.PnlAddCarPart.Controls.Add(this.CtrlBoxClose);
            this.PnlAddCarPart.Location = new System.Drawing.Point(0, 0);
            this.PnlAddCarPart.Name = "PnlAddCarPart";
            this.PnlAddCarPart.Size = new System.Drawing.Size(939, 100);
            this.PnlAddCarPart.TabIndex = 33;
            // 
            // LblPartNo
            // 
            this.LblPartNo.BackColor = System.Drawing.Color.Transparent;
            this.LblPartNo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPartNo.Location = new System.Drawing.Point(65, 328);
            this.LblPartNo.Name = "LblPartNo";
            this.LblPartNo.Size = new System.Drawing.Size(104, 21);
            this.LblPartNo.TabIndex = 35;
            this.LblPartNo.Text = "Part Number";
            // 
            // TbPartNo
            // 
            this.TbPartNo.BorderRadius = 5;
            this.TbPartNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbPartNo.DefaultText = "";
            this.TbPartNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbPartNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbPartNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPartNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPartNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPartNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbPartNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPartNo.Location = new System.Drawing.Point(65, 355);
            this.TbPartNo.Name = "TbPartNo";
            this.TbPartNo.PasswordChar = '\0';
            this.TbPartNo.PlaceholderText = "";
            this.TbPartNo.SelectedText = "";
            this.TbPartNo.Size = new System.Drawing.Size(360, 36);
            this.TbPartNo.TabIndex = 34;
            // 
            // LblDescription
            // 
            this.LblDescription.BackColor = System.Drawing.Color.Transparent;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(65, 510);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(94, 21);
            this.LblDescription.TabIndex = 50;
            this.LblDescription.Text = "Description";
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
            this.TbDescription.Location = new System.Drawing.Point(65, 537);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.PasswordChar = '\0';
            this.TbDescription.PlaceholderText = "";
            this.TbDescription.SelectedText = "";
            this.TbDescription.Size = new System.Drawing.Size(360, 134);
            this.TbDescription.TabIndex = 49;
            // 
            // LblCarPartImage
            // 
            this.LblCarPartImage.BackColor = System.Drawing.Color.Transparent;
            this.LblCarPartImage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarPartImage.Location = new System.Drawing.Point(511, 157);
            this.LblCarPartImage.Name = "LblCarPartImage";
            this.LblCarPartImage.Size = new System.Drawing.Size(126, 21);
            this.LblCarPartImage.TabIndex = 51;
            this.LblCarPartImage.Text = "Car Part Image";
            // 
            // CarPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 728);
            this.Controls.Add(this.LblCarPartImage);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.LblPartNo);
            this.Controls.Add(this.TbPartNo);
            this.Controls.Add(this.PnlAddCarPart);
            this.Controls.Add(this.LblCarPartName);
            this.Controls.Add(this.CmbBrand);
            this.Controls.Add(this.LblBrandName);
            this.Controls.Add(this.TbCarPart);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnChoose);
            this.Controls.Add(this.PicBoxCarPart);
            this.Controls.Add(this.LblPartPrice);
            this.Controls.Add(this.TbPartPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCarPart";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCarPart)).EndInit();
            this.PnlAddCarPart.ResumeLayout(false);
            this.PnlAddCarPart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormCarPart;
        private Guna.UI2.WinForms.Guna2Button BtnSubmit;
        private Guna.UI2.WinForms.Guna2Button BtnRemove;
        private Guna.UI2.WinForms.Guna2Button BtnChoose;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxCarPart;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPartPrice;
        private Guna.UI2.WinForms.Guna2TextBox TbPartPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCarPartName;
        private Guna.UI2.WinForms.Guna2ComboBox CmbBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrandName;
        private Guna.UI2.WinForms.Guna2TextBox TbCarPart;
        private Guna.UI2.WinForms.Guna2Panel PnlAddCarPart;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFormHeading;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPartNo;
        private Guna.UI2.WinForms.Guna2TextBox TbPartNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDescription;
        private Guna.UI2.WinForms.Guna2TextBox TbDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCarPartImage;
    }
}