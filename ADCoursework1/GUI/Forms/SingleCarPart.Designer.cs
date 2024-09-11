namespace ADCoursework1.GUI.Forms
{
    partial class SingleCarPart
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
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPartNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblMake = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnQuickOrder = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.LblCarPartName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PicBoxCarPart = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CarRatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NmrcUpDwnQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCarPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormCarPart
            // 
            this.BorderlessFormCarPart.ContainerControl = this;
            this.BorderlessFormCarPart.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormCarPart.TransparentWhileDrag = true;
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
            this.CtrlBoxClose.IconColor = System.Drawing.Color.Black;
            this.CtrlBoxClose.Location = new System.Drawing.Point(764, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 4;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = false;
            this.LblDescription.BackColor = System.Drawing.Color.Transparent;
            this.LblDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(522, 224);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(287, 218);
            this.LblDescription.TabIndex = 72;
            this.LblDescription.Text = "Description";
            // 
            // LblPartNo
            // 
            this.LblPartNo.BackColor = System.Drawing.Color.Transparent;
            this.LblPartNo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPartNo.Location = new System.Drawing.Point(656, 107);
            this.LblPartNo.Name = "LblPartNo";
            this.LblPartNo.Size = new System.Drawing.Size(104, 21);
            this.LblPartNo.TabIndex = 71;
            this.LblPartNo.Text = "Part Number";
            // 
            // LblMake
            // 
            this.LblMake.BackColor = System.Drawing.Color.Transparent;
            this.LblMake.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMake.Location = new System.Drawing.Point(522, 107);
            this.LblMake.Name = "LblMake";
            this.LblMake.Size = new System.Drawing.Size(114, 21);
            this.LblMake.TabIndex = 70;
            this.LblMake.Text = "Part Number :";
            // 
            // LblPrice
            // 
            this.LblPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.ForeColor = System.Drawing.Color.Green;
            this.LblPrice.Location = new System.Drawing.Point(522, 463);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(51, 25);
            this.LblPrice.TabIndex = 69;
            this.LblPrice.Text = "Price";
            // 
            // BtnQuickOrder
            // 
            this.BtnQuickOrder.BorderRadius = 5;
            this.BtnQuickOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnQuickOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnQuickOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnQuickOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnQuickOrder.FillColor = System.Drawing.Color.DarkGreen;
            this.BtnQuickOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnQuickOrder.ForeColor = System.Drawing.Color.White;
            this.BtnQuickOrder.Location = new System.Drawing.Point(613, 526);
            this.BtnQuickOrder.Name = "BtnQuickOrder";
            this.BtnQuickOrder.Size = new System.Drawing.Size(170, 36);
            this.BtnQuickOrder.TabIndex = 68;
            this.BtnQuickOrder.Text = "Quick Order";
            this.BtnQuickOrder.Click += new System.EventHandler(this.BtnQuickOrder_Click);
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.BorderRadius = 5;
            this.BtnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddToCart.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAddToCart.ForeColor = System.Drawing.Color.White;
            this.BtnAddToCart.Location = new System.Drawing.Point(423, 526);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(170, 36);
            this.BtnAddToCart.TabIndex = 67;
            this.BtnAddToCart.Text = "Add To Cart";
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // LblCarPartName
            // 
            this.LblCarPartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCarPartName.BackColor = System.Drawing.Color.Transparent;
            this.LblCarPartName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarPartName.ForeColor = System.Drawing.Color.Black;
            this.LblCarPartName.Location = new System.Drawing.Point(28, 28);
            this.LblCarPartName.Name = "LblCarPartName";
            this.LblCarPartName.Size = new System.Drawing.Size(362, 47);
            this.LblCarPartName.TabIndex = 65;
            this.LblCarPartName.Text = "Brand + Car Part Name";
            this.LblCarPartName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBoxCarPart
            // 
            this.PicBoxCarPart.ErrorImage = global::ADCoursework1.Properties.Resources.white;
            this.PicBoxCarPart.FillColor = System.Drawing.Color.Gainsboro;
            this.PicBoxCarPart.ImageRotate = 0F;
            this.PicBoxCarPart.Location = new System.Drawing.Point(28, 99);
            this.PicBoxCarPart.Name = "PicBoxCarPart";
            this.PicBoxCarPart.Size = new System.Drawing.Size(438, 389);
            this.PicBoxCarPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxCarPart.TabIndex = 64;
            this.PicBoxCarPart.TabStop = false;
            // 
            // CarRatingStar
            // 
            this.CarRatingStar.BorderColor = System.Drawing.Color.Gray;
            this.CarRatingStar.Location = new System.Drawing.Point(472, 47);
            this.CarRatingStar.Name = "CarRatingStar";
            this.CarRatingStar.RatingColor = System.Drawing.Color.Yellow;
            this.CarRatingStar.Size = new System.Drawing.Size(120, 28);
            this.CarRatingStar.TabIndex = 73;
            this.CarRatingStar.Value = 3.5F;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(522, 174);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(70, 21);
            this.guna2HtmlLabel1.TabIndex = 75;
            this.guna2HtmlLabel1.Text = "Quantity";
            // 
            // NmrcUpDwnQuantity
            // 
            this.NmrcUpDwnQuantity.BackColor = System.Drawing.Color.Transparent;
            this.NmrcUpDwnQuantity.BorderRadius = 5;
            this.NmrcUpDwnQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NmrcUpDwnQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NmrcUpDwnQuantity.Location = new System.Drawing.Point(613, 168);
            this.NmrcUpDwnQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmrcUpDwnQuantity.Name = "NmrcUpDwnQuantity";
            this.NmrcUpDwnQuantity.Size = new System.Drawing.Size(88, 36);
            this.NmrcUpDwnQuantity.TabIndex = 74;
            this.NmrcUpDwnQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NmrcUpDwnQuantity.UpDownButtonForeColor = System.Drawing.Color.White;
            this.NmrcUpDwnQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SingleCarPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(821, 591);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.NmrcUpDwnQuantity);
            this.Controls.Add(this.CarRatingStar);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblPartNo);
            this.Controls.Add(this.LblMake);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.BtnQuickOrder);
            this.Controls.Add(this.BtnAddToCart);
            this.Controls.Add(this.LblCarPartName);
            this.Controls.Add(this.CtrlBoxClose);
            this.Controls.Add(this.PicBoxCarPart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingleCarPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigleCarPart";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCarPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormCarPart;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPartNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblMake;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPrice;
        private Guna.UI2.WinForms.Guna2Button BtnQuickOrder;
        private Guna.UI2.WinForms.Guna2Button BtnAddToCart;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCarPartName;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxCarPart;
        private Guna.UI2.WinForms.Guna2RatingStar CarRatingStar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown NmrcUpDwnQuantity;
    }
}