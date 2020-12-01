using QuanLyNhanSu_Master.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DAO
{
    class HoSoNhanVienDAO
    {
        private static HoSoNhanVienDAO instance;

        public static HoSoNhanVienDAO Instance
        {
            get { if (instance == null) instance = new HoSoNhanVienDAO(); return instance; }
            private set { instance = value; }
        }

        public DataTable GetNhanVien()
        {
            string query = "SELECT NV.MaNV AS [Mã NV], NV.TenNV AS [Họ tên], NV.GioiTinh AS [Giới tính], CV.TenChucVu AS [Chức vụ], PB.TenPhongBan AS [Tên phòng ban], NV.Cmnd AS CMND, NV.NgaySinh AS [Ngày sinh], NV.DiaChi AS [Địa chỉ], NV.Email, NV.Sdt AS SĐT, ";
            query += "  NV.ThamNien AS[Thâm niên], NV.HeSoLuong AS[Hệ số lương], NV.TinhTrangLamViec AS[Tình trạng làm việc], NV.SoBHXH AS BHXH, NV.SoBHYT AS BHYT, ";
            query += " NV.TaikhoanNH AS[Số tài khoản], NV.DanToc AS[Dân tộc], NV.NgayBatDau AS[Ngày vào làm], NV.NgayKetThuc AS[Ngày nghỉ] ";
            query += " FROM NhanVien AS NV INNER JOIN ";
            query += " PhongBan AS PB ON NV.MaPhongBan = PB.MaPhongBan INNER JOIN ";
            query += " ChucVu AS CV ON NV.MaChucVu = CV.MaChucVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetNhanVien(string name)
        {
            string query = "SELECT NV.MaNV AS [Mã NV], NV.TenNV AS [Họ tên], NV.GioiTinh AS [Giới tính], CV.TenChucVu AS [Chức vụ], PB.TenPhongBan AS [Tên phòng ban], NV.Cmnd AS CMND, NV.NgaySinh AS [Ngày sinh], NV.DiaChi AS [Địa chỉ], NV.Email, NV.Sdt AS SĐT, ";
            query += " NV.ThamNien AS[Thâm niên], NV.HeSoLuong AS[Hệ số lương], NV.TinhTrangLamViec AS[Tình trạng làm việc], NV.SoBHXH AS BHXH, NV.SoBHYT AS BHYT, ";
            query += " NV.TaikhoanNH AS[Số tài khoản], NV.DanToc AS[Dân tộc], NV.NgayBatDau AS[Ngày vào làm], NV.NgayKetThuc AS[Ngày nghỉ]";
            query += " FROM NhanVien AS NV INNER JOIN ";
            query += " PhongBan AS PB ON NV.MaPhongBan = PB.MaPhongBan INNER JOIN ";
            query += " ChucVu AS CV ON NV.MaChucVu = CV.MaChucVu ";
            query += " where NV.TenNV like N'%" + name + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetNhanVien(int MaNV)
        {
            string query = "SELECT NV.MaNV AS [Mã NV], NV.TenNV AS [Họ tên], NV.GioiTinh AS [Giới tính], CV.TenChucVu AS [Chức vụ], PB.TenPhongBan AS [Tên phòng ban], NV.Cmnd AS CMND, NV.NgaySinh AS [Ngày sinh], NV.DiaChi AS [Địa chỉ], NV.Email, NV.Sdt AS SĐT, ";
            query += " NV.ThamNien AS[Thâm niên], NV.HeSoLuong AS[Hệ số lương], NV.TinhTrangLamViec AS[Tình trạng làm việc], NV.SoBHXH AS BHXH, NV.SoBHYT AS BHYT, ";
            query += " NV.TaikhoanNH AS[Số tài khoản], NV.DanToc AS[Dân tộc], NV.NgayBatDau AS[Ngày vào làm], NV.NgayKetThuc AS[Ngày nghỉ]";
            query += " FROM NhanVien AS NV INNER JOIN ";
            query += " PhongBan AS PB ON NV.MaPhongBan = PB.MaPhongBan INNER JOIN ";
            query += " ChucVu AS CV ON NV.MaChucVu = CV.MaChucVu ";
            query += " where NV.MaNV = '" + MaNV + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable SearchAllNhanVien()
        {
            string query =
                string.Format(
                    "select CONCAT(TenNV,' - ', MaNV) as [ThongTinNV] from NhanVien");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool AddNewImployee(string txtTenNhanVien, string txtNgaySinh, string txtGioiTinh, string txtDiaChi, string txtEmail, string txtSdt, string txtCmnd, string txtNgayCap, string txtTenTinhThanh, string txtDanToc, string txtPhongBan, string txtTenChucVu, float txtHeSoLuong, string txtTinhTrangLamViec, string txtSoBHXH, string txtSoBHYT, string txtTaiKhoanNH)
        {
            string query = string.Empty;
            try
            {
                query = "INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Email, Sdt, Cmnd, NgayCap, MaTinhThanh, DanToc, MaPhongBan, MaChucVu, HeSoLuong, TinhTrangLamViec, SoBHXH, SoBHYT, TaiKhoanNH) ";
                query += " VALUES((select max(MaNV) + 1 from NhanVien),N'" + txtTenNhanVien + "',"+ txtNgaySinh  +", N'" + txtGioiTinh + "', N'" + txtDiaChi + "', N'" + txtEmail + "', N'" + txtSdt + "', N'" + txtCmnd + "', " + txtNgayCap + "', (select MaTinhThanh from TinhThanh where TenTinhThanh like CONCAT(N'" + txtTenTinhThanh + "', '%')) ,N'" + txtDanToc + "', (select MaPhongBan from PhongBan where TenPhongBan like CONCAT( N'" + txtPhongBan + "', '%')), (select MaChucVu from ChucVu where TenChucVu like CONCAT(N'" + txtTenChucVu + "', '%')) , N'" + txtHeSoLuong + "', N'" + txtTinhTrangLamViec + "', N'" + txtSoBHXH + "', N'" + txtSoBHYT + "', N'" + txtTaiKhoanNH + "')";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
