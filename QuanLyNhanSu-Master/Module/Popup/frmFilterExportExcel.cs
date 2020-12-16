using Microsoft.Office.Interop.Excel;
using QuanLyNhanSu_Master.DAO;
using QuanLyNhanSu_Master.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master.Module.Popup
{
    public partial class frmFilterExportExcel : Form
    {
        public frmFilterExportExcel()
        {
            InitializeComponent();
            (new DropShadow()).ApplyShadows(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAllPhongBan_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //if (.GetItemChecked(0))
            //    for (int i = 0; i < cbAllPhongBan.Items.Count; i++)
            //        cbAllPhongBan.SetItemChecked(i, true);
            //else
            //    for (int i = 0; i < cbAllPhongBan.Items.Count; i++)
            //        cbAllPhongBan.SetItemChecked(i, false);
        }

        private void cbAllGender_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cbAllGender.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = cbAllGender.CheckedIndices[0];
                    cbAllGender.ItemCheck -= cbAllGender_ItemCheck;
                    cbAllGender.SetItemChecked(checkedItemIndex, false);
                    cbAllGender.ItemCheck += cbAllGender_ItemCheck;
                }

                return;
            }
        }

        private void frmFilterExportExcel_Load(object sender, EventArgs e)
        {

            List<PhongBan> phongBan = HoSoNhanVienDAO.Instance.GetAllPhongBan();
           
            foreach (PhongBan phong in phongBan)
            {
                cbAllPhongBan.Items.Add(phong.TenPhongBan);
            }
            cbAllPhongBan.SetItemChecked(0, true);
            cbAllGender.SetItemChecked(0, true);
            cbTinhTrangLamViec.SetItemChecked(0, true);

        }

        private void cbTinhTrangLamViec_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cbTinhTrangLamViec.CheckedItems.Count == 1)
            {
                Boolean isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = cbTinhTrangLamViec.CheckedIndices[0];
                    cbTinhTrangLamViec.ItemCheck -= cbTinhTrangLamViec_ItemCheck;
                    cbTinhTrangLamViec.SetItemChecked(checkedItemIndex, false);
                    cbTinhTrangLamViec.ItemCheck += cbTinhTrangLamViec_ItemCheck;
                }

                return;
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }
        public void thred()
        {

            Thread thread = new Thread(ExportExcel);
            thread.IsBackground = true;
            thread.Start();
        }
        public void ExportExcel()
        {
            string ListPhongBan = "";
            string Gender = "";
            string TinhTrangLamViec = "";
            string Query = ""; 
            if (cbAllPhongBan.GetItemChecked(0))
            {
                ListPhongBan = HoSoNhanVienDAO.Instance.GetAllPhongBanToString();
            }
            else
            {
                ListPhongBan = "";
                foreach (var item in cbAllPhongBan.CheckedItems)
                {
                    ListPhongBan += item + ",";
                }
            }
            Query += " PB.TenPhongBan IN (SELECT CONVERT(NVARCHAR(4000), Item) FROM SplitString('" + ListPhongBan + "', ',')) ";

            if (cbAllGender.GetItemChecked(0))
            {
                Gender = "'1,0'";
            }
            else
            {
                foreach (var item in cbAllGender.CheckedItems)
                {
                    if (item == "Nam")
                    {
                        Gender = "1";
                    }
                    if (item == "Nữ")
                    {
                        Gender = "0";
                    }
                }
            }
            Query += " and NV.GioiTinh IN(SELECT CONVERT(bit, Item) FROM SplitString(" + Gender + ", ',')) ";

            if (cbTinhTrangLamViec.GetItemChecked(0))
            {
                TinhTrangLamViec += "'Đang làm,Đã nghỉ'";
            }
            else
            {
                foreach (var item in cbTinhTrangLamViec.CheckedItems)
                {
                    if (item == "Đang làm")
                    {
                        TinhTrangLamViec = "'Đang làm'";
                    }
                    if (item == "Đã nghỉ")
                    {
                        TinhTrangLamViec = "'Đã nghỉ'";
                    }
                }
            }
            Query += " and NV.TinhTrangLamViec IN (SELECT CONVERT(NVARCHAR(4000), Item) FROM SplitString(N" + TinhTrangLamViec + ", ',')) ";

            System.Data.DataTable dataTable2 = new System.Data.DataTable();
            dataTable2 = HoSoNhanVienDAO.Instance.GetFilterNhanVien(Query);


            //IsExport = true;
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
                range = xlWorkSheet.Range["J2", "A" + intRowCount];
                range.NumberFormat = "0";

                xlWorkSheet.Columns.AutoFit();
                xlWorkBook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                xl.Visible = true;
                if (xlWorkSheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                if (xlWorkBook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
                if (xl != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(xl);
                // Exit from the application  
                // xl.Quit();
            }

        }

        private void FormatExportExcel()
        {

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
    }
}
