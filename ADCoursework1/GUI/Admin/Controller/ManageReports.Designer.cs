namespace ADCoursework1.GUI.Admin.Controller
{
    partial class ManageReports
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
            this.TbCtrlReports = new Guna.UI2.WinForms.Guna2TabControl();
            this.TbPageFinance = new System.Windows.Forms.TabPage();
            this.TbPageDailyIncome = new System.Windows.Forms.TabPage();
            this.TbPageInventory = new System.Windows.Forms.TabPage();
            this.TbPageOrder = new System.Windows.Forms.TabPage();
            this.TbCtrlReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbCtrlReports
            // 
            this.TbCtrlReports.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TbCtrlReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbCtrlReports.Controls.Add(this.TbPageFinance);
            this.TbCtrlReports.Controls.Add(this.TbPageDailyIncome);
            this.TbCtrlReports.Controls.Add(this.TbPageInventory);
            this.TbCtrlReports.Controls.Add(this.TbPageOrder);
            this.TbCtrlReports.ItemSize = new System.Drawing.Size(200, 50);
            this.TbCtrlReports.Location = new System.Drawing.Point(0, 0);
            this.TbCtrlReports.Name = "TbCtrlReports";
            this.TbCtrlReports.SelectedIndex = 0;
            this.TbCtrlReports.Size = new System.Drawing.Size(1644, 857);
            this.TbCtrlReports.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TbCtrlReports.TabButtonHoverState.FillColor = System.Drawing.Color.Lavender;
            this.TbCtrlReports.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCtrlReports.TabButtonHoverState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TbCtrlReports.TabButtonHoverState.InnerColor = System.Drawing.Color.Lavender;
            this.TbCtrlReports.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TbCtrlReports.TabButtonIdleState.FillColor = System.Drawing.Color.Lavender;
            this.TbCtrlReports.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCtrlReports.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.TbCtrlReports.TabButtonIdleState.InnerColor = System.Drawing.Color.Lavender;
            this.TbCtrlReports.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TbCtrlReports.TabButtonSelectedState.FillColor = System.Drawing.Color.Lavender;
            this.TbCtrlReports.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.TbCtrlReports.TabButtonSelectedState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TbCtrlReports.TabButtonSelectedState.InnerColor = System.Drawing.SystemColors.Highlight;
            this.TbCtrlReports.TabButtonSize = new System.Drawing.Size(200, 50);
            this.TbCtrlReports.TabIndex = 0;
            this.TbCtrlReports.TabMenuBackColor = System.Drawing.Color.Lavender;
            this.TbCtrlReports.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalBottom;
            // 
            // TbPageFinance
            // 
            this.TbPageFinance.Location = new System.Drawing.Point(4, 4);
            this.TbPageFinance.Name = "TbPageFinance";
            this.TbPageFinance.Padding = new System.Windows.Forms.Padding(3);
            this.TbPageFinance.Size = new System.Drawing.Size(1636, 799);
            this.TbPageFinance.TabIndex = 0;
            this.TbPageFinance.Text = "Financial Report";
            this.TbPageFinance.UseVisualStyleBackColor = true;
            // 
            // TbPageDailyIncome
            // 
            this.TbPageDailyIncome.Location = new System.Drawing.Point(4, 4);
            this.TbPageDailyIncome.Name = "TbPageDailyIncome";
            this.TbPageDailyIncome.Padding = new System.Windows.Forms.Padding(3);
            this.TbPageDailyIncome.Size = new System.Drawing.Size(1617, 784);
            this.TbPageDailyIncome.TabIndex = 1;
            this.TbPageDailyIncome.Text = "Daily Income Report";
            this.TbPageDailyIncome.UseVisualStyleBackColor = true;
            // 
            // TbPageInventory
            // 
            this.TbPageInventory.Location = new System.Drawing.Point(4, 4);
            this.TbPageInventory.Name = "TbPageInventory";
            this.TbPageInventory.Size = new System.Drawing.Size(1617, 784);
            this.TbPageInventory.TabIndex = 2;
            this.TbPageInventory.Text = "Inventory Status";
            this.TbPageInventory.UseVisualStyleBackColor = true;
            // 
            // TbPageOrder
            // 
            this.TbPageOrder.Location = new System.Drawing.Point(4, 4);
            this.TbPageOrder.Name = "TbPageOrder";
            this.TbPageOrder.Size = new System.Drawing.Size(1636, 799);
            this.TbPageOrder.TabIndex = 3;
            this.TbPageOrder.Text = "Order Quantity Status";
            this.TbPageOrder.UseVisualStyleBackColor = true;
            // 
            // ManageReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TbCtrlReports);
            this.Name = "ManageReports";
            this.Size = new System.Drawing.Size(1644, 857);
            this.TbCtrlReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl TbCtrlReports;
        private System.Windows.Forms.TabPage TbPageFinance;
        private System.Windows.Forms.TabPage TbPageDailyIncome;
        private System.Windows.Forms.TabPage TbPageInventory;
        private System.Windows.Forms.TabPage TbPageOrder;
    }
}
