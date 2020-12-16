using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DTO
{
    class ChucVu
    {
        private int maChucVu;
        private string tenChucVu;
        public int MaChucVu
        {
            get { return maChucVu; }
            set { maChucVu = value; }
        }
        public string TenChucVu
        {
            get { return tenChucVu; }
            set { tenChucVu = value; }
        }

        public ChucVu(DataRow row)
        {
            this.MaChucVu = (int)row["MaChucVu"];
            this.TenChucVu = (string)row["TenChucVu"];
        }
    }
}
