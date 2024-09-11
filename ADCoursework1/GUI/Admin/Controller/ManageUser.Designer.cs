namespace ADCoursework1.GUI.Controller
{
    partial class ManageUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.TbSearchUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAll = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.DgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRecover = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.SuspendLayout();
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
            this.BtnSearch.Location = new System.Drawing.Point(682, 45);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(47, 45);
            this.BtnSearch.TabIndex = 17;
            this.BtnSearch.UseTransparentBackground = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddUser.BorderRadius = 5;
            this.BtnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddUser.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnAddUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUser.ForeColor = System.Drawing.Color.White;
            this.BtnAddUser.Image = global::ADCoursework1.Properties.Resources.add_white;
            this.BtnAddUser.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnAddUser.Location = new System.Drawing.Point(1440, 53);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(157, 47);
            this.BtnAddUser.TabIndex = 16;
            this.BtnAddUser.Text = "Add";
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // TbSearchUser
            // 
            this.TbSearchUser.BorderRadius = 20;
            this.TbSearchUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbSearchUser.DefaultText = "";
            this.TbSearchUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbSearchUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbSearchUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbSearchUser.IconRightOffset = new System.Drawing.Point(10, 0);
            this.TbSearchUser.Location = new System.Drawing.Point(35, 45);
            this.TbSearchUser.Name = "TbSearchUser";
            this.TbSearchUser.PasswordChar = '\0';
            this.TbSearchUser.PlaceholderText = "Search Users Here...";
            this.TbSearchUser.SelectedText = "";
            this.TbSearchUser.Size = new System.Drawing.Size(692, 45);
            this.TbSearchUser.TabIndex = 15;
            this.TbSearchUser.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.BtnCustomer.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnCustomer.BorderRadius = 20;
            this.BtnCustomer.BorderThickness = 2;
            this.BtnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnCustomer.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnCustomer.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnCustomer.CustomizableEdges.BottomLeft = false;
            this.BtnCustomer.CustomizableEdges.BottomRight = false;
            this.BtnCustomer.CustomizableEdges.TopLeft = false;
            this.BtnCustomer.CustomizableEdges.TopRight = false;
            this.BtnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.BtnCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCustomer.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.BtnCustomer.Location = new System.Drawing.Point(129, 129);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.PressedColor = System.Drawing.Color.DarkBlue;
            this.BtnCustomer.Size = new System.Drawing.Size(97, 45);
            this.BtnCustomer.TabIndex = 20;
            this.BtnCustomer.Text = "Customer";
            this.BtnCustomer.UseTransparentBackground = true;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // BtnAll
            // 
            this.BtnAll.BackColor = System.Drawing.Color.Transparent;
            this.BtnAll.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnAll.BorderRadius = 20;
            this.BtnAll.BorderThickness = 2;
            this.BtnAll.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnAll.Checked = true;
            this.BtnAll.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnAll.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnAll.CustomizableEdges.BottomRight = false;
            this.BtnAll.CustomizableEdges.TopRight = false;
            this.BtnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAll.FillColor = System.Drawing.Color.Transparent;
            this.BtnAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAll.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnAll.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.BtnAll.Location = new System.Drawing.Point(35, 129);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.PressedColor = System.Drawing.Color.DarkBlue;
            this.BtnAll.Size = new System.Drawing.Size(97, 45);
            this.BtnAll.TabIndex = 19;
            this.BtnAll.Text = "All";
            this.BtnAll.UseTransparentBackground = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnAdmin.BorderRadius = 20;
            this.BtnAdmin.BorderThickness = 2;
            this.BtnAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnAdmin.CheckedState.FillColor = System.Drawing.SystemColors.Highlight;
            this.BtnAdmin.CheckedState.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin.CustomizableEdges.BottomLeft = false;
            this.BtnAdmin.CustomizableEdges.TopLeft = false;
            this.BtnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdmin.FillColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnAdmin.HoverState.FillColor = System.Drawing.Color.Lavender;
            this.BtnAdmin.Location = new System.Drawing.Point(223, 129);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.PressedColor = System.Drawing.Color.DarkBlue;
            this.BtnAdmin.Size = new System.Drawing.Size(97, 45);
            this.BtnAdmin.TabIndex = 21;
            this.BtnAdmin.Text = "Admin";
            this.BtnAdmin.UseTransparentBackground = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            this.DgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUsers.ColumnHeadersHeight = 40;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colUtype,
            this.colFname,
            this.colLname,
            this.colAddress,
            this.colContactNo,
            this.colEmail,
            this.colBtnUpdate,
            this.colBtnDelete,
            this.colBtnView});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvUsers.Location = new System.Drawing.Point(35, 194);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvUsers.RowHeadersVisible = false;
            this.DgvUsers.RowHeadersWidth = 51;
            this.DgvUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvUsers.RowTemplate.Height = 100;
            this.DgvUsers.Size = new System.Drawing.Size(1542, 562);
            this.DgvUsers.TabIndex = 23;
            this.DgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvUsers.ThemeStyle.ReadOnly = true;
            this.DgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvUsers.ThemeStyle.RowsStyle.Height = 100;
            this.DgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colUserID
            // 
            this.colUserID.HeaderText = "User ID";
            this.colUserID.MinimumWidth = 6;
            this.colUserID.Name = "colUserID";
            this.colUserID.ReadOnly = true;
            // 
            // colUtype
            // 
            this.colUtype.HeaderText = "User Type";
            this.colUtype.MinimumWidth = 6;
            this.colUtype.Name = "colUtype";
            this.colUtype.ReadOnly = true;
            // 
            // colFname
            // 
            this.colFname.HeaderText = "First Name";
            this.colFname.MinimumWidth = 6;
            this.colFname.Name = "colFname";
            this.colFname.ReadOnly = true;
            // 
            // colLname
            // 
            this.colLname.HeaderText = "Last Name";
            this.colLname.MinimumWidth = 6;
            this.colLname.Name = "colLname";
            this.colLname.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colContactNo
            // 
            this.colContactNo.HeaderText = "Contact No";
            this.colContactNo.MinimumWidth = 6;
            this.colContactNo.Name = "colContactNo";
            this.colContactNo.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colBtnUpdate
            // 
            this.colBtnUpdate.HeaderText = "Update";
            this.colBtnUpdate.MinimumWidth = 6;
            this.colBtnUpdate.Name = "colBtnUpdate";
            this.colBtnUpdate.ReadOnly = true;
            this.colBtnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBtnUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBtnDelete
            // 
            this.colBtnDelete.HeaderText = "Delete";
            this.colBtnDelete.MinimumWidth = 6;
            this.colBtnDelete.Name = "colBtnDelete";
            this.colBtnDelete.ReadOnly = true;
            this.colBtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBtnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBtnView
            // 
            this.colBtnView.HeaderText = "View";
            this.colBtnView.MinimumWidth = 6;
            this.colBtnView.Name = "colBtnView";
            this.colBtnView.ReadOnly = true;
            this.colBtnView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBtnView.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.BorderRadius = 5;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = global::ADCoursework1.Properties.Resources.refresh;
            this.BtnRefresh.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnRefresh.Location = new System.Drawing.Point(1510, 141);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(67, 47);
            this.BtnRefresh.TabIndex = 24;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnRecover
            // 
            this.BtnRecover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRecover.BorderRadius = 5;
            this.BtnRecover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecover.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRecover.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRecover.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRecover.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRecover.FillColor = System.Drawing.Color.Navy;
            this.BtnRecover.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecover.ForeColor = System.Drawing.Color.White;
            this.BtnRecover.Image = global::ADCoursework1.Properties.Resources.recover;
            this.BtnRecover.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnRecover.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnRecover.Location = new System.Drawing.Point(1260, 53);
            this.BtnRecover.Name = "BtnRecover";
            this.BtnRecover.Size = new System.Drawing.Size(157, 47);
            this.BtnRecover.TabIndex = 32;
            this.BtnRecover.Text = "Recover";
            this.BtnRecover.Click += new System.EventHandler(this.BtnRecover_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRecover);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DgvUsers);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.BtnCustomer);
            this.Controls.Add(this.BtnAll);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.TbSearchUser);
            this.Name = "ManageUser";
            this.Size = new System.Drawing.Size(1644, 857);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnSearch;
        private Guna.UI2.WinForms.Guna2Button BtnAddUser;
        private Guna.UI2.WinForms.Guna2TextBox TbSearchUser;
        private Guna.UI2.WinForms.Guna2Button BtnCustomer;
        private Guna.UI2.WinForms.Guna2Button BtnAll;
        private Guna.UI2.WinForms.Guna2Button BtnAdmin;
        private Guna.UI2.WinForms.Guna2DataGridView DgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBtnView;
        private Guna.UI2.WinForms.Guna2Button BtnRefresh;
        private Guna.UI2.WinForms.Guna2Button BtnRecover;
    }
}
