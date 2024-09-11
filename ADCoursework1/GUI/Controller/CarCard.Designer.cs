namespace ADCoursework1.GUI.Controller
{
    partial class CarCard
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
            this.ShdwPnlCar = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.BtnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.BtnQuickOrder = new Guna.UI2.WinForms.Guna2Button();
            this.BtnViewMore = new Guna.UI2.WinForms.Guna2Button();
            this.LblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblModel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PicBoxCar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ShdwPnlCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // ShdwPnlCar
            // 
            this.ShdwPnlCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShdwPnlCar.BackColor = System.Drawing.Color.Transparent;
            this.ShdwPnlCar.Controls.Add(this.BtnAddToCart);
            this.ShdwPnlCar.Controls.Add(this.BtnQuickOrder);
            this.ShdwPnlCar.Controls.Add(this.BtnViewMore);
            this.ShdwPnlCar.Controls.Add(this.LblPrice);
            this.ShdwPnlCar.Controls.Add(this.LblYear);
            this.ShdwPnlCar.Controls.Add(this.LblModel);
            this.ShdwPnlCar.Controls.Add(this.LblBrand);
            this.ShdwPnlCar.Controls.Add(this.PicBoxCar);
            this.ShdwPnlCar.FillColor = System.Drawing.Color.White;
            this.ShdwPnlCar.Location = new System.Drawing.Point(9, 3);
            this.ShdwPnlCar.Name = "ShdwPnlCar";
            this.ShdwPnlCar.Radius = 5;
            this.ShdwPnlCar.ShadowColor = System.Drawing.Color.Black;
            this.ShdwPnlCar.ShadowDepth = 50;
            this.ShdwPnlCar.Size = new System.Drawing.Size(275, 415);
            this.ShdwPnlCar.TabIndex = 0;
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
            this.BtnAddToCart.Location = new System.Drawing.Point(210, 18);
            this.BtnAddToCart.Name = "BtnAddToCart";
            this.BtnAddToCart.Size = new System.Drawing.Size(50, 50);
            this.BtnAddToCart.TabIndex = 8;
            this.BtnAddToCart.UseTransparentBackground = true;
            this.BtnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
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
            this.BtnQuickOrder.Location = new System.Drawing.Point(13, 358);
            this.BtnQuickOrder.Name = "BtnQuickOrder";
            this.BtnQuickOrder.Size = new System.Drawing.Size(121, 36);
            this.BtnQuickOrder.TabIndex = 7;
            this.BtnQuickOrder.Text = "Quick Order";
            this.BtnQuickOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
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
            this.BtnViewMore.Location = new System.Drawing.Point(140, 358);
            this.BtnViewMore.Name = "BtnViewMore";
            this.BtnViewMore.Size = new System.Drawing.Size(121, 36);
            this.BtnViewMore.TabIndex = 5;
            this.BtnViewMore.Text = "View More";
            this.BtnViewMore.Click += new System.EventHandler(this.BtnViewMore_Click);
            // 
            // LblPrice
            // 
            this.LblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.ForeColor = System.Drawing.Color.Green;
            this.LblPrice.Location = new System.Drawing.Point(31, 302);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(51, 25);
            this.LblPrice.TabIndex = 4;
            this.LblPrice.Text = "Price";
            // 
            // LblYear
            // 
            this.LblYear.BackColor = System.Drawing.Color.Transparent;
            this.LblYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYear.Location = new System.Drawing.Point(210, 252);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(37, 20);
            this.LblYear.TabIndex = 3;
            this.LblYear.Text = "Year";
            // 
            // LblModel
            // 
            this.LblModel.BackColor = System.Drawing.Color.Transparent;
            this.LblModel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModel.Location = new System.Drawing.Point(116, 251);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(65, 25);
            this.LblModel.TabIndex = 2;
            this.LblModel.Text = "Model";
            // 
            // LblBrand
            // 
            this.LblBrand.BackColor = System.Drawing.Color.Transparent;
            this.LblBrand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrand.Location = new System.Drawing.Point(31, 251);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(59, 25);
            this.LblBrand.TabIndex = 1;
            this.LblBrand.Text = "Brand";
            // 
            // PicBoxCar
            // 
            this.PicBoxCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxCar.BorderRadius = 5;
            this.PicBoxCar.FillColor = System.Drawing.Color.Gainsboro;
            this.PicBoxCar.ImageRotate = 0F;
            this.PicBoxCar.Location = new System.Drawing.Point(7, 8);
            this.PicBoxCar.Name = "PicBoxCar";
            this.PicBoxCar.Size = new System.Drawing.Size(261, 208);
            this.PicBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxCar.TabIndex = 0;
            this.PicBoxCar.TabStop = false;
            // 
            // CarCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ShdwPnlCar);
            this.Name = "CarCard";
            this.Size = new System.Drawing.Size(292, 424);
            this.ShdwPnlCar.ResumeLayout(false);
            this.ShdwPnlCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ShdwPnlCar;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxCar;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblModel;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrand;
        private Guna.UI2.WinForms.Guna2Button BtnViewMore;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblYear;
        private Guna.UI2.WinForms.Guna2Button BtnQuickOrder;
        private Guna.UI2.WinForms.Guna2Button BtnAddToCart;
    }
}
