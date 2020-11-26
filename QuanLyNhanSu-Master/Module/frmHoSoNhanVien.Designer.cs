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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.buniDataGridHoSoNhanVien = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.buniDataGridHoSoNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // buniDataGridHoSoNhanVien
            // 
            this.buniDataGridHoSoNhanVien.AllowUserToAddRows = false;
            this.buniDataGridHoSoNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buniDataGridHoSoNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.buniDataGridHoSoNhanVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.buniDataGridHoSoNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buniDataGridHoSoNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.buniDataGridHoSoNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buniDataGridHoSoNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.buniDataGridHoSoNhanVien.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.buniDataGridHoSoNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.buniDataGridHoSoNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buniDataGridHoSoNhanVien.DoubleBuffered = true;
            this.buniDataGridHoSoNhanVien.EnableHeadersVisualStyles = false;
            this.buniDataGridHoSoNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buniDataGridHoSoNhanVien.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(155)))));
            this.buniDataGridHoSoNhanVien.HeaderForeColor = System.Drawing.Color.White;
            this.buniDataGridHoSoNhanVien.Location = new System.Drawing.Point(0, 0);
            this.buniDataGridHoSoNhanVien.Name = "buniDataGridHoSoNhanVien";
            this.buniDataGridHoSoNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.buniDataGridHoSoNhanVien.RowHeadersVisible = false;
            this.buniDataGridHoSoNhanVien.RowTemplate.Height = 24;
            this.buniDataGridHoSoNhanVien.Size = new System.Drawing.Size(1148, 655);
            this.buniDataGridHoSoNhanVien.TabIndex = 0;
            // 
            // frmHoSoNhanVien
            // 
            this.ClientSize = new System.Drawing.Size(1148, 655);
            this.Controls.Add(this.buniDataGridHoSoNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoSoNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.buniDataGridHoSoNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid buniDataGridHoSoNhanVien;
    }
}