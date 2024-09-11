namespace ADCoursework1.GUI.Admin.Recover
{
    partial class CarPartArchive
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
            this.BorderlessFormCarPartArchive = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PnlAddBrand = new Guna.UI2.WinForms.Guna2Panel();
            this.LblFormHeading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DgvDeletedCarParts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCarPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPartImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBtnRecover = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBtnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.PnlAddBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeletedCarParts)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessFormCarPartArchive
            // 
            this.BorderlessFormCarPartArchive.ContainerControl = this;
            this.BorderlessFormCarPartArchive.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessFormCarPartArchive.TransparentWhileDrag = true;
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
            this.LblFormHeading.Location = new System.Drawing.Point(552, 23);
            this.LblFormHeading.Name = "LblFormHeading";
            this.LblFormHeading.Size = new System.Drawing.Size(272, 47);
            this.LblFormHeading.TabIndex = 3;
            this.LblFormHeading.Text = "Deleted Car Parts";
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
            // DgvDeletedCarParts
            // 
            this.DgvDeletedCarParts.AllowUserToAddRows = false;
            this.DgvDeletedCarParts.AllowUserToDeleteRows = false;
            this.DgvDeletedCarParts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvDeletedCarParts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDeletedCarParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvDeletedCarParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDeletedCarParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDeletedCarParts.ColumnHeadersHeight = 40;
            this.DgvDeletedCarParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarPartID,
            this.colCarPartName,
            this.colBrandName,
            this.colPartNo,
            this.colPartPrice,
            this.colPartImage,
            this.colBtnRecover,
            this.colBtnDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDeletedCarParts.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDeletedCarParts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDeletedCarParts.Location = new System.Drawing.Point(25, 122);
            this.DgvDeletedCarParts.Name = "DgvDeletedCarParts";
            this.DgvDeletedCarParts.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDeletedCarParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDeletedCarParts.RowHeadersVisible = false;
            this.DgvDeletedCarParts.RowHeadersWidth = 51;
            this.DgvDeletedCarParts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDeletedCarParts.RowTemplate.Height = 100;
            this.DgvDeletedCarParts.Size = new System.Drawing.Size(1358, 566);
            this.DgvDeletedCarParts.TabIndex = 30;
            this.DgvDeletedCarParts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvDeletedCarParts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvDeletedCarParts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvDeletedCarParts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvDeletedCarParts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvDeletedCarParts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvDeletedCarParts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDeletedCarParts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvDeletedCarParts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvDeletedCarParts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDeletedCarParts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvDeletedCarParts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDeletedCarParts.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvDeletedCarParts.ThemeStyle.ReadOnly = true;
            this.DgvDeletedCarParts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvDeletedCarParts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvDeletedCarParts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDeletedCarParts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvDeletedCarParts.ThemeStyle.RowsStyle.Height = 100;
            this.DgvDeletedCarParts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvDeletedCarParts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colCarPartID
            // 
            this.colCarPartID.HeaderText = "Car Part ID";
            this.colCarPartID.MinimumWidth = 6;
            this.colCarPartID.Name = "colCarPartID";
            this.colCarPartID.ReadOnly = true;
            // 
            // colCarPartName
            // 
            this.colCarPartName.HeaderText = "Car Part Name";
            this.colCarPartName.MinimumWidth = 6;
            this.colCarPartName.Name = "colCarPartName";
            this.colCarPartName.ReadOnly = true;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Brand Name";
            this.colBrandName.MinimumWidth = 6;
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            // 
            // colPartNo
            // 
            this.colPartNo.HeaderText = "Part Number";
            this.colPartNo.MinimumWidth = 6;
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.ReadOnly = true;
            // 
            // colPartPrice
            // 
            this.colPartPrice.HeaderText = "Part Price";
            this.colPartPrice.MinimumWidth = 6;
            this.colPartPrice.Name = "colPartPrice";
            this.colPartPrice.ReadOnly = true;
            // 
            // colPartImage
            // 
            this.colPartImage.HeaderText = "Car Part Image";
            this.colPartImage.MinimumWidth = 6;
            this.colPartImage.Name = "colPartImage";
            this.colPartImage.ReadOnly = true;
            this.colPartImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPartImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // CarPartArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 736);
            this.Controls.Add(this.DgvDeletedCarParts);
            this.Controls.Add(this.PnlAddBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarPartArchive";
            this.Text = "CarPartArchive";
            this.PnlAddBrand.ResumeLayout(false);
            this.PnlAddBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeletedCarParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessFormCarPartArchive;
        private Guna.UI2.WinForms.Guna2Panel PnlAddBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblFormHeading;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2DataGridView DgvDeletedCarParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPartPrice;
        private System.Windows.Forms.DataGridViewImageColumn colPartImage;
        private System.Windows.Forms.DataGridViewImageColumn colBtnRecover;
        private System.Windows.Forms.DataGridViewImageColumn colBtnDelete;
    }
}