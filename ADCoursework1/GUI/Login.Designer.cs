namespace ADCoursework1.GUI
{
    partial class Login
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
            this.BorderlessFormLogin = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TbUname = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblUname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.LblNoAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LnkRegister = new System.Windows.Forms.LinkLabel();
            this.LblLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PicBoxLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnShowPassword = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormLogin
            // 
            this.BorderlessFormLogin.ContainerControl = this;
            this.BorderlessFormLogin.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormLogin.TransparentWhileDrag = true;
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
            this.CtrlBoxClose.IconColor = System.Drawing.Color.Black;
            this.CtrlBoxClose.Location = new System.Drawing.Point(1063, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 0;
            this.CtrlBoxClose.Click += new System.EventHandler(this.CtrlBoxClose_Click);
            // 
            // TbUname
            // 
            this.TbUname.BorderRadius = 5;
            this.TbUname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbUname.DefaultText = "";
            this.TbUname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbUname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbUname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbUname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbUname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbUname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbUname.Location = new System.Drawing.Point(657, 277);
            this.TbUname.Name = "TbUname";
            this.TbUname.PasswordChar = '\0';
            this.TbUname.PlaceholderText = "";
            this.TbUname.SelectedText = "";
            this.TbUname.Size = new System.Drawing.Size(360, 36);
            this.TbUname.TabIndex = 2;
            // 
            // TbPassword
            // 
            this.TbPassword.BorderRadius = 5;
            this.TbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbPassword.DefaultText = "";
            this.TbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbPassword.Location = new System.Drawing.Point(657, 388);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '\0';
            this.TbPassword.PlaceholderText = "";
            this.TbPassword.SelectedText = "";
            this.TbPassword.Size = new System.Drawing.Size(360, 36);
            this.TbPassword.TabIndex = 3;
            // 
            // LblUname
            // 
            this.LblUname.BackColor = System.Drawing.Color.Transparent;
            this.LblUname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUname.Location = new System.Drawing.Point(657, 250);
            this.LblUname.Name = "LblUname";
            this.LblUname.Size = new System.Drawing.Size(85, 21);
            this.LblUname.TabIndex = 4;
            this.LblUname.Text = "Username";
            // 
            // LblPassword
            // 
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(657, 361);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(81, 21);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "Password";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BorderRadius = 5;
            this.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogin.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(657, 501);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(360, 40);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblNoAccount
            // 
            this.LblNoAccount.BackColor = System.Drawing.Color.Transparent;
            this.LblNoAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoAccount.Location = new System.Drawing.Point(657, 548);
            this.LblNoAccount.Name = "LblNoAccount";
            this.LblNoAccount.Size = new System.Drawing.Size(184, 22);
            this.LblNoAccount.TabIndex = 7;
            this.LblNoAccount.Text = "Don\'t have an Account?";
            // 
            // LnkRegister
            // 
            this.LnkRegister.AutoSize = true;
            this.LnkRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkRegister.Location = new System.Drawing.Point(848, 548);
            this.LnkRegister.Name = "LnkRegister";
            this.LnkRegister.Size = new System.Drawing.Size(84, 20);
            this.LnkRegister.TabIndex = 8;
            this.LnkRegister.TabStop = true;
            this.LnkRegister.Text = "Click Here";
            this.LnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRegister_LinkClicked);
            // 
            // LblLogin
            // 
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(784, 129);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(107, 41);
            this.LblLogin.TabIndex = 9;
            this.LblLogin.Text = "LOGIN";
            // 
            // PicBoxLogin
            // 
            this.PicBoxLogin.Image = global::ADCoursework1.Properties.Resources.Login;
            this.PicBoxLogin.ImageRotate = 0F;
            this.PicBoxLogin.Location = new System.Drawing.Point(-240, 0);
            this.PicBoxLogin.Name = "PicBoxLogin";
            this.PicBoxLogin.Size = new System.Drawing.Size(880, 684);
            this.PicBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxLogin.TabIndex = 1;
            this.PicBoxLogin.TabStop = false;
            // 
            // BtnShowPassword
            // 
            this.BtnShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.BtnShowPassword.BorderColor = System.Drawing.Color.White;
            this.BtnShowPassword.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnShowPassword.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnShowPassword.CheckedState.Image = global::ADCoursework1.Properties.Resources.Hide;
            this.BtnShowPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnShowPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnShowPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnShowPassword.FillColor = System.Drawing.Color.White;
            this.BtnShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnShowPassword.ForeColor = System.Drawing.Color.White;
            this.BtnShowPassword.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnShowPassword.Image = global::ADCoursework1.Properties.Resources.View;
            this.BtnShowPassword.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnShowPassword.Location = new System.Drawing.Point(981, 392);
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.PressedColor = System.Drawing.Color.White;
            this.BtnShowPassword.PressedDepth = 0;
            this.BtnShowPassword.Size = new System.Drawing.Size(30, 30);
            this.BtnShowPassword.TabIndex = 12;
            this.BtnShowPassword.UseTransparentBackground = true;
            this.BtnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1120, 696);
            this.Controls.Add(this.BtnShowPassword);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.LnkRegister);
            this.Controls.Add(this.LblNoAccount);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUname);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUname);
            this.Controls.Add(this.PicBoxLogin);
            this.Controls.Add(this.CtrlBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormLogin;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxLogin;
        private Guna.UI2.WinForms.Guna2TextBox TbPassword;
        private Guna.UI2.WinForms.Guna2TextBox TbUname;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblUname;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblNoAccount;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblLogin;
        private System.Windows.Forms.LinkLabel LnkRegister;
        private Guna.UI2.WinForms.Guna2Button BtnShowPassword;
    }
}