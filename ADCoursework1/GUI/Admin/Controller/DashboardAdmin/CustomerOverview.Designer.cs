namespace ADCoursework1.GUI.Admin.Controller.DashboardComponents
{
    partial class CustomerOverview
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
            this.PnlCustomer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.DgvCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblCustomer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCustomer
            // 
            this.PnlCustomer.BackColor = System.Drawing.Color.Transparent;
            this.PnlCustomer.Controls.Add(this.DgvCustomer);
            this.PnlCustomer.Controls.Add(this.LblCustomer);
            this.PnlCustomer.FillColor = System.Drawing.Color.White;
            this.PnlCustomer.Location = new System.Drawing.Point(3, 3);
            this.PnlCustomer.Name = "PnlCustomer";
            this.PnlCustomer.Radius = 5;
            this.PnlCustomer.ShadowColor = System.Drawing.SystemColors.Highlight;
            this.PnlCustomer.Size = new System.Drawing.Size(603, 396);
            this.PnlCustomer.TabIndex = 26;
            // 
            // DgvCustomer
            // 
            this.DgvCustomer.AllowUserToAddRows = false;
            this.DgvCustomer.AllowUserToDeleteRows = false;
            this.DgvCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCustomer.ColumnHeadersHeight = 40;
            this.DgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerName,
            this.colPoints});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCustomer.Location = new System.Drawing.Point(40, 79);
            this.DgvCustomer.Name = "DgvCustomer";
            this.DgvCustomer.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCustomer.RowHeadersVisible = false;
            this.DgvCustomer.RowHeadersWidth = 51;
            this.DgvCustomer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCustomer.RowTemplate.Height = 100;
            this.DgvCustomer.Size = new System.Drawing.Size(522, 296);
            this.DgvCustomer.TabIndex = 24;
            this.DgvCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgvCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgvCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgvCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgvCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgvCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCustomer.ThemeStyle.HeaderStyle.Height = 40;
            this.DgvCustomer.ThemeStyle.ReadOnly = true;
            this.DgvCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvCustomer.ThemeStyle.RowsStyle.Height = 100;
            this.DgvCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colCustomerName
            // 
            this.colCustomerName.HeaderText = "Customer Name";
            this.colCustomerName.MinimumWidth = 6;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colPoints
            // 
            this.colPoints.HeaderText = "Points";
            this.colPoints.MinimumWidth = 6;
            this.colPoints.Name = "colPoints";
            this.colPoints.ReadOnly = true;
            // 
            // LblCustomer
            // 
            this.LblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.LblCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomer.Location = new System.Drawing.Point(167, 32);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(260, 30);
            this.LblCustomer.TabIndex = 22;
            this.LblCustomer.Text = "Customer Details Overview";
            // 
            // CustomerOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlCustomer);
            this.Name = "CustomerOverview";
            this.Size = new System.Drawing.Size(610, 402);
            this.PnlCustomer.ResumeLayout(false);
            this.PnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel PnlCustomer;
        private Guna.UI2.WinForms.Guna2DataGridView DgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoints;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblCustomer;
    }
}
