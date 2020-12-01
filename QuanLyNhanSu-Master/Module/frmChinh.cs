using ExcelDataReader;
using QuanLyNhanSu_Master.DAO;
using QuanLyNhanSu_Master.DTO;
using QuanLyNhanSu_Master.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu_Master
{
    public partial class frmChinh : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));

        private bool IsCollapsed;
        private bool IsSearch;
        public DataGridView buniDataGridHoSoNhanVien { get; private set; }
        private Account loginAccount;
        DataTable temp;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value;  }
        }
        
        public frmChinh(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            ChangeAccount(loginAccount.Role);
        }


        private void frmChinh_Load(object sender, EventArgs e)
        {
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            temp = HoSoNhanVienDAO.Instance.SearchAllNhanVien();

            DataView dtview = new DataView(temp);
            dtview.Sort = "ThongTinNV DESC";
            temp = dtview.ToTable();

            comboBox1.DataSource = temp;
            comboBox1.ValueMember = "ThongTinNV";
            comboBox1.DisplayMember = "ThongTinNV";
        }

        void ChangeAccount(string role)
        {
            // MessageBox.Show("" + role);
            if (role != "Admin")
            {
                ToolStripAddTKAdmin.Visible = false;
                ToolStripReSetPass.Visible = false;
            }
            //adminToolStripMenuItem.Enabled = type == 1;
           // thôngTinTàiKhoảnToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           
            Form frmLayouLogin = new frmLayoutLogin();
            Button bt = (Button)sender;
            //bt = (Button)sender;
            //frmLayouLogin.Show();
            //FormChild<frmLogin>();
            //if (sender.GetType().Name == "Button")
            //{
            //     bt = (Button)sender;
            //}
            //else
            //{
            //    bt = (Bunifu.Framework.UI.BunifuTileButton)sender;
            //}
           
            //Bunifu.Framework.UI.BunifuTileButton bunifuTileButton = (Bunifu.Framework.UI.BunifuTileButton)sender;
            if (bt.Name == "btnDashboard")
            {
                lblStatus.Text = "DASHBOARD";
                //FormChild<frmLogin>();
                btnDashboard.BackColor = Color.FromArgb(81, 136, 202);
                btnDashboard.ForeColor = Color.White;
                iconDashboard.Image = ((System.Drawing.Image)(resources.GetObject("iconDashboard.ImageActive")));
            }
            else
            {
                btnDashboard.BackColor = Color.Transparent;
                btnDashboard.ForeColor = Color.Black;
                iconDashboard.Image = ((System.Drawing.Image)(resources.GetObject("iconDashboard.Image")));
            }

            if (bt.Name == "btnNhanVien" || bt.Name == "btnImport")
            {
                lblStatus.Text = "HỒ SƠ NHÂN VIÊN";
                //FormChild<frmHoSoNhanVien>();
                lblStatus.Text = "HỒ SƠ NHÂN VIÊN";
                frmHoSoNhanVien frmHoSoNhanVien = new frmHoSoNhanVien();
                frmHoSoNhanVien.Action = "Không tìm kiếm";
                frmHoSoNhanVien.TopLevel = false;
                frmHoSoNhanVien.MdiParent = this.MdiParent;
                PanelCenter.Controls.Add(frmHoSoNhanVien);
                frmHoSoNhanVien.Dock = DockStyle.Fill;
                frmHoSoNhanVien.Show();
                frmHoSoNhanVien.BringToFront();

                btnNhanVien.BackColor = Color.FromArgb(81, 136, 202);
                btnNhanVien.ForeColor = Color.White;
               iconNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("iconNhanVien.ImageActive")));
            }
            else
            {
                btnNhanVien.BackColor = Color.Transparent;
                btnNhanVien.ForeColor = Color.Black;
                iconNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("iconNhanVien.Image")));
            }

            if (bt.Name == "btnChamCong")
            {
                lblStatus.Text = "CHẤM CÔNG";
                //FormChild<frmLogin>();
                btnChamCong.BackColor = Color.FromArgb(81, 136, 202);
                btnChamCong.ForeColor = Color.White;
                iconChamCong.Image = ((System.Drawing.Image)(resources.GetObject("iconChamCong.ImageActive")));
            }
            else
            {
                btnChamCong.BackColor = Color.Transparent;
                btnChamCong.ForeColor = Color.Black;
                iconChamCong.Image = ((System.Drawing.Image)(resources.GetObject("iconChamCong.Image")));

            }

            if (bt.Name == "btnBangLuong")
            {
                lblStatus.Text = "BẢNG LƯƠNG";
                //FormChild<frmLogin>();
                btnBangLuong.BackColor = Color.FromArgb(81, 136, 202);
                btnBangLuong.ForeColor = Color.White;
                iconBangLuong.Image = ((System.Drawing.Image)(resources.GetObject("iconChamCong.ImageActive")));

            }
            else
            {
                btnBangLuong.BackColor = Color.Transparent;
                btnBangLuong.ForeColor = Color.Black;
                iconBangLuong.Image = ((System.Drawing.Image)(resources.GetObject("iconChamCong.Image")));

            }
        }


        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormChild<ChildForm>() where ChildForm : Form, new()
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
                
                if (formCenter.Name == "frmHoSoNhanVien")
                {
                    if (IsSearch == true)
                    {
                        frmHoSoNhanVien.Action = "Tìm kiếm";
                        frmHoSoNhanVien.TenNhanVien = txtSearch.Text;
                       
                    }
                    else
                    {
                        frmHoSoNhanVien.Action = "Không tìm kiếm";
                        
                    }
                   
                }
                formCenter.Show();
                formCenter.BringToFront();
            }
            else
            {
                formCenter.BringToFront();
            }
        }
        
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "CHẤM CÔNG";
            this.iconDashboard.Image = ((System.Drawing.Image)(resources.GetObject("iconDashboard.ImageActive")));
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "BẢNG LƯƠNG";
            
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            this.iconDashboard.Image = ((System.Drawing.Image)(resources.GetObject("iconDashboard.ImageActive")));
          
        }

        private void btnChamCong_MouseHover(object sender, EventArgs e)
        {
            this.iconDashboard.Image = ((System.Drawing.Image)(resources.GetObject("iconDashboard.ImageActive")));
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //FormChild<frmAddInfoNhanVien>();
            lblStatus.Text = "HỒ SƠ NHÂN VIÊN";
            frmAddInfoNhanVien frmAddInfoNhanVien = new frmAddInfoNhanVien();
            frmAddInfoNhanVien.TopLevel = false;
            frmAddInfoNhanVien.MdiParent = this.MdiParent;
            PanelCenter.Controls.Add(frmAddInfoNhanVien);
            frmAddInfoNhanVien.Dock = DockStyle.Fill;
            frmAddInfoNhanVien.Show();
            frmAddInfoNhanVien.BringToFront();



        }

        private void TimerNghiepVu_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                PanelNghiepVu.Height += 20;
                if (PanelNghiepVu.Size == PanelNghiepVu.MaximumSize)
                {
                    TimerNghiepVu.Stop();
                    IsCollapsed = false;
                }
            }
            else
            {
                PanelNghiepVu.Height -= 20;
                if (PanelNghiepVu.Size == PanelNghiepVu.MinimumSize)
                {
                    TimerNghiepVu.Stop();
                    IsCollapsed = true;
                }
            }
            
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            TimerNghiepVu.Start();
        }


        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            IsSearch = true;
            if (e.KeyCode == Keys.Enter)
            {
                lblStatus.Text = "TÌM NHÂN VIÊN - " + txtSearch.Text;
                frmHoSoNhanVien frmHoSoNhanVien = new frmHoSoNhanVien();
                frmHoSoNhanVien.Action = "Tìm kiếm";
                frmHoSoNhanVien.TenNhanVien = txtSearch.Text;
                frmHoSoNhanVien.TopLevel = false;
                frmHoSoNhanVien.MdiParent = this.MdiParent;
                PanelCenter.Controls.Add(frmHoSoNhanVien);
                frmHoSoNhanVien.Dock = DockStyle.Fill;
                frmHoSoNhanVien.Show();
                frmHoSoNhanVien.BringToFront();
            }
        }

        private void ToolStripAddNewNhanVien_Click(object sender, EventArgs e)
        {
          
            btnAddNew_Click(sender, e);         //values preserved after close
         

        }

        private void ToolStripReSetPass_Click(object sender, EventArgs e)
        {
             frmResetPass frmAddNewUser = new frmResetPass();
            frmAddNewUser.StartPosition = FormStartPosition.CenterParent;
            var result =  frmAddNewUser.ShowDialog();
            if (result == DialogResult.OK)
            {
                btnAddNew_Click(sender, e);         //values preserved after close
               
            }
        }

        private void ToolStripAddTKAdmin_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser();
            frmAddNewUser.StartPosition = FormStartPosition.CenterParent;
            var result = frmAddNewUser.ShowDialog();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            IsSearch = true;
            if (e.KeyCode == Keys.Enter)
            {
                lblStatus.Text = "TÌM NHÂN VIÊN - " + txtSearch.Text;
                frmHoSoNhanVien frmHoSoNhanVien = new frmHoSoNhanVien();
                frmHoSoNhanVien.Action = "Tìm kiếm";
                //frmHoSoNhanVien.TenNhanVien = txtSearch.Text;
                string MaNV = comboBox1.SelectedValue.ToString();
                MaNV = MaNV.Split('-')[1];
                frmHoSoNhanVien.MaNhanVien = Convert.ToInt32(MaNV.Trim());
                frmHoSoNhanVien.TopLevel = false;
                frmHoSoNhanVien.MdiParent = this.MdiParent;
                PanelCenter.Controls.Add(frmHoSoNhanVien);
                frmHoSoNhanVien.Dock = DockStyle.Fill;
                frmHoSoNhanVien.Show();
                frmHoSoNhanVien.BringToFront();
            }
        }

        DataTableCollection TableCollection;
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text.Contains("Import Excel từ File"))
            {
                DataTable dataGrid = new DataTable();
                BindingSource SBind = new BindingSource();
                SBind.DataSource = frmImportExcelNhanVien.dataTable;
                dataGrid = frmImportExcelNhanVien.dataTable;
                int ss = dataGrid.Rows.Count;
                for (int i = 0; i <= dataGrid.Rows.Count-1; i++)
                {
                    try
                    {
                        HoSoNhanVienDAO.Instance.AddNewImployee(dataGrid.Rows[i][0].ToString(), dataGrid.Rows[i][1].ToString(), dataGrid.Rows[i][2].ToString(), dataGrid.Rows[i][3].ToString(), dataGrid.Rows[i][4].ToString(), dataGrid.Rows[i][5].ToString(), dataGrid.Rows[i][6].ToString(), dataGrid.Rows[i][7].ToString(), dataGrid.Rows[i][8].ToString(), dataGrid.Rows[i][9].ToString(), dataGrid.Rows[i][10].ToString(), dataGrid.Rows[i][11].ToString(),Convert.ToInt64(dataGrid.Rows[i][12]), dataGrid.Rows[i][13].ToString(), dataGrid.Rows[i][14].ToString(), dataGrid.Rows[i][15].ToString(), dataGrid.Rows[i][16].ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(""+ex);
                    }
                }
                MessageBox.Show("Import nhân viên thành công");
                btnDashboard_Click(btnNhanVien, e);
            }
            else
            {
                frmImportExcelNhanVien ImportExcelNhanVien = new frmImportExcelNhanVien();
                ImportExcelNhanVien.ImportExcel();
                lblStatus.Text = ImportExcelNhanVien.status;
                ImportExcelNhanVien.TopLevel = false;
                ImportExcelNhanVien.MdiParent = this.MdiParent;
                PanelCenter.Controls.Add(ImportExcelNhanVien);
                ImportExcelNhanVien.Dock = DockStyle.Fill;
                ImportExcelNhanVien.Show();
                ImportExcelNhanVien.BringToFront();
            }
        }
    }
}