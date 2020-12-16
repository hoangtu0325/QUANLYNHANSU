using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DTO
{
    class BacLuong
    {
        private int maBacLuong;
        private int bacLuong;
        public int MaBacLuong
        {
            get { return maBacLuong; }
            set { maBacLuong = value; }
        }
        public int BacLuong1
        {
            get { return bacLuong; }
            set { bacLuong = value; }
        }

        public BacLuong(DataRow row)
        {
            this.MaBacLuong = (int)row["MaBacLuong"];
            this.BacLuong1 = (int)row["BacLuong"];
        }
    }
}
