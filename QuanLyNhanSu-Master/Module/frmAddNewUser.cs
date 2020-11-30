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
    public partial class frmAddNewUser : frmLayoutLogin
    {

        public string ReturnValue1 { get; set; }

        public frmAddNewUser()
        {
            InitializeComponent();
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
            if (true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
