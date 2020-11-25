using QuanLyNhanSu_Master.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master
{
    public partial class frmChinh : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));

        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("đá");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form frmLayouLogin = new frmLayoutLogin();
            frmLayouLogin.Show();

        }

        private void iconDashboard_MouseHover(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }
    }
}