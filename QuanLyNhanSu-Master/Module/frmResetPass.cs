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
    public partial class frmResetPass : frmLayoutLogin
    {
        public frmResetPass()
        {
            InitializeComponent();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            int flag = AccountDAO.Instance.ResetPassAccount(txtUserName.Text);
            MessageBox.Show("" + flag);
            if (flag == 1)
            {
                MessageBox.Show("Reset Pass User thành công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản");
            }
           
        }
    }
}
