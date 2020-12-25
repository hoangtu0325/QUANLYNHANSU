namespace QuanLyNhanSu_Master.Module
{
    partial class frmChiLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiLuong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbListMonth = new System.Windows.Forms.ComboBox();
            this.GridBangChiLuong = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblCountMoney = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.labelss = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBangChiLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cbListMonth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 49);
            this.panel1.TabIndex = 0;
            // 
            // cbListMonth
            // 
            this.cbListMonth.BackColor = System.Drawing.SystemColors.Menu;
            this.cbListMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListMonth.DropDownWidth = 162;
            this.cbListMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbListMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListMonth.FormattingEnabled = true;
            this.cbListMonth.ItemHeight = 28;
            this.cbListMonth.Location = new System.Drawing.Point(23, 7);
            this.cbListMonth.Name = "cbListMonth";
            this.cbListMonth.Size = new System.Drawing.Size(162, 36);
            this.cbListMonth.TabIndex = 27;
            this.cbListMonth.SelectedIndexChanged += new System.EventHandler(this.cbListMonth_SelectedIndexChanged);
            // 
            // GridBangChiLuong
            // 
            this.GridBangChiLuong.AllowUserToAddRows = false;
            this.GridBangChiLuong.AllowUserToDeleteRows = false;
            this.GridBangChiLuong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridBangChiLuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridBangChiLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridBangChiLuong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridBangChiLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridBangChiLuong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridBangChiLuong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridBangChiLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridBangChiLuong.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridBangChiLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridBangChiLuong.DoubleBuffered = true;
            this.GridBangChiLuong.EnableHeadersVisualStyles = false;
            this.GridBangChiLuong.GridColor = System.Drawing.Color.LightGray;
            this.GridBangChiLuong.HeaderBgColor = System.Drawing.Color.White;
            this.GridBangChiLuong.HeaderForeColor = System.Drawing.Color.Black;
            this.GridBangChiLuong.Location = new System.Drawing.Point(23, 49);
            this.GridBangChiLuong.Name = "GridBangChiLuong";
            this.GridBangChiLuong.ReadOnly = true;
            this.GridBangChiLuong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridBangChiLuong.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GridBangChiLuong.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridBangChiLuong.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GridBangChiLuong.RowTemplate.Height = 40;
            this.GridBangChiLuong.Size = new System.Drawing.Size(1042, 604);
            this.GridBangChiLuong.TabIndex = 2;
            // 
            // lblCountMoney
            // 
            this.lblCountMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCountMoney.AutoSize = true;
            this.lblCountMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblCountMoney.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountMoney.ForeColor = System.Drawing.Color.Black;
            this.lblCountMoney.Location = new System.Drawing.Point(118, 661);
            this.lblCountMoney.Name = "lblCountMoney";
            this.lblCountMoney.Size = new System.Drawing.Size(32, 25);
            this.lblCountMoney.TabIndex = 9;
            this.lblCountMoney.Text = "10";
            // 
            // labelss
            // 
            this.labelss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelss.AutoSize = true;
            this.labelss.BackColor = System.Drawing.Color.Transparent;
            this.labelss.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelss.ForeColor = System.Drawing.Color.DimGray;
            this.labelss.Location = new System.Drawing.Point(18, 661);
            this.labelss.Name = "labelss";
            this.labelss.Size = new System.Drawing.Size(95, 25);
            this.labelss.TabIndex = 10;
            this.labelss.Text = "Tổng NV :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.GridBangChiLuong;
            // 
            // btnExport
            // 
            this.btnExport.ActiveBorderThickness = 1;
            this.btnExport.ActiveCornerRadius = 20;
            this.btnExport.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.btnExport.ActiveForecolor = System.Drawing.Color.White;
            this.btnExport.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.ButtonText = "Xuất";
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnExport.IdleBorderThickness = 1;
            this.btnExport.IdleCornerRadius = 20;
            this.btnExport.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnExport.IdleForecolor = System.Drawing.Color.White;
            this.btnExport.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(184)))));
            this.btnExport.Location = new System.Drawing.Point(972, 654);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(93, 42);
            this.btnExport.TabIndex = 62;
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmChiLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1087, 695);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblCountMoney);
            this.Controls.Add(this.labelss);
            this.Controls.Add(this.GridBangChiLuong);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChiLuong";
            this.Text = "frmChiLuong";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBangChiLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbListMonth;
        public Bunifu.Framework.UI.BunifuCustomDataGrid GridBangChiLuong;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCountMoney;
        private Bunifu.Framework.UI.BunifuCustomLabel labelss;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExport;
    }
}