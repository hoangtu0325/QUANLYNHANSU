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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form frmLayouLogin = new frmLayoutLogin();
            //frmLayouLogin.Show();
            FrmChinh<FrmLogin>();

        }


        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmChinh<ChildForm>() where ChildForm : Form, new()
        {
            Form formCenter;
            formCenter = PanelCenter.Controls.OfType<ChildForm>().FirstOrDefault();
            if (formCenter == null)
            {
                formCenter = new ChildForm();
                formCenter.TopLevel = false;
                PanelCenter.Controls.Add(formCenter);
                formCenter.Dock = DockStyle.Fill;
                PanelCenter.Tag = formCenter;
                formCenter.Show();
                formCenter.BringToFront();
            }
            else
            {
                formCenter.BringToFront();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            FrmChinh<frmLayout>();
        }
    }
}