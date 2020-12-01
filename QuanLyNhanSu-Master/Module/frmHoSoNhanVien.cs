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

            //buniDataGridHoSoNhanVien.DataSource = GetNhanVien();
            // SetFieldType(buniDataGridHoSoNhanVien);
        }


        public static string Action = "";
        public static string TenNhanVien = "";
        public static int MaNhanVien;
        public DataGridView SetFieldType(DataGridView buniDataGridHoSoNhanVien)
        {
            buniDataGridHoSoNhanVien.Columns["Họ tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            buniDataGridHoSoNhanVien.Columns["Tên phòng ban"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            // buniDataGridHoSoNhanVien.Columns["Hình ảnh"].Visible = false;

            foreach (DataGridViewRow item in buniDataGridHoSoNhanVien.Rows)
            {
                if (item.Index == 1)
                {
                    item.DefaultCellStyle.BackColor = Color.FromArgb(31, 65, 155);
                }
              //  item.Cells["Giới tính"].Value = (bool)item.Cells["Giới tính"].Value ? "Nam" : "Nữ";
            }
            return buniDataGridHoSoNhanVien;
        }

        public DataTable GetNhanVien()
        {
            return HoSoNhanVienDAO.Instance.GetNhanVien();
        }

        public DataTable GetNhanVien(int MaNhanVien)
        {

          return  HoSoNhanVienDAO.Instance.GetNhanVien(MaNhanVien);
        }

        private void frmHoSoNhanVien_Load(object sender, EventArgs e)
        {
            if (Action == "Tìm kiếm")
            {
                //buniDataGridHoSoNhanVien.DataSource = GetNhanVien(TenNhanVien);
                buniDataGridHoSoNhanVien.DataSource = GetNhanVien(MaNhanVien);
            }
            if (Action == "Không tìm kiếm")
            {
                buniDataGridHoSoNhanVien.DataSource = GetNhanVien();
            }
            SetFieldType(buniDataGridHoSoNhanVien);
        }
    }
}
