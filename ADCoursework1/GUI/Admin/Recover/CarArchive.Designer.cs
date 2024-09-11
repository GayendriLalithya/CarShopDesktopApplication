namespace ADCoursework1.GUI.Admin.Recover
{
    partial class CarArchive
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
            this.BorderlessFormCarArchive = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PnlAddBrand = new Guna.UI2.WinForms.Guna2Panel();
            this.LblFormHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DgvDeletedCars = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBtnRecover = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBtnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.PnlAddBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeletedCars)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormCarArchive
            // 
            this.BorderlessFormCarArchive.ContainerControl = this;
            this.BorderlessFormCarArchive.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormCarArchive.TransparentWhileDrag = true;
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
            this.PnlAddBrand.TabIndex = 10;
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
            this.LblFormHeading.Size = new System.Drawing.Size(199, 47);
            this.LblFormHeading.TabIndex = 3;
            this.LblFormHeading.Text = "Deleted Cars";
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
            // DgvDeletedCars
            // 
            this.DgvDeletedCars.AllowUserToAddRows = false;
            this.DgvDeletedCars.AllowUserToDeleteRows = false;
            this.DgvDeletedCars.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvDeletedCars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDeletedCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvDeletedCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDeletedCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDeletedCars.ColumnHeadersHeight = 40;
            this.DgvDeletedCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarID,
            this.colBrandName,
            this.colModel,
            this.colYear,
            this.colPrice,
            this.colCarImage,
            this.colBtnRecover,
            this.colBtnDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDeletedCars.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDeletedCars.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDeletedCars.Location = new System.Drawing.Point(28, 122);
            this.DgvDeletedCars.Name = "DgvDeletedCars";
            this.DgvDeletedCars.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDeletedCars.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDeletedCars.RowHeadersVisible = false;
            this.DgvDeletedCars.RowHeadersWidth = 51;
            this.DgvDeletedCars.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDeletedCars.RowTemplate.Height = 100;
            this.DgvDeletedCars.Size = new System.Drawing.Size(1358, 581);
            this.DgvDeletedCars.TabIndex = 25;
            this.DgvDeletedCars.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvDeletedCars.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvDeletedCars.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvDeletedCars.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvDeletedCars.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvDeletedCars.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvDeletedCars.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDeletedCars.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvDeletedCars.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvDeletedCars.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDeletedCars.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvDeletedCars.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDeletedCars.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvDeletedCars.ThemeStyle.ReadOnly = true;
            this.DgvDeletedCars.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvDeletedCars.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvDeletedCars.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDeletedCars.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvDeletedCars.ThemeStyle.RowsStyle.Height = 100;
            this.DgvDeletedCars.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDeletedCars.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colCarID
            // 
            this.colCarID.HeaderText = "Car ID";
            this.colCarID.MinimumWidth = 6;
            this.colCarID.Name = "colCarID";
            this.colCarID.ReadOnly = true;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Brand Name";
            this.colBrandName.MinimumWidth = 6;
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            // 
            // colModel
            // 
            this.colModel.HeaderText = "Model";
            this.colModel.MinimumWidth = 6;
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            // 
            // colYear
            // 
            this.colYear.HeaderText = "Year";
            this.colYear.MinimumWidth = 6;
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colCarImage
            // 
            this.colCarImage.HeaderText = "Car Image";
            this.colCarImage.MinimumWidth = 6;
            this.colCarImage.Name = "colCarImage";
            this.colCarImage.ReadOnly = true;
            this.colCarImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCarImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // CarArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 736);
            this.Controls.Add(this.DgvDeletedCars);
            this.Controls.Add(this.PnlAddBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarArchive";
            this.Text = "CarArchive";
            this.PnlAddBrand.ResumeLayout(false);
            this.PnlAddBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeletedCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormCarArchive;
        private Guna.UI2.WinForms.Guna2Panel PnlAddBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFormHeading;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2DataGridView DgvDeletedCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewImageColumn colCarImage;
        private System.Windows.Forms.DataGridViewImageColumn colBtnRecover;
        private System.Windows.Forms.DataGridViewImageColumn colBtnDelete;
    }
}