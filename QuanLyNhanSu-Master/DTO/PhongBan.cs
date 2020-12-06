using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DTO
{
    class PhongBan
    {
        private int maPhongBan;
        private string tenPhongBan;
        public int MaPhongBan
        {
            get { return maPhongBan; }
            set { maPhongBan = value; }
        }
        public string TenPhongBan
        {
            get { return tenPhongBan; }
            set { tenPhongBan = value; }
        }

        public PhongBan(DataRow row)
        {
            this.MaPhongBan = (int)row["MaPhongBan"];
            this.TenPhongBan = (string)row["TenPhongBan"];
        }
    }
}
