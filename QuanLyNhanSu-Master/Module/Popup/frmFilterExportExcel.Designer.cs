namespace QuanLyNhanSu_Master.Module.Popup
{
    partial class frmFilterExportExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilterExportExcel));
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.paneltop = new System.Windows.Forms.Panel();
            this.LogoACB = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbExcel = new System.Windows.Forms.RadioButton();
            this.rbPDF = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTinhTrangLamViec = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAllGender = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAllPhongBan = new System.Windows.Forms.CheckedListBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoACB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.PanelCenter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.paneltop;
            this.DragControl.Vertical = true;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.paneltop.Controls.Add(this.LogoACB);
            this.paneltop.Controls.Add(this.btnMinimized);
            this.paneltop.Controls.Add(this.btnExit);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(2);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(664, 58);
            this.paneltop.TabIndex = 11;
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
            this.LogoACB.TabIndex = 44;
            this.LogoACB.TabStop = false;
            this.LogoACB.Zoom = 10;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMinimized.ImageActive")));
            this.btnMinimized.Location = new System.Drawing.Point(573, 3);
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
            this.btnExit.Location = new System.Drawing.Point(611, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PanelCenter
            // 
            this.PanelCenter.Controls.Add(this.panel1);
            this.PanelCenter.Controls.Add(this.bunifuCustomLabel1);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(0, 58);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(664, 528);
            this.PanelCenter.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(60, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 445);
            this.panel1.TabIndex = 63;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.ActiveBorderThickness = 1;
            this.btnExportExcel.ActiveCornerRadius = 20;
            this.btnExportExcel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.btnExportExcel.ActiveForecolor = System.Drawing.Color.White;
            this.btnExportExcel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.btnExportExcel.BackColor = System.Drawing.Color.White;
            this.btnExportExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.BackgroundImage")));
            this.btnExportExcel.ButtonText = "Xuất File";
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnExportExcel.IdleBorderThickness = 1;
            this.btnExportExcel.IdleCornerRadius = 20;
            this.btnExportExcel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnExportExcel.IdleForecolor = System.Drawing.Color.White;
            this.btnExportExcel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnExportExcel.Location = new System.Drawing.Point(340, 392);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(146, 53);
            this.btnExportExcel.TabIndex = 65;
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbExcel);
            this.groupBox4.Controls.Add(this.rbPDF);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(337, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 105);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Loại File";
            // 
            // rbExcel
            // 
            this.rbExcel.AutoSize = true;
            this.rbExcel.Location = new System.Drawing.Point(12, 62);
            this.rbExcel.Name = "rbExcel";
            this.rbExcel.Size = new System.Drawing.Size(69, 27);
            this.rbExcel.TabIndex = 1;
            this.rbExcel.TabStop = true;
            this.rbExcel.Text = "Excel";
            this.rbExcel.UseVisualStyleBackColor = true;
            // 
            // rbPDF
            // 
            this.rbPDF.AutoSize = true;
            this.rbPDF.Location = new System.Drawing.Point(12, 29);
            this.rbPDF.Name = "rbPDF";
            this.rbPDF.Size = new System.Drawing.Size(55, 27);
            this.rbPDF.TabIndex = 1;
            this.rbPDF.TabStop = true;
            this.rbPDF.Text = "Pdf";
            this.rbPDF.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTinhTrangLamViec);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(62, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 105);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tình trạng làm việc";
            // 
            // cbTinhTrangLamViec
            // 
            this.cbTinhTrangLamViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbTinhTrangLamViec.CheckOnClick = true;
            this.cbTinhTrangLamViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTinhTrangLamViec.FormattingEnabled = true;
            this.cbTinhTrangLamViec.Items.AddRange(new object[] {
            "All",
            "Đang làm",
            "Đã nghỉ"});
            this.cbTinhTrangLamViec.Location = new System.Drawing.Point(3, 26);
            this.cbTinhTrangLamViec.Name = "cbTinhTrangLamViec";
            this.cbTinhTrangLamViec.Size = new System.Drawing.Size(261, 76);
            this.cbTinhTrangLamViec.TabIndex = 0;
            this.cbTinhTrangLamViec.ThreeDCheckBoxes = true;
            this.cbTinhTrangLamViec.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbTinhTrangLamViec_ItemCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAllGender);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(334, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 240);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // cbAllGender
            // 
            this.cbAllGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbAllGender.CheckOnClick = true;
            this.cbAllGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAllGender.FormattingEnabled = true;
            this.cbAllGender.Items.AddRange(new object[] {
            "Nam & Nữ",
            "Nam",
            "Nữ"});
            this.cbAllGender.Location = new System.Drawing.Point(3, 26);
            this.cbAllGender.Name = "cbAllGender";
            this.cbAllGender.Size = new System.Drawing.Size(146, 211);
            this.cbAllGender.TabIndex = 0;
            this.cbAllGender.ThreeDCheckBoxes = true;
            this.cbAllGender.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbAllGender_ItemCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAllPhongBan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 240);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng ban";
            // 
            // cbAllPhongBan
            // 
            this.cbAllPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbAllPhongBan.CheckOnClick = true;
            this.cbAllPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAllPhongBan.FormattingEnabled = true;
            this.cbAllPhongBan.Items.AddRange(new object[] {
            "All phòng ban"});
            this.cbAllPhongBan.Location = new System.Drawing.Point(3, 26);
            this.cbAllPhongBan.Name = "cbAllPhongBan";
            this.cbAllPhongBan.Size = new System.Drawing.Size(263, 211);
            this.cbAllPhongBan.TabIndex = 0;
            this.cbAllPhongBan.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbAllPhongBan_ItemCheck);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(212, 4);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(221, 32);
            this.bunifuCustomLabel1.TabIndex = 62;
            this.bunifuCustomLabel1.Text = "Tùy chọn xuất File";
            // 
            // frmFilterExportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 586);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilterExportExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFilterExportExcel";
            this.Load += new System.EventHandler(this.frmFilterExportExcel_Load);
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoACB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.PanelCenter.ResumeLayout(false);
            this.PanelCenter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Panel paneltop;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        public Bunifu.Framework.UI.BunifuImageButton LogoACB;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExportExcel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox cbTinhTrangLamViec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox cbAllGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox cbAllPhongBan;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbExcel;
        private System.Windows.Forms.RadioButton rbPDF;
    }
}