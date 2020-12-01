namespace QuanLyNhanSu_Master.Module
{
    partial class frmImportExcelNhanVien
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtGridViewChinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewChinh)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dtGridViewChinh
            // 
            this.dtGridViewChinh.BackgroundColor = System.Drawing.Color.White;
            this.dtGridViewChinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewChinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewChinh.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewChinh.Name = "dtGridViewChinh";
            this.dtGridViewChinh.RowTemplate.Height = 24;
            this.dtGridViewChinh.Size = new System.Drawing.Size(1134, 715);
            this.dtGridViewChinh.TabIndex = 0;
            // 
            // frmImportExcelNhanViencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 715);
            this.Controls.Add(this.dtGridViewChinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImportExcelNhanViencs";
            this.Text = "frmImportExcelNhanViencs";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewChinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dtGridViewChinh;
    }
}