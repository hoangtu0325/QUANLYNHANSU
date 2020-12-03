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
    public partial class frmResetPass : Form
    {
        public frmResetPass()
        {
            InitializeComponent();
            (new DropShadow()).ApplyShadows(this);
        }
        //private const int CS_DROPSHADOW = 0x00020000;

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //            cp.ClassStyle |= CS_DROPSHADOW;
        //        return cp;
        //    }
        //}
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            int flag = AccountDAO.Instance.ResetPassAccount(txtUserName.Text);
            //MessageBox.Show("" + flag);
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

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnResetPass_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
