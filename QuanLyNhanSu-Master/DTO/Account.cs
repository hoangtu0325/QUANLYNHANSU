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

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

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
