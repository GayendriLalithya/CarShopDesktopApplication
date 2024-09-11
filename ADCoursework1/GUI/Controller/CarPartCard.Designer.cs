namespace ADCoursework1.GUI.Controller
{
    partial class CarPartCard
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
            this.ShdwPnlCarPart = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.BtnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.BtnViewMore = new Guna.UI2.WinForms.Guna2Button();
            this.BtnQuickOrder = new Guna.UI2.WinForms.Guna2Button();
            this.LblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPartNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPartName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PicBoxCarPart = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ShdwPnlCarPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCarPart)).BeginInit();
            this.SuspendLayout();
            // 
            // ShdwPnlCarPart
            // 
            this.ShdwPnlCarPart.BackColor = System.Drawing.Color.Transparent;
            this.ShdwPnlCarPart.Controls.Add(this.BtnAddToCart);
            this.ShdwPnlCarPart.Controls.Add(this.BtnViewMore);
            this.ShdwPnlCarPart.Controls.Add(this.BtnQuickOrder);
            this.ShdwPnlCarPart.Controls.Add(this.LblPrice);
            this.ShdwPnlCarPart.Controls.Add(this.LblPartNo);
            this.ShdwPnlCarPart.Controls.Add(this.LblPartName);
            this.ShdwPnlCarPart.Controls.Add(this.LblBrand);
            this.ShdwPnlCarPart.Controls.Add(this.PicBoxCarPart);
            this.ShdwPnlCarPart.FillColor = System.Drawing.Color.White;
            this.ShdwPnlCarPart.Location = new System.Drawing.Point(9, 3);
            this.ShdwPnlCarPart.Name = "ShdwPnlCarPart";
            this.ShdwPnlCarPart.Radius = 5;
            this.ShdwPnlCarPart.ShadowColor = System.Drawing.Color.Black;
            this.ShdwPnlCarPart.ShadowDepth = 50;
            this.ShdwPnlCarPart.Size = new System.Drawing.Size(275, 415);
            this.ShdwPnlCarPart.TabIndex = 1;
            // 
            // BtnAddToCart
            // 
            this.BtnAddToCart.BorderRadius = 27;
            this.BtnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddToCart.FillColor = System.Drawing.Color.LightSteelBlue;
            this.BtnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.BtnAddToCart.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddToCart.HoverState.Image = global::ADCoursework1.Properties.Resources.cart_white;
            this.BtnAddToCart.Image = global::ADCoursework1.Properties.Resources.cart;
            this.BtnAddToCart.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnAddToCart.Location = new System.Drawing.Point(207, 18);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(50, 50);
            this.BtnAddToCart.TabIndex = 11;
            this.BtnAddToCart.UseTransparentBackground = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // BtnViewMore
            // 
            this.BtnViewMore.BorderColor = System.Drawing.Color.Silver;
            this.BtnViewMore.BorderRadius = 5;
            this.BtnViewMore.BorderThickness = 2;
            this.BtnViewMore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnViewMore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnViewMore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnViewMore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnViewMore.FillColor = System.Drawing.Color.Transparent;
            this.BtnViewMore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnViewMore.ForeColor = System.Drawing.Color.Black;
            this.BtnViewMore.Location = new System.Drawing.Point(140, 363);
            this.BtnViewMore.Name = "BtnViewMore";
            this.BtnViewMore.Size = new System.Drawing.Size(121, 36);
            this.BtnViewMore.TabIndex = 10;
            this.BtnViewMore.Text = "View More";
            this.BtnViewMore.Click += new System.EventHandler(this.BtnViewMore_Click);
            // 
            // BtnQuickOrder
            // 
            this.BtnQuickOrder.BorderRadius = 5;
            this.BtnQuickOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnQuickOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnQuickOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnQuickOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnQuickOrder.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnQuickOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnQuickOrder.ForeColor = System.Drawing.Color.White;
            this.BtnQuickOrder.Location = new System.Drawing.Point(13, 363);
            this.BtnQuickOrder.Name = "BtnQuickOrder";
            this.BtnQuickOrder.Size = new System.Drawing.Size(121, 36);
            this.BtnQuickOrder.TabIndex = 9;
            this.BtnQuickOrder.Text = "Quick Order";
            this.BtnQuickOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // LblPrice
            // 
            this.LblPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.ForeColor = System.Drawing.Color.Green;
            this.LblPrice.Location = new System.Drawing.Point(28, 317);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(51, 25);
            this.LblPrice.TabIndex = 4;
            this.LblPrice.Text = "Price";
            // 
            // LblPartNo
            // 
            this.LblPartNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPartNo.BackColor = System.Drawing.Color.Transparent;
            this.LblPartNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPartNo.Location = new System.Drawing.Point(28, 280);
            this.LblPartNo.Name = "LblPartNo";
            this.LblPartNo.Size = new System.Drawing.Size(93, 20);
            this.LblPartNo.TabIndex = 3;
            this.LblPartNo.Text = "Part Number";
            // 
            // LblPartName
            // 
            this.LblPartName.BackColor = System.Drawing.Color.Transparent;
            this.LblPartName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPartName.Location = new System.Drawing.Point(124, 236);
            this.LblPartName.Name = "LblPartName";
            this.LblPartName.Size = new System.Drawing.Size(105, 25);
            this.LblPartName.TabIndex = 2;
            this.LblPartName.Text = "Part Name";
            // 
            // LblBrand
            // 
            this.LblBrand.BackColor = System.Drawing.Color.Transparent;
            this.LblBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrand.Location = new System.Drawing.Point(28, 236);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(59, 25);
            this.LblBrand.TabIndex = 1;
            this.LblBrand.Text = "Brand";
            // 
            // PicBoxCarPart
            // 
            this.PicBoxCarPart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxCarPart.BorderRadius = 5;
            this.PicBoxCarPart.FillColor = System.Drawing.Color.Gainsboro;
            this.PicBoxCarPart.ImageRotate = 0F;
            this.PicBoxCarPart.Location = new System.Drawing.Point(7, 8);
            this.PicBoxCarPart.Name = "PicBoxCarPart";
            this.PicBoxCarPart.Size = new System.Drawing.Size(261, 210);
            this.PicBoxCarPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxCarPart.TabIndex = 0;
            this.PicBoxCarPart.TabStop = false;
            // 
            // CarPartCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShdwPnlCarPart);
            this.Name = "CarPartCard";
            this.Size = new System.Drawing.Size(292, 424);
            this.ShdwPnlCarPart.ResumeLayout(false);
            this.ShdwPnlCarPart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCarPart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ShdwPnlCarPart;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPartNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPartName;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrand;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxCarPart;
        private Guna.UI2.WinForms.Guna2Button BtnQuickOrder;
        private Guna.UI2.WinForms.Guna2Button BtnAddToCart;
        private Guna.UI2.WinForms.Guna2Button BtnViewMore;
    }
}
