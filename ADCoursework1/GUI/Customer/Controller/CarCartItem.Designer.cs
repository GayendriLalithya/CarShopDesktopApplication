namespace ADCoursework1.GUI.Customer.Controller
{
    partial class CarCartItem
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
            this.ShdwPnlCarCart = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.LblItemCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblCarPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblCarYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblModel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.PicBoxCar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NmrcUpDwnQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ShdwPnlCarCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // ShdwPnlCarCart
            // 
            this.ShdwPnlCarCart.BackColor = System.Drawing.Color.Transparent;
            this.ShdwPnlCarCart.Controls.Add(this.NmrcUpDwnQuantity);
            this.ShdwPnlCarCart.Controls.Add(this.LblItemCount);
            this.ShdwPnlCarCart.Controls.Add(this.LblPrice);
            this.ShdwPnlCarCart.Controls.Add(this.LblYear);
            this.ShdwPnlCarCart.Controls.Add(this.LblCarPrice);
            this.ShdwPnlCarCart.Controls.Add(this.LblCarYear);
            this.ShdwPnlCarCart.Controls.Add(this.LblModel);
            this.ShdwPnlCarCart.Controls.Add(this.LblBrand);
            this.ShdwPnlCarCart.Controls.Add(this.BtnDelete);
            this.ShdwPnlCarCart.Controls.Add(this.PicBoxCar);
            this.ShdwPnlCarCart.FillColor = System.Drawing.Color.White;
            this.ShdwPnlCarCart.Location = new System.Drawing.Point(14, 15);
            this.ShdwPnlCarCart.Name = "ShdwPnlCarCart";
            this.ShdwPnlCarCart.Radius = 5;
            this.ShdwPnlCarCart.ShadowColor = System.Drawing.Color.Black;
            this.ShdwPnlCarCart.Size = new System.Drawing.Size(805, 314);
            this.ShdwPnlCarCart.TabIndex = 0;
            // 
            // LblItemCount
            // 
            this.LblItemCount.BackColor = System.Drawing.Color.Transparent;
            this.LblItemCount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemCount.Location = new System.Drawing.Point(375, 171);
            this.LblItemCount.Name = "LblItemCount";
            this.LblItemCount.Size = new System.Drawing.Size(73, 20);
            this.LblItemCount.TabIndex = 8;
            this.LblItemCount.Text = "Quantity :";
            // 
            // LblPrice
            // 
            this.LblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(468, 226);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(40, 20);
            this.LblPrice.TabIndex = 7;
            this.LblPrice.Text = "Price";
            // 
            // LblYear
            // 
            this.LblYear.BackColor = System.Drawing.Color.Transparent;
            this.LblYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYear.Location = new System.Drawing.Point(468, 119);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(37, 20);
            this.LblYear.TabIndex = 6;
            this.LblYear.Text = "Year";
            // 
            // LblCarPrice
            // 
            this.LblCarPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCarPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblCarPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarPrice.Location = new System.Drawing.Point(375, 226);
            this.LblCarPrice.Name = "LblCarPrice";
            this.LblCarPrice.Size = new System.Drawing.Size(48, 20);
            this.LblCarPrice.TabIndex = 5;
            this.LblCarPrice.Text = "Price :";
            // 
            // LblCarYear
            // 
            this.LblCarYear.BackColor = System.Drawing.Color.Transparent;
            this.LblCarYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarYear.Location = new System.Drawing.Point(375, 119);
            this.LblCarYear.Name = "LblCarYear";
            this.LblCarYear.Size = new System.Drawing.Size(45, 20);
            this.LblCarYear.TabIndex = 4;
            this.LblCarYear.Text = "Year :";
            // 
            // LblModel
            // 
            this.LblModel.BackColor = System.Drawing.Color.Transparent;
            this.LblModel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModel.Location = new System.Drawing.Point(468, 57);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(55, 21);
            this.LblModel.TabIndex = 3;
            this.LblModel.Text = "Model";
            // 
            // LblBrand
            // 
            this.LblBrand.BackColor = System.Drawing.Color.Transparent;
            this.LblBrand.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrand.Location = new System.Drawing.Point(375, 57);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(50, 21);
            this.LblBrand.TabIndex = 2;
            this.LblBrand.Text = "Brand";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BorderRadius = 5;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.FillColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Image = global::ADCoursework1.Properties.Resources.detete_white;
            this.BtnDelete.Location = new System.Drawing.Point(739, 253);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(45, 45);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // PicBoxCar
            // 
            this.PicBoxCar.FillColor = System.Drawing.Color.Gainsboro;
            this.PicBoxCar.ImageRotate = 0F;
            this.PicBoxCar.Location = new System.Drawing.Point(15, 16);
            this.PicBoxCar.Name = "PicBoxCar";
            this.PicBoxCar.Size = new System.Drawing.Size(306, 282);
            this.PicBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxCar.TabIndex = 0;
            this.PicBoxCar.TabStop = false;
            // 
            // NmrcUpDwnQuantity
            // 
            this.NmrcUpDwnQuantity.BackColor = System.Drawing.Color.Transparent;
            this.NmrcUpDwnQuantity.BorderRadius = 5;
            this.NmrcUpDwnQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NmrcUpDwnQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NmrcUpDwnQuantity.Location = new System.Drawing.Point(468, 163);
            this.NmrcUpDwnQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmrcUpDwnQuantity.Name = "NmrcUpDwnQuantity";
            this.NmrcUpDwnQuantity.Size = new System.Drawing.Size(82, 36);
            this.NmrcUpDwnQuantity.TabIndex = 38;
            this.NmrcUpDwnQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NmrcUpDwnQuantity.UpDownButtonForeColor = System.Drawing.Color.White;
            this.NmrcUpDwnQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CarCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShdwPnlCarCart);
            this.Name = "CarCartItem";
            this.Size = new System.Drawing.Size(839, 345);
            this.ShdwPnlCarCart.ResumeLayout(false);
            this.ShdwPnlCarCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ShdwPnlCarCart;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxCar;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblModel;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCarYear;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCarPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblItemCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblYear;
        private Guna.UI2.WinForms.Guna2NumericUpDown NmrcUpDwnQuantity;
    }
}
