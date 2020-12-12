﻿using QuanLyNhanSu_Master.DAO;
using QuanLyNhanSu_Master.Module.Popup;
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
    public partial class frmAddNewUser : Form
    {
        public string ReturnValue1 { get; set; }

        public frmAddNewUser()
        {
            InitializeComponent();
            (new DropShadow()).ApplyShadows(this);
           
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string passWord = txtPassword.Text.Trim();
            string RePassword = txtRePassword.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string HoTen = txtHoTen.Text.Trim();

            if (userName == "" || passWord == "" || RePassword == "" || Email == "")
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
                    if (AccountDAO.Instance.IsAddNewUser(userName, passWord, Email, HoTen))
                    {
                        MessageBox.Show("Thêm tài khoản Admin thành công");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã khai báo hoặc không kết nối được server!!");
                    }
                }
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister_Click(sender, e);
            }
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuMaterialTextbox textbox = (Bunifu.Framework.UI.BunifuMaterialTextbox)sender;
            textbox.isPassword = true;
        }
    }
}
