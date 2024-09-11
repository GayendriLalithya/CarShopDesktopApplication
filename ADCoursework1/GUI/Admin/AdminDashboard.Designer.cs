namespace ADCoursework1.GUI.Admin
{
    partial class AdminDashboard
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
            this.BorderlessFormAdminDashboard = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ImgBtnHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ImgBtnLogout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PicBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TbControlAdmin = new Guna.UI2.WinForms.Guna2TabControl();
            this.TbPageDashboard = new System.Windows.Forms.TabPage();
            this.CtrlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TbPageBrand = new System.Windows.Forms.TabPage();
            this.TbPageCar = new System.Windows.Forms.TabPage();
            this.TbPageCarPart = new System.Windows.Forms.TabPage();
            this.TbPageUser = new System.Windows.Forms.TabPage();
            this.TbPageOrder = new System.Windows.Forms.TabPage();
            this.TbPageInventory = new System.Windows.Forms.TabPage();
            this.TbPageReports = new System.Windows.Forms.TabPage();
            this.TbPageProfile = new System.Windows.Forms.TabPage();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.TbControlAdmin.SuspendLayout();
            this.TbPageDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessFormAdminDashboard
            // 
            this.BorderlessFormAdminDashboard.ContainerControl = this;
            this.BorderlessFormAdminDashboard.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormAdminDashboard.TransparentWhileDrag = true;
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PnlTop.Controls.Add(this.guna2ControlBox1);
            this.PnlTop.Controls.Add(this.ImgBtnHome);
            this.PnlTop.Controls.Add(this.ImgBtnLogout);
            this.PnlTop.Controls.Add(this.PicBoxLogo);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1485, 135);
            this.PnlTop.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.CustomIconSize = 15F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1328, 36);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 45);
            this.guna2ControlBox1.TabIndex = 12;
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
            this.ImgBtnHome.TabIndex = 8;
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
            this.ImgBtnLogout.Location = new System.Drawing.Point(1397, 36);
            this.ImgBtnLogout.Name = "ImgBtnLogout";
            this.ImgBtnLogout.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.ImgBtnLogout.Size = new System.Drawing.Size(45, 45);
            this.ImgBtnLogout.TabIndex = 7;
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
            // TbControlAdmin
            // 
            this.TbControlAdmin.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TbControlAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbControlAdmin.Controls.Add(this.TbPageDashboard);
            this.TbControlAdmin.Controls.Add(this.TbPageBrand);
            this.TbControlAdmin.Controls.Add(this.TbPageCar);
            this.TbControlAdmin.Controls.Add(this.TbPageCarPart);
            this.TbControlAdmin.Controls.Add(this.TbPageUser);
            this.TbControlAdmin.Controls.Add(this.TbPageOrder);
            this.TbControlAdmin.Controls.Add(this.TbPageInventory);
            this.TbControlAdmin.Controls.Add(this.TbPageReports);
            this.TbControlAdmin.Controls.Add(this.TbPageProfile);
            this.TbControlAdmin.ItemSize = new System.Drawing.Size(300, 100);
            this.TbControlAdmin.Location = new System.Drawing.Point(0, 135);
            this.TbControlAdmin.Name = "TbControlAdmin";
            this.TbControlAdmin.SelectedIndex = 0;
            this.TbControlAdmin.Size = new System.Drawing.Size(1485, 967);
            this.TbControlAdmin.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TbControlAdmin.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TbControlAdmin.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbControlAdmin.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TbControlAdmin.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TbControlAdmin.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TbControlAdmin.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TbControlAdmin.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbControlAdmin.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TbControlAdmin.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TbControlAdmin.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TbControlAdmin.TabButtonSelectedState.FillColor = System.Drawing.Color.Lavender;
            this.TbControlAdmin.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbControlAdmin.TabButtonSelectedState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TbControlAdmin.TabButtonSelectedState.InnerColor = System.Drawing.SystemColors.Highlight;
            this.TbControlAdmin.TabButtonSize = new System.Drawing.Size(300, 100);
            this.TbControlAdmin.TabIndex = 5;
            this.TbControlAdmin.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // TbPageDashboard
            // 
            this.TbPageDashboard.Controls.Add(this.CtrlBox);
            this.TbPageDashboard.Location = new System.Drawing.Point(304, 4);
            this.TbPageDashboard.Name = "TbPageDashboard";
            this.TbPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.TbPageDashboard.Size = new System.Drawing.Size(1177, 959);
            this.TbPageDashboard.TabIndex = 0;
            this.TbPageDashboard.Text = "Dashboard";
            this.TbPageDashboard.UseVisualStyleBackColor = true;
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
            this.CtrlBox.Location = new System.Drawing.Point(566, 457);
            this.CtrlBox.Name = "CtrlBox";
            this.CtrlBox.PressedColor = System.Drawing.Color.Navy;
            this.CtrlBox.Size = new System.Drawing.Size(45, 45);
            this.CtrlBox.TabIndex = 12;
            // 
            // TbPageBrand
            // 
            this.TbPageBrand.Location = new System.Drawing.Point(304, 4);
            this.TbPageBrand.Name = "TbPageBrand";
            this.TbPageBrand.Padding = new System.Windows.Forms.Padding(3);
            this.TbPageBrand.Size = new System.Drawing.Size(1177, 959);
            this.TbPageBrand.TabIndex = 1;
            this.TbPageBrand.Text = "Manage Brand";
            this.TbPageBrand.UseVisualStyleBackColor = true;
            // 
            // TbPageCar
            // 
            this.TbPageCar.Location = new System.Drawing.Point(304, 4);
            this.TbPageCar.Name = "TbPageCar";
            this.TbPageCar.Size = new System.Drawing.Size(1177, 959);
            this.TbPageCar.TabIndex = 2;
            this.TbPageCar.Text = "Manage Car";
            this.TbPageCar.UseVisualStyleBackColor = true;
            // 
            // TbPageCarPart
            // 
            this.TbPageCarPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPageCarPart.Location = new System.Drawing.Point(304, 4);
            this.TbPageCarPart.Name = "TbPageCarPart";
            this.TbPageCarPart.Size = new System.Drawing.Size(1177, 959);
            this.TbPageCarPart.TabIndex = 3;
            this.TbPageCarPart.Text = "Manage Car Part";
            this.TbPageCarPart.UseVisualStyleBackColor = true;
            // 
            // TbPageUser
            // 
            this.TbPageUser.Location = new System.Drawing.Point(304, 4);
            this.TbPageUser.Name = "TbPageUser";
            this.TbPageUser.Size = new System.Drawing.Size(1177, 959);
            this.TbPageUser.TabIndex = 4;
            this.TbPageUser.Text = "Manage User";
            this.TbPageUser.UseVisualStyleBackColor = true;
            // 
            // TbPageOrder
            // 
            this.TbPageOrder.Location = new System.Drawing.Point(304, 4);
            this.TbPageOrder.Name = "TbPageOrder";
            this.TbPageOrder.Size = new System.Drawing.Size(1177, 959);
            this.TbPageOrder.TabIndex = 5;
            this.TbPageOrder.Text = "Manage Order";
            this.TbPageOrder.UseVisualStyleBackColor = true;
            // 
            // TbPageInventory
            // 
            this.TbPageInventory.Location = new System.Drawing.Point(304, 4);
            this.TbPageInventory.Name = "TbPageInventory";
            this.TbPageInventory.Size = new System.Drawing.Size(1177, 959);
            this.TbPageInventory.TabIndex = 8;
            this.TbPageInventory.Text = "Manage Inventory";
            this.TbPageInventory.UseVisualStyleBackColor = true;
            // 
            // TbPageReports
            // 
            this.TbPageReports.Location = new System.Drawing.Point(304, 4);
            this.TbPageReports.Name = "TbPageReports";
            this.TbPageReports.Size = new System.Drawing.Size(1177, 959);
            this.TbPageReports.TabIndex = 6;
            this.TbPageReports.Text = "Manage Reports";
            this.TbPageReports.UseVisualStyleBackColor = true;
            // 
            // TbPageProfile
            // 
            this.TbPageProfile.Location = new System.Drawing.Point(304, 4);
            this.TbPageProfile.Name = "TbPageProfile";
            this.TbPageProfile.Size = new System.Drawing.Size(1177, 959);
            this.TbPageProfile.TabIndex = 7;
            this.TbPageProfile.Text = "My Profile";
            this.TbPageProfile.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1485, 1102);
            this.Controls.Add(this.TbControlAdmin);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.TbControlAdmin.ResumeLayout(false);
            this.TbPageDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormAdminDashboard;
        private Guna.UI2.WinForms.Guna2Panel PnlTop;
        private Guna.UI2.WinForms.Guna2TabControl TbControlAdmin;
        private System.Windows.Forms.TabPage TbPageDashboard;
        private System.Windows.Forms.TabPage TbPageBrand;
        private System.Windows.Forms.TabPage TbPageCar;
        private System.Windows.Forms.TabPage TbPageCarPart;
        private System.Windows.Forms.TabPage TbPageUser;
        private System.Windows.Forms.TabPage TbPageOrder;
        private System.Windows.Forms.TabPage TbPageReports;
        private System.Windows.Forms.TabPage TbPageProfile;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxLogo;
        private Guna.UI2.WinForms.Guna2ImageButton ImgBtnLogout;
        private Guna.UI2.WinForms.Guna2ImageButton ImgBtnHome;
        private System.Windows.Forms.TabPage TbPageInventory;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBox;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}