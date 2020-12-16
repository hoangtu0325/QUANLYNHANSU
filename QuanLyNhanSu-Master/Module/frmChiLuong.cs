using QuanLyNhanSu_Master.DAO;
using System;
using System.Collections.Generic;
using QuanLyNhanSu_Master.Module.Popup;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master.Module
{
    public partial class frmChiLuong : Form
    {
        public frmChiLuong()
        {
            InitializeComponent();
            LoadData();
            SetFieldType(GridBangChiLuong);
        }
        string CountMoney;
        private void LoadData()
        {
            List<string> chamCong = ChiLuongDAO.Instance.GetAllMonthBangChiLuong();
            foreach (string item in chamCong)
            {
                cbListMonth.Items.Add(item.ToString());
            }
            cbListMonth.ValueMember = "BangChiLuong";
            cbListMonth.DisplayMember = "BangChiLuong";
            cbListMonth.SelectedItem = null;
            cbListMonth.SelectedIndex = 0;
            //   string ss = cbListMonth.SelectedItem.ToString();
        }

        public DataGridView SetFieldType(DataGridView gridView)
        {
            GridBangChiLuong.Columns["MaNV"].HeaderText = "Mã nhân viên";
            GridBangChiLuong.Columns["TenNV"].HeaderText = "Tên nhân viên";
            GridBangChiLuong.Columns["TenNV"].Frozen = true;
            GridBangChiLuong.Columns["TenNV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GridBangChiLuong.Columns["SoNgayLamViec"].HeaderText = "Số ngày làm";
            GridBangChiLuong.Columns["LuongCoBan"].HeaderText = "Lương cơ bản";
            GridBangChiLuong.Columns["LuongThangCoBan"].HeaderText = "Lương tháng";
            GridBangChiLuong.Columns["SoGioTangCa"].HeaderText = "Số giờ tăng ca";
            GridBangChiLuong.Columns["TongTienTangCa"].HeaderText = "Tổng tiền tăng ca";
            GridBangChiLuong.Columns["TroCapAnTrua"].HeaderText = "Trợ cấp ăn trưa";
            GridBangChiLuong.Columns["TroCapXangXe"].HeaderText = "Trợ cấp xăng xe";
            GridBangChiLuong.Columns["TroCapTrachNhiem"].HeaderText = "Trợ cấp trách nhiệm";
            GridBangChiLuong.Columns["TienThuong"].HeaderText = "Tiền thưởng";
            GridBangChiLuong.Columns["TongLuong"].HeaderText = "Tổng lương";
            GridBangChiLuong.Columns["CongDoan"].HeaderText = "Công đoàn";
            GridBangChiLuong.Columns["ThucLanh"].HeaderText = "Thực lãnh";
            GridBangChiLuong.Columns["TenChucVu"].HeaderText = "Chức vụ";
            GridBangChiLuong.Columns["ThucLanh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return GridBangChiLuong;
        }

        private void cbListMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            float Count = 0;
            string productId = cbListMonth.SelectedItem as string;
            if (productId != null)
            {
                string lastMonth = Convert.ToDateTime(cbListMonth.SelectedItem).ToString("yyyy/MM");
                GridBangChiLuong.DataSource = ChiLuongDAO.Instance.GetAllBangChiLuongByMonth(lastMonth);
                foreach (DataGridViewRow item in GridBangChiLuong.Rows)
                {
                    Count += Convert.ToSingle(item.Cells["ThucLanh"].Value);
                }
            }
            CountMoney = String.Format("{0:C}", Count);
            lblCountMoney.Text = CountMoney;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            frmExportBangLuong exportBangLuong = new frmExportBangLuong();
            exportBangLuong.StartPosition = FormStartPosition.CenterScreen;
            frmExportBangLuong.Data = (DataTable)GridBangChiLuong.DataSource;
            exportBangLuong.ShowDialog();
        }
    }
}
