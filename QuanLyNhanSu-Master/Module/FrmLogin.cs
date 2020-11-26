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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool ValidateTextBox()
        {
            if (txtUsername.Text.ToString().Trim() == "" && txtPassword.Text.ToString().Trim() == "")
            {
                imgErrorUserName.Visible = true;
                imgErrorPassWord.Visible = true;
                return false;
            }

            if (txtUsername.Text.ToString().Trim() == "" || txtPassword.Text.ToString().Trim() == "")
            {
                if (txtUsername.Text.ToString().Trim() == "")
                {
                    imgErrorUserName.Visible = true;
                    return false;
                }
                else
                {
                    imgErrorUserName.Visible = false;
                }

                if (txtPassword.Text.ToString().Trim() == "")
                {
                    imgErrorPassWord.Visible = true;
                    return false;
                }
                else
                {
                    imgErrorPassWord.Visible = false;
                }
            }
            else
            {
                imgErrorUserName.Visible = false;
                imgErrorPassWord.Visible = false;
                return true;
            }

            return true;
        }

      

        public bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;

            if (ValidateTextBox())
            {
                if (Login(userName, passWord))
                {
                    Form frmChinh = new frmChinh();
                    frmChinh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!");
                }
                
            }
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
           
        }
    }
}
