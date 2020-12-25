using QuanLyNhanSu_Master.DAO;
using QuanLyNhanSu_Master.DTO;
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
    public partial class frmBangChamCong : Form
    {
        public frmBangChamCong()
        {
            InitializeComponent();
            string lastMonth = DateTime.Now.AddMonths(-1).ToString("MM/yyyy");
            LoadData();
            SetFieldType(GridBangChamCong);
        }
        private void LoadData()
        {
            List<string> chamCong = ChamCongDAO.Instance.GetAllMonthBangChamCong();
            foreach (string item in chamCong)
            {
                cbListMonth.Items.Add(item.ToString());
            }
            cbListMonth.ValueMember = "BangChamCong";
            cbListMonth.DisplayMember = "BangChamCong";
            cbListMonth.SelectedItem = null;
            cbListMonth.SelectedIndex = 0;
            //   string ss = cbListMonth.SelectedItem.ToString();
        }
        public DataGridView SetFieldType(DataGridView GridBangChamCong)
        {
            GridBangChamCong.Columns["Tên nhân viên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            GridBangChamCong.Columns["Tên nhân viên"].Frozen = true;
            GridBangChamCong.Columns["Tổng số ngày"].DisplayIndex = 2;
            GridBangChamCong.Columns["Số giờ tăng ca"].DisplayIndex = 3;
            foreach (DataGridViewRow item in GridBangChamCong.Rows)
            {
                if (item.Index == 1)
                {
                    item.DefaultCellStyle.BackColor = Color.FromArgb(31, 65, 155);
                }
            }
            return GridBangChamCong;
        }
        private void frmBangChamCong_Load(object sender, EventArgs e)
        {
        }

        private void cbListMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productId = cbListMonth.SelectedItem as string;
            if (productId != null)
            {
                string lastMonth = Convert.ToDateTime(cbListMonth.SelectedItem).ToString("yyyy/MM");
                GridBangChamCong.DataSource = ChamCongDAO.Instance.GetAllBangChamCong(lastMonth);
             
                
            }
        }
    }
}
