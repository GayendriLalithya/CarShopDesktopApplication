namespace ADCoursework1.GUI.Forms
{
    partial class Alert
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
            this.CtrlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PnlMessageBox = new Guna.UI2.WinForms.Guna2Panel();
            this.PicBoxIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LblMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TimerAlert = new System.Windows.Forms.Timer(this.components);
            this.PnlMessageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CtrlBoxClose
            // 
            this.CtrlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.CtrlBoxClose.BorderRadius = 5;
            this.CtrlBoxClose.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.CtrlBoxClose.CustomIconSize = 15F;
            this.CtrlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.CtrlBoxClose.HoverState.FillColor = System.Drawing.Color.White;
            this.CtrlBoxClose.HoverState.IconColor = System.Drawing.Color.Black;
            this.CtrlBoxClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtrlBoxClose.Location = new System.Drawing.Point(485, 38);
            this.CtrlBoxClose.Name = "CtrlBoxClose";
            this.CtrlBoxClose.PressedColor = System.Drawing.Color.Transparent;
            this.CtrlBoxClose.Size = new System.Drawing.Size(45, 45);
            this.CtrlBoxClose.TabIndex = 4;
            this.CtrlBoxClose.Click += new System.EventHandler(this.CtrlBoxClose_Click);
            // 
            // PnlMessageBox
            // 
            this.PnlMessageBox.BorderColor = System.Drawing.Color.LimeGreen;
            this.PnlMessageBox.BorderThickness = 2;
            this.PnlMessageBox.Controls.Add(this.PicBoxIcon);
            this.PnlMessageBox.Controls.Add(this.CtrlBoxClose);
            this.PnlMessageBox.Controls.Add(this.LblMessage);
            this.PnlMessageBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PnlMessageBox.Location = new System.Drawing.Point(0, 0);
            this.PnlMessageBox.Name = "PnlMessageBox";
            this.PnlMessageBox.Size = new System.Drawing.Size(552, 118);
            this.PnlMessageBox.TabIndex = 5;
            // 
            // PicBoxIcon
            // 
            this.PicBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxIcon.Image = global::ADCoursework1.Properties.Resources.success_icon;
            this.PicBoxIcon.ImageRotate = 0F;
            this.PicBoxIcon.Location = new System.Drawing.Point(48, 36);
            this.PicBoxIcon.Name = "PicBoxIcon";
            this.PicBoxIcon.Size = new System.Drawing.Size(50, 50);
            this.PicBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxIcon.TabIndex = 1;
            this.PicBoxIcon.TabStop = false;
            this.PicBoxIcon.UseTransparentBackground = true;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = false;
            this.LblMessage.BackColor = System.Drawing.Color.Transparent;
            this.LblMessage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.LblMessage.Location = new System.Drawing.Point(127, 31);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(338, 63);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "Successfull Message";
            this.LblMessage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimerAlert
            // 
            this.TimerAlert.Tick += new System.EventHandler(this.TimerAlert_Tick);
            // 
            // Alert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 118);
            this.Controls.Add(this.PnlMessageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Text = "Alert";
            this.PnlMessageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox CtrlBoxClose;
        private Guna.UI2.WinForms.Guna2Panel PnlMessageBox;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxIcon;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblMessage;
        private System.Windows.Forms.Timer TimerAlert;
    }
}