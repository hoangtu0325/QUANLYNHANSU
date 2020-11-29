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
        private static string tenNhanVien;
        public static string TenNhanVien = "";
        public DataGridView SetFieldType(DataGridView buniDataGridHoSoNhanVien)
        {
            //buniDataGridHoSoNhanVien.Columns["Tên NV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            // buniDataGridHoSoNhanVien.Columns["Hình ảnh"].Visible = false;
           
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

        public DataTable GetNhanVien(string TenNhanVien)
        {

          return  HoSoNhanVienDAO.Instance.GetNhanVien(TenNhanVien);
        }

        private void frmHoSoNhanVien_Load(object sender, EventArgs e)
        {
            if (Action == "Tìm kiếm")
            {
                buniDataGridHoSoNhanVien.DataSource = GetNhanVien(TenNhanVien);
            }
            if (Action == "Không tìm kiếm")
            {
                buniDataGridHoSoNhanVien.DataSource = GetNhanVien();
            }
        }
    }
}
