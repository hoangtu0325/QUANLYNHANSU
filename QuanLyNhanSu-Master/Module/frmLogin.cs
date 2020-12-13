using MyINI;
using QuanLyNhanSu_Master.DAO;
using QuanLyNhanSu_Master.DTO;
using QuanLyNhanSu_Master.Module;
using QuanLyNhanSu_Master.Module.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            LoadData();
            (new DropShadow()).ApplyShadows(this);
        }
       
        private string storeConfig = "config.ini";
        private string init = "init";
        private bool IsAdmin = false;
        #region Methods
        private void LoadData()
        {
            bool flag = File.Exists(this.storeConfig);
            if (flag)
            {
                IniFile iniFile = new IniFile();
                iniFile.Load(this.storeConfig);
                string pass = this.GetStoreValue(iniFile.GetKeyValue(this.init, "PassWord"));
                this.txtUsername.Text = this.GetStoreValue(iniFile.GetKeyValue(this.init, "UserName"));
                this.txtPassword.Text = AccountDAO.Instance.DeCrypt(pass, "%4oPNbxNwO3Z15CoNCbi").ToString(); 
            }
        }

        private void SaveData()
        {
            bool flag = !File.Exists(this.storeConfig);
            if (flag)
            {
                File.Create(this.storeConfig).Close();
            }
            IniFile iniFile = new IniFile();
            iniFile.Load(this.storeConfig);
            iniFile.SetKeyValue(this.init, "UserName", this.txtUsername.Text);
            iniFile.SetKeyValue(this.init, "PassWord", AccountDAO.Instance.EnCrypt(txtPassword.Text, "%4oPNbxNwO3Z15CoNCbi").ToString());
            iniFile.Save(this.storeConfig);
        }

        private string GetStoreValue(string strValue)
        {
            bool flag = strValue == null;
            string result;
            if (flag)
            {
                result = "";
            }
            else
            {
                result = strValue.Trim();
            }
            return result;
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

        
        #endregion

        #region Events
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
                if (AccountDAO.Instance.IsAdmin(userName))
                {
                    IsAdmin = true;
                }

                if (Login(userName, passWord))
                {
                    if (CbSaveAccount.Checked == true)
                    {
                        SaveData();
                    }
                    Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                    AccountDAO.Instance.LastLogin(userName);
                    frmChinh frmChinh = new frmChinh(loginAccount);
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

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            frmDoiMatKhau.StartPosition = FormStartPosition.CenterParent;
            if (IsAdmin)
            {
                frmDoiMatKhau.SendCodeXacThucToAdmin(IsAdmin,txtUsername.Text);
            }
            var result = frmDoiMatKhau.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                this.txtUsername.Text = frmDoiMatKhau.UserName;  //values preserved after close
                this.txtPassword.Text = frmDoiMatKhau.PassWord;

            }
        }
        #endregion
    }
}
