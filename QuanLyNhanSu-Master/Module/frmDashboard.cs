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
            lblCountUser.Text =  GridDashboard.RowCount.ToString();
            string lastMonth = DateTime.Now.AddMonths(-1).ToString("yyyy/MM");
             lastMonth += "/01";
            lblCountMoney.Text = ChiLuongDAO.Instance.CountMoneyByMonth(lastMonth).ToString();
        }
    }
}
