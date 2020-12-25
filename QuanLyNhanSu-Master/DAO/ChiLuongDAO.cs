using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DAO
{
    class ChiLuongDAO
    {
        private static ChiLuongDAO instance;

        public static ChiLuongDAO Instance
        {
            get { if (instance == null) instance = new ChiLuongDAO(); return instance; }
            private set { instance = value; }
        }
        private ChiLuongDAO() { }

        public float GetLuongByMaNV(int MaNV)
        {
            float MucLuong;
            DataTable data = new DataTable();
            string query = string.Empty;
            query = " select LuongCoBan from BacLuong where MaBacLuong = (select MaBacLuong from NhanVien where MaNV = @MaNV )";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaNV });
            return MucLuong = float.Parse(data.Rows[0]["LuongCoBan"].ToString());
        }

        public bool AddNewBangChiLuong(int MaNV, DateTime ThangChamCong, float SoNgayLamViec, float SoGioTangCa, float TongTienTangCa, float TroCapAnTrua, float TroCapXangXe, float TroCapTrachNhiem, float TienThuong, float TongLuong, float BHXH, float BHYT, float CongDoan, float ThucLanh)
        {
            string query = string.Empty;
            string thangchamcong = ThangChamCong.ToString("yyyy-MM-dd");
            try
            {
                query = "Insert Into BangChiLuong( MaNV, ThangChi, SoNgaylamviec, MaBacLuong, SoGioTangCa, TongTienTangCa, TroCapAnTrua, TroCapXangXe, TroCapTrachNhiem, TienThuong, TongLuong, BHXH, BHYT, CongDoan, ThucLanh) ";
                query += " VALUES( @MaNV , @ThangChi , @SoNgayLamViec , ( select MaBacLuong from NhanVien where MaNV = @MaNV1 ) , @SoGioTangCa , @TongTienTangCa , @TroCapAnTrua , @TroCapXangXe , @TroCapTrachNhiem , @TienThuong , @TongLuong , @BHXH , @BHYT , @CongDoan , @ThucLanh ) ";

                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNV, thangchamcong, SoNgayLamViec, MaNV, SoGioTangCa, TongTienTangCa, TroCapAnTrua, TroCapXangXe,TroCapTrachNhiem, TienThuong , TongLuong, BHXH, BHYT, CongDoan, ThucLanh });
                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateBangChiLuongByMonth(int MaNV, DateTime ThangChamCong, float SoNgayLamViec, float SoGioTangCa, float TongTienTangCa, float TroCapAnTrua, float TroCapXangXe, float TroCapTrachNhiem, float TienThuong, float TongLuong, float BHXH, float BHYT, float CongDoan, float ThucLanh)
        {
            string query = string.Empty;
            string thangchamcong = ThangChamCong.ToString("yyyy-MM-dd");
            try
            {
                query = "update top(1) BangChiLuong set SoNgaylamviec = @SoNgaylamviec , MaBacLuong = ( select MaBacLuong from NhanVien where MaNV = @MaNV ) , SoGioTangCa = @SoGioTangCa , TongTienTangCa = @TongTienTangCa , TroCapAnTrua = @TroCapAnTrua , TroCapXangXe = @TroCapXangXe , TroCapTrachNhiem = @TroCapTrachNhiem , TienThuong = @TienThuong , TongLuong = @TongLuong , BHXH = @BHXH , BHYT = @BHYT , CongDoan = @CongDoan ,ThucLanh = @ThucLanh ";
                query += " where MaNV = @MaNV1 and ThangChi = @ThangChi ";
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { SoNgayLamViec, MaNV, SoGioTangCa, TongTienTangCa, TroCapAnTrua, TroCapXangXe, TroCapTrachNhiem, TienThuong, TongLuong, BHXH, BHYT, CongDoan, ThucLanh , MaNV, thangchamcong });
                return result > 0;
            }
            catch (Exception ex)
            {
                string exs = ex.ToString();
                return false;
            }
        }

        public string CountMoneyByMonth(string dateTime)
        {
            string Money;
            string query = string.Empty;
            DataTable data = new DataTable();
            query = " select FORMAT(Sum(ThucLanh),'#,0') as [CountMoney]  from BangChiLuong where ThangChi = @date ";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { dateTime });
            return Money = data.Rows[0]["CountMoney"].ToString();
        }

        public List<string> GetAllMonthBangChiLuong()
        {
            List<string> listMonthBangChamCong = new List<string>();

            string query =
            string.Format("SELECT Distinct(ThangChi) FROM [QuanLyNhanSu].[dbo].[BangChiLuong] Order by ThangChi DESC");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                listMonthBangChamCong.Add(((DateTime)item["ThangChi"]).ToString("MM/yyyy"));
            }
            return listMonthBangChamCong;
        }

        public DataTable GetAllBangChiLuongByMonth(string date)
        {
            date = date + "/01";
            string query = "SELECT CL.MaNV, NV.TenNV, CV.TenChucVu, CL.SoNgaylamviec, BL.LuongCoBan, ROUND(BL.LuongCoBan / 26 * CL.SoNgaylamviec, - 3) AS LuongThangCoBan, CL.SoGioTangCa, CL.TongTienTangCa, CL.TroCapAnTrua, CL.TroCapXangXe, ";
            query += " CL.TroCapTrachNhiem, CL.TienThuong,CL.TongLuong, CL.BHXH, CL.BHYT, CL.CongDoan, CL.ThucLanh ";
            query += " FROM BangChiLuong AS CL INNER JOIN ";
            query += " NhanVien AS NV ON NV.MaNV = CL.MaNV INNER JOIN ";
            query += " BacLuong AS BL ON CL.MaBacLuong = BL.MaBacLuong ";
            query += " Inner join ChucVu CV on NV.MaChucVu=CV.MaChucVu  ";
            query += " WHERE(CL.ThangChi = '"+ date + "') ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
