namespace QuanLyNhanSu_Master.Module
{
    partial class frmAddNewPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewPhongBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoACB = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtTenPhongBan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMaPhongBan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoACB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogoACB);
            this.panel1.Controls.Add(this.btnMinimized);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 67);
            this.panel1.TabIndex = 1;
            // 
            // LogoACB
            // 
            this.LogoACB.BackColor = System.Drawing.Color.Transparent;
            this.LogoACB.Image = ((System.Drawing.Image)(resources.GetObject("LogoACB.Image")));
            this.LogoACB.ImageActive = null;
            this.LogoACB.Location = new System.Drawing.Point(12, 11);
            this.LogoACB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoACB.Name = "LogoACB";
            this.LogoACB.Size = new System.Drawing.Size(81, 47);
            this.LogoACB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoACB.TabIndex = 42;
            this.LogoACB.TabStop = false;
            this.LogoACB.Zoom = 10;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMinimized.ImageActive")));
            this.btnMinimized.Location = new System.Drawing.Point(493, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(50, 50);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 1;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Zoom = 10;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageActive")));
            this.btnExit.Location = new System.Drawing.Point(531, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenPhongBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenPhongBan.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenPhongBan.HintText = "";
            this.txtTenPhongBan.isPassword = true;
            this.txtTenPhongBan.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTenPhongBan.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTenPhongBan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTenPhongBan.LineThickness = 3;
            this.txtTenPhongBan.Location = new System.Drawing.Point(251, 213);
            this.txtTenPhongBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(276, 44);
            this.txtTenPhongBan.TabIndex = 40;
            this.txtTenPhongBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMaPhongBan
            // 
            this.txtMaPhongBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhongBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhongBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaPhongBan.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaPhongBan.HintText = "";
            this.txtMaPhongBan.isPassword = false;
            this.txtMaPhongBan.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMaPhongBan.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaPhongBan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMaPhongBan.LineThickness = 3;
            this.txtMaPhongBan.Location = new System.Drawing.Point(251, 167);
            this.txtMaPhongBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhongBan.Name = "txtMaPhongBan";
            this.txtMaPhongBan.Size = new System.Drawing.Size(276, 44);
            this.txtMaPhongBan.TabIndex = 39;
            this.txtMaPhongBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(54, 234);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(134, 23);
            this.bunifuCustomLabel2.TabIndex = 43;
            this.bunifuCustomLabel2.Text = "Tên Phòng Ban :";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(143, 92);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(317, 38);
            this.bunifuCustomLabel5.TabIndex = 41;
            this.bunifuCustomLabel5.Text = "TẠO MỚI PHÒNG BAN";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 188);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(132, 23);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Mã Phòng Ban :";
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 20;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.btnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.btnRegister.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "Đăng Kí";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnRegister.IdleForecolor = System.Drawing.Color.White;
            this.btnRegister.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnRegister.Location = new System.Drawing.Point(353, 316);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(162, 52);
            this.btnRegister.TabIndex = 44;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmAddNewPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtTenPhongBan);
            this.Controls.Add(this.txtMaPhongBan);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewPhongBan";
            this.Text = "frmAddNewPhongBan";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoACB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuImageButton LogoACB;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenPhongBan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaPhongBan;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}