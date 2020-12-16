using QuanLyNhanSu_Master.DAO;
using QuanLyNhanSu_Master.DTO;
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
        string date;
        private void SetFieldType(Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid)
        {
            int IntRow = dataGrid.Rows.Count;
            
            date = dataGrid.Rows[0].Cells["ThangChamCong"].Value.ToString();
            date = date.Substring(3, 7);
            this.bunifuCustomLabel1.Text = "Import Bảng chấm công nhân viên tháng " + date;
            this.lblStatus.Text = "Tổng cộng: " + IntRow;
            dataGrid.Columns["TenNV"].Frozen = true;
            dataGrid.Columns["MaChamCong"].Visible = false;
            dataGrid.Columns["ThangChamCong"].Visible = false;
            dataGrid.Columns["UserModified"].ReadOnly = true;
            dataGrid.Columns["MaNV"].HeaderText = "Mã NV";
            dataGrid.Columns["MaNV"].ReadOnly = true;
            dataGrid.Columns["TenNV"].HeaderText = "Tên NV";
            dataGrid.Columns["TenNV"].ReadOnly = true;
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
            bool DataError = false;
            bool status = false;
            DateTime dateTime = DateTime.Parse(date);
            string UserModified = Account.UserName;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn lưu không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < GridImportBangChamCong.Rows.Count; i++)
                {
                    if (GridImportBangChamCong.Rows[i].Cells["MaNV"].ValueType != typeof(int))
                    {
                        MessageBox.Show("Lỗi dữ liệu cột Mã NV thứ " + i);
                        DataError = true;
                        break;
                    }
                    for (int j = 4; j < GridImportBangChamCong.Columns.Count - 4; j++)
                    {
                        if (GridImportBangChamCong.Rows[i].Cells[j].Value.ToString() != "x" && GridImportBangChamCong.Rows[i].Cells[j].Value.ToString() != "x/2" && GridImportBangChamCong.Rows[i].Cells[j].Value.ToString() != "cn" && GridImportBangChamCong.Rows[i].Cells[j].Value.ToString() != "")
                        {
                            MessageBox.Show("Lỗi dữ liệu cột " + GridImportBangChamCong.Columns[j].HeaderText + " của nhân viên " + GridImportBangChamCong.Rows[i].Cells["MaNV"].Value.ToString());
                            DataError = true;
                            break;
                        }
                    }
                }
                if (!DataError)
                {
                    for (int i = 0; i < GridImportBangChamCong.Rows.Count; i++)
                    {
                        try
                        {
                            int MaNV = Convert.ToInt32(GridImportBangChamCong.Rows[i].Cells["MaNV"].Value);
                            string Ngay1 = GridImportBangChamCong.Rows[i].Cells["Ngay1"].Value.ToString();
                            string Ngay2 = GridImportBangChamCong.Rows[i].Cells["Ngay2"].Value.ToString();
                            string Ngay3 = GridImportBangChamCong.Rows[i].Cells["Ngay3"].Value.ToString();
                            string Ngay4 = GridImportBangChamCong.Rows[i].Cells["Ngay4"].Value.ToString();
                            string Ngay5 = GridImportBangChamCong.Rows[i].Cells["Ngay5"].Value.ToString();
                            string Ngay6 = GridImportBangChamCong.Rows[i].Cells["Ngay6"].Value.ToString();
                            string Ngay7 = GridImportBangChamCong.Rows[i].Cells["Ngay7"].Value.ToString();
                            string Ngay8 = GridImportBangChamCong.Rows[i].Cells["Ngay8"].Value.ToString();
                            string Ngay9 = GridImportBangChamCong.Rows[i].Cells["Ngay9"].Value.ToString();
                            string Ngay10 = GridImportBangChamCong.Rows[i].Cells["Ngay10"].Value.ToString();
                            string Ngay11 = GridImportBangChamCong.Rows[i].Cells["Ngay11"].Value.ToString();
                            string Ngay12 = GridImportBangChamCong.Rows[i].Cells["Ngay12"].Value.ToString();
                            string Ngay13 = GridImportBangChamCong.Rows[i].Cells["Ngay13"].Value.ToString();
                            string Ngay14 = GridImportBangChamCong.Rows[i].Cells["Ngay14"].Value.ToString();
                            string Ngay15 = GridImportBangChamCong.Rows[i].Cells["Ngay15"].Value.ToString();
                            string Ngay16 = GridImportBangChamCong.Rows[i].Cells["Ngay16"].Value.ToString();
                            string Ngay17 = GridImportBangChamCong.Rows[i].Cells["Ngay17"].Value.ToString();
                            string Ngay18 = GridImportBangChamCong.Rows[i].Cells["Ngay18"].Value.ToString();
                            string Ngay19 = GridImportBangChamCong.Rows[i].Cells["Ngay19"].Value.ToString();
                            string Ngay20 = GridImportBangChamCong.Rows[i].Cells["Ngay20"].Value.ToString();
                            string Ngay21 = GridImportBangChamCong.Rows[i].Cells["Ngay21"].Value.ToString();
                            string Ngay22 = GridImportBangChamCong.Rows[i].Cells["Ngay22"].Value.ToString();
                            string Ngay23 = GridImportBangChamCong.Rows[i].Cells["Ngay23"].Value.ToString();
                            string Ngay24 = GridImportBangChamCong.Rows[i].Cells["Ngay24"].Value.ToString();
                            string Ngay25 = GridImportBangChamCong.Rows[i].Cells["Ngay25"].Value.ToString();
                            string Ngay26 = GridImportBangChamCong.Rows[i].Cells["Ngay26"].Value.ToString();
                            string Ngay27 = GridImportBangChamCong.Rows[i].Cells["Ngay27"].Value.ToString();
                            string Ngay28 = GridImportBangChamCong.Rows[i].Cells["Ngay28"].Value.ToString();
                            string Ngay29 = GridImportBangChamCong.Rows[i].Cells["Ngay29"].Value.ToString();
                            string Ngay30 = GridImportBangChamCong.Rows[i].Cells["Ngay30"].Value.ToString();
                            string Ngay31 = GridImportBangChamCong.Rows[i].Cells["Ngay31"].Value.ToString();
                            float TongSoNgay = float.Parse(GridImportBangChamCong.Rows[i].Cells["TongSoNgay"].Value.ToString());
                            float SoGioTangCa = float.Parse(GridImportBangChamCong.Rows[i].Cells["SoGioTangCa"].Value.ToString());
                            status = ChamCongDAO.Instance.AddNewBangChamCong(MaNV, dateTime, Ngay1, Ngay2, Ngay3, Ngay4, Ngay5, Ngay6, Ngay7, Ngay8, Ngay9, Ngay10, Ngay11, Ngay12, Ngay13, Ngay14, Ngay15, Ngay16, Ngay17, Ngay18, Ngay19, Ngay20, Ngay21, Ngay22, Ngay23, Ngay24, Ngay25, Ngay26, Ngay27, Ngay28, Ngay29, Ngay30, Ngay31, TongSoNgay, SoGioTangCa, UserModified);

                            float LuongThang = ChiLuongDAO.Instance.GetLuongByMaNV(MaNV);
                            float LuongTangCa1Gio = Convert.ToSingle(LuongThang / 26 / 8 * 1.5);
                            float TongTienTangCa = Round(SoGioTangCa * LuongTangCa1Gio);
                            LuongThang = Round(LuongThang / 26 * TongSoNgay);
                            float TongLuong = Round(LuongThang + TongTienTangCa + 1000000);
                            float BHXH = Round(TongLuong * 5 / 100);
                            float  BHYT = Round(TongLuong / 100);
                            float CongDoan = Round(TongLuong / 100);
                            float ThucLanh = Round(TongLuong - (BHXH + BHYT + CongDoan));
                            ThucLanh = ThucLanh / 10000;
                            ThucLanh = Convert.ToSingle(Math.Round(ThucLanh, 1));
                            ThucLanh = ThucLanh * 10000;
                            ChiLuongDAO.Instance.AddNewBangChiLuong(MaNV, dateTime, TongSoNgay, SoGioTangCa, TongTienTangCa, 500000, 500000, 0, 0, TongLuong, BHXH, BHYT, CongDoan, ThucLanh);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex);
                        }
                    }
                    if (status)
                    {
                        this.Close();
                        MessageBox.Show("Import thành công", "Thông báo");

                    }
                    else { MessageBox.Show("Import thất bại"); }
                }
            }
        }

        float Round(float Money)
        {
            Money = Money / 10000;
            Money = Convert.ToSingle(Math.Round(Money, 1));
            return Money * 10000;
        }
    }
}
