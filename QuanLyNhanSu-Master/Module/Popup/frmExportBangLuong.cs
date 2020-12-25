using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
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
using System.IO;
using System.Reflection;

namespace QuanLyNhanSu_Master.Module.Popup
{
    public partial class frmExportBangLuong : Form
    {
        public frmExportBangLuong()
        {
            InitializeComponent();
            (new DropShadow()).ApplyShadows(this);
        }
        public static System.Data.DataTable Data;
        public static string date;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (rbExcel.Checked)
            {
                IsPdf = false;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Exel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 0;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.FileName = "Bảng chi lương";
                saveFileDialog.Title = "Chọn thư mục lưu file ";

                string filepath = AppDomain.CurrentDomain.BaseDirectory;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        openExcel(PathTemplate, Data);
                        closeExcel(saveFileDialog.FileName);
                        System.Diagnostics.Process.Start(saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        myExcelWorkbook.Close(Type.Missing, Type.Missing, Type.Missing);
                        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(myExcelWorkbook);
                        myExcelApplication.Quit();
                        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(myExcelApplication);
                        MessageBox.Show("Không tìm thấy file template!!");
                    }
                }
            }
            else
            {
                IsPdf = true;
                openExcel(PathTemplate, Data);
                closeExcel(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Template\\Temp.xlsx");
            }
        }
        private int startRowData = 9;
        Excel.Application myExcelApplication;
        Excel._Workbook myExcelWorkbook;
        bool IsPdf = false;
        private string PathTemplate = Application.StartupPath + "\\Template\\ReportBangChiLuong.xlsx";

        public void openExcel(string pathTemplate, DataTable dataTable)
        {
            Excel.Workbooks myExcelWorkbooks;
            Excel.Sheets Sheets;
            Excel._Worksheet myExcelWorkSheet;
            Excel.Range range;

            myExcelApplication = null;
            myExcelApplication = new Excel.Application(); // create Excell App
            myExcelApplication.DisplayAlerts = false; // turn off alerts
            myExcelWorkbooks = myExcelApplication.Workbooks;

            myExcelWorkbook = myExcelWorkbooks.Add(System.Reflection.Missing.Value);
            Sheets = myExcelWorkbook.Worksheets;
            myExcelWorkSheet = (Excel._Worksheet)Sheets.get_Item(1);

            myExcelWorkbook = (Excel.Workbook)(myExcelApplication.Workbooks._Open(pathTemplate, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value)); // open the existing excel file

            int numberOfWorkbooks = myExcelApplication.Workbooks.Count; // get number of workbooks (optional)

            myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets[1]; // define in which worksheet, do you want to add data
            myExcelWorkSheet.Name = "Sheet 1"; // define a name for the worksheet (optinal)
            myExcelWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;
            myExcelWorkSheet.PageSetup.FitToPagesTall = 1;
            myExcelWorkSheet.PageSetup.FitToPagesWide = 1;
            int numberOfSheets = myExcelWorkbook.Worksheets.Count; // get number of worksheets (optional)
            int intColumnCount = dataTable.Columns.Count;
            int intRowCount = dataTable.Rows.Count;
            myExcelWorkSheet.Cells[5, 1] ="BẢNG CHI LƯƠNG THÁNG " + date;
            for (int i = 0; i < intRowCount; i++)
            {
                int row = i + startRowData;
                for (int j = 0; j < intColumnCount; j++)
                {
                    if (j == 1)
                    {
                        myExcelWorkSheet.Cells[row, 2] = dataTable.Rows[i][j].ToString();
                        myExcelWorkSheet.Cells[row, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }
                    if (j == 0) { myExcelWorkSheet.Cells[row, 3] = dataTable.Rows[i][j].ToString();}
                    if (j == 2) { myExcelWorkSheet.Cells[row, 4] = dataTable.Rows[i][j].ToString(); }
                    if (j == 4) { myExcelWorkSheet.Cells[row, 5] = dataTable.Rows[i][j].ToString(); }
                    if (j == 3) { myExcelWorkSheet.Cells[row, 12] = dataTable.Rows[i][j].ToString(); }
                    if (j == 10) { myExcelWorkSheet.Cells[row, 6] = dataTable.Rows[i][j].ToString(); }
                    if (j == 9) { myExcelWorkSheet.Cells[row, 9] = dataTable.Rows[i][j].ToString(); }
                    if (j == 8) { myExcelWorkSheet.Cells[row, 7] = dataTable.Rows[i][j].ToString(); }
                }
                myExcelWorkSheet.Cells[row, 11] = "=SUM(E" + row + ":J" + row + ")";
                myExcelWorkSheet.Cells[row, 13] = "= K" + row + " / 24 * L" + row + "";
                myExcelWorkSheet.Cells[row, 14] = "=SUM(E" + row + ":F" + row + ")";
                myExcelWorkSheet.Cells[row, 15] = "=N" + row + " * 0.02";
                myExcelWorkSheet.Cells[row, 16] = "=N" + row + " *0.175";
                myExcelWorkSheet.Cells[row, 17] = "=N" + row + " *0.003";
                myExcelWorkSheet.Cells[row, 18] = "=N" + row + " *0.001";
                myExcelWorkSheet.Cells[row, 19] = "=SUM(O" + row + ":R" + row + ")";
                myExcelWorkSheet.Cells[row, 20] = "=N" + row + " *0.08";
                myExcelWorkSheet.Cells[row, 21] = "=N" + row + " *0.015";
                myExcelWorkSheet.Cells[row, 22] = "=N" + row + " *0.01";
                myExcelWorkSheet.Cells[row, 23] = "=SUM(T" + row + ":V" + row + ")";
                myExcelWorkSheet.Cells[row, 25] = "=M" + row + "-W" + row + "-X" + row + "";
                myExcelWorkSheet.Cells[row, 1] = i;
            }
            int rowAfterData = intRowCount + startRowData;
            Excel.Range all = myExcelApplication.get_Range("A" + rowAfterData + ":X" + rowAfterData + "", Type.Missing);
            all.Merge();
            all.Value = "TỔNG";
            all.Interior.Color = Color.FromArgb(234, 153, 153);

            myExcelWorkSheet.Cells[rowAfterData, 25] = "=SUM(Y" + startRowData + ":Y" + (rowAfterData -1) + ")";

            all = myExcelApplication.get_Range("A" + startRowData + ":Y" + rowAfterData + "", Type.Missing);
            all.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            myExcelWorkSheet.Cells[rowAfterData + 2, 22] = "TP HCM, ngày 11 tháng 11 năm 2020";
            myExcelWorkSheet.Cells[rowAfterData + 2, 22].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            myExcelWorkSheet.Cells[rowAfterData + 3, 22] = "Giám đốc";
            myExcelWorkSheet.Cells[rowAfterData + 3, 22].Font.Size = 9;
            myExcelWorkSheet.Cells[rowAfterData + 3, 22].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            if (IsPdf)
            {
                string ss = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Template\\Bảng chi lương.pdf";
                myExcelWorkbook.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Template\\Bảng chi lương.pdf");
                System.Diagnostics.Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Template\\Bảng chi lương.pdf");
            }
        }
        public void closeExcel(string SavePath)
        {
            try
            {
                myExcelWorkbook.SaveAs(SavePath, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSaveAsAccessMode.xlShared,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value); // Save data in excel

                myExcelWorkbook.Close(true, SavePath, System.Reflection.Missing.Value); // close the worksheet
            }
            finally
            {
                if (myExcelApplication != null)
                {
                    myExcelApplication.Quit(); // close the excel application
                }
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

    }
}
