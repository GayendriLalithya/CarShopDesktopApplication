namespace ADCoursework1.GUI.Admin.Recover
{
    partial class UserArchive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BorderlessFormUserArchive = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PnlAddBrand = new Guna.UI2.WinForms.Guna2Panel();
            this.LblFormHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DgvDeletedUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnRecover = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBtnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.PnlAddBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeletedUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormUserArchive
            // 
            this.BorderlessFormUserArchive.ContainerControl = this;
            this.BorderlessFormUserArchive.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormUserArchive.TransparentWhileDrag = true;
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
            this.PnlAddBrand.Size = new System.Drawing.Size(1411, 100);
            this.PnlAddBrand.TabIndex = 11;
            // 
            // LblFormHeading
            // 
            this.LblFormHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFormHeading.BackColor = System.Drawing.Color.Transparent;
            this.LblFormHeading.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormHeading.ForeColor = System.Drawing.Color.White;
            this.LblFormHeading.Location = new System.Drawing.Point(598, 23);
            this.LblFormHeading.Name = "LblFormHeading";
            this.LblFormHeading.Size = new System.Drawing.Size(217, 47);
            this.LblFormHeading.TabIndex = 3;
            this.LblFormHeading.Text = "Deleted Users";
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
            this.CtrlBoxClose.Location = new System.Drawing.Point(1353, 12);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 2;
            // 
            // DgvDeletedUsers
            // 
            this.DgvDeletedUsers.AllowUserToAddRows = false;
            this.DgvDeletedUsers.AllowUserToDeleteRows = false;
            this.DgvDeletedUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvDeletedUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDeletedUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDeletedUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDeletedUsers.ColumnHeadersHeight = 40;
            this.DgvDeletedUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colUtype,
            this.colFname,
            this.colLname,
            this.colAddress,
            this.colContactNo,
            this.colEmail,
            this.colBtnRecover,
            this.colBtnDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDeletedUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDeletedUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDeletedUsers.Location = new System.Drawing.Point(29, 123);
            this.DgvDeletedUsers.Name = "DgvDeletedUsers";
            this.DgvDeletedUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDeletedUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDeletedUsers.RowHeadersVisible = false;
            this.DgvDeletedUsers.RowHeadersWidth = 51;
            this.DgvDeletedUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDeletedUsers.RowTemplate.Height = 100;
            this.DgvDeletedUsers.Size = new System.Drawing.Size(1352, 562);
            this.DgvDeletedUsers.TabIndex = 24;
            this.DgvDeletedUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvDeletedUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvDeletedUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvDeletedUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvDeletedUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvDeletedUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvDeletedUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDeletedUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvDeletedUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvDeletedUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDeletedUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvDeletedUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDeletedUsers.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvDeletedUsers.ThemeStyle.ReadOnly = true;
            this.DgvDeletedUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvDeletedUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvDeletedUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDeletedUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvDeletedUsers.ThemeStyle.RowsStyle.Height = 100;
            this.DgvDeletedUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDeletedUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // colBtnRecover
            // 
            this.colBtnRecover.HeaderText = "Recover";
            this.colBtnRecover.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colBtnRecover.MinimumWidth = 6;
            this.colBtnRecover.Name = "colBtnRecover";
            this.colBtnRecover.ReadOnly = true;
            this.colBtnRecover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colBtnDelete
            // 
            this.colBtnDelete.HeaderText = "Delete";
            this.colBtnDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colBtnDelete.MinimumWidth = 6;
            this.colBtnDelete.Name = "colBtnDelete";
            this.colBtnDelete.ReadOnly = true;
            this.colBtnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UserArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 736);
            this.Controls.Add(this.DgvDeletedUsers);
            this.Controls.Add(this.PnlAddBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserArchive";
            this.Text = "UserArchive";
            this.PnlAddBrand.ResumeLayout(false);
            this.PnlAddBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeletedUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormUserArchive;
        private Guna.UI2.WinForms.Guna2Panel PnlAddBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFormHeading;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2DataGridView DgvDeletedUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewImageColumn colBtnRecover;
        private System.Windows.Forms.DataGridViewImageColumn colBtnDelete;
    }
}