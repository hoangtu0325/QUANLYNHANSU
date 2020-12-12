using QuanLyNhanSu_Master.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DAO
{
    class ChamCongDAO
    {
        private static ChamCongDAO instance;

        public static ChamCongDAO Instance
        {
            get { if (instance == null) instance = new ChamCongDAO(); return instance; }
            private set { instance = value; }
        }
        private ChamCongDAO() { }

        public bool AddNewBangChamCong(int MaNV, DateTime ThangChamCong, string ngay1, string ngay2, string ngay3, string ngay4, string ngay5, string ngay6, string ngay7, string ngay8, string ngay9, string ngay10, string ngay11, string ngay12, string ngay13, string ngay14, string ngay15, string ngay16, string ngay17, string ngay18, string ngay19, string ngay20, string ngay21, string ngay22, string ngay23, string ngay24, string ngay25, string ngay26, string ngay27, string ngay28, string ngay29, string ngay30, string ngay31, float TongSoNgay, float SoGioTangCa, string UserModified)
        {
            string query = string.Empty;

            string thangchamcong = ThangChamCong.ToString("yyyy-MM");
            try
            {
                query = "INSERT INTO BangChamCong(MaNV, ThangChamCong, Ngay1, Ngay2, Ngay3, Ngay4, Ngay5, Ngay6, Ngay7, Ngay8, Ngay9, Ngay10, Ngay11, Ngay12, Ngay13, Ngay14, Ngay15, Ngay16, Ngay17, Ngay18, Ngay19, Ngay20, Ngay21, Ngay22, Ngay23, ";
                query += " Ngay24, Ngay25, Ngay26, Ngay27, Ngay28, Ngay29, Ngay30, Ngay31, TongSoNgay, SoGioTangCa, UserModified) ";
                query += " VALUES( @MaNV , @ThangChamCong , @Ngay1 , @Ngay2 , @Ngay3 , @Ngay4 , @Ngay5 , @Ngay6 , @Ngay7 , @Ngay8 , @Ngay9 , @Ngay10 , @Ngay11 , @Ngay12 , @Ngay13 , @Ngay14 , @Ngay15 , @Ngay16 , @Ngay17 , @Ngay18 , @Ngay19 , @Ngay20 , @Ngay21 , @Ngay22 , @Ngay23 , @Ngay24 , @Ngay25 , @Ngay26 , @Ngay27 , @Ngay28 , @Ngay29 , @Ngay30 , @Ngay31 , @TongSoNgay , @SoGioTangCa , @UserModified )";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNV, ThangChamCong, ngay1, ngay2, ngay3, ngay4, ngay5, ngay6, ngay7, ngay8, ngay9, ngay10, ngay11, ngay12, ngay13, ngay14, ngay15, ngay16, ngay17, ngay18, ngay19, ngay20, ngay21, ngay22, ngay23, ngay24, ngay25, ngay26, ngay27, ngay28, ngay29, ngay30, ngay31, TongSoNgay, SoGioTangCa, UserModified });

                query = "Insert Into BangChiLuong( MaNV, ThangChi, SoNgaylamviec, MaBacLuong, SoGioTangCa, TongTienTangCa, TroCapAnTrua, TroCapXangXe, TroCapTrachNhiem, TienThuong, Phat, TongLuong, BHXH, BHYT, CongDoan, ThatNghiep, ThucLanh) ";
                query += " VALUES( @MaNV , @ThangChi , @SoNgayLamViec , ( select MaBacLuong from NhanVien where MaNV = @MaNV ) , @SoGioTangCa , ) ";
                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<string> GetAllMonthBangChamCong()
        {
            List<string> listMonthBangChamCong = new List<string>();
            
            string query =
            string.Format("SELECT Distinct(ThangChamCong) FROM [QuanLyNhanSu].[dbo].[BangChamCong] Order by ThangChamCong DESC");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                listMonthBangChamCong.Add(((DateTime)item["ThangChamCong"]).ToString("MM/yyyy"));
            }
            return listMonthBangChamCong;
        }
        public List<string> GetHeader()
        {
            string query = "SELECT CC.MaNV AS [Mã NV], NV.TenNV AS [Tên nhân viên],CC.ThangChamCong AS [Tháng chấm công], CC.Ngay1 AS [1], CC.Ngay2 AS [2], CC.Ngay3 AS [3], CC.Ngay4 AS [4], CC.Ngay5 AS [5], CC.Ngay6 AS [6], CC.Ngay7 AS [7], CC.Ngay8 AS [8], CC.Ngay9 AS [9], CC.Ngay10 AS [10], ";
            query += " CC.Ngay11 AS[11], CC.Ngay12 AS[12], CC.Ngay13 AS[13], CC.Ngay14 AS[14], CC.Ngay15 AS[15], CC.Ngay16 AS[16], CC.Ngay17 AS[17], CC.Ngay18 AS[18], CC.Ngay19 AS[19], CC.Ngay20 AS[20], CC.Ngay21 AS[21], CC.Ngay22 AS[22], ";
            query += " CC.Ngay23 AS[23], CC.Ngay24 AS[24], CC.Ngay25 AS[25], CC.Ngay26 AS[26], CC.Ngay27 AS[27], CC.Ngay28 AS[28], CC.Ngay29 AS[29], CC.Ngay30 AS[30], CC.Ngay31 AS[31], CC.TongSoNgay AS[Tổng số ngày], ";
            query += " CC.SoGioTangCa AS[Số giờ tăng ca], CC.UserModified AS[Người sửa], CC.DateModified AS[Ngày sửa] ";
            query += " FROM BangChamCong AS CC INNER JOIN ";
            query += " NhanVien AS NV ON CC.MaNV = NV.MaNV where CC.MaNV = '23424'";
            //query += " where ThangChamCong = '" + date + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<string> listHeader = new List<string>();
            foreach (DataColumn header in data.Columns)
            {
                listHeader.Add(header.ToString());
            }
            return listHeader;
        }
        public DataTable GetAllBangChamCong(string date)
        {
            //List<BangChamCong> listBangChamCong = new List<BangChamCong>();
            string query = "SELECT CC.MaNV AS [Mã NV], NV.TenNV AS [Tên nhân viên],CC.ThangChamCong AS [Tháng chấm công], CC.Ngay1 AS [1], CC.Ngay2 AS [2], CC.Ngay3 AS [3], CC.Ngay4 AS [4], CC.Ngay5 AS [5], CC.Ngay6 AS [6], CC.Ngay7 AS [7], CC.Ngay8 AS [8], CC.Ngay9 AS [9], CC.Ngay10 AS [10], ";
            query += " CC.Ngay11 AS[11], CC.Ngay12 AS[12], CC.Ngay13 AS[13], CC.Ngay14 AS[14], CC.Ngay15 AS[15], CC.Ngay16 AS[16], CC.Ngay17 AS[17], CC.Ngay18 AS[18], CC.Ngay19 AS[19], CC.Ngay20 AS[20], CC.Ngay21 AS[21], CC.Ngay22 AS[22], ";
            query += " CC.Ngay23 AS[23], CC.Ngay24 AS[24], CC.Ngay25 AS[25], CC.Ngay26 AS[26], CC.Ngay27 AS[27], CC.Ngay28 AS[28], CC.Ngay29 AS[29], CC.Ngay30 AS[30], CC.Ngay31 AS[31], CC.TongSoNgay AS[Tổng số ngày], ";
            query += " CC.SoGioTangCa AS[Số giờ tăng ca], CC.UserModified AS[Người sửa], CC.DateModified AS[Ngày sửa] ";
            query += " FROM BangChamCong AS CC INNER JOIN ";
            query += " NhanVien AS NV ON CC.MaNV = NV.MaNV";
            query += " where ThangChamCong = '" + date + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
       
            //foreach (DataRow item in data.Rows)
            //{
            //    BangChamCong menu = new BangChamCong(item);
            //    listBangChamCong.Add(menu);
            //}
            return data;
        }
    }
}
