using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DTO
{
    public class Account
    {
       
        private string role;
        private string password;
        private string hoTen;
        private string iD;
        private string userName;
        private string email;
        
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Role { get => role; set => role = value; }

        public Account() { }

        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.ID = row["ID"].ToString();
            this.Role = row["Role"].ToString();
            this.Password = row["Password"].ToString();
            this.Email = row["Email"].ToString();
        }

        public Account(string userName, string id, string type, string email, string password = null)
        {
            this.UserName = userName;
            this.ID = id;
            this.Role = type;
            this.Password = password;
            this.Email = email;
        }
    }
}
