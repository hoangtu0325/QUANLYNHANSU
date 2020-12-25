namespace QuanLyNhanSu_Master.Module
{
    partial class frmHoSoNhanVien
    {
       
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private  System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoSoNhanVien));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buniDataGridHoSoNhanVien = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPhongban = new System.Windows.Forms.ComboBox();
            this.btnPrevious = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblCountNhanVien = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label22 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExport = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.buniDataGridHoSoNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.buniDataGridHoSoNhanVien;
            // 
            // buniDataGridHoSoNhanVien
            // 
            this.buniDataGridHoSoNhanVien.AllowUserToAddRows = false;
            this.buniDataGridHoSoNhanVien.AllowUserToDeleteRows = false;
            this.buniDataGridHoSoNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.buniDataGridHoSoNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.buniDataGridHoSoNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buniDataGridHoSoNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.buniDataGridHoSoNhanVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.buniDataGridHoSoNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buniDataGridHoSoNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.buniDataGridHoSoNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buniDataGridHoSoNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.buniDataGridHoSoNhanVien.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.buniDataGridHoSoNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.buniDataGridHoSoNhanVien.DoubleBuffered = true;
            this.buniDataGridHoSoNhanVien.EnableHeadersVisualStyles = false;
            this.buniDataGridHoSoNhanVien.GridColor = System.Drawing.Color.LightGray;
            this.buniDataGridHoSoNhanVien.HeaderBgColor = System.Drawing.Color.White;
            this.buniDataGridHoSoNhanVien.HeaderForeColor = System.Drawing.Color.Black;
            this.buniDataGridHoSoNhanVien.Location = new System.Drawing.Point(31, 48);
            this.buniDataGridHoSoNhanVien.Name = "buniDataGridHoSoNhanVien";
            this.buniDataGridHoSoNhanVien.ReadOnly = true;
            this.buniDataGridHoSoNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.buniDataGridHoSoNhanVien.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.buniDataGridHoSoNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.buniDataGridHoSoNhanVien.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.buniDataGridHoSoNhanVien.RowTemplate.Height = 40;
            this.buniDataGridHoSoNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.buniDataGridHoSoNhanVien.Size = new System.Drawing.Size(1084, 559);
            this.buniDataGridHoSoNhanVien.TabIndex = 0;
            this.buniDataGridHoSoNhanVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buniDataGridHoSoNhanVien_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.cbPhongban);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lblCountNhanVien);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.buniDataGridHoSoNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 655);
            this.panel1.TabIndex = 1;
            // 
            // cbPhongban
            // 
            this.cbPhongban.BackColor = System.Drawing.SystemColors.Menu;
            this.cbPhongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongban.DropDownWidth = 162;
            this.cbPhongban.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPhongban.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhongban.FormattingEnabled = true;
            this.cbPhongban.ItemHeight = 28;
            this.cbPhongban.Location = new System.Drawing.Point(31, 6);
            this.cbPhongban.Name = "cbPhongban";
            this.cbPhongban.Size = new System.Drawing.Size(214, 36);
            this.cbPhongban.TabIndex = 27;
            this.cbPhongban.SelectedIndexChanged += new System.EventHandler(this.cbPhongban_SelectedIndexChanged);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageActive = null;
            this.btnPrevious.Location = new System.Drawing.Point(1000, 612);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 40);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Zoom = 10;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageActive = null;
            this.btnNext.Location = new System.Drawing.Point(1042, 612);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            this.btnNext.Zoom = 10;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCountNhanVien
            // 
            this.lblCountNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountNhanVien.AutoSize = true;
            this.lblCountNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblCountNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblCountNhanVien.Location = new System.Drawing.Point(176, 619);
            this.lblCountNhanVien.Name = "lblCountNhanVien";
            this.lblCountNhanVien.Size = new System.Drawing.Size(45, 28);
            this.lblCountNhanVien.TabIndex = 9;
            this.lblCountNhanVien.Text = "100";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(934, 619);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(60, 25);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "1 - 12";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gray;
            this.label22.Location = new System.Drawing.Point(26, 621);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(152, 25);
            this.label22.TabIndex = 9;
            this.label22.Text = "Tổng nhân viên :";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageActive = null;
            this.btnExport.Location = new System.Drawing.Point(1070, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(45, 36);
            this.btnExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExport.TabIndex = 28;
            this.btnExport.TabStop = false;
            this.btnExport.Zoom = 10;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmHoSoNhanVien
            // 
            this.ClientSize = new System.Drawing.Size(1148, 655);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoSoNhanVien";
            this.Load += new System.EventHandler(this.frmHoSoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buniDataGridHoSoNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid buniDataGridHoSoNhanVien;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel label22;
        private Bunifu.Framework.UI.BunifuImageButton btnNext;
        private Bunifu.Framework.UI.BunifuImageButton btnPrevious;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCountNhanVien;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cbPhongban;
        private Bunifu.Framework.UI.BunifuImageButton btnExport;
    }
}