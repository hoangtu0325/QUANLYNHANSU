using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DAO
{
    class PhongBanDAO
    {

        private static PhongBanDAO instance;

        public static PhongBanDAO Instance
        {
            get { if (instance == null) instance = new PhongBanDAO(); return instance; }
            private set { instance = value; }
        }
        private PhongBanDAO() { }

        public string GetIdNewPhongBan()
        {
            string id;
            string query = string.Empty;
            DataTable data = new DataTable();
            query = "SELECT MAX(MaPhongBan) + 1 AS MaPhongBan FROM PhongBan";
            data = DataProvider.Instance.ExecuteQuery(query);

            DataRow firstRow = data.Rows[0];
            return id = firstRow["MaPhongBan"].ToString();
            
        }

        public bool AddNewPhongBan(string id, string tenPhongBan)
        {
            string query = string.Empty;
            query = string.Format("insert into PhongBan(MaPhongBan, TenPhongBan) values({0}, N'{1}')", id, tenPhongBan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
