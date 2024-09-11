namespace ADCoursework1.GUI.Forms
{
    partial class SingleCar
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
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BtnQuickOrder = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.LblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CarRatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.PicBoxCar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LblMake = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblCarName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NmrcUpDwnQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormCar
            // 
            this.BorderlessFormCar.ContainerControl = this;
            this.BorderlessFormCar.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormCar.TransparentWhileDrag = true;
            // 
            // CtrlBoxClose
            // 
            this.CtrlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.CtrlBoxClose.BorderRadius = 5;
            this.CtrlBoxClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.CtrlBoxClose.CustomIconSize = 15F;
            this.CtrlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.CtrlBoxClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.CtrlBoxClose.HoverState.IconColor = System.Drawing.Color.White;
            this.CtrlBoxClose.IconColor = System.Drawing.Color.Black;
            this.CtrlBoxClose.Location = new System.Drawing.Point(801, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 3;
            // 
            // BtnQuickOrder
            // 
            this.BtnQuickOrder.BackColor = System.Drawing.Color.Transparent;
            this.BtnQuickOrder.BorderRadius = 5;
            this.BtnQuickOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnQuickOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnQuickOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnQuickOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnQuickOrder.FillColor = System.Drawing.Color.DarkGreen;
            this.BtnQuickOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnQuickOrder.ForeColor = System.Drawing.Color.White;
            this.BtnQuickOrder.Location = new System.Drawing.Point(624, 594);
            this.BtnQuickOrder.Name = "BtnQuickOrder";
            this.BtnQuickOrder.Size = new System.Drawing.Size(170, 36);
            this.BtnQuickOrder.TabIndex = 59;
            this.BtnQuickOrder.Text = "Quick Order";
            this.BtnQuickOrder.Click += new System.EventHandler(this.BtnQuickOrder_Click);
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddToCart.BorderRadius = 5;
            this.BtnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddToCart.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAddToCart.ForeColor = System.Drawing.Color.White;
            this.BtnAddToCart.Location = new System.Drawing.Point(436, 594);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(170, 36);
            this.BtnAddToCart.TabIndex = 58;
            this.BtnAddToCart.Text = "Add To Cart";
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // LblPrice
            // 
            this.LblPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.ForeColor = System.Drawing.Color.Green;
            this.LblPrice.Location = new System.Drawing.Point(649, 471);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(51, 25);
            this.LblPrice.TabIndex = 60;
            this.LblPrice.Text = "Price";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = false;
            this.LblDescription.BackColor = System.Drawing.Color.Transparent;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(31, 527);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(381, 103);
            this.LblDescription.TabIndex = 63;
            this.LblDescription.Text = "Description";
            // 
            // CarRatingStar
            // 
            this.CarRatingStar.BackColor = System.Drawing.Color.Transparent;
            this.CarRatingStar.BorderColor = System.Drawing.Color.Gray;
            this.CarRatingStar.Location = new System.Drawing.Point(479, 42);
            this.CarRatingStar.Name = "CarRatingStar";
            this.CarRatingStar.RatingColor = System.Drawing.Color.Yellow;
            this.CarRatingStar.Size = new System.Drawing.Size(120, 28);
            this.CarRatingStar.TabIndex = 64;
            this.CarRatingStar.Value = 4F;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 17;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Image = global::ADCoursework1.Properties.Resources.milage;
            this.guna2Button3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button3.Location = new System.Drawing.Point(640, 248);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(128, 37);
            this.guna2Button3.TabIndex = 67;
            this.guna2Button3.Text = "Bets Drive";
            this.guna2Button3.UseTransparentBackground = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 17;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Image = global::ADCoursework1.Properties.Resources.manual;
            this.guna2Button2.Location = new System.Drawing.Point(640, 180);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(104, 37);
            this.guna2Button2.TabIndex = 66;
            this.guna2Button2.Text = "Manual";
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::ADCoursework1.Properties.Resources.diesal;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(640, 115);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(94, 37);
            this.guna2Button1.TabIndex = 65;
            this.guna2Button1.Text = "Diesal";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // PicBoxCar
            // 
            this.PicBoxCar.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxCar.BorderRadius = 5;
            this.PicBoxCar.ErrorImage = global::ADCoursework1.Properties.Resources.white;
            this.PicBoxCar.FillColor = System.Drawing.Color.LightGray;
            this.PicBoxCar.ImageRotate = 0F;
            this.PicBoxCar.Location = new System.Drawing.Point(31, 90);
            this.PicBoxCar.Name = "PicBoxCar";
            this.PicBoxCar.Size = new System.Drawing.Size(568, 416);
            this.PicBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxCar.TabIndex = 41;
            this.PicBoxCar.TabStop = false;
            this.PicBoxCar.UseTransparentBackground = true;
            // 
            // LblMake
            // 
            this.LblMake.BackColor = System.Drawing.Color.Transparent;
            this.LblMake.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMake.Location = new System.Drawing.Point(640, 334);
            this.LblMake.Name = "LblMake";
            this.LblMake.Size = new System.Drawing.Size(60, 21);
            this.LblMake.TabIndex = 61;
            this.LblMake.Text = "Make :";
            // 
            // LblYear
            // 
            this.LblYear.BackColor = System.Drawing.Color.Transparent;
            this.LblYear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYear.Location = new System.Drawing.Point(731, 334);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(41, 21);
            this.LblYear.TabIndex = 69;
            this.LblYear.Text = "Year";
            // 
            // LblCarName
            // 
            this.LblCarName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCarName.BackColor = System.Drawing.Color.Transparent;
            this.LblCarName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarName.ForeColor = System.Drawing.Color.Black;
            this.LblCarName.Location = new System.Drawing.Point(31, 23);
            this.LblCarName.Name = "LblCarName";
            this.LblCarName.Size = new System.Drawing.Size(235, 47);
            this.LblCarName.TabIndex = 68;
            this.LblCarName.Text = "Brand + Model";
            this.LblCarName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NmrcUpDwnQuantity
            // 
            this.NmrcUpDwnQuantity.BackColor = System.Drawing.Color.Transparent;
            this.NmrcUpDwnQuantity.BorderRadius = 5;
            this.NmrcUpDwnQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NmrcUpDwnQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NmrcUpDwnQuantity.Location = new System.Drawing.Point(731, 394);
            this.NmrcUpDwnQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmrcUpDwnQuantity.Name = "NmrcUpDwnQuantity";
            this.NmrcUpDwnQuantity.Size = new System.Drawing.Size(88, 36);
            this.NmrcUpDwnQuantity.TabIndex = 70;
            this.NmrcUpDwnQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NmrcUpDwnQuantity.UpDownButtonForeColor = System.Drawing.Color.White;
            this.NmrcUpDwnQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(640, 400);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(70, 21);
            this.guna2HtmlLabel1.TabIndex = 71;
            this.guna2HtmlLabel1.Text = "Quantity";
            // 
            // SingleCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(858, 653);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.NmrcUpDwnQuantity);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblCarName);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.CarRatingStar);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblMake);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.BtnQuickOrder);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.CtrlBoxClose);
            this.Controls.Add(this.PicBoxCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingleCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingleCar";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormCar;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxCar;
        private Guna.UI2.WinForms.Guna2Button BtnQuickOrder;
        private Guna.UI2.WinForms.Guna2Button BtnAddToCart;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDescription;
        private Guna.UI2.WinForms.Guna2RatingStar CarRatingStar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblMake;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCarName;
        private Guna.UI2.WinForms.Guna2NumericUpDown NmrcUpDwnQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}