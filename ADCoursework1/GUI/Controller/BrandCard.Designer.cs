namespace ADCoursework1.GUI.Controller
{
    partial class BrandCard
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
            this.ShdwPnlBrand = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.PicBoxBrand = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LblBrandName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ShdwPnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // ShdwPnlBrand
            // 
            this.ShdwPnlBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShdwPnlBrand.BackColor = System.Drawing.Color.Transparent;
            this.ShdwPnlBrand.Controls.Add(this.PicBoxBrand);
            this.ShdwPnlBrand.FillColor = System.Drawing.Color.White;
            this.ShdwPnlBrand.Location = new System.Drawing.Point(15, 14);
            this.ShdwPnlBrand.Name = "ShdwPnlBrand";
            this.ShdwPnlBrand.Radius = 5;
            this.ShdwPnlBrand.ShadowColor = System.Drawing.Color.Black;
            this.ShdwPnlBrand.ShadowDepth = 20;
            this.ShdwPnlBrand.Size = new System.Drawing.Size(137, 123);
            this.ShdwPnlBrand.TabIndex = 0;
            // 
            // PicBoxBrand
            // 
            this.PicBoxBrand.BorderRadius = 5;
            this.PicBoxBrand.FillColor = System.Drawing.Color.Gainsboro;
            this.PicBoxBrand.ImageRotate = 0F;
            this.PicBoxBrand.Location = new System.Drawing.Point(15, 14);
            this.PicBoxBrand.Name = "PicBoxBrand";
            this.PicBoxBrand.Size = new System.Drawing.Size(108, 95);
            this.PicBoxBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxBrand.TabIndex = 0;
            this.PicBoxBrand.TabStop = false;
            // 
            // LblBrandName
            // 
            this.LblBrandName.AutoSize = false;
            this.LblBrandName.AutoSizeHeightOnly = true;
            this.LblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.LblBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrandName.Location = new System.Drawing.Point(15, 150);
            this.LblBrandName.Name = "LblBrandName";
            this.LblBrandName.Size = new System.Drawing.Size(137, 17);
            this.LblBrandName.TabIndex = 1;
            this.LblBrandName.Text = "Brand";
            this.LblBrandName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrandCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblBrandName);
            this.Controls.Add(this.ShdwPnlBrand);
            this.Name = "BrandCard";
            this.Size = new System.Drawing.Size(171, 175);
            this.ShdwPnlBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBrand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ShdwPnlBrand;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrandName;
    }
}
