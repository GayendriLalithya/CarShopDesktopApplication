namespace ADCoursework1.GUI
{
    partial class Register
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
            this.BorderlessFormRegister = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LblRegister = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LnkLogin = new System.Windows.Forms.LinkLabel();
            this.LblHaveAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.LblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblContact = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblLname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbLname = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblFname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TbFname = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbUtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LblUtype = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblContactError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblEmailError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblPasswordError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnShowPassword = new Guna.UI2.WinForms.Guna2Button();
            this.PicBoxLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormRegister
            // 
            this.BorderlessFormRegister.ContainerControl = this;
            this.BorderlessFormRegister.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormRegister.TransparentWhileDrag = true;
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
            this.CtrlBoxClose.Location = new System.Drawing.Point(1159, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 1;
            this.CtrlBoxClose.Click += new System.EventHandler(this.CtrlBoxClose_Click);
            // 
            // LblRegister
            // 
            this.LblRegister.BackColor = System.Drawing.Color.Transparent;
            this.LblRegister.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegister.Location = new System.Drawing.Point(879, 88);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(143, 41);
            this.LblRegister.TabIndex = 19;
            this.LblRegister.Text = "REGISTER";
            // 
            // LnkLogin
            // 
            this.LnkLogin.AutoSize = true;
            this.LnkLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkLogin.Location = new System.Drawing.Point(984, 926);
            this.LnkLogin.Name = "LnkLogin";
            this.LnkLogin.Size = new System.Drawing.Size(84, 20);
            this.LnkLogin.TabIndex = 18;
            this.LnkLogin.TabStop = true;
            this.LnkLogin.Text = "Click Here";
            this.LnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLogin_LinkClicked);
            // 
            // LblHaveAccount
            // 
            this.LblHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.LblHaveAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHaveAccount.Location = new System.Drawing.Point(775, 926);
            this.LblHaveAccount.Name = "LblHaveAccount";
            this.LblHaveAccount.Size = new System.Drawing.Size(203, 22);
            this.LblHaveAccount.TabIndex = 17;
            this.LblHaveAccount.Text = "Already have an Account?";
            // 
            // BtnRegister
            // 
            this.BtnRegister.BorderRadius = 5;
            this.BtnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRegister.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnRegister.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(775, 873);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(360, 40);
            this.BtnRegister.TabIndex = 16;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(775, 781);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(81, 21);
            this.LblPassword.TabIndex = 15;
            this.LblPassword.Text = "Password";
            // 
            // LblEmail
            // 
            this.LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(775, 682);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(47, 21);
            this.LblEmail.TabIndex = 14;
            this.LblEmail.Text = "Email";
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
            this.TbPassword.Location = new System.Drawing.Point(775, 808);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '\0';
            this.TbPassword.PlaceholderText = "";
            this.TbPassword.SelectedText = "";
            this.TbPassword.Size = new System.Drawing.Size(360, 36);
            this.TbPassword.TabIndex = 13;
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
            this.TbEmail.Location = new System.Drawing.Point(775, 709);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.PasswordChar = '\0';
            this.TbEmail.PlaceholderText = "";
            this.TbEmail.SelectedText = "";
            this.TbEmail.Size = new System.Drawing.Size(360, 36);
            this.TbEmail.TabIndex = 12;
            // 
            // LblContact
            // 
            this.LblContact.BackColor = System.Drawing.Color.Transparent;
            this.LblContact.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContact.Location = new System.Drawing.Point(775, 580);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(96, 21);
            this.LblContact.TabIndex = 23;
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
            this.TbContact.Location = new System.Drawing.Point(775, 607);
            this.TbContact.Name = "TbContact";
            this.TbContact.PasswordChar = '\0';
            this.TbContact.PlaceholderText = "";
            this.TbContact.SelectedText = "";
            this.TbContact.Size = new System.Drawing.Size(360, 36);
            this.TbContact.TabIndex = 22;
            // 
            // LblAddress
            // 
            this.LblAddress.BackColor = System.Drawing.Color.Transparent;
            this.LblAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(775, 451);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(70, 21);
            this.LblAddress.TabIndex = 25;
            this.LblAddress.Text = "Address";
            // 
            // TbAddress
            // 
            this.TbAddress.AutoScroll = true;
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
            this.TbAddress.Location = new System.Drawing.Point(775, 478);
            this.TbAddress.Multiline = true;
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.PasswordChar = '\0';
            this.TbAddress.PlaceholderText = "";
            this.TbAddress.SelectedText = "";
            this.TbAddress.Size = new System.Drawing.Size(360, 74);
            this.TbAddress.TabIndex = 24;
            // 
            // LblLname
            // 
            this.LblLname.BackColor = System.Drawing.Color.Transparent;
            this.LblLname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLname.Location = new System.Drawing.Point(775, 357);
            this.LblLname.Name = "LblLname";
            this.LblLname.Size = new System.Drawing.Size(89, 21);
            this.LblLname.TabIndex = 27;
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
            this.TbLname.Location = new System.Drawing.Point(775, 384);
            this.TbLname.Name = "TbLname";
            this.TbLname.PasswordChar = '\0';
            this.TbLname.PlaceholderText = "";
            this.TbLname.SelectedText = "";
            this.TbLname.Size = new System.Drawing.Size(360, 36);
            this.TbLname.TabIndex = 26;
            // 
            // LblFname
            // 
            this.LblFname.BackColor = System.Drawing.Color.Transparent;
            this.LblFname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFname.Location = new System.Drawing.Point(775, 267);
            this.LblFname.Name = "LblFname";
            this.LblFname.Size = new System.Drawing.Size(88, 21);
            this.LblFname.TabIndex = 29;
            this.LblFname.Text = "First Name";
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
            this.TbFname.Location = new System.Drawing.Point(775, 294);
            this.TbFname.Name = "TbFname";
            this.TbFname.PasswordChar = '\0';
            this.TbFname.PlaceholderText = "";
            this.TbFname.SelectedText = "";
            this.TbFname.Size = new System.Drawing.Size(360, 36);
            this.TbFname.TabIndex = 28;
            // 
            // CmbUtype
            // 
            this.CmbUtype.BackColor = System.Drawing.Color.Transparent;
            this.CmbUtype.BorderRadius = 5;
            this.CmbUtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbUtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbUtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbUtype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbUtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbUtype.ItemHeight = 30;
            this.CmbUtype.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.CmbUtype.Location = new System.Drawing.Point(775, 200);
            this.CmbUtype.Name = "CmbUtype";
            this.CmbUtype.Size = new System.Drawing.Size(360, 36);
            this.CmbUtype.TabIndex = 30;
            // 
            // LblUtype
            // 
            this.LblUtype.BackColor = System.Drawing.Color.Transparent;
            this.LblUtype.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUtype.Location = new System.Drawing.Point(775, 173);
            this.LblUtype.Name = "LblUtype";
            this.LblUtype.Size = new System.Drawing.Size(81, 21);
            this.LblUtype.TabIndex = 31;
            this.LblUtype.Text = "User Type";
            // 
            // LblContactError
            // 
            this.LblContactError.BackColor = System.Drawing.Color.Transparent;
            this.LblContactError.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContactError.Location = new System.Drawing.Point(775, 649);
            this.LblContactError.Name = "LblContactError";
            this.LblContactError.Size = new System.Drawing.Size(3, 2);
            this.LblContactError.TabIndex = 32;
            this.LblContactError.Text = null;
            // 
            // LblEmailError
            // 
            this.LblEmailError.BackColor = System.Drawing.Color.Transparent;
            this.LblEmailError.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailError.Location = new System.Drawing.Point(775, 749);
            this.LblEmailError.Name = "LblEmailError";
            this.LblEmailError.Size = new System.Drawing.Size(3, 2);
            this.LblEmailError.TabIndex = 33;
            this.LblEmailError.Text = null;
            // 
            // LblPasswordError
            // 
            this.LblPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.LblPasswordError.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasswordError.Location = new System.Drawing.Point(775, 844);
            this.LblPasswordError.Name = "LblPasswordError";
            this.LblPasswordError.Size = new System.Drawing.Size(3, 2);
            this.LblPasswordError.TabIndex = 34;
            this.LblPasswordError.Text = null;
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
            this.BtnShowPassword.Location = new System.Drawing.Point(1100, 812);
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.PressedColor = System.Drawing.Color.White;
            this.BtnShowPassword.PressedDepth = 0;
            this.BtnShowPassword.Size = new System.Drawing.Size(30, 30);
            this.BtnShowPassword.TabIndex = 35;
            this.BtnShowPassword.UseTransparentBackground = true;
            this.BtnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // PicBoxLogin
            // 
            this.PicBoxLogin.Image = global::ADCoursework1.Properties.Resources.Login;
            this.PicBoxLogin.ImageRotate = 0F;
            this.PicBoxLogin.Location = new System.Drawing.Point(-242, 127);
            this.PicBoxLogin.Name = "PicBoxLogin";
            this.PicBoxLogin.Size = new System.Drawing.Size(1020, 819);
            this.PicBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxLogin.TabIndex = 36;
            this.PicBoxLogin.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1216, 989);
            this.Controls.Add(this.BtnShowPassword);
            this.Controls.Add(this.LblPasswordError);
            this.Controls.Add(this.LblEmailError);
            this.Controls.Add(this.LblContactError);
            this.Controls.Add(this.LblUtype);
            this.Controls.Add(this.CmbUtype);
            this.Controls.Add(this.LblFname);
            this.Controls.Add(this.TbFname);
            this.Controls.Add(this.LblLname);
            this.Controls.Add(this.TbLname);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.TbAddress);
            this.Controls.Add(this.LblContact);
            this.Controls.Add(this.TbContact);
            this.Controls.Add(this.LblRegister);
            this.Controls.Add(this.LnkLogin);
            this.Controls.Add(this.LblHaveAccount);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.CtrlBoxClose);
            this.Controls.Add(this.PicBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormRegister;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblUtype;
        private Guna.UI2.WinForms.Guna2ComboBox CmbUtype;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFname;
        private Guna.UI2.WinForms.Guna2TextBox TbFname;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblLname;
        private Guna.UI2.WinForms.Guna2TextBox TbLname;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblAddress;
        private Guna.UI2.WinForms.Guna2TextBox TbAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblContact;
        private Guna.UI2.WinForms.Guna2TextBox TbContact;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblRegister;
        private System.Windows.Forms.LinkLabel LnkLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblHaveAccount;
        private Guna.UI2.WinForms.Guna2Button BtnRegister;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblEmail;
        private Guna.UI2.WinForms.Guna2TextBox TbPassword;
        private Guna.UI2.WinForms.Guna2TextBox TbEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblEmailError;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblContactError;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblPasswordError;
        private Guna.UI2.WinForms.Guna2Button BtnShowPassword;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxLogin;
    }
}