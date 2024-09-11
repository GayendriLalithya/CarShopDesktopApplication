namespace ADCoursework1.GUI.Customer.Controller
{
    partial class CustomerControl
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
            this.FlwPnlSpendingOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.FlwPnlCustomerRank = new System.Windows.Forms.FlowLayoutPanel();
            this.FlwPnlBrand = new System.Windows.Forms.FlowLayoutPanel();
            this.FlwPnlOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlwPnlSpendingOverview
            // 
            this.FlwPnlSpendingOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwPnlSpendingOverview.Location = new System.Drawing.Point(19, 23);
            this.FlwPnlSpendingOverview.Name = "FlwPnlSpendingOverview";
            this.FlwPnlSpendingOverview.Size = new System.Drawing.Size(1104, 405);
            this.FlwPnlSpendingOverview.TabIndex = 31;
            // 
            // FlwPnlCustomerRank
            // 
            this.FlwPnlCustomerRank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwPnlCustomerRank.Location = new System.Drawing.Point(1129, 23);
            this.FlwPnlCustomerRank.Name = "FlwPnlCustomerRank";
            this.FlwPnlCustomerRank.Size = new System.Drawing.Size(490, 405);
            this.FlwPnlCustomerRank.TabIndex = 32;
            // 
            // FlwPnlBrand
            // 
            this.FlwPnlBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwPnlBrand.Location = new System.Drawing.Point(19, 446);
            this.FlwPnlBrand.Name = "FlwPnlBrand";
            this.FlwPnlBrand.Size = new System.Drawing.Size(512, 381);
            this.FlwPnlBrand.TabIndex = 33;
            // 
            // FlwPnlOrder
            // 
            this.FlwPnlOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwPnlOrder.Location = new System.Drawing.Point(557, 446);
            this.FlwPnlOrder.Name = "FlwPnlOrder";
            this.FlwPnlOrder.Size = new System.Drawing.Size(1062, 381);
            this.FlwPnlOrder.TabIndex = 34;
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlwPnlOrder);
            this.Controls.Add(this.FlwPnlBrand);
            this.Controls.Add(this.FlwPnlCustomerRank);
            this.Controls.Add(this.FlwPnlSpendingOverview);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(1644, 863);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlwPnlSpendingOverview;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlCustomerRank;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlBrand;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlOrder;
    }
}
