using QuanLyNhanSu_Master.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelEngine;
using Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Timers;
using QuanLyNhanSu_Master.Module.Popup;
using QuanLyNhanSu_Master.DTO;

namespace QuanLyNhanSu_Master.Module
{
    public partial class frmHoSoNhanVien : Form
    {
        public frmHoSoNhanVien(bool IsVisibleGrid)
        {
            InitializeComponent();
        }
        public static System.Data.DataTable dataTable;
        public static System.Data.DataTable dataTable2;
        private bool IsExport;

        public bool IsExport1
        {
            get { return IsExport; }
            set { IsExport = value; }
        }
        public static string Action = "";
        public static string TenNhanVien = "";
        public static int MaNhanVien;
        public DataGridView SetFieldType(DataGridView buniDataGridHoSoNhanVien)
        {
            buniDataGridHoSoNhanVien.Columns["Họ tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            buniDataGridHoSoNhanVien.Columns["Tên phòng ban"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            buniDataGridHoSoNhanVien.Columns["Giới tính"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            buniDataGridHoSoNhanVien.Columns["Họ tên"].Frozen = true;
            foreach (DataGridViewRow item in buniDataGridHoSoNhanVien.Rows)
            {
                if (item.Index == 1)
                {
                    item.DefaultCellStyle.BackColor = Color.FromArgb(31, 65, 155);
                }
            }
            lblCountNhanVien.Text = buniDataGridHoSoNhanVien.RowCount.ToString();
            return buniDataGridHoSoNhanVien;
        }

        public System.Data.DataTable GetNhanVienByFilter(string filter)
        {
            return HoSoNhanVienDAO.Instance.GetNhanVienByFilter(filter);
        }

        public System.Data.DataTable GetNhanVien(int MaNhanVien)
        {

          return  HoSoNhanVienDAO.Instance.GetNhanVien(MaNhanVien);
        }

        private void frmHoSoNhanVien_Load(object sender, EventArgs e)
        {
            if (Action == "Tìm kiếm")
            {
                //buniDataGridHoSoNhanVien.DataSource = GetNhanVien(TenNhanVien);
                buniDataGridHoSoNhanVien.DataSource = GetNhanVien(MaNhanVien);
                dataTable = (System.Data.DataTable)(buniDataGridHoSoNhanVien.DataSource);
                cbPhongban.Enabled = false;
            }
            if (Action == "Không tìm kiếm")
            {
                buniDataGridHoSoNhanVien.DataSource = GetNhanVienByFilter("All");
                dataTable = (System.Data.DataTable)(buniDataGridHoSoNhanVien.DataSource);
                cbPhongban.Items.Insert(0, "All");
                cbPhongban.SelectedIndex = 0;
                List<PhongBan> phongBan = HoSoNhanVienDAO.Instance.GetAllPhongBan();
                foreach (PhongBan item in phongBan)
                {
                    cbPhongban.Items.Add(item.TenPhongBan);
                }
                cbPhongban.ValueMember = "MaPhongBan";
                cbPhongban.DisplayMember = "TenPhongBan";
            }
            
            SetFieldType(buniDataGridHoSoNhanVien);
        }

        public void thred()
        {
            
            Thread thread = new Thread(ExportExcel);
            thread.IsBackground = true;
            thread.Start();
        }
        public void ExportExcel()
        {
            IsExport = true;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Exel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.FileName = null;
            saveFileDialog.Title = "Chọn thư mục lưu file ";
            
            string filepath = AppDomain.CurrentDomain.BaseDirectory;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application xl = null;
                _Workbook xlWorkBook = null;

                xl = new Microsoft.Office.Interop.Excel.Application();
                xl.Visible = false;
                xlWorkBook = (_Workbook)(xl.Workbooks.Add(XlWBATemplate.xlWBATWorksheet));
                _Worksheet xlWorkSheet = null;
                xlWorkSheet = xlWorkBook.Worksheets[1];
                int intColumnCount = dataTable2.Columns.Count;
                int intRowCount = dataTable2.Rows.Count;
                xlWorkSheet.Name = "Sheet_1";
                
                for (int i = 1; i < intColumnCount + 1; i++)
                {
                    xlWorkSheet.Cells[1, i] = dataTable2.Columns[i - 1].ColumnName;
                }
                Microsoft.Office.Interop.Excel.Range range = xlWorkSheet.Range["A1", DataGridViewToExcel_ByfinalColLetter(intColumnCount) + "1"];
                range.Font.Size = 16;
                range.Interior.ColorIndex = 36;
                for (int i = 0; i < intRowCount - 1; i++)
                {
                    for (int j = 0; j < intColumnCount; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dataTable2.Rows[i][j].ToString();
                    }
                }
                xlWorkSheet.Columns.AutoFit();
                xlWorkBook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                xl.Visible = true;
                if (xlWorkSheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                if (xlWorkBook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                if (xl != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(xl);
            }

        }
        public string DataGridViewToExcel_ByfinalColLetter(int lintColumnCount)
        {
            string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string finalColLetter = "";
            if (lintColumnCount > colCharset.Length)
                finalColLetter = colCharset.Substring((lintColumnCount - 1) / colCharset.Length - 1, 1);
            finalColLetter += colCharset.Substring((lintColumnCount - 1) % colCharset.Length, 1);

            return finalColLetter;
        }

        private void buniDataGridHoSoNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex != 0)
                {
                    int ID = (int)buniDataGridHoSoNhanVien.Rows[e.RowIndex].Cells["Mã NV"].Value;
                    frmInfoNhanVien frminfonhanvien = new frmInfoNhanVien(ID);
                    frminfonhanvien.TopLevel = false;
                    frminfonhanvien.MdiParent = this.MdiParent;
                    panel1.Controls.Add(frminfonhanvien);
                    buniDataGridHoSoNhanVien.Visible = false;
                    frminfonhanvien.Dock = DockStyle.Fill;
                    frminfonhanvien.Show();
                    frminfonhanvien.BringToFront();
                }

            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
        }

        private void cbPhongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PhongBan = cbPhongban.SelectedItem as string;
            if (PhongBan != null)
            {

                buniDataGridHoSoNhanVien.DataSource = GetNhanVienByFilter(PhongBan);
                lblCountNhanVien.Text = buniDataGridHoSoNhanVien.RowCount.ToString();

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            frmFilterExportExcel frmFilterExportExcel = new frmFilterExportExcel();
            frmFilterExportExcel.StartPosition = FormStartPosition.CenterScreen;
            frmFilterExportExcel.Show();
        }
    }
}
