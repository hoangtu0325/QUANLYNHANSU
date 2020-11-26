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
            string query = "SELECT MaNV AS [Mã NV], TenNV AS [Tên NV], PhongBan AS [Phòng ban], Cmnd AS CMND, NgayCap AS [Ngày cấp], NgaySinh AS [Ngày sinh], GioiTinh AS [Giới tính], DiaChi AS [Địa chỉ], Email, Sdt AS [Số điện thoại], NgayVaoLam AS [Ngày vào làm], ";
            query += " ThamNien AS[Thâm niên], HeSoLuong AS[Hệ số lương], TinhTrangLamViec AS[Tình trạng làm việc], HinhAnh AS[Hình ảnh], SoBHXH AS[Số BHXH], SoBHYT AS[Số BHYT], TaikhoanNH AS[Tài khoản ngân hàng], DanToc AS[Dân tộc] ";
            query += " FROM NhanVien ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
