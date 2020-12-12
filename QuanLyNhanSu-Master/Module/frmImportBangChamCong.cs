using QuanLyNhanSu_Master.Module.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master.Module
{
    public partial class frmImportBangChamCong : Form
    {
        public frmImportBangChamCong()
        {
            InitializeComponent();
            (new DropShadow()).ApplyShadows(this);
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadDataGrid(Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid)
        {
            //GridImportBangChamCong.DataSource = dataGrid;
            SetFieldType(dataGrid);
        }

        private void SetFieldType(Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid)
        {
            int IntRow = dataGrid.Rows.Count;
            string date;
            date = dataGrid.Rows[0].Cells["ThangChamCong"].Value.ToString();
            date = date.Substring(3, 7);
            //DateTime dateTime = DateTime.Parse(date);
            this.bunifuCustomLabel1.Text = "Import Bảng chấm công nhân viên tháng " + date;
            this.lblStatus.Text = "Tổng cộng: " + IntRow;
            dataGrid.Columns["TenNV"].Frozen = true;
            //dataGrid.Columns["MaChamCong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGrid.Columns["MaChamCong"].Visible = false;
            dataGrid.Columns["ThangChamCong"].Visible = false;
            dataGrid.Columns["UserModified"].ReadOnly = true;
            dataGrid.Columns["MaNV"].HeaderText = "Mã NV";
            dataGrid.Columns["TenNV"].HeaderText = "Tên NV";
            dataGrid.Columns["Ngay1"].HeaderText = "Ngày 1";
            dataGrid.Columns["Ngay2"].HeaderText = "Ngày 2";
            dataGrid.Columns["Ngay3"].HeaderText = "Ngày 3";
            dataGrid.Columns["Ngay4"].HeaderText = "Ngày 4";
            dataGrid.Columns["Ngay5"].HeaderText = "Ngày 5";
            dataGrid.Columns["Ngay6"].HeaderText = "Ngày 6";
            dataGrid.Columns["Ngay7"].HeaderText = "Ngày 7";
            dataGrid.Columns["Ngay8"].HeaderText = "Ngày 8";
            dataGrid.Columns["Ngay9"].HeaderText = "Ngày 9";
            dataGrid.Columns["Ngay10"].HeaderText = "Ngày 10";
            dataGrid.Columns["Ngay11"].HeaderText = "Ngày 11";
            dataGrid.Columns["Ngay12"].HeaderText = "Ngày 12";
            dataGrid.Columns["Ngay13"].HeaderText = "Ngày 13";
            dataGrid.Columns["Ngay14"].HeaderText = "Ngày 14";
            dataGrid.Columns["Ngay15"].HeaderText = "Ngày 15";
            dataGrid.Columns["Ngay16"].HeaderText = "Ngày 16";
            dataGrid.Columns["Ngay17"].HeaderText = "Ngày 17";
            dataGrid.Columns["Ngay18"].HeaderText = "Ngày 18";
            dataGrid.Columns["Ngay19"].HeaderText = "Ngày 19";
            dataGrid.Columns["Ngay20"].HeaderText = "Ngày 20";
            dataGrid.Columns["Ngay21"].HeaderText = "Ngày 21";
            dataGrid.Columns["Ngay22"].HeaderText = "Ngày 22";
            dataGrid.Columns["Ngay23"].HeaderText = "Ngày 23";
            dataGrid.Columns["Ngay24"].HeaderText = "Ngày 24";
            dataGrid.Columns["Ngay25"].HeaderText = "Ngày 25";
            dataGrid.Columns["Ngay26"].HeaderText = "Ngày 26";
            dataGrid.Columns["Ngay27"].HeaderText = "Ngày 27";
            dataGrid.Columns["Ngay28"].HeaderText = "Ngày 28";
            dataGrid.Columns["Ngay29"].HeaderText = "Ngày 29";
            dataGrid.Columns["Ngay30"].HeaderText = "Ngày 30";
            dataGrid.Columns["Ngay31"].HeaderText = "Ngày 31";
            dataGrid.Columns["Ngay31"].HeaderText = "Ngày 31";
            dataGrid.Columns["TongSoNgay"].HeaderText = "Số ngày làm";
            dataGrid.Columns["SoGioTangCa"].HeaderText = "Tăng ca";
            dataGrid.Columns["UserModified"].HeaderText = "Người sửa";
            
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridImportBangChamCong.Rows.Count; i++)
            {
                if (GridImportBangChamCong.Rows[i].Cells["MaNV"].ValueType !=  typeof(int))
                {
                    MessageBox.Show("Lỗi dữ liệu cột Mã NV thứ " + i);
                    break;
                }
                for (int j = 4; j < GridImportBangChamCong.Columns.Count - 3; j++)
                {
                    if (GridImportBangChamCong.Rows[i].Cells[j].Value.ToString() != "x" && GridImportBangChamCong.Rows[i].Cells[j].Value.ToString() != "x/2" && GridImportBangChamCong.Rows[i].Cells[j].Value.ToString() != "cn")
                    {
                        MessageBox.Show("Lỗi dữ liệu cột " + GridImportBangChamCong.Columns[j].HeaderText + " của nhân viên " + GridImportBangChamCong.Rows[i].Cells["MaNV"].Value.ToString());
                        break;
                    }
                }
                //if (GridImportBangChamCong.Rows[i].Cells["Ngay1"].Value.ToString() != "x")
                //{
                //    MessageBox.Show("Lỗi dữ liệu cột Ngày 1 của nhân viên " + GridImportBangChamCong.Rows[i].Cells["MaNV"].Value.ToString());
                //    break;
                //}
            }
        }
    }
}
