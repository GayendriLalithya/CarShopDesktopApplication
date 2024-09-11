namespace ADCoursework1.GUI.Customer.Controller
{
    partial class ViewCart
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
            this.ShdwPnlCart = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flwPnlCart = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlTotal = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClearCart = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.LblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblTotalAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ShdwPnlCart.SuspendLayout();
            this.PnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShdwPnlCart
            // 
            this.ShdwPnlCart.BackColor = System.Drawing.Color.Transparent;
            this.ShdwPnlCart.Controls.Add(this.flwPnlCart);
            this.ShdwPnlCart.Controls.Add(this.PnlTotal);
            this.ShdwPnlCart.Controls.Add(this.guna2HtmlLabel2);
            this.ShdwPnlCart.FillColor = System.Drawing.Color.White;
            this.ShdwPnlCart.Location = new System.Drawing.Point(286, 57);
            this.ShdwPnlCart.Name = "ShdwPnlCart";
            this.ShdwPnlCart.Radius = 5;
            this.ShdwPnlCart.ShadowColor = System.Drawing.Color.Black;
            this.ShdwPnlCart.Size = new System.Drawing.Size(1103, 767);
            this.ShdwPnlCart.TabIndex = 0;
            // 
            // flwPnlCart
            // 
            this.flwPnlCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flwPnlCart.AutoScroll = true;
            this.flwPnlCart.Location = new System.Drawing.Point(116, 118);
            this.flwPnlCart.Name = "flwPnlCart";
            this.flwPnlCart.Size = new System.Drawing.Size(870, 531);
            this.flwPnlCart.TabIndex = 12;
            // 
            // PnlTotal
            // 
            this.PnlTotal.BackColor = System.Drawing.Color.Lavender;
            this.PnlTotal.Controls.Add(this.BtnClearCart);
            this.PnlTotal.Controls.Add(this.BtnPlaceOrder);
            this.PnlTotal.Controls.Add(this.LblTotal);
            this.PnlTotal.Controls.Add(this.LblTotalAmount);
            this.PnlTotal.Location = new System.Drawing.Point(117, 668);
            this.PnlTotal.Name = "PnlTotal";
            this.PnlTotal.Size = new System.Drawing.Size(870, 62);
            this.PnlTotal.TabIndex = 11;
            // 
            // BtnClearCart
            // 
            this.BtnClearCart.BorderRadius = 5;
            this.BtnClearCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClearCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClearCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClearCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClearCart.FillColor = System.Drawing.Color.Red;
            this.BtnClearCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnClearCart.ForeColor = System.Drawing.Color.White;
            this.BtnClearCart.Location = new System.Drawing.Point(481, 13);
            this.BtnClearCart.Name = "BtnClearCart";
            this.BtnClearCart.Size = new System.Drawing.Size(170, 36);
            this.BtnClearCart.TabIndex = 21;
            this.BtnClearCart.Text = "Clear Cart";
            this.BtnClearCart.Click += new System.EventHandler(this.BtnClearCart_Click);
            // 
            // BtnPlaceOrder
            // 
            this.BtnPlaceOrder.BorderRadius = 5;
            this.BtnPlaceOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPlaceOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPlaceOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPlaceOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPlaceOrder.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.BtnPlaceOrder.Location = new System.Drawing.Point(677, 13);
            this.BtnPlaceOrder.Name = "BtnPlaceOrder";
            this.BtnPlaceOrder.Size = new System.Drawing.Size(176, 36);
            this.BtnPlaceOrder.TabIndex = 9;
            this.BtnPlaceOrder.Text = "Place Order";
            this.BtnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(144, 24);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(44, 21);
            this.LblTotal.TabIndex = 1;
            this.LblTotal.Text = "Price";
            // 
            // LblTotalAmount
            // 
            this.LblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalAmount.Location = new System.Drawing.Point(19, 24);
            this.LblTotalAmount.Name = "LblTotalAmount";
            this.LblTotalAmount.Size = new System.Drawing.Size(119, 21);
            this.LblTotalAmount.TabIndex = 0;
            this.LblTotalAmount.Text = "Total Amount :";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(482, 57);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(130, 41);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "My Cart";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShdwPnlCart);
            this.Name = "ViewCart";
            this.Size = new System.Drawing.Size(1644, 857);
            this.Load += new System.EventHandler(this.ViewCart_Load);
            this.ShdwPnlCart.ResumeLayout(false);
            this.ShdwPnlCart.PerformLayout();
            this.PnlTotal.ResumeLayout(false);
            this.PnlTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ShdwPnlCart;
        private Guna.UI2.WinForms.Guna2Panel PnlTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTotalAmount;
        private Guna.UI2.WinForms.Guna2Button BtnPlaceOrder;
        private System.Windows.Forms.FlowLayoutPanel flwPnlCart;
        private Guna.UI2.WinForms.Guna2Button BtnClearCart;
    }
}
