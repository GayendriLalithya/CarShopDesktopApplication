namespace ADCoursework1.GUI.Customer
{
    partial class CustomerDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BorderlessFormCustomerDashboard = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.CtrlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ImgBtnHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ImgBtnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PicBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TbControlCustomer = new Guna.UI2.WinForms.Guna2TabControl();
            this.TbPageDashboard = new System.Windows.Forms.TabPage();
            this.TbPageCart = new System.Windows.Forms.TabPage();
            this.TbPageOrder = new System.Windows.Forms.TabPage();
            this.TbPageProfile = new System.Windows.Forms.TabPage();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.TbControlCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessFormCustomerDashboard
            // 
            this.BorderlessFormCustomerDashboard.ContainerControl = this;
            this.BorderlessFormCustomerDashboard.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormCustomerDashboard.TransparentWhileDrag = true;
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PnlTop.Controls.Add(this.CtrlBox);
            this.PnlTop.Controls.Add(this.ImgBtnHome);
            this.PnlTop.Controls.Add(this.ImgBtnLogout);
            this.PnlTop.Controls.Add(this.PicBoxLogo);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1485, 135);
            this.PnlTop.TabIndex = 4;
            // 
            // CtrlBox
            // 
            this.CtrlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlBox.BorderRadius = 5;
            this.CtrlBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.CtrlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.CtrlBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CtrlBox.CustomIconSize = 15F;
            this.CtrlBox.FillColor = System.Drawing.Color.Transparent;
            this.CtrlBox.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.CtrlBox.HoverState.IconColor = System.Drawing.Color.White;
            this.CtrlBox.IconColor = System.Drawing.Color.White;
            this.CtrlBox.Location = new System.Drawing.Point(1326, 36);
            this.CtrlBox.Name = "CtrlBox";
            this.CtrlBox.PressedColor = System.Drawing.Color.Navy;
            this.CtrlBox.Size = new System.Drawing.Size(45, 45);
            this.CtrlBox.TabIndex = 11;
            // 
            // ImgBtnHome
            // 
            this.ImgBtnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgBtnHome.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImgBtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgBtnHome.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.ImgBtnHome.Image = global::ADCoursework1.Properties.Resources.home_white;
            this.ImgBtnHome.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImgBtnHome.ImageRotate = 0F;
            this.ImgBtnHome.ImageSize = new System.Drawing.Size(30, 30);
            this.ImgBtnHome.Location = new System.Drawing.Point(1253, 36);
            this.ImgBtnHome.Name = "ImgBtnHome";
            this.ImgBtnHome.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.ImgBtnHome.Size = new System.Drawing.Size(45, 45);
            this.ImgBtnHome.TabIndex = 5;
            this.ImgBtnHome.Click += new System.EventHandler(this.ImgBtnHome_Click);
            // 
            // ImgBtnLogout
            // 
            this.ImgBtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgBtnLogout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImgBtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgBtnLogout.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.ImgBtnLogout.Image = global::ADCoursework1.Properties.Resources.logout_white;
            this.ImgBtnLogout.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImgBtnLogout.ImageRotate = 0F;
            this.ImgBtnLogout.ImageSize = new System.Drawing.Size(45, 45);
            this.ImgBtnLogout.Location = new System.Drawing.Point(1395, 36);
            this.ImgBtnLogout.Name = "ImgBtnLogout";
            this.ImgBtnLogout.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.ImgBtnLogout.Size = new System.Drawing.Size(45, 45);
            this.ImgBtnLogout.TabIndex = 4;
            this.ImgBtnLogout.Click += new System.EventHandler(this.ImgBtnLogout_Click);
            // 
            // PicBoxLogo
            // 
            this.PicBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxLogo.Image = global::ADCoursework1.Properties.Resources.Logo_white;
            this.PicBoxLogo.ImageRotate = 0F;
            this.PicBoxLogo.Location = new System.Drawing.Point(-22, 0);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Size = new System.Drawing.Size(346, 135);
            this.PicBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxLogo.TabIndex = 2;
            this.PicBoxLogo.TabStop = false;
            // 
            // TbControlCustomer
            // 
            this.TbControlCustomer.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TbControlCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbControlCustomer.Controls.Add(this.TbPageDashboard);
            this.TbControlCustomer.Controls.Add(this.TbPageCart);
            this.TbControlCustomer.Controls.Add(this.TbPageOrder);
            this.TbControlCustomer.Controls.Add(this.TbPageProfile);
            this.TbControlCustomer.ItemSize = new System.Drawing.Size(300, 100);
            this.TbControlCustomer.Location = new System.Drawing.Point(0, 135);
            this.TbControlCustomer.Name = "TbControlCustomer";
            this.TbControlCustomer.SelectedIndex = 0;
            this.TbControlCustomer.Size = new System.Drawing.Size(1485, 867);
            this.TbControlCustomer.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TbControlCustomer.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TbControlCustomer.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbControlCustomer.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TbControlCustomer.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TbControlCustomer.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TbControlCustomer.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TbControlCustomer.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbControlCustomer.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TbControlCustomer.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TbControlCustomer.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TbControlCustomer.TabButtonSelectedState.FillColor = System.Drawing.Color.Lavender;
            this.TbControlCustomer.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbControlCustomer.TabButtonSelectedState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TbControlCustomer.TabButtonSelectedState.InnerColor = System.Drawing.SystemColors.Highlight;
            this.TbControlCustomer.TabButtonSize = new System.Drawing.Size(300, 100);
            this.TbControlCustomer.TabIndex = 6;
            this.TbControlCustomer.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // TbPageDashboard
            // 
            this.TbPageDashboard.Location = new System.Drawing.Point(304, 4);
            this.TbPageDashboard.Name = "TbPageDashboard";
            this.TbPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.TbPageDashboard.Size = new System.Drawing.Size(1177, 859);
            this.TbPageDashboard.TabIndex = 0;
            this.TbPageDashboard.Text = "Dashboard";
            this.TbPageDashboard.UseVisualStyleBackColor = true;
            // 
            // TbPageCart
            // 
            this.TbPageCart.Location = new System.Drawing.Point(304, 4);
            this.TbPageCart.Name = "TbPageCart";
            this.TbPageCart.Size = new System.Drawing.Size(1177, 859);
            this.TbPageCart.TabIndex = 1;
            this.TbPageCart.Text = "View Cart";
            this.TbPageCart.UseVisualStyleBackColor = true;
            // 
            // TbPageOrder
            // 
            this.TbPageOrder.Location = new System.Drawing.Point(304, 4);
            this.TbPageOrder.Name = "TbPageOrder";
            this.TbPageOrder.Size = new System.Drawing.Size(1177, 859);
            this.TbPageOrder.TabIndex = 2;
            this.TbPageOrder.Text = "View Orders";
            this.TbPageOrder.UseVisualStyleBackColor = true;
            // 
            // TbPageProfile
            // 
            this.TbPageProfile.Location = new System.Drawing.Point(304, 4);
            this.TbPageProfile.Name = "TbPageProfile";
            this.TbPageProfile.Size = new System.Drawing.Size(1177, 859);
            this.TbPageProfile.TabIndex = 4;
            this.TbPageProfile.Text = "My Profile";
            this.TbPageProfile.UseVisualStyleBackColor = true;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 953);
            this.Controls.Add(this.TbControlCustomer);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.TbControlCustomer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormCustomerDashboard;
        private Guna.UI2.WinForms.Guna2Panel PnlTop;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxLogo;
        private Guna.UI2.WinForms.Guna2TabControl TbControlCustomer;
        private System.Windows.Forms.TabPage TbPageDashboard;
        private System.Windows.Forms.TabPage TbPageCart;
        private System.Windows.Forms.TabPage TbPageOrder;
        private System.Windows.Forms.TabPage TbPageProfile;
        private Guna.UI2.WinForms.Guna2ImageButton ImgBtnLogout;
        private Guna.UI2.WinForms.Guna2ImageButton ImgBtnHome;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBox;
    }
}