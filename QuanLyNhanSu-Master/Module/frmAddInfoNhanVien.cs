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


namespace QuanLyNhanSu_Master.Module
{


    public partial class frmAddInfoNhanVien : Form
    {

        public frmAddInfoNhanVien()
        {
            InitializeComponent();
        }
        public bool IsShowfrmHoSoNhanVien = false;
        public bool AddNewImployee(string txtTenNhanVien, string txtNgaySinh, string txtGioiTinh, string txtDiaChi, string txtEmail, string txtSdt, string txtCmnd, string txtNgayCap, string txtTenTinhThanh, string txtDanToc, string txtPhongBan, string txtTenChucVu, float txtHeSoLuong, string txtTinhTrangLamViec, string txtSoBHXH, string txtSoBHYT, string txtTaiKhoanNH)
        {
            return AccountDAO.Instance.AddNewImployee(txtTenNhanVien, txtNgaySinh, txtGioiTinh, txtDiaChi, txtEmail, txtSdt, txtCmnd, txtNgayCap, txtTenTinhThanh, txtDanToc, txtPhongBan, txtTenChucVu, txtHeSoLuong, txtTinhTrangLamViec, txtSoBHXH, txtSoBHYT, txtTaiKhoanNH);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string TenNV = txtTenNhanVien.Text;
            string NgaySinh = txtNgaySinh.Text;
            string Cmnd = txtCmnd.Text;
            string NgayCap = txtNgayCap.Text;
            string TenTT = txtTenTinhThanh.Text;
            string GT = txtGioiTinh.Text;
            string DiaChi = txtDiaChi.Text;
            string Email = txtEmail.Text;
            string Sdt = txtSdt.Text;
            string TenCV = txtTenChucVu.Text;
            float HSLuong = (float)Convert.ToDouble(txtHeSoLuong.Text);
            string TTLV = txtTinhTrangLamViec.Text;
            string BHXH = txtSoBHXH.Text;
            string BHYT = txtSoBHYT.Text;
            string TKNH = txtTaiKhoanNH.Text;
            string DanToc = txtDanToc.Text;
            string PB = txtPhongBan.Text;

            bool flag = AddNewImployee(TenNV, NgaySinh, GT, DiaChi, Email, Sdt, Cmnd, NgayCap, TenTT, DanToc, PB, TenCV, HSLuong, TTLV, BHXH, BHYT, TKNH);
            if (flag)
            {
                MessageBox.Show("Thêm thông tin nhân viên thành công");
                IsShowfrmHoSoNhanVien = true;
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }


        }
    }

}
