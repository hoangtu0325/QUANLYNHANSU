using QuanLyNhanSu_Master.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master.Module
{
    public partial class frmDoiMatKhau : frmLayoutLogin
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public string UserName;
        public string PassWord;

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string passWord = txtPassword.Text.Trim();
            string RePassword = txtRePassword.Text.Trim();
            string CodeVerify = txtCodeXacThuc.Text.Trim();

            if (userName == "" || passWord == "" || RePassword == "" || CodeVerify == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (passWord != RePassword)
                {
                    MessageBox.Show("Mật khẩu mới phải trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (AccountDAO.Instance.IsVerify(userName, CodeVerify))
                    {
                        AccountDAO.Instance.AllowChagePassword(userName, passWord);
                        this.UserName = userName;
                        this.PassWord = passWord;
                        MessageBox.Show("Đổi mật khẩu thành công");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập sai tài khoản");
                    }
                }
            } 
        }

        private void txtRePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMatKhau_Click(sender, e);
            }
        }
    }
}
