namespace ADCoursework1.GUI.Customer.Controller.DashboardCustomer
{
    partial class MostPurchasedBrand
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
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.LblBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PicBoxBrand = new System.Windows.Forms.PictureBox();
            this.LblPurchaseHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.LblBrand);
            this.guna2ShadowPanel3.Controls.Add(this.PicBoxBrand);
            this.guna2ShadowPanel3.Controls.Add(this.LblPurchaseHeading);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(10, 15);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.Radius = 5;
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.SystemColors.Highlight;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(491, 353);
            this.guna2ShadowPanel3.TabIndex = 31;
            // 
            // LblBrand
            // 
            this.LblBrand.AutoSize = false;
            this.LblBrand.BackColor = System.Drawing.Color.Transparent;
            this.LblBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrand.Location = new System.Drawing.Point(136, 284);
            this.LblBrand.Name = "LblBrand";
            this.LblBrand.Size = new System.Drawing.Size(216, 30);
            this.LblBrand.TabIndex = 24;
            this.LblBrand.Text = "Brand Name";
            this.LblBrand.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBoxBrand
            // 
            this.PicBoxBrand.Location = new System.Drawing.Point(136, 81);
            this.PicBoxBrand.Name = "PicBoxBrand";
            this.PicBoxBrand.Size = new System.Drawing.Size(216, 183);
            this.PicBoxBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxBrand.TabIndex = 23;
            this.PicBoxBrand.TabStop = false;
            // 
            // LblPurchaseHeading
            // 
            this.LblPurchaseHeading.BackColor = System.Drawing.Color.Transparent;
            this.LblPurchaseHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPurchaseHeading.Location = new System.Drawing.Point(136, 25);
            this.LblPurchaseHeading.Name = "LblPurchaseHeading";
            this.LblPurchaseHeading.Size = new System.Drawing.Size(216, 30);
            this.LblPurchaseHeading.TabIndex = 22;
            this.LblPurchaseHeading.Text = "Most Purchased Brand";
            // 
            // MostPurchasedBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel3);
            this.Name = "MostPurchasedBrand";
            this.Size = new System.Drawing.Size(512, 381);
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrand;
        private System.Windows.Forms.PictureBox PicBoxBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPurchaseHeading;
    }
}
