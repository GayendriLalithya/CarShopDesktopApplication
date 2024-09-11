namespace ADCoursework1.GUI.Forms
{
    partial class BrandForm
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
            this.BorderlessFormBrand = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LblBrandName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.PnlAddBrand = new Guna.UI2.WinForms.Guna2Panel();
            this.LblFormHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblBrandImage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnChoose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.PicBoxBrand = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.PnlAddBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBrand)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormBrand
            // 
            this.BorderlessFormBrand.ContainerControl = this;
            this.BorderlessFormBrand.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormBrand.TransparentWhileDrag = true;
            // 
            // CtrlBoxClose
            // 
            this.CtrlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlBoxClose.BorderRadius = 5;
            this.CtrlBoxClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.CtrlBoxClose.CustomIconSize = 15F;
            this.CtrlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.CtrlBoxClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.CtrlBoxClose.HoverState.IconColor = System.Drawing.Color.White;
            this.CtrlBoxClose.IconColor = System.Drawing.Color.White;
            this.CtrlBoxClose.Location = new System.Drawing.Point(587, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 2;
            // 
            // LblBrandName
            // 
            this.LblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.LblBrandName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrandName.Location = new System.Drawing.Point(140, 129);
            this.LblBrandName.Name = "LblBrandName";
            this.LblBrandName.Size = new System.Drawing.Size(106, 21);
            this.LblBrandName.TabIndex = 6;
            this.LblBrandName.Text = "Brand Name";
            // 
            // TbBrand
            // 
            this.TbBrand.BorderRadius = 5;
            this.TbBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbBrand.DefaultText = "";
            this.TbBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbBrand.Location = new System.Drawing.Point(140, 156);
            this.TbBrand.Name = "TbBrand";
            this.TbBrand.PasswordChar = '\0';
            this.TbBrand.PlaceholderText = "";
            this.TbBrand.SelectedText = "";
            this.TbBrand.Size = new System.Drawing.Size(360, 36);
            this.TbBrand.TabIndex = 5;
            // 
            // PnlAddBrand
            // 
            this.PnlAddBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PnlAddBrand.Controls.Add(this.LblFormHeading);
            this.PnlAddBrand.Controls.Add(this.CtrlBoxClose);
            this.PnlAddBrand.Location = new System.Drawing.Point(0, 0);
            this.PnlAddBrand.Name = "PnlAddBrand";
            this.PnlAddBrand.Size = new System.Drawing.Size(645, 100);
            this.PnlAddBrand.TabIndex = 7;
            // 
            // LblFormHeading
            // 
            this.LblFormHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFormHeading.BackColor = System.Drawing.Color.Transparent;
            this.LblFormHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormHeading.ForeColor = System.Drawing.Color.White;
            this.LblFormHeading.Location = new System.Drawing.Point(188, 23);
            this.LblFormHeading.Name = "LblFormHeading";
            this.LblFormHeading.Size = new System.Drawing.Size(246, 47);
            this.LblFormHeading.TabIndex = 3;
            this.LblFormHeading.Text = "Add New Brand";
            // 
            // LblBrandImage
            // 
            this.LblBrandImage.BackColor = System.Drawing.Color.Transparent;
            this.LblBrandImage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrandImage.Location = new System.Drawing.Point(140, 215);
            this.LblBrandImage.Name = "LblBrandImage";
            this.LblBrandImage.Size = new System.Drawing.Size(109, 21);
            this.LblBrandImage.TabIndex = 8;
            this.LblBrandImage.Text = "Brand Image";
            // 
            // BtnChoose
            // 
            this.BtnChoose.BorderRadius = 5;
            this.BtnChoose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnChoose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnChoose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnChoose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnChoose.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnChoose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnChoose.ForeColor = System.Drawing.Color.White;
            this.BtnChoose.Location = new System.Drawing.Point(140, 631);
            this.BtnChoose.Name = "BtnChoose";
            this.BtnChoose.Size = new System.Drawing.Size(170, 36);
            this.BtnChoose.TabIndex = 10;
            this.BtnChoose.Text = "Choose";
            this.BtnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BorderRadius = 5;
            this.BtnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRemove.FillColor = System.Drawing.Color.Red;
            this.BtnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.Location = new System.Drawing.Point(330, 631);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(170, 36);
            this.BtnRemove.TabIndex = 11;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // PicBoxBrand
            // 
            this.PicBoxBrand.ErrorImage = global::ADCoursework1.Properties.Resources.white;
            this.PicBoxBrand.ImageRotate = 0F;
            this.PicBoxBrand.Location = new System.Drawing.Point(140, 251);
            this.PicBoxBrand.Name = "PicBoxBrand";
            this.PicBoxBrand.Size = new System.Drawing.Size(360, 360);
            this.PicBoxBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxBrand.TabIndex = 9;
            this.PicBoxBrand.TabStop = false;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BorderRadius = 5;
            this.BtnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSubmit.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(140, 691);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(360, 36);
            this.BtnSubmit.TabIndex = 13;
            this.BtnSubmit.Text = "Insert Brand";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 756);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnChoose);
            this.Controls.Add(this.PicBoxBrand);
            this.Controls.Add(this.LblBrandImage);
            this.Controls.Add(this.PnlAddBrand);
            this.Controls.Add(this.LblBrandName);
            this.Controls.Add(this.TbBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBrand";
            this.PnlAddBrand.ResumeLayout(false);
            this.PnlAddBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBrand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormBrand;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrandName;
        private Guna.UI2.WinForms.Guna2TextBox TbBrand;
        private Guna.UI2.WinForms.Guna2Panel PnlAddBrand;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblBrandImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFormHeading;
        private Guna.UI2.WinForms.Guna2Button BtnChoose;
        private Guna.UI2.WinForms.Guna2Button BtnRemove;
        private Guna.UI2.WinForms.Guna2Button BtnSubmit;
    }
}