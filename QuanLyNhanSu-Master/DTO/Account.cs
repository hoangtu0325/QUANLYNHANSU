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
       
        private static string role;
        private static string password;
        private static string hoTen;
        private static string iD;
        private static string userName;
        private static string email;
        private static int codeXacThuc;
        private static bool allowResetPass;
        private static string lastLogin;
        
        public static string HoTen { get => hoTen; set => hoTen = value; }
        public static string ID { get => iD; set => iD = value; }
        public static string UserName { get => userName; set => userName = value; }
        public static string Password { get => password; set => password = value; }
        public static string Email { get => email; set => email = value; }
        public static string Role { get => role; set => role = value; }
        public static int CodeXacThuc { get => codeXacThuc; set => codeXacThuc = value; }
        public static bool AllowResetPass { get => allowResetPass; set => allowResetPass = value; }
        public static string LastLogin { get => lastLogin; set => lastLogin = value; }

        public  Account() { }

        public  Account(DataRow row)
        {
            ID = row["ID"].ToString();
            UserName = row["UserName"].ToString();
            Password = row["Password"].ToString();
            Role = row["Role"].ToString();
            Email = row["Email"].ToString();
            CodeXacThuc = (int)row["CodeXacThuc"];
            AllowResetPass = (bool)row["AllowResetPass"];
            HoTen = row["HoTen"].ToString();
            //LastLogin = (bool)row["LastLogin"];

        }

        public Account(string userName, string id, string type, string email, int codeXacThuc,string hoTen, bool allowResetPass, string password = null)
        {
            UserName = userName;
            ID = id;
            Role = type;
            Password = password;
            Email = email;
            HoTen = hoTen;
            CodeXacThuc = codeXacThuc;
        }
    }
}
