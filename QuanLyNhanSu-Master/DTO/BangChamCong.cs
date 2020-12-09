using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DTO
{
    class BangChamCong
    {
        private int maChamCong;
        private int maNV;
        private DateTime thangChamCong;
        private string ngay1;
        private string ngay2;
        private string ngay3;
        private string ngay4;
        private string ngay5;
        private string ngay6;
        private string ngay7;
        private string ngay8;
        private string ngay9;
        private string ngay10;
        private string ngay11;
        private string ngay12;
        private string ngay13;
        private string ngay14;
        private string ngay15;
        private string ngay16;
        private string ngay17;
        private string ngay18;
        private string ngay19;
        private string ngay20;
        private string ngay21;
        private string ngay22;
        private string ngay23;
        private string ngay24;
        private string ngay25;
        private string ngay26;
        private string ngay27;
        private string ngay28;
        private string ngay29;
        private string ngay30;
        private string ngay31;
        private float tongSoNgay;
        private float ngayDiLam;
        private float vang;
        private string userModified;
        private string dateModified;

        public int MaChamCong { get => maChamCong; set => maChamCong = value; }
        public int MaNV { get => maNV; set => maNV = value; }
        public DateTime ThangChamCong { get => thangChamCong; set => thangChamCong = value; }
        public string Ngay1 { get => ngay1; set => ngay1 = value; }
        public string Ngay2 { get => ngay2; set => ngay2 = value; }
        public string Ngay3 { get => ngay3; set => ngay3 = value; }
        public string Ngay4 { get => ngay4; set => ngay4 = value; }
        public string Ngay5 { get => ngay5; set => ngay5 = value; }
        public string Ngay6 { get => ngay6; set => ngay6 = value; }
        public string Ngay7 { get => ngay7; set => ngay7 = value; }
        public string Ngay8 { get => ngay8; set => ngay8 = value; }
        public string Ngay9 { get => ngay9; set => ngay9 = value; }
        public string Ngay10 { get => ngay10; set => ngay10 = value; }
        public string Ngay11 { get => ngay11; set => ngay11 = value; }
        public string Ngay13 { get => ngay13; set => ngay13 = value; }
        public string Ngay14 { get => ngay14; set => ngay14 = value; }
        public string Ngay15 { get => ngay15; set => ngay15 = value; }
        public string Ngay16 { get => ngay16; set => ngay16 = value; }
        public string Ngay17 { get => ngay17; set => ngay17 = value; }
        public string Ngay20 { get => ngay20; set => ngay20 = value; }
        public string Ngay21 { get => ngay21; set => ngay21 = value; }
        public string Ngay22 { get => ngay22; set => ngay22 = value; }
        public string Ngay23 { get => ngay23; set => ngay23 = value; }
        public string Ngay24 { get => ngay24; set => ngay24 = value; }
        public string Ngay25 { get => ngay25; set => ngay25 = value; }
        public string Ngay26 { get => ngay26; set => ngay26 = value; }
        public string Ngay27 { get => ngay27; set => ngay27 = value; }
        public string Ngay28 { get => ngay28; set => ngay28 = value; }
        public string Ngay29 { get => ngay29; set => ngay29 = value; }
        public string Ngay30 { get => ngay30; set => ngay30 = value; }
        public string Ngay31 { get => ngay31; set => ngay31 = value; }
        public string Ngay12 { get => ngay12; set => ngay12 = value; }
        public string Ngay18 { get => ngay18; set => ngay18 = value; }
        public string Ngay19 { get => ngay19; set => ngay19 = value; }
        public float TongSoNgay { get => tongSoNgay; set => tongSoNgay = value; }
        public float NgayDiLam { get => ngayDiLam; set => ngayDiLam = value; }
        public float Vang { get => vang; set => vang = value; }
        public string UserModified { get => userModified; set => userModified = value; }
        public string DateModified { get => dateModified; set => dateModified = value; }


        public BangChamCong(DataRow row)
        {
            MaNV = Convert.ToInt32(row["MaNV"]);
            ThangChamCong = Convert.ToDateTime(row["ThangChamCong"]);
            Ngay1 = row["Ngay1"].ToString();
            Ngay2 = row["Ngay2"].ToString();
            Ngay3 = row["Ngay3"].ToString();
            Ngay4 = row["Ngay4"].ToString();
            Ngay5 = row["Ngay5"].ToString();
            Ngay6 = row["Ngay6"].ToString();
            Ngay7 = row["Ngay7"].ToString();
            Ngay8 = row["Ngay8"].ToString();
            Ngay9 = row["Ngay9"].ToString();
            Ngay10 = row["Ngay10"].ToString();
            Ngay11 = row["Ngay11"].ToString();
            Ngay12 = row["Ngay12"].ToString();
            Ngay13 = row["Ngay13"].ToString();
            Ngay14 = row["Ngay14"].ToString();
            Ngay15 = row["Ngay15"].ToString();
            Ngay16 = row["Ngay16"].ToString();
            Ngay17 = row["Ngay17"].ToString();
            Ngay18 = row["Ngay18"].ToString();
            Ngay19 = row["Ngay19"].ToString();
            Ngay20 = row["Ngay20"].ToString();
            Ngay21 = row["Ngay21"].ToString();
            Ngay22 = row["Ngay22"].ToString();
            Ngay23 = row["Ngay23"].ToString();
            Ngay24 = row["Ngay24"].ToString();
            Ngay25 = row["Ngay25"].ToString();
            Ngay26 = row["Ngay26"].ToString();
            Ngay27 = row["Ngay27"].ToString();
            Ngay28 = row["Ngay28"].ToString();
            Ngay29 = row["Ngay29"].ToString();
            Ngay30 = row["Ngay30"].ToString();
            Ngay31 = row["Ngay31"].ToString();
            TongSoNgay = float.Parse(row["TongSoNgay"].ToString());
            NgayDiLam = float.Parse(row["NgayDiLam"].ToString());
            Vang = float.Parse(row["Vang"].ToString());
            //UserModified = row["UserModified"].ToString();
            //DateModified = row["DateModified"].ToString();

        }
    }
}
