using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DTO
{
    class Account
    {
        private int role;

        public int Role
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

        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
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

        public Account(string userName, string displayName, int type, string password = null, string email)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Role = type;
            this.Password = password;
            this.Email = email;
        }
    }
}
