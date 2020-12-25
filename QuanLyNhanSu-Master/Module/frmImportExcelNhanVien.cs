using ExcelDataReader;
using QuanLyNhanSu_Master.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master.Module
{
    public partial class frmImportExcelNhanVien : Form
    {
        public static DataTable dataTable;
        DataTableCollection TableCollection;
        public frmImportExcelNhanVien()
        {
            InitializeComponent();
        }
        public string status;
        public void ImportExcel()
        {
            string tableName = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2020 Workbook|*.xls*" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.status = "Import Excel từ File - " + openFileDialog.SafeFileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            TableCollection = result.Tables;
                            tableName = TableCollection[0].TableName;
                        }
                    }
                    dataTable = TableCollection[tableName.ToString()];
                    dtGridViewChinh.DataSource = dataTable;
                    btnCount.Text += dtGridViewChinh.RowCount - 1;
                }
                else
                {
                    this.status = "None Import Excel";
                }
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            int CountRow = dtGridViewChinh.Rows.Count;
            int CountSuccess = 0;
            for (int i = 0; i <= dtGridViewChinh.Rows.Count - 1; i++)
            {
                try
                {
                    string TenNV = dataTable.Rows[i][0].ToString();
                    DateTime NgaySinh = (DateTime)dataTable.Rows[i][1];
                    string GioiTinh = dataTable.Rows[i][2].ToString();
                    string DiaChi = dataTable.Rows[i][3].ToString();
                    string Email = dataTable.Rows[i][4].ToString();
                    string Sdt = dataTable.Rows[i][5].ToString();
                    string Cmnd = dataTable.Rows[i][6].ToString();
                    DateTime NgayCap = (DateTime)dataTable.Rows[i][7];
                    string TenTinhThanh = dataTable.Rows[i][8].ToString();
                    string DanToc = dataTable.Rows[i][9].ToString();
                    string PhongBan = dataTable.Rows[i][10].ToString();
                    string TenChucVu = dataTable.Rows[i][11].ToString();
                    string MaBacLuong = dataTable.Rows[i][12].ToString();
                    string TinhTrangLamViec = dataTable.Rows[i][13].ToString();
                    string SoBHXH = dataTable.Rows[i][14].ToString();
                    string SoBHYT = dataTable.Rows[i][15].ToString();
                    string TaiKhoanNH = dataTable.Rows[i][16].ToString();
                    bool Status = HoSoNhanVienDAO.Instance.AddNewImployee(TenNV, NgaySinh, GioiTinh, DiaChi, Email, Sdt, Cmnd, NgayCap, TenTinhThanh, DanToc, PhongBan, TenChucVu, MaBacLuong, TinhTrangLamViec, SoBHXH, SoBHYT, TaiKhoanNH);
                    if (Status)
                    {
                        CountSuccess++;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            if (CountSuccess == CountRow)
            {
                MessageBox.Show("Import nhân viên thành công");

            }
            else
            {
                MessageBox.Show("Import thành công " + CountSuccess + " nhân viên");

            }
        }
    }
}
