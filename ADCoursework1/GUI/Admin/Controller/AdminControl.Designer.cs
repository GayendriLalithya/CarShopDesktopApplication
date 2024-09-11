namespace ADCoursework1.GUI.Admin.Controller
{
    partial class AdminControl
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
            this.FlwPnlStockOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.FlwPnlTopSalse = new System.Windows.Forms.FlowLayoutPanel();
            this.FlwPnlCustomer = new System.Windows.Forms.FlowLayoutPanel();
            this.FlwPnlSalesOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlwPnlStockOverview
            // 
            this.FlwPnlStockOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwPnlStockOverview.Location = new System.Drawing.Point(27, 17);
            this.FlwPnlStockOverview.Name = "FlwPnlStockOverview";
            this.FlwPnlStockOverview.Size = new System.Drawing.Size(559, 391);
            this.FlwPnlStockOverview.TabIndex = 26;
            // 
            // FlwPnlTopSalse
            // 
            this.FlwPnlTopSalse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwPnlTopSalse.Location = new System.Drawing.Point(610, 17);
            this.FlwPnlTopSalse.Name = "FlwPnlTopSalse";
            this.FlwPnlTopSalse.Size = new System.Drawing.Size(990, 391);
            this.FlwPnlTopSalse.TabIndex = 27;
            // 
            // FlwPnlCustomer
            // 
            this.FlwPnlCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwPnlCustomer.Location = new System.Drawing.Point(985, 434);
            this.FlwPnlCustomer.Name = "FlwPnlCustomer";
            this.FlwPnlCustomer.Size = new System.Drawing.Size(615, 388);
            this.FlwPnlCustomer.TabIndex = 28;
            // 
            // FlwPnlSalesOverview
            // 
            this.FlwPnlSalesOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FlwPnlSalesOverview.Location = new System.Drawing.Point(27, 434);
            this.FlwPnlSalesOverview.Name = "FlwPnlSalesOverview";
            this.FlwPnlSalesOverview.Size = new System.Drawing.Size(937, 388);
            this.FlwPnlSalesOverview.TabIndex = 29;
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlwPnlSalesOverview);
            this.Controls.Add(this.FlwPnlCustomer);
            this.Controls.Add(this.FlwPnlTopSalse);
            this.Controls.Add(this.FlwPnlStockOverview);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1644, 857);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FlwPnlStockOverview;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlTopSalse;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlCustomer;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlSalesOverview;
    }
}
