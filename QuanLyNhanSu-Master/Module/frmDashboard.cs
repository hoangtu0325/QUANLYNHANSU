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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            FillDataToGridDashboard();
        }

        private void FillDataToGridDashboard()
        {
            GridDashboard.DataSource = AccountDAO.Instance.GetInfoAccount();
            lblCountNV.Text = AccountDAO.Instance.GetCountNV();
            lblCountUser.Text = "Tổng Users : " + GridDashboard.RowCount.ToString();
        }
    }
}
