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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
           
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


                    MessageBox.Show("Không tìm thấy file template hoặc file đang được mở!!");
                }
              
                ////Thread thread = new Thread(() => ExportExcel(saveFileDialog.FileName, Data));
                //Thread thread = new Thread(() => ExportExcel(saveFileDialog.FileName, Data));
                //thread.IsBackground = true;
                //thread.Start();
            }


        }
        private int startRowData = 9;
        Excel.Application myExcelApplication;
        Excel._Workbook myExcelWorkbook;
        //Excel.Worksheet myExcelWorkSheet;

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

            int numberOfSheets = myExcelWorkbook.Worksheets.Count; // get number of worksheets (optional)

            myExcelWorkSheet.Cells[1, 8] = "=K11/24*L11";
            int intColumnCount = dataTable.Columns.Count;
            int intRowCount = dataTable.Rows.Count;
            for (int i = 0; i < intRowCount - 1; i++)
            {
                for (int j = 0; j < intColumnCount; j++)
                {
                    if (j == 1) //Tên NV
                    {
                        myExcelWorkSheet.Cells[i + startRowData, 2] = dataTable.Rows[i][j].ToString();
                        myExcelWorkSheet.Cells[i + startRowData, 2].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }
                    if (j == 0) //Mã NV
                    {
                        myExcelWorkSheet.Cells[i + startRowData, 3] = dataTable.Rows[i][j].ToString();
                    }
                    if (j == 2) //Chức vụ
                    {
                        myExcelWorkSheet.Cells[i + startRowData, 4] = dataTable.Rows[i][j].ToString();
                    }
                    if (j == 4) //Lương cơ bản
                    {
                        myExcelWorkSheet.Cells[i + startRowData, 5] = dataTable.Rows[i][j].ToString();
                    }
                    if (j == 3) //Ngày công
                    {
                        myExcelWorkSheet.Cells[i + startRowData, 12] = dataTable.Rows[i][j].ToString();
                    }
                    myExcelWorkSheet.Cells[i + startRowData, 11] = "=SUM(E" + (i + startRowData) + ":J" + (i + startRowData) + ")";
                    myExcelWorkSheet.Cells[i + startRowData, 13] = "= K" + (i + startRowData) + " / 24 * L" + (i + startRowData) + "";
                    myExcelWorkSheet.Cells[i + startRowData, 14] = "=SUM(E"+ (i + startRowData) +":F"+ (i + startRowData) + ")";
                    myExcelWorkSheet.Cells[i + startRowData, 15] = "=N" + (i + startRowData) + " * 0.02";
                    myExcelWorkSheet.Cells[i + startRowData, 16] = "=N"+ (i + startRowData) + " *0.175";
                    myExcelWorkSheet.Cells[i + startRowData, 17] = "=N"+ (i + startRowData) + " *0.003";
                    myExcelWorkSheet.Cells[i + startRowData, 18] = "=N"+ (i + startRowData) + " *0.001";
                    myExcelWorkSheet.Cells[i + startRowData, 19] = "=SUM(O" + (i + startRowData) + ":R" + (i + startRowData) + ")";
                    myExcelWorkSheet.Cells[i + startRowData, 20] = "=N" + (i + startRowData) + " *0.08";
                    myExcelWorkSheet.Cells[i + startRowData, 21] = "=N" + (i + startRowData) + " *0.015";
                    myExcelWorkSheet.Cells[i + startRowData, 22] = "=N" + (i + startRowData) + " *0.01";
                    myExcelWorkSheet.Cells[i + startRowData, 23] = "=SUM(T" + (i + startRowData) + ":V" + (i + startRowData) + ")";
                    string a = "=IF(M" + (i + startRowData) + ">11000000; (M" + (i + startRowData) + "-G" + (i + startRowData) + "+730000-H" + (i + startRowData) + "-I" + (i + startRowData) + "-11000000) *0.05;0)";
                    a = "=(M9-G9+730000-H9-I9-11000000) *0.05";
                    myExcelWorkSheet.Cells[i + startRowData, 11] = a; 
                    myExcelWorkSheet.Cells[i + startRowData, 26] = "=M" + (i + startRowData) + "-W" + (i + startRowData) + "-X" + (i + startRowData) + "-Y" + (i + startRowData) + "";
                    //  myExcelWorkSheet.Cells[i + startRowData, j + 1] = dataTable.Rows[i][j].ToString();
                }
                myExcelWorkSheet.Cells[i + startRowData, 1] = i;

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

        public void ExportExcel(object FileName, System.Data.DataTable dataTable2)
        {
            Microsoft.Office.Interop.Excel.Application xl = null;
            Microsoft.Office.Interop.Excel._Workbook xlWorkBook = null;

            xl = new Microsoft.Office.Interop.Excel.Application();
            xl.Visible = false;
            xlWorkBook = (Excel._Workbook)(xl.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet));
            Excel._Worksheet xlWorkSheet = null;
            xlWorkSheet = xlWorkBook.Worksheets[1];
            int intColumnCount = dataTable2.Columns.Count;
            int intRowCount = dataTable2.Rows.Count;
            xlWorkSheet.Name = "Sheet_1";
            xlWorkSheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            xlWorkSheet.Cells[1, 1] = "Ngân hàng thương mại cổ phần Á Châu";
            xlWorkSheet.Cells[1, 1].Style.WrapText = false;
            xlWorkSheet.Cells[2, 1] = "442 Nguyễn Thị Minh Khai, Phường 05, Quận 3, Tp. Hồ Chí Minh";
            xlWorkSheet.Cells[2, 1].Style.WrapText = false;
            xlWorkSheet.Cells[2, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            xlWorkSheet.Cells[4, 1] = "BẢNG LƯƠNG THÁNG 11 NĂM 2020";

            Microsoft.Office.Interop.Excel.Range range1 = xlWorkSheet.Range["A6", "A7"];
            range1.Merge();
            range1.Value = "Mã nhân viên";
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range1.Style.WrapText = true;

            range1 = xlWorkSheet.Range["A4", "P4"];
            range1.Merge();
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            range1 = xlWorkSheet.Range["B6", "B7"];
            range1.Merge();
            range1.Value = "Tên nhân viên";
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range1.Style.WrapText = true;

            range1 = xlWorkSheet.Range["C6", "C7"];
            range1.Merge();
            range1.Value = "Ngày công";
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range1.Style.WrapText = true;

            range1 = xlWorkSheet.Range["D6", "D7"];
            range1.Merge();
            range1.Value = "Lương cơ bản";
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range1.Style.WrapText = true;

            range1 = xlWorkSheet.Range["E6", "E7"];
            range1.Merge();
            range1.Value = "Lương tháng";
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range1.Style.WrapText = false;

            range1 = xlWorkSheet.Range["F6", "F7"];
            range1.Merge();
            range1.Value = "Giờ tăng ca";
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range1.Style.WrapText = true;

            range1 = xlWorkSheet.Range["G6", "G7"];
            range1.Merge();
            range1.Value = "Tiền tăng ca";
            range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range1.Style.WrapText = true;


            //Microsoft.Office.Interop.Excel.Range range = xlWorkSheet.Range["A1", DataGridViewToExcel_ByfinalColLetter(intColumnCount) + "1"];
            //range.Font.Size = 16;
            //range.Interior.ColorIndex = 36;


            for (int i = 0; i < intRowCount - 1; i++)
            {
                for (int j = 0; j < intColumnCount; j++)
                {
                    xlWorkSheet.Cells[i + startRowData, j + 1] = dataTable2.Rows[i][j].ToString();
                }
            }
            //range = xlWorkSheet.Range["J2", "A" + intRowCount];
            //range.NumberFormat = "0";

            //xlWorkSheet.Columns[2].AutoFit();
            xlWorkBook.SaveAs(FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            xl.Visible = true;
            if (xlWorkSheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
            if (xlWorkBook != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            if (xl != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(xl);
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
