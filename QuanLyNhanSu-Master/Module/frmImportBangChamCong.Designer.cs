namespace QuanLyNhanSu_Master.Module
{
    partial class frmImportBangChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportBangChamCong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltop = new System.Windows.Forms.Panel();
            this.LogoACB = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GridImportBangChamCong = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveToDB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.cbAllowUpdate = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoACB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridImportBangChamCong)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.White;
            this.paneltop.Controls.Add(this.LogoACB);
            this.paneltop.Controls.Add(this.btnMinimized);
            this.paneltop.Controls.Add(this.btnExit);
            this.paneltop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(2);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(994, 58);
            this.paneltop.TabIndex = 63;
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
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMinimized.ImageActive")));
            this.btnMinimized.Location = new System.Drawing.Point(903, 3);
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
            this.btnExit.Location = new System.Drawing.Point(941, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.GridImportBangChamCong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 642);
            this.panel1.TabIndex = 64;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 54);
            this.panel3.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(487, 28);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Import Bảng chấm công nhân viên tháng 01/2020";
            // 
            // GridImportBangChamCong
            // 
            this.GridImportBangChamCong.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridImportBangChamCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridImportBangChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridImportBangChamCong.BackgroundColor = System.Drawing.Color.White;
            this.GridImportBangChamCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridImportBangChamCong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridImportBangChamCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridImportBangChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridImportBangChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridImportBangChamCong.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridImportBangChamCong.DoubleBuffered = true;
            this.GridImportBangChamCong.EnableHeadersVisualStyles = false;
            this.GridImportBangChamCong.GridColor = System.Drawing.Color.LightGray;
            this.GridImportBangChamCong.HeaderBgColor = System.Drawing.Color.White;
            this.GridImportBangChamCong.HeaderForeColor = System.Drawing.Color.Black;
            this.GridImportBangChamCong.Location = new System.Drawing.Point(12, 60);
            this.GridImportBangChamCong.Name = "GridImportBangChamCong";
            this.GridImportBangChamCong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridImportBangChamCong.RowTemplate.Height = 24;
            this.GridImportBangChamCong.Size = new System.Drawing.Size(970, 509);
            this.GridImportBangChamCong.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.cbAllowUpdate);
            this.panel2.Controls.Add(this.btnSaveToDB);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 633);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 67);
            this.panel2.TabIndex = 65;
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.ActiveBorderThickness = 1;
            this.btnSaveToDB.ActiveCornerRadius = 20;
            this.btnSaveToDB.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.btnSaveToDB.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaveToDB.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.btnSaveToDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.btnSaveToDB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveToDB.BackgroundImage")));
            this.btnSaveToDB.ButtonText = "Lưu";
            this.btnSaveToDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveToDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnSaveToDB.IdleBorderThickness = 1;
            this.btnSaveToDB.IdleCornerRadius = 20;
            this.btnSaveToDB.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnSaveToDB.IdleForecolor = System.Drawing.Color.White;
            this.btnSaveToDB.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnSaveToDB.Location = new System.Drawing.Point(823, 5);
            this.btnSaveToDB.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(144, 52);
            this.btnSaveToDB.TabIndex = 61;
            this.btnSaveToDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 23);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Text";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.paneltop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // cbAllowUpdate
            // 
            this.cbAllowUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbAllowUpdate.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbAllowUpdate.Checked = false;
            this.cbAllowUpdate.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbAllowUpdate.Enabled = false;
            this.cbAllowUpdate.ForeColor = System.Drawing.Color.White;
            this.cbAllowUpdate.Location = new System.Drawing.Point(581, 24);
            this.cbAllowUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAllowUpdate.Name = "cbAllowUpdate";
            this.cbAllowUpdate.Size = new System.Drawing.Size(20, 20);
            this.cbAllowUpdate.TabIndex = 62;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(608, 21);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(207, 23);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Cập nhật dữ liệu( Admin )";
            // 
            // frmImportBangChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImportBangChamCong";
            this.Text = "frmImportBangChamCong";
            this.paneltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoACB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridImportBangChamCong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        public Bunifu.Framework.UI.BunifuImageButton LogoACB;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuCustomDataGrid GridImportBangChamCong;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStatus;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveToDB;
        private Bunifu.Framework.UI.BunifuCheckbox cbAllowUpdate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}