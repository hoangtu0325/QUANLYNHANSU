using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DTO
{
    class TinhThanh
    {
        private int maTinhThanh;
        private string tenTinhThanh;
        public int MaTinhThanh
        {
            get { return maTinhThanh; }
            set { maTinhThanh = value; }
        }
        public string TenTinhThanh
        {
            get { return tenTinhThanh; }
            set { tenTinhThanh = value; }
        }

        public TinhThanh(DataRow row)
        {
            this.MaTinhThanh = (int)row["MaTinhThanh"];
            this.TenTinhThanh = (string)row["TenTinhThanh"];
        }
    }
}
