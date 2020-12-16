using QuanLyNhanSu_Master.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
            string query = "SELECT  ROW_NUMBER()OVER (ORDER BY TenNV) as [STT], NV.MaNV AS [Mã NV], NV.TenNV AS [Họ tên], (CASE NV.GioiTinh WHEN 1 THEN 'Nam' ELSE N'Nữ' END) AS [Giới tính], CV.TenChucVu AS [Chức vụ], PB.TenPhongBan AS [Tên phòng ban], NV.Cmnd AS CMND, NV.NgaySinh AS [Ngày sinh], NV.DiaChi AS [Địa chỉ], NV.Email, NV.Sdt AS SĐT, ";
            query += "  NV.ThamNien AS[Thâm niên], NV.MaBacLuong AS[Hệ số lương], NV.TinhTrangLamViec AS[Tình trạng làm việc], NV.SoBHXH AS BHXH, NV.SoBHYT AS BHYT, ";
            query += " NV.TaikhoanNH AS[Số tài khoản], NV.DanToc AS[Dân tộc], NV.NgayBatDau AS[Ngày vào làm], NV.NgayKetThuc AS[Ngày nghỉ] ";
            query += " FROM NhanVien AS NV INNER JOIN ";
            query += " PhongBan AS PB ON NV.MaPhongBan = PB.MaPhongBan INNER JOIN ";
            query += " ChucVu AS CV ON NV.MaChucVu = CV.MaChucVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetNhanVien(string name)
        {
            string query = "SELECT NV.MaNV AS [Mã NV], NV.TenNV AS [Họ tên], (CASE NV.GioiTinh WHEN 1 THEN 'Nam' ELSE N'Nữ' END) AS [Giới tính], CV.TenChucVu AS [Chức vụ], PB.TenPhongBan AS [Tên phòng ban], NV.Cmnd AS CMND, NV.NgaySinh AS [Ngày sinh], NV.DiaChi AS [Địa chỉ], NV.Email, NV.Sdt AS SĐT, ";
            query += " NV.ThamNien AS[Thâm niên], NV.MaBacLuong AS[Hệ số lương], NV.TinhTrangLamViec AS[Tình trạng làm việc], NV.SoBHXH AS BHXH, NV.SoBHYT AS BHYT, ";
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
            string query = "SELECT NV.MaNV AS [Mã NV], NV.TenNV AS [Họ tên], (CASE NV.GioiTinh WHEN 1 THEN 'Nam' ELSE N'Nữ' END) AS [Giới tính], CV.TenChucVu AS [Chức vụ], PB.TenPhongBan AS [Tên phòng ban], NV.Cmnd AS CMND, NV.NgaySinh AS [Ngày sinh], NV.DiaChi AS [Địa chỉ], NV.Email, NV.Sdt AS SĐT, ";
            query += " NV.ThamNien AS[Thâm niên], NV.MaBacLuong AS[Hệ số lương], NV.TinhTrangLamViec AS[Tình trạng làm việc], NV.SoBHXH AS BHXH, NV.SoBHYT AS BHYT, ";
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

        public bool AddNewImployee(string txtTenNhanVien, DateTime txtNgaySinh, string txtGioiTinh, string txtDiaChi, string txtEmail, string txtSdt, string txtCmnd, DateTime txtNgayCap, string txtTenTinhThanh, string txtDanToc, string txtPhongBan, string txtTenChucVu, string txtMaBacLuong, string txtTinhTrangLamViec, string txtSoBHXH, string txtSoBHYT, string txtTaiKhoanNH)
        {
            string query = string.Empty;
            DateTime n = txtNgaySinh;
            DateTime m = txtNgayCap;
            string NgayCap = m.ToString("yyyy-MM-dd");
            string NgaySinh = n.ToString("yyyy-MM-dd");
            try
            {
                query = "INSERT INTO NhanVien(MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Email, Sdt, Cmnd, NgayCap, MaTinhThanh, DanToc, MaPhongBan, MaChucVu, MaBacLuong, TinhTrangLamViec, SoBHXH, SoBHYT, TaiKhoanNH) ";
                query += " VALUES((select max(MaNV) + 1 from NhanVien),N'" + txtTenNhanVien + "','"+ NgaySinh+ "',  (CASE '" + txtGioiTinh+"' WHEN N'Nam' THEN 1 ELSE 0 END), N'" + txtDiaChi + "', N'" + txtEmail + "', N'" + txtSdt + "', N'" + txtCmnd + "','" + NgayCap + "', (select MaTinhThanh from TinhThanh where TenTinhThanh like CONCAT(N'" + txtTenTinhThanh + "', '%')) ,N'" + txtDanToc + "', (select MaPhongBan from PhongBan where TenPhongBan like CONCAT( N'" + txtPhongBan + "', '%')), (select MaChucVu from ChucVu where TenChucVu like CONCAT(N'" + txtTenChucVu + "', '%')) , N'" + txtMaBacLuong + "', N'" + txtTinhTrangLamViec + "', N'" + txtSoBHXH + "', N'" + txtSoBHYT + "', N'" + txtTaiKhoanNH + "')";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<NhanVien> GetNhanVienToList(int ID)
        {
            List<NhanVien> listNhanVien = new List<NhanVien>();
            string query = "exec [SP_GetNhanVienByID] @MaNV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ID });
            foreach (DataRow item in data.Rows)
            {
                NhanVien menu = new NhanVien(item);
                listNhanVien.Add(menu);
            }
            return listNhanVien;
        }

        public List<PhongBan> GetAllPhongBan()
        {
            List<PhongBan> listPhongBan = new List<PhongBan>();
            string query = "exec SP_GetAllPhongBan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhongBan menu = new PhongBan(item);
                listPhongBan.Add(menu);
            }
            return listPhongBan;
        }

        public List<BacLuong> GetAllBacLuong()
        {
            List<BacLuong> listBacLuong = new List<BacLuong>();
            string query = "select * from BacLuong";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BacLuong menu = new BacLuong(item);
                listBacLuong.Add(menu);
            }
            return listBacLuong;
        }


        public List<TinhThanh> GetListTinhThanh()
        {
            List<TinhThanh> tinhThanhs = new List<TinhThanh>();
            string query = "select * from TinhThanh";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TinhThanh menu = new TinhThanh(item);
                tinhThanhs.Add(menu);
            }
            return tinhThanhs;
        }

        public List<ChucVu> GetListChucVu()
        {
            List<ChucVu> chucVu = new List<ChucVu>();
            string query = "select * from ChucVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChucVu menu = new ChucVu(item);
                chucVu.Add(menu);
            }
            return chucVu;
        }

        public string GetAllPhongBanToString()
        {
            string listPhongBan = "";
            string query = "select TenPhongBan from PhongBan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                listPhongBan += (string)item["TenPhongBan"];
                listPhongBan += ",";
            }
            return listPhongBan;
        }

        public int DataGridViewToExcel_ByRawData(System.Data.DataTable dataSource, string pstrRowFillter, ref object excelSheet, int Begin_rawDataCol = 0, int Begin_RawDataRow = 0, bool isIns = true)
        {

            int TotalRowsExport = 0;
            TotalRowsExport = dataSource.DefaultView.Count;
            if (TotalRowsExport == 0)
                return 0;
            int lintColumnCount = dataSource.Columns.Count;
            int row = 0;
            string excelRange = "";
            string finalColLetter = string.Empty;
            string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int colCharsetLen = colCharset.Length;

            if (lintColumnCount > colCharsetLen)
                finalColLetter = colCharset.Substring(((lintColumnCount - 1) / colCharsetLen) - 1, 1);
            finalColLetter += colCharset.Substring((lintColumnCount - 1) % colCharsetLen, 1);

            object[,] rawData = new object[TotalRowsExport + 1, lintColumnCount - 1 + 1];
        
            return TotalRowsExport;
        }

        public DataTable GetFilterNhanVien(string Query)
        {
            string ListPhongBan = GetAllPhongBanToString();
            string query = "SELECT NV.MaNV AS [Mã NV], NV.TenNV AS [Họ tên], (CASE NV.GioiTinh WHEN 1 THEN 'Nam' ELSE N'Nữ' END) AS [Giới tính], CV.TenChucVu AS [Chức vụ], PB.TenPhongBan AS [Tên phòng ban], NV.Cmnd AS CMND, NV.NgaySinh AS [Ngày sinh], NV.DiaChi AS [Địa chỉ], NV.Email, NV.Sdt AS SĐT, ";
            query += "  NV.ThamNien AS[Thâm niên], NV.MaBacLuong AS[Hệ số lương], NV.TinhTrangLamViec AS[Tình trạng làm việc], NV.SoBHXH AS BHXH, NV.SoBHYT AS BHYT, ";
            query += " NV.TaikhoanNH AS[Số tài khoản], NV.DanToc AS[Dân tộc], NV.NgayBatDau AS[Ngày vào làm], NV.NgayKetThuc AS[Ngày nghỉ] ";
            query += " FROM NhanVien AS NV INNER JOIN ";
            query += " PhongBan AS PB ON NV.MaPhongBan = PB.MaPhongBan INNER JOIN ";
            query += " ChucVu AS CV ON NV.MaChucVu = CV.MaChucVu where 1 = 1 and";

            query += Query;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public int UpdateInfoNhanVien(int ID, string TenNhanVien, DateTime NgaySinh, string GioiTinh, string DiaChi, string Email, string Sdt, string Cmnd, DateTime NgayCap, string TenTinhThanh, string DanToc, string PhongBan, string TenChucVu, float MaBacLuong, string TinhTrangLamViec, string SoBHXH, string SoBHYT, string TaiKhoanNH, string LastModified, string UserModified, string HinhAnh)
        {
            string query = "exec [SP_UpdateImployee] @MaNV , @TenNV , @Cmnd , @NgayCap , @TenTinhThanh , ";
            query += " @NgaySinh , @GioiTinh , @DiaChi , @Email , @Sdt , @TenChucVu , @MaBacLuong , ";
            query += " @TinhTrangLamViec , @HinhAnh , @SoBHXH , @SoBHYT , @TaiKhoanNH , @TenPhongBan , ";
            query += " @DanToc ,  @LastModified , @UserModified";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID, TenNhanVien, Cmnd, NgayCap, TenTinhThanh, NgaySinh, GioiTinh, DiaChi, Email, Sdt, TenChucVu, MaBacLuong, TinhTrangLamViec, HinhAnh, SoBHXH, SoBHYT, TaiKhoanNH, PhongBan, DanToc, LastModified, UserModified});
            return result;
        }

        public DataTable GetListProvinces()
        {
            string query = string.Empty;
            query = "select * from TinhThanh";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
