using QuanLyNhanSu_Master.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public bool Login(string userName, string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            //var list = hasData.ToString();
            //list.Reverse();

            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPass /*list*/});

            return result.Rows.Count > 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Form frmChinh = new frmChinh();
            frmChinh.Show();
            this.Hide();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
