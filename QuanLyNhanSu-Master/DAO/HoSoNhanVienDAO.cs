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
        public DataTable GetNhanVien(String name)
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
    }
}
