using ExcelDataReader;
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
                }
                else
                {
                    //MessageBox.Show("Vui lòng chọn file để Import");
                    this.status = "None Import Excel";
                }
            }
           
            //foreach (DataRow item in dataTable.Rows)
            //{
            //    if (Convert.ToBoolean(item["Ngày sinh"]) == true)
            //    {
            //        item["Ngày sinh"] = "Nam";
            //    } 
            //}
           

        }
    }
}
