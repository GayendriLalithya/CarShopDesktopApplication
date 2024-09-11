namespace ADCoursework1.GUI.Forms
{
    partial class UserForm
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
            this.BorderlessFormUser = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PnlAddUser = new Guna.UI2.WinForms.Guna2Panel();
            this.LblFormHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblFname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CmbUType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblUType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbFname = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblLname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbLname = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblContact = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.PnlAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessFormUser
            // 
            this.BorderlessFormUser.ContainerControl = this;
            this.BorderlessFormUser.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormUser.TransparentWhileDrag = true;
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
            this.CtrlBoxClose.Location = new System.Drawing.Point(858, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 2;
            // 
            // PnlAddUser
            // 
            this.PnlAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.PnlAddUser.Controls.Add(this.LblFormHeading);
            this.PnlAddUser.Controls.Add(this.CtrlBoxClose);
            this.PnlAddUser.Location = new System.Drawing.Point(0, 0);
            this.PnlAddUser.Name = "PnlAddUser";
            this.PnlAddUser.Size = new System.Drawing.Size(916, 100);
            this.PnlAddUser.TabIndex = 8;
            // 
            // LblFormHeading
            // 
            this.LblFormHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblFormHeading.BackColor = System.Drawing.Color.Transparent;
            this.LblFormHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormHeading.ForeColor = System.Drawing.Color.White;
            this.LblFormHeading.Location = new System.Drawing.Point(351, 23);
            this.LblFormHeading.Name = "LblFormHeading";
            this.LblFormHeading.Size = new System.Drawing.Size(224, 47);
            this.LblFormHeading.TabIndex = 3;
            this.LblFormHeading.Text = "Add New User";
            // 
            // LblFname
            // 
            this.LblFname.BackColor = System.Drawing.Color.Transparent;
            this.LblFname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFname.Location = new System.Drawing.Point(74, 240);
            this.LblFname.Name = "LblFname";
            this.LblFname.Size = new System.Drawing.Size(88, 21);
            this.LblFname.TabIndex = 52;
            this.LblFname.Text = "First Name";
            // 
            // CmbUType
            // 
            this.CmbUType.BackColor = System.Drawing.Color.Transparent;
            this.CmbUType.BorderRadius = 5;
            this.CmbUType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbUType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbUType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbUType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbUType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbUType.ItemHeight = 30;
            this.CmbUType.Items.AddRange(new object[] {
            "Customer",
            "Admin"});
            this.CmbUType.Location = new System.Drawing.Point(74, 179);
            this.CmbUType.Name = "CmbUType";
            this.CmbUType.Size = new System.Drawing.Size(360, 36);
            this.CmbUType.TabIndex = 51;
            // 
            // LblUType
            // 
            this.LblUType.BackColor = System.Drawing.Color.Transparent;
            this.LblUType.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUType.Location = new System.Drawing.Point(74, 152);
            this.LblUType.Name = "LblUType";
            this.LblUType.Size = new System.Drawing.Size(81, 21);
            this.LblUType.TabIndex = 50;
            this.LblUType.Text = "User Type";
            // 
            // TbFname
            // 
            this.TbFname.BorderRadius = 5;
            this.TbFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbFname.DefaultText = "";
            this.TbFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbFname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbFname.Location = new System.Drawing.Point(74, 267);
            this.TbFname.Name = "TbFname";
            this.TbFname.PasswordChar = '\0';
            this.TbFname.PlaceholderText = "";
            this.TbFname.SelectedText = "";
            this.TbFname.Size = new System.Drawing.Size(360, 36);
            this.TbFname.TabIndex = 49;
            // 
            // LblLname
            // 
            this.LblLname.BackColor = System.Drawing.Color.Transparent;
            this.LblLname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLname.Location = new System.Drawing.Point(480, 240);
            this.LblLname.Name = "LblLname";
            this.LblLname.Size = new System.Drawing.Size(89, 21);
            this.LblLname.TabIndex = 54;
            this.LblLname.Text = "Last Name";
            // 
            // TbLname
            // 
            this.TbLname.BorderRadius = 5;
            this.TbLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbLname.DefaultText = "";
            this.TbLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbLname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbLname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbLname.Location = new System.Drawing.Point(480, 267);
            this.TbLname.Name = "TbLname";
            this.TbLname.PasswordChar = '\0';
            this.TbLname.PlaceholderText = "";
            this.TbLname.SelectedText = "";
            this.TbLname.Size = new System.Drawing.Size(360, 36);
            this.TbLname.TabIndex = 53;
            // 
            // LblAddress
            // 
            this.LblAddress.BackColor = System.Drawing.Color.Transparent;
            this.LblAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(74, 328);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(70, 21);
            this.LblAddress.TabIndex = 56;
            this.LblAddress.Text = "Address";
            // 
            // TbAddress
            // 
            this.TbAddress.BorderRadius = 5;
            this.TbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbAddress.DefaultText = "";
            this.TbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbAddress.Location = new System.Drawing.Point(74, 355);
            this.TbAddress.Multiline = true;
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.PasswordChar = '\0';
            this.TbAddress.PlaceholderText = "";
            this.TbAddress.SelectedText = "";
            this.TbAddress.Size = new System.Drawing.Size(766, 64);
            this.TbAddress.TabIndex = 55;
            // 
            // LblContact
            // 
            this.LblContact.BackColor = System.Drawing.Color.Transparent;
            this.LblContact.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContact.Location = new System.Drawing.Point(74, 441);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(96, 21);
            this.LblContact.TabIndex = 58;
            this.LblContact.Text = "Contact No";
            // 
            // TbContact
            // 
            this.TbContact.BorderRadius = 5;
            this.TbContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbContact.DefaultText = "";
            this.TbContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbContact.Location = new System.Drawing.Point(74, 468);
            this.TbContact.Name = "TbContact";
            this.TbContact.PasswordChar = '\0';
            this.TbContact.PlaceholderText = "";
            this.TbContact.SelectedText = "";
            this.TbContact.Size = new System.Drawing.Size(360, 36);
            this.TbContact.TabIndex = 57;
            // 
            // LblPassword
            // 
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(480, 534);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(81, 21);
            this.LblPassword.TabIndex = 62;
            this.LblPassword.Text = "Password";
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
            this.TbPassword.Location = new System.Drawing.Point(480, 561);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '\0';
            this.TbPassword.PlaceholderText = "";
            this.TbPassword.SelectedText = "";
            this.TbPassword.Size = new System.Drawing.Size(360, 36);
            this.TbPassword.TabIndex = 61;
            // 
            // LblEmail
            // 
            this.LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(74, 534);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(47, 21);
            this.LblEmail.TabIndex = 60;
            this.LblEmail.Text = "Email";
            // 
            // TbEmail
            // 
            this.TbEmail.BorderRadius = 5;
            this.TbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbEmail.DefaultText = "";
            this.TbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbEmail.Location = new System.Drawing.Point(74, 561);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.PasswordChar = '\0';
            this.TbEmail.PlaceholderText = "";
            this.TbEmail.SelectedText = "";
            this.TbEmail.Size = new System.Drawing.Size(360, 36);
            this.TbEmail.TabIndex = 59;
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
            this.BtnSubmit.Location = new System.Drawing.Point(263, 640);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(360, 36);
            this.BtnSubmit.TabIndex = 63;
            this.BtnSubmit.Text = "Insert User";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 722);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.LblContact);
            this.Controls.Add(this.TbContact);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.TbAddress);
            this.Controls.Add(this.LblLname);
            this.Controls.Add(this.TbLname);
            this.Controls.Add(this.LblFname);
            this.Controls.Add(this.CmbUType);
            this.Controls.Add(this.LblUType);
            this.Controls.Add(this.TbFname);
            this.Controls.Add(this.PnlAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "AddUser";
            this.PnlAddUser.ResumeLayout(false);
            this.PnlAddUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormUser;
        private Guna.UI2.WinForms.Guna2Panel PnlAddUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFormHeading;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblAddress;
        private Guna.UI2.WinForms.Guna2TextBox TbAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblLname;
        private Guna.UI2.WinForms.Guna2TextBox TbLname;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFname;
        private Guna.UI2.WinForms.Guna2ComboBox CmbUType;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblUType;
        private Guna.UI2.WinForms.Guna2TextBox TbFname;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPassword;
        private Guna.UI2.WinForms.Guna2TextBox TbPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblEmail;
        private Guna.UI2.WinForms.Guna2TextBox TbEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblContact;
        private Guna.UI2.WinForms.Guna2TextBox TbContact;
        private Guna.UI2.WinForms.Guna2Button BtnSubmit;
    }
}