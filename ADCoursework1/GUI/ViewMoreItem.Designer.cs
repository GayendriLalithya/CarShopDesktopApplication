namespace ADCoursework1.GUI
{
    partial class ViewMoreItem
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
            this.BorderlessFormViewMore = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.ImgBtnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PicBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LblFilterBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CmbBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblFilterPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CmbPriceRange = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.flwLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.DrgCtrlViewMore = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormViewMore
            // 
            this.BorderlessFormViewMore.ContainerControl = this;
            this.BorderlessFormViewMore.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormViewMore.TransparentWhileDrag = true;
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PnlTop.Controls.Add(this.ImgBtnBack);
            this.PnlTop.Controls.Add(this.PicBoxLogo);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1924, 135);
            this.PnlTop.TabIndex = 5;
            // 
            // ImgBtnBack
            // 
            this.ImgBtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgBtnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImgBtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgBtnBack.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.ImgBtnBack.Image = global::ADCoursework1.Properties.Resources.back_white;
            this.ImgBtnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImgBtnBack.ImageRotate = 0F;
            this.ImgBtnBack.ImageSize = new System.Drawing.Size(45, 45);
            this.ImgBtnBack.Location = new System.Drawing.Point(1833, 41);
            this.ImgBtnBack.Name = "ImgBtnBack";
            this.ImgBtnBack.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.ImgBtnBack.Size = new System.Drawing.Size(50, 50);
            this.ImgBtnBack.TabIndex = 10;
            this.ImgBtnBack.Click += new System.EventHandler(this.ImgBtnBack_Click);
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
            // LblFilterBrand
            // 
            this.LblFilterBrand.BackColor = System.Drawing.Color.Transparent;
            this.LblFilterBrand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilterBrand.Location = new System.Drawing.Point(857, 205);
            this.LblFilterBrand.Name = "LblFilterBrand";
            this.LblFilterBrand.Size = new System.Drawing.Size(123, 25);
            this.LblFilterBrand.TabIndex = 27;
            this.LblFilterBrand.Text = "Filter By Brand";
            // 
            // CmbBrand
            // 
            this.CmbBrand.BackColor = System.Drawing.Color.Transparent;
            this.CmbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBrand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbBrand.ItemHeight = 30;
            this.CmbBrand.Location = new System.Drawing.Point(996, 199);
            this.CmbBrand.Name = "CmbBrand";
            this.CmbBrand.Size = new System.Drawing.Size(262, 36);
            this.CmbBrand.TabIndex = 26;
            // 
            // LblFilterPrice
            // 
            this.LblFilterPrice.BackColor = System.Drawing.Color.Transparent;
            this.LblFilterPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilterPrice.Location = new System.Drawing.Point(1331, 205);
            this.LblFilterPrice.Name = "LblFilterPrice";
            this.LblFilterPrice.Size = new System.Drawing.Size(114, 25);
            this.LblFilterPrice.TabIndex = 25;
            this.LblFilterPrice.Text = "Filter By Price";
            // 
            // CmbPriceRange
            // 
            this.CmbPriceRange.BackColor = System.Drawing.Color.Transparent;
            this.CmbPriceRange.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbPriceRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPriceRange.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbPriceRange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbPriceRange.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbPriceRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbPriceRange.ItemHeight = 30;
            this.CmbPriceRange.Location = new System.Drawing.Point(1470, 199);
            this.CmbPriceRange.Name = "CmbPriceRange";
            this.CmbPriceRange.Size = new System.Drawing.Size(262, 36);
            this.CmbPriceRange.TabIndex = 24;
            // 
            // TbSearch
            // 
            this.TbSearch.BorderRadius = 20;
            this.TbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbSearch.DefaultText = "";
            this.TbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.TbSearch.Location = new System.Drawing.Point(53, 190);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.PasswordChar = '\0';
            this.TbSearch.PlaceholderText = "Search Here...";
            this.TbSearch.SelectedText = "";
            this.TbSearch.Size = new System.Drawing.Size(692, 45);
            this.TbSearch.TabIndex = 28;
            this.TbSearch.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // flwLayoutPanel
            // 
            this.flwLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flwLayoutPanel.AutoScroll = true;
            this.flwLayoutPanel.Location = new System.Drawing.Point(47, 290);
            this.flwLayoutPanel.Name = "flwLayoutPanel";
            this.flwLayoutPanel.Size = new System.Drawing.Size(1836, 588);
            this.flwLayoutPanel.TabIndex = 30;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BorderRadius = 23;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSearch.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Image = global::ADCoursework1.Properties.Resources.search_white;
            this.BtnSearch.Location = new System.Drawing.Point(698, 190);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(47, 45);
            this.BtnSearch.TabIndex = 29;
            this.BtnSearch.UseTransparentBackground = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DrgCtrlViewMore
            // 
            this.DrgCtrlViewMore.DockIndicatorTransparencyValue = 0.6D;
            this.DrgCtrlViewMore.TargetControl = this.PnlTop;
            this.DrgCtrlViewMore.UseTransparentDrag = true;
            // 
            // ViewMoreItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 906);
            this.Controls.Add(this.flwLayoutPanel);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.LblFilterBrand);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.CmbBrand);
            this.Controls.Add(this.LblFilterPrice);
            this.Controls.Add(this.CmbPriceRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMoreItem";
            this.Text = "ViewMoreItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormViewMore;
        private Guna.UI2.WinForms.Guna2Panel PnlTop;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFilterBrand;
        private Guna.UI2.WinForms.Guna2ComboBox CmbBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFilterPrice;
        private Guna.UI2.WinForms.Guna2ComboBox CmbPriceRange;
        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2TextBox TbSearch;
        private System.Windows.Forms.FlowLayoutPanel flwLayoutPanel;
        private Guna.UI2.WinForms.Guna2ImageButton ImgBtnBack;
        private Guna.UI2.WinForms.Guna2DragControl DrgCtrlViewMore;
    }
}