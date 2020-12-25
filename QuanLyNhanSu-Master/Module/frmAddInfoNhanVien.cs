using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhanSu_Master.DAO;
using QuanLyNhanSu_Master.DTO;

namespace QuanLyNhanSu_Master.Module
{


    public partial class frmAddInfoNhanVien : Form
    {

        public frmAddInfoNhanVien()
        {
            InitializeComponent();
        }
        public bool IsShowfrmHoSoNhanVien = false;
        public bool AddNewImployee(string txtTenNhanVien, string txtNgaySinh, string txtGioiTinh, string txtDiaChi, string txtEmail, string txtSdt, string txtCmnd, string txtNgayCap, string txtTenTinhThanh, string txtDanToc, string txtPhongBan, string txtTenChucVu, float txtMaBacLuong, string txtTinhTrangLamViec, string txtSoBHXH, string txtSoBHYT, string txtTaiKhoanNH)
        {
            return AccountDAO.Instance.AddNewImployee(txtTenNhanVien, txtNgaySinh, txtGioiTinh, txtDiaChi, txtEmail, txtSdt, txtCmnd, txtNgayCap, txtTenTinhThanh, txtDanToc, txtPhongBan, txtTenChucVu, txtMaBacLuong, txtTinhTrangLamViec, txtSoBHXH, txtSoBHYT, txtTaiKhoanNH);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string TenNV = txtTenNhanVien.Text;
            string NgaySinh = (Convert.ToDateTime(txtNgaySinh.Text)).ToString("yyyy/MM/dd");
            string Cmnd = txtCmnd.Text;
            string NgayCap = (Convert.ToDateTime(txtNgayCap.Text)).ToString("yyyy/MM/dd");
            string TenTT = cbListTinhThanh.GetItemText(cbListTinhThanh.SelectedItem);
            string GT = txtGioiTinh.Text;
            if (GT == "Nam")
            {
                GT = "1";
            }
            else
            {
                GT = "0";
            }

            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;
            string Sdt = txtSdt.Text;
            string TenCV = cbListChucVu.GetItemText(cbListChucVu.SelectedItem);
            float HSLuong = (float)Convert.ToDouble(cbListBacLuong.GetItemText(cbListBacLuong.SelectedValue.ToString()));
            string TTLV = txtTinhTrangLamViec.Text;
            string BHXH = txtSoBHXH.Text;
            string BHYT = txtSoBHYT.Text;
            string TKNH = txtTaiKhoanNH.Text;
            string DanToc = txtDanToc.Text;
            string PB = cbListPhongBan.GetItemText(cbListPhongBan.SelectedItem);

            bool flag = AddNewImployee(TenNV, NgaySinh, GT, DiaChi, Email, Sdt, Cmnd, NgayCap, TenTT, DanToc, PB, TenCV, HSLuong, TTLV, BHXH, BHYT, TKNH);
            if (flag)
            {
                MessageBox.Show("Thêm thông tin nhân viên thành công");
                IsShowfrmHoSoNhanVien = true;
            }
            else
            {
                MessageBox.Show("Lỗi, Vui lòng nhập đủ thông tin Nhân Viên");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddInfoNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

            List<TinhThanh> tinhThanh = HoSoNhanVienDAO.Instance.GetListTinhThanh();
            BindingList<TinhThanh> bl = new BindingList<TinhThanh>(tinhThanh);
            cbListTinhThanh.DataSource = bl;
            cbListTinhThanh.ValueMember = "MaTinhThanh";
            cbListTinhThanh.DisplayMember = "TenTinhThanh";
            cbListTinhThanh.SelectedItem = null;
            cbListTinhThanh.SelectedIndex = 0;

            List<PhongBan> phongBan = HoSoNhanVienDAO.Instance.GetAllPhongBan();
            foreach (PhongBan item in phongBan)
            {
                cbListPhongBan.Items.Add(item.TenPhongBan);
            }
            cbListPhongBan.ValueMember = "MaPhongBan";
            cbListPhongBan.DisplayMember = "TenPhongBan";
            cbListPhongBan.SelectedItem = null;
            cbListPhongBan.SelectedIndex = 0;

            List<BacLuong> bacLuong = HoSoNhanVienDAO.Instance.GetAllBacLuong();
            BindingList<BacLuong> binding = new BindingList<BacLuong>(bacLuong);
            cbListBacLuong.DataSource = binding;
            cbListBacLuong.ValueMember = "MaBacLuong";
            cbListBacLuong.DisplayMember = "BacLuong1";
            cbListBacLuong.SelectedItem = null;
            cbListBacLuong.SelectedIndex = 0;

            List<ChucVu> chucVu = HoSoNhanVienDAO.Instance.GetListChucVu();
            BindingList<ChucVu> bindingChucVu = new BindingList<ChucVu>(chucVu);
            cbListChucVu.DataSource = bindingChucVu;
            cbListChucVu.ValueMember = "MaChucVu";
            cbListChucVu.DisplayMember = "TenChucVu";
            cbListChucVu.SelectedItem = null;
            cbListChucVu.SelectedIndex = 0;

        }
    }

}
