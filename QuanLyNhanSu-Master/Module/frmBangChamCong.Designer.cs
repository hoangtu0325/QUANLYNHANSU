namespace QuanLyNhanSu_Master.Module
{
    partial class frmBangChamCong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbListMonth = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridBangChamCong = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBangChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cbListMonth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 51);
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
            this.cbListMonth.Location = new System.Drawing.Point(27, 9);
            this.cbListMonth.Name = "cbListMonth";
            this.cbListMonth.Size = new System.Drawing.Size(162, 36);
            this.cbListMonth.TabIndex = 26;
            this.cbListMonth.SelectedIndexChanged += new System.EventHandler(this.cbListMonth_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.GridBangChamCong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 724);
            this.panel2.TabIndex = 1;
            // 
            // GridBangChamCong
            // 
            this.GridBangChamCong.AllowUserToAddRows = false;
            this.GridBangChamCong.AllowUserToDeleteRows = false;
            this.GridBangChamCong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridBangChamCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridBangChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridBangChamCong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridBangChamCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridBangChamCong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridBangChamCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridBangChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridBangChamCong.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridBangChamCong.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridBangChamCong.DoubleBuffered = true;
            this.GridBangChamCong.EnableHeadersVisualStyles = false;
            this.GridBangChamCong.GridColor = System.Drawing.Color.LightGray;
            this.GridBangChamCong.HeaderBgColor = System.Drawing.Color.White;
            this.GridBangChamCong.HeaderForeColor = System.Drawing.Color.Black;
            this.GridBangChamCong.Location = new System.Drawing.Point(27, 6);
            this.GridBangChamCong.Name = "GridBangChamCong";
            this.GridBangChamCong.ReadOnly = true;
            this.GridBangChamCong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridBangChamCong.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GridBangChamCong.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridBangChamCong.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GridBangChamCong.RowTemplate.Height = 40;
            this.GridBangChamCong.Size = new System.Drawing.Size(1085, 689);
            this.GridBangChamCong.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.GridBangChamCong;
            // 
            // frmBangChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 775);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBangChamCong";
            this.Text = "frmBangChamCong";
            this.Load += new System.EventHandler(this.frmBangChamCong_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridBangChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbListMonth;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuCustomDataGrid GridBangChamCong;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}