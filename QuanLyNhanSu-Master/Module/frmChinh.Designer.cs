using Bunifu.Framework.UI;

namespace QuanLyNhanSu_Master
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LogoACB = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.iconSearch = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PanelNghiepVu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKhaiBaoPhongBan = new System.Windows.Forms.Button();
            this.btnNghiepVu = new System.Windows.Forms.Button();
            this.iconDashboard = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.iconBangLuong = new Bunifu.Framework.UI.BunifuImageButton();
            this.iconChamCong = new Bunifu.Framework.UI.BunifuImageButton();
            this.iconNhanVien = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExport = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnImport = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnAddNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgBtnAddNew = new Bunifu.Framework.UI.BunifuImageButton();
            this.TimerNghiepVu = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.PanelNghiepVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDashboard)).BeginInit();
            this.PanelCenter.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBangLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBtnAddNew)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(173)))));
            this.PanelTop.Controls.Add(this.LogoACB);
            this.PanelTop.Controls.Add(this.btnMinimized);
            this.PanelTop.Controls.Add(this.bunifuImageButton1);
            this.PanelTop.Controls.Add(this.btnExit);
            this.PanelTop.Controls.Add(this.iconSearch);
            this.PanelTop.Controls.Add(this.iconPictureBox1);
            this.PanelTop.Controls.Add(this.txtSearch);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1379, 53);
            this.PanelTop.TabIndex = 0;
            // 
            // LogoACB
            // 
            this.LogoACB.BackColor = System.Drawing.Color.Transparent;
            this.LogoACB.color = System.Drawing.Color.Transparent;
            this.LogoACB.colorActive = System.Drawing.Color.Transparent;
            this.LogoACB.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogoACB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoACB.ForeColor = System.Drawing.Color.Transparent;
            this.LogoACB.Image = ((System.Drawing.Image)(resources.GetObject("LogoACB.Image")));
            this.LogoACB.ImagePosition = 0;
            this.LogoACB.ImageZoom = 70;
            this.LogoACB.LabelPosition = 0;
            this.LogoACB.LabelText = "";
            this.LogoACB.Location = new System.Drawing.Point(13, -8);
            this.LogoACB.Margin = new System.Windows.Forms.Padding(4);
            this.LogoACB.Name = "LogoACB";
            this.LogoACB.Size = new System.Drawing.Size(98, 61);
            this.LogoACB.TabIndex = 0;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMinimized.ImageActive")));
            this.btnMinimized.Location = new System.Drawing.Point(1288, -2);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(50, 50);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 3;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Zoom = 10;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1568, 7);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 24;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageActive")));
            this.btnExit.Location = new System.Drawing.Point(1326, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // iconSearch
            // 
            this.iconSearch.BackColor = System.Drawing.Color.White;
            this.iconSearch.ForeColor = System.Drawing.Color.Black;
            this.iconSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconSearch.IconColor = System.Drawing.Color.Black;
            this.iconSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSearch.IconSize = 28;
            this.iconSearch.Location = new System.Drawing.Point(229, 12);
            this.iconSearch.Margin = new System.Windows.Forms.Padding(4);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.iconSearch.Size = new System.Drawing.Size(33, 28);
            this.iconSearch.TabIndex = 2;
            this.iconSearch.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(1517, 7);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "Tìm kiếm hồ sơ nhân sự";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.White;
            this.txtSearch.LineIdleColor = System.Drawing.Color.White;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtSearch.LineThickness = 4;
            this.txtSearch.Location = new System.Drawing.Point(229, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.txtSearch.Size = new System.Drawing.Size(341, 34);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // PanelNghiepVu
            // 
            this.PanelNghiepVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.PanelNghiepVu.Controls.Add(this.button3);
            this.PanelNghiepVu.Controls.Add(this.button2);
            this.PanelNghiepVu.Controls.Add(this.button1);
            this.PanelNghiepVu.Controls.Add(this.btnKhaiBaoPhongBan);
            this.PanelNghiepVu.Controls.Add(this.btnNghiepVu);
            this.PanelNghiepVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNghiepVu.Location = new System.Drawing.Point(0, 240);
            this.PanelNghiepVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelNghiepVu.MaximumSize = new System.Drawing.Size(229, 502);
            this.PanelNghiepVu.MinimumSize = new System.Drawing.Size(229, 71);
            this.PanelNghiepVu.Name = "PanelNghiepVu";
            this.PanelNghiepVu.Size = new System.Drawing.Size(229, 71);
            this.PanelNghiepVu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cập nhật tiền lương";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnKhaiBaoPhongBan
            // 
            this.btnKhaiBaoPhongBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhaiBaoPhongBan.FlatAppearance.BorderSize = 0;
            this.btnKhaiBaoPhongBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnKhaiBaoPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhaiBaoPhongBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhaiBaoPhongBan.Location = new System.Drawing.Point(0, 71);
            this.btnKhaiBaoPhongBan.Name = "btnKhaiBaoPhongBan";
            this.btnKhaiBaoPhongBan.Size = new System.Drawing.Size(229, 71);
            this.btnKhaiBaoPhongBan.TabIndex = 0;
            this.btnKhaiBaoPhongBan.Text = "Cập nhật phòng ban";
            this.btnKhaiBaoPhongBan.UseVisualStyleBackColor = true;
            // 
            // btnNghiepVu
            // 
            this.btnNghiepVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNghiepVu.FlatAppearance.BorderSize = 0;
            this.btnNghiepVu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNghiepVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghiepVu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNghiepVu.Location = new System.Drawing.Point(0, 0);
            this.btnNghiepVu.Name = "btnNghiepVu";
            this.btnNghiepVu.Size = new System.Drawing.Size(229, 71);
            this.btnNghiepVu.TabIndex = 0;
            this.btnNghiepVu.Text = "Nghiệp vụ";
            this.btnNghiepVu.UseVisualStyleBackColor = true;
            this.btnNghiepVu.Click += new System.EventHandler(this.btnNghiepVu_Click);
            // 
            // iconDashboard
            // 
            this.iconDashboard.BackColor = System.Drawing.Color.Transparent;
            this.iconDashboard.Image = ((System.Drawing.Image)(resources.GetObject("iconDashboard.Image")));
            this.iconDashboard.ImageActive = ((System.Drawing.Image)(resources.GetObject("iconDashboard.ImageActive")));
            this.iconDashboard.Location = new System.Drawing.Point(13, 10);
            this.iconDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconDashboard.Name = "iconDashboard";
            this.iconDashboard.Size = new System.Drawing.Size(40, 40);
            this.iconDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconDashboard.TabIndex = 3;
            this.iconDashboard.TabStop = false;
            this.iconDashboard.Tag = "";
            this.iconDashboard.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelCenter
            // 
            this.PanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.PanelCenter.Controls.Add(this.PanelLeft);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(0, 125);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(1379, 655);
            this.PanelCenter.TabIndex = 2;
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.PanelLeft.Controls.Add(this.PanelNghiepVu);
            this.PanelLeft.Controls.Add(this.iconBangLuong);
            this.PanelLeft.Controls.Add(this.iconChamCong);
            this.PanelLeft.Controls.Add(this.iconNhanVien);
            this.PanelLeft.Controls.Add(this.iconDashboard);
            this.PanelLeft.Controls.Add(this.btnBangLuong);
            this.PanelLeft.Controls.Add(this.btnChamCong);
            this.PanelLeft.Controls.Add(this.btnNhanVien);
            this.PanelLeft.Controls.Add(this.btnDashboard);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(229, 655);
            this.PanelLeft.TabIndex = 0;
            // 
            // iconBangLuong
            // 
            this.iconBangLuong.BackColor = System.Drawing.Color.Transparent;
            this.iconBangLuong.Image = ((System.Drawing.Image)(resources.GetObject("iconBangLuong.Image")));
            this.iconBangLuong.ImageActive = ((System.Drawing.Image)(resources.GetObject("iconBangLuong.ImageActive")));
            this.iconBangLuong.Location = new System.Drawing.Point(13, 190);
            this.iconBangLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconBangLuong.Name = "iconBangLuong";
            this.iconBangLuong.Size = new System.Drawing.Size(40, 40);
            this.iconBangLuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBangLuong.TabIndex = 3;
            this.iconBangLuong.TabStop = false;
            this.iconBangLuong.Tag = "";
            this.iconBangLuong.Zoom = 10;
            // 
            // iconChamCong
            // 
            this.iconChamCong.BackColor = System.Drawing.Color.Transparent;
            this.iconChamCong.Image = ((System.Drawing.Image)(resources.GetObject("iconChamCong.Image")));
            this.iconChamCong.ImageActive = ((System.Drawing.Image)(resources.GetObject("iconChamCong.ImageActive")));
            this.iconChamCong.Location = new System.Drawing.Point(13, 130);
            this.iconChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconChamCong.Name = "iconChamCong";
            this.iconChamCong.Size = new System.Drawing.Size(40, 40);
            this.iconChamCong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconChamCong.TabIndex = 3;
            this.iconChamCong.TabStop = false;
            this.iconChamCong.Tag = "";
            this.iconChamCong.Zoom = 10;
            // 
            // iconNhanVien
            // 
            this.iconNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.iconNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("iconNhanVien.Image")));
            this.iconNhanVien.ImageActive = ((System.Drawing.Image)(resources.GetObject("iconNhanVien.ImageActive")));
            this.iconNhanVien.Location = new System.Drawing.Point(13, 70);
            this.iconNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconNhanVien.Name = "iconNhanVien";
            this.iconNhanVien.Size = new System.Drawing.Size(40, 40);
            this.iconNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconNhanVien.TabIndex = 3;
            this.iconNhanVien.TabStop = false;
            this.iconNhanVien.Tag = "";
            this.iconNhanVien.Zoom = 10;
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBangLuong.FlatAppearance.BorderSize = 0;
            this.btnBangLuong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBangLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangLuong.Location = new System.Drawing.Point(0, 180);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBangLuong.Size = new System.Drawing.Size(229, 60);
            this.btnBangLuong.TabIndex = 1;
            this.btnBangLuong.Text = "Bảng lương";
            this.btnBangLuong.UseVisualStyleBackColor = true;
            this.btnBangLuong.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Location = new System.Drawing.Point(0, 120);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnChamCong.Size = new System.Drawing.Size(229, 60);
            this.btnChamCong.TabIndex = 1;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Location = new System.Drawing.Point(0, 60);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(229, 60);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Hồ sơ nhân sự";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(229, 60);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.imgBtnAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 72);
            this.panel1.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(173)))));
            this.lblStatus.Location = new System.Drawing.Point(231, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(129, 28);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "DASHBOARD";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.color = System.Drawing.Color.Transparent;
            this.btnExport.colorActive = System.Drawing.Color.Transparent;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImagePosition = 5;
            this.btnExport.ImageZoom = 50;
            this.btnExport.LabelPosition = 21;
            this.btnExport.LabelText = "Export";
            this.btnExport.Location = new System.Drawing.Point(1162, 9);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(56, 54);
            this.btnExport.TabIndex = 0;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 0;
            this.bunifuTileButton1.ImageZoom = 40;
            this.bunifuTileButton1.LabelPosition = 21;
            this.bunifuTileButton1.LabelText = "Cài đặt";
            this.bunifuTileButton1.Location = new System.Drawing.Point(1306, 17);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(61, 46);
            this.bunifuTileButton1.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.color = System.Drawing.Color.Transparent;
            this.btnImport.colorActive = System.Drawing.Color.Transparent;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImagePosition = 5;
            this.btnImport.ImageZoom = 50;
            this.btnImport.LabelPosition = 21;
            this.btnImport.LabelText = "Import";
            this.btnImport.Location = new System.Drawing.Point(1226, 9);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(56, 54);
            this.btnImport.TabIndex = 0;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Activecolor = System.Drawing.Color.Transparent;
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.BorderRadius = 0;
            this.btnAddNew.ButtonText = "Tạo mới";
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(173)))));
            this.btnAddNew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddNew.Iconimage = null;
            this.btnAddNew.Iconimage_right = null;
            this.btnAddNew.Iconimage_right_Selected = null;
            this.btnAddNew.Iconimage_Selected = null;
            this.btnAddNew.IconMarginLeft = 0;
            this.btnAddNew.IconMarginRight = 0;
            this.btnAddNew.IconRightVisible = true;
            this.btnAddNew.IconRightZoom = 0D;
            this.btnAddNew.IconVisible = true;
            this.btnAddNew.IconZoom = 90D;
            this.btnAddNew.IsTab = false;
            this.btnAddNew.Location = new System.Drawing.Point(76, 17);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddNew.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAddNew.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(34)))), ((int)(((byte)(110)))));
            this.btnAddNew.selected = false;
            this.btnAddNew.Size = new System.Drawing.Size(92, 39);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Tạo mới";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNew.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(71)))), ((int)(((byte)(173)))));
            this.btnAddNew.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // imgBtnAddNew
            // 
            this.imgBtnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.imgBtnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("imgBtnAddNew.Image")));
            this.imgBtnAddNew.ImageActive = null;
            this.imgBtnAddNew.Location = new System.Drawing.Point(27, 17);
            this.imgBtnAddNew.Name = "imgBtnAddNew";
            this.imgBtnAddNew.Size = new System.Drawing.Size(40, 40);
            this.imgBtnAddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBtnAddNew.TabIndex = 0;
            this.imgBtnAddNew.TabStop = false;
            this.imgBtnAddNew.Zoom = 5;
            this.imgBtnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // TimerNghiepVu
            // 
            this.TimerNghiepVu.Interval = 1;
            this.TimerNghiepVu.Tick += new System.EventHandler(this.TimerNghiepVu_Tick);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 71);
            this.button2.TabIndex = 0;
            this.button2.Text = "Khai báo phòng ban";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 71);
            this.button3.TabIndex = 0;
            this.button3.Text = "Khai báo phòng ban";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 780);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTop);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChinh";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.PanelNghiepVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconDashboard)).EndInit();
            this.PanelCenter.ResumeLayout(false);
            this.PanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBtnAddNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PanelNghiepVu;
        private System.Windows.Forms.Panel PanelTop;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconSearch;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton iconDashboard;
        public Bunifu.Framework.UI.BunifuImageButton btnMinimized;
        public Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Panel panel1;
        private BunifuImageButton imgBtnAddNew;
        private BunifuFlatButton btnAddNew;
        private BunifuTileButton btnImport;
        private BunifuTileButton btnExport;
        private BunifuTileButton LogoACB;
        private BunifuTileButton bunifuTileButton1;
        private BunifuCustomLabel lblStatus;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnNhanVien;
        private BunifuImageButton iconBangLuong;
        private BunifuImageButton iconChamCong;
        private BunifuImageButton iconNhanVien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKhaiBaoPhongBan;
        private System.Windows.Forms.Button btnNghiepVu;
        private System.Windows.Forms.Timer TimerNghiepVu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

