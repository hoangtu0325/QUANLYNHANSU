namespace QuanLyNhanSu_Master.Module
{
    partial class frmResetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPass));
            this.txtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnResetPass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.paneltop = new System.Windows.Forms.Panel();
            this.LogoACB = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoACB)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.HintForeColor = System.Drawing.Color.Empty;
            this.txtUserName.HintText = "";
            this.txtUserName.isPassword = false;
            this.txtUserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUserName.LineThickness = 3;
            this.txtUserName.Location = new System.Drawing.Point(191, 195);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(222, 44);
            this.txtUserName.TabIndex = 61;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnResetPass
            // 
            this.btnResetPass.ActiveBorderThickness = 1;
            this.btnResetPass.ActiveCornerRadius = 20;
            this.btnResetPass.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.btnResetPass.ActiveForecolor = System.Drawing.Color.White;
            this.btnResetPass.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.btnResetPass.BackColor = System.Drawing.Color.White;
            this.btnResetPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetPass.BackgroundImage")));
            this.btnResetPass.ButtonText = "Reset";
            this.btnResetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnResetPass.IdleBorderThickness = 1;
            this.btnResetPass.IdleCornerRadius = 20;
            this.btnResetPass.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnResetPass.IdleForecolor = System.Drawing.Color.White;
            this.btnResetPass.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnResetPass.Location = new System.Drawing.Point(218, 298);
            this.btnResetPass.Margin = new System.Windows.Forms.Padding(5);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(162, 52);
            this.btnResetPass.TabIndex = 60;
            this.btnResetPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(131, 100);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(249, 38);
            this.bunifuCustomLabel5.TabIndex = 58;
            this.bunifuCustomLabel5.Text = "RESET PASS USER";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(53, 211);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(131, 28);
            this.bunifuCustomLabel1.TabIndex = 59;
            this.bunifuCustomLabel1.Text = "Tên tài khoản:";
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMinimized.ImageActive")));
            this.btnMinimized.Location = new System.Drawing.Point(417, 3);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(50, 50);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 0;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Visible = false;
            this.btnMinimized.Zoom = 10;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageActive")));
            this.btnExit.Location = new System.Drawing.Point(455, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.White;
            this.paneltop.Controls.Add(this.LogoACB);
            this.paneltop.Controls.Add(this.btnMinimized);
            this.paneltop.Controls.Add(this.btnExit);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(2);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(508, 58);
            this.paneltop.TabIndex = 62;
            // 
            // LogoACB
            // 
            this.LogoACB.BackColor = System.Drawing.Color.Transparent;
            this.LogoACB.Image = ((System.Drawing.Image)(resources.GetObject("LogoACB.Image")));
            this.LogoACB.ImageActive = null;
            this.LogoACB.Location = new System.Drawing.Point(12, 6);
            this.LogoACB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoACB.Name = "LogoACB";
            this.LogoACB.Size = new System.Drawing.Size(81, 47);
            this.LogoACB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoACB.TabIndex = 43;
            this.LogoACB.TabStop = false;
            this.LogoACB.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.paneltop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmResetPass
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 422);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResetPass";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoACB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnResetPass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Panel paneltop;
        public Bunifu.Framework.UI.BunifuImageButton LogoACB;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}