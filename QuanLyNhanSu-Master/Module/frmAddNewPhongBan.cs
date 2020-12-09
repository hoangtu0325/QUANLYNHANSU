using QuanLyNhanSu_Master.DAO;
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
    public partial class frmAddNewPhongBan : Form
    {
        public frmAddNewPhongBan()
        {
            InitializeComponent();
            (new DropShadow()).ApplyShadows(this);
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string MaPB = txtMaPhongBan.Text.Trim();
            string TenPB = txtTenPhongBan.Text.Trim();


            if (MaPB == "" || TenPB == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (AccountDAO.Instance.IsAddNewPhongBan(MaPB, TenPB))
                {

                    MessageBox.Show("Thêm Phòng Ban thành công");
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
}






