namespace ADCoursework1.GUI.Customer.Controller
{
    partial class CarPartCartItem
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
            this.ShdwPnlCarPartCart = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.LblItemCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPartNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPartPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblCarPartNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPartName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.PicBoxCarPart = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NmrcUpDwnQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ShdwPnlCarPartCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCarPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // ShdwPnlCarPartCart
            // 
            this.ShdwPnlCarPartCart.BackColor = System.Drawing.Color.Transparent;
            this.ShdwPnlCarPartCart.Controls.Add(this.NmrcUpDwnQuantity);
            this.ShdwPnlCarPartCart.Controls.Add(this.LblItemCount);
            this.ShdwPnlCarPartCart.Controls.Add(this.LblPrice);
            this.ShdwPnlCarPartCart.Controls.Add(this.LblPartNo);
            this.ShdwPnlCarPartCart.Controls.Add(this.LblPartPrice);
            this.ShdwPnlCarPartCart.Controls.Add(this.LblCarPartNumber);
            this.ShdwPnlCarPartCart.Controls.Add(this.LblPartName);
            this.ShdwPnlCarPartCart.Controls.Add(this.LblBrand);
            this.ShdwPnlCarPartCart.Controls.Add(this.BtnDelete);
            this.ShdwPnlCarPartCart.Controls.Add(this.PicBoxCarPart);
            this.ShdwPnlCarPartCart.FillColor = System.Drawing.Color.White;
            this.ShdwPnlCarPartCart.Location = new System.Drawing.Point(14, 15);
            this.ShdwPnlCarPartCart.Name = "ShdwPnlCarPartCart";
            this.ShdwPnlCarPartCart.Radius = 5;
            this.ShdwPnlCarPartCart.ShadowColor = System.Drawing.Color.Black;
            this.ShdwPnlCarPartCart.Size = new System.Drawing.Size(805, 314);
            this.ShdwPnlCarPartCart.TabIndex = 2;
            // 
            // LblItemCount
            // 
            this.LblItemCount.BackColor = System.Drawing.Color.Transparent;
            this.LblItemCount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemCount.Location = new System.Drawing.Point(375, 169);
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
            this.LblPrice.Location = new System.Drawing.Point(493, 226);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(40, 20);
            this.LblPrice.TabIndex = 7;
            this.LblPrice.Text = "Price";
            // 
            // LblPartNo
            // 
            this.LblPartNo.BackColor = System.Drawing.Color.Transparent;
            this.LblPartNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPartNo.Location = new System.Drawing.Point(493, 119);
            this.LblPartNo.Name = "LblPartNo";
            this.LblPartNo.Size = new System.Drawing.Size(93, 20);
            this.LblPartNo.TabIndex = 6;
            this.LblPartNo.Text = "Part Number";
            // 
            // LblPartPrice
            // 
            this.LblPartPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPartPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblPartPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPartPrice.Location = new System.Drawing.Point(375, 226);
            this.LblPartPrice.Name = "LblPartPrice";
            this.LblPartPrice.Size = new System.Drawing.Size(48, 20);
            this.LblPartPrice.TabIndex = 5;
            this.LblPartPrice.Text = "Price :";
            // 
            // LblCarPartNumber
            // 
            this.LblCarPartNumber.BackColor = System.Drawing.Color.Transparent;
            this.LblCarPartNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarPartNumber.Location = new System.Drawing.Point(375, 119);
            this.LblCarPartNumber.Name = "LblCarPartNumber";
            this.LblCarPartNumber.Size = new System.Drawing.Size(101, 20);
            this.LblCarPartNumber.TabIndex = 4;
            this.LblCarPartNumber.Text = "Part Number :";
            // 
            // LblPartName
            // 
            this.LblPartName.BackColor = System.Drawing.Color.Transparent;
            this.LblPartName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPartName.Location = new System.Drawing.Point(468, 57);
            this.LblPartName.Name = "LblPartName";
            this.LblPartName.Size = new System.Drawing.Size(89, 21);
            this.LblPartName.TabIndex = 3;
            this.LblPartName.Text = "Part Name";
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
            // PicBoxCarPart
            // 
            this.PicBoxCarPart.FillColor = System.Drawing.Color.Gainsboro;
            this.PicBoxCarPart.ImageRotate = 0F;
            this.PicBoxCarPart.Location = new System.Drawing.Point(15, 16);
            this.PicBoxCarPart.Name = "PicBoxCarPart";
            this.PicBoxCarPart.Size = new System.Drawing.Size(306, 282);
            this.PicBoxCarPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxCarPart.TabIndex = 0;
            this.PicBoxCarPart.TabStop = false;
            // 
            // NmrcUpDwnQuantity
            // 
            this.NmrcUpDwnQuantity.BackColor = System.Drawing.Color.Transparent;
            this.NmrcUpDwnQuantity.BorderRadius = 5;
            this.NmrcUpDwnQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NmrcUpDwnQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NmrcUpDwnQuantity.Location = new System.Drawing.Point(494, 163);
            this.NmrcUpDwnQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmrcUpDwnQuantity.Name = "NmrcUpDwnQuantity";
            this.NmrcUpDwnQuantity.Size = new System.Drawing.Size(82, 36);
            this.NmrcUpDwnQuantity.TabIndex = 39;
            this.NmrcUpDwnQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.NmrcUpDwnQuantity.UpDownButtonForeColor = System.Drawing.Color.White;
            this.NmrcUpDwnQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CarPartCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ShdwPnlCarPartCart);
            this.Name = "CarPartCartItem";
            this.Size = new System.Drawing.Size(839, 345);
            this.ShdwPnlCarPartCart.ResumeLayout(false);
            this.ShdwPnlCarPartCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCarPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcUpDwnQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ShdwPnlCarPartCart;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblItemCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPartNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPartPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCarPartNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPartName;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrand;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxCarPart;
        private Guna.UI2.WinForms.Guna2NumericUpDown NmrcUpDwnQuantity;
    }
}
