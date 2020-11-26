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
    public partial class frmHoSoNhanVien : Form
    {
        public frmHoSoNhanVien()
        {
            InitializeComponent();
            buniDataGridHoSoNhanVien.DataSource = GetNhanVien();
            SetFieldType(buniDataGridHoSoNhanVien);
        }

        public DataGridView SetFieldType(DataGridView buniDataGridHoSoNhanVien)
        {
            buniDataGridHoSoNhanVien.Columns["Tên NV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            buniDataGridHoSoNhanVien.Columns["Hình ảnh"].Visible = false;

            foreach (DataGridViewRow item in buniDataGridHoSoNhanVien.Rows)
            {
                if (item.Index == 1)
                {
                    item.DefaultCellStyle.BackColor = Color.FromArgb(31, 65, 155);
                }
            }
            return buniDataGridHoSoNhanVien;
        }

        public DataTable GetNhanVien()
        {
            return HoSoNhanVienDAO.Instance.GetNhanVien();
        }
    }
}
