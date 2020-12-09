using System;
using System.Collections.Generic;
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
                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
