using ExcelDataReader;
using QuanLyNhanSu_Master.DAO;
using QuanLyNhanSu_Master.DTO;
using QuanLyNhanSu_Master.Module;
using QuanLyNhanSu_Master.Module.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            set { loginAccount = value; }
        }

        public frmChinh(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            ChangeAccount(Account.Role);

        }


        private void frmChinh_Load(object sender, EventArgs e)
        {
            cbSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSearch.AutoCompleteSource = AutoCompleteSource.ListItems;

            temp = HoSoNhanVienDAO.Instance.SearchAllNhanVien();

            DataView dtview = new DataView(temp);
            dtview.Sort = "ThongTinNV DESC";
            temp = dtview.ToTable();

            cbSearch.DataSource = temp;
            cbSearch.ValueMember = "ThongTinNV";
            cbSearch.DisplayMember = "ThongTinNV";
            cbSearch.SelectedItem = null;
            cbSearch.SelectedText = "Tìm kiếm hồ sơ nhân sự";
           
        }

        void ChangeAccount(string role)
        {
            if (role != "Admin")
            {
                ToolStripAddTKAdmin.Visible = false;
                ToolStripReSetPass.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            Form frmLayouLogin = new frmLayoutLogin();
            Button bt = (Button)sender;
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
                frmHoSoNhanVien frmHoSoNhanVien = new frmHoSoNhanVien(true);
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
                        string MaNV = cbSearch.SelectedValue.ToString();
                        MaNV = MaNV.Split('-')[1];
                        frmHoSoNhanVien.MaNhanVien = Convert.ToInt32(MaNV.Trim());

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

        private void ToolStripAddNewNhanVien_Click(object sender, EventArgs e)
        {
            btnAddNew_Click(sender, e);         //values preserved after close
        }

        private void ToolStripReSetPass_Click(object sender, EventArgs e)
        {
            frmResetPass frmAddNewUser = new frmResetPass();
            frmAddNewUser.StartPosition = FormStartPosition.CenterParent;
            var result = frmAddNewUser.ShowDialog();
            if (result == DialogResult.OK)
            {
                btnAddNew_Click(sender, e);         //values preserved after close

            }
        }

        private void ToolStripAddTKAdmin_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser();
            frmAddNewUser.StartPosition = FormStartPosition.CenterParent;
            frmAddNewUser.Show();
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
                for (int i = 0; i <= dataGrid.Rows.Count - 1; i++)
                {
                    try
                    {
                        HoSoNhanVienDAO.Instance.AddNewImployee(dataGrid.Rows[i][0].ToString(), (DateTime)dataGrid.Rows[i][1], dataGrid.Rows[i][2].ToString(), dataGrid.Rows[i][3].ToString(), dataGrid.Rows[i][4].ToString(), dataGrid.Rows[i][5].ToString(), dataGrid.Rows[i][6].ToString(), (DateTime)dataGrid.Rows[i][7], dataGrid.Rows[i][8].ToString(), dataGrid.Rows[i][9].ToString(), dataGrid.Rows[i][10].ToString(), dataGrid.Rows[i][11].ToString(), dataGrid.Rows[i][12].ToString(), dataGrid.Rows[i][13].ToString(), dataGrid.Rows[i][14].ToString(), dataGrid.Rows[i][15].ToString(), dataGrid.Rows[i][16].ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                MessageBox.Show("Import nhân viên thành công");
                btnDashboard_Click(btnNhanVien, e);
            }
            else
            {
                frmImportExcelNhanVien ImportExcelNhanVien = new frmImportExcelNhanVien();
                ImportExcelNhanVien.ImportExcel();
                if (ImportExcelNhanVien.status.Contains("Import Excel từ File"))
                {
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

        private void cbSearch_Click(object sender, EventArgs e)
        {
            cbSearch.SelectedItem = null;
            cbSearch.SelectedText = "";
        }
        private void cbSearch_Leave(object sender, EventArgs e)
        {
            cbSearch.SelectedItem = null;
            cbSearch.SelectedText = "";
            cbSearch.SelectedText = "Tìm kiếm hồ sơ nhân sự";
        }
        private void cbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            IsSearch = true;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (cbSearch.SelectedItem != null)
                {
                    lblStatus.Text = "TÌM NHÂN VIÊN - " + cbSearch.SelectedValue.ToString();
                    frmHoSoNhanVien frmHoSoNhanVien = new frmHoSoNhanVien(true);
                    frmHoSoNhanVien.Action = "Tìm kiếm";
                    //frmHoSoNhanVien.TenNhanVien = txtSearch.Text;
                    string MaNV = cbSearch.SelectedValue.ToString();
                    MaNV = MaNV.Split('-')[1];
                    frmHoSoNhanVien.MaNhanVien = Convert.ToInt32(MaNV.Trim());
                    frmHoSoNhanVien.TopLevel = false;
                    frmHoSoNhanVien.MdiParent = this.MdiParent;
                    PanelCenter.Controls.Add(frmHoSoNhanVien);
                    frmHoSoNhanVien.Dock = DockStyle.Fill;
                    frmHoSoNhanVien.Show();
                    frmHoSoNhanVien.BringToFront();
                    cbSearch.SelectedItem = null;
                    cbSearch.SelectedText = "Tìm kiếm hồ sơ nhân sự";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên");
                }

            }
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
            //Bunifu.Framework.UI.BunifuTileButton bt = (Bunifu.Framework.UI.BunifuTileButton)sender;
            //bt.BackColor = Color.FromArgb(238, 238, 238);
            //bt.ForeColor = Color.White;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            //Bunifu.Framework.UI.BunifuTileButton bt = (Bunifu.Framework.UI.BunifuTileButton)sender;
           // bt.BackColor = Color.Transparent;
            //bt.ForeColor = Color.Black;
        }

        private void PanelTop_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }
        private void MainWindow_OnResize(object sender, EventArgs e)
        {
            this.WindowState = WindowState;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            
            switch (lblStatus.Text)
            {
                case "HỒ SƠ NHÂN VIÊN":
                    DataTable dataGrid = new DataTable();
                    BindingSource SBind = new BindingSource();
                    SBind.DataSource = frmHoSoNhanVien.dataTable;
                    frmHoSoNhanVien.dataTable2 = frmHoSoNhanVien.dataTable;
                    try
                    {
                        frmHoSoNhanVien.Action = "Export";
                        frmHoSoNhanVien hoSoNhanVien = new frmHoSoNhanVien(true);
                        hoSoNhanVien.IsExport1 = true;
                       
                        hoSoNhanVien.ExportExcel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                    break;
                case "CHẤM CÔNG":
                    break;
                case "":
                    break;
                default:
                    break;
            }
        }
      
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void toolStripReLogin_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Bạn có chắc muốn đăng nhập lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                this.Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
        }

        private void ToolStripExportNhanVien_Click(object sender, EventArgs e)
        {
            frmFilterExportExcel frmFilterExportExcel = new frmFilterExportExcel();
            frmFilterExportExcel.StartPosition = FormStartPosition.CenterScreen;
            frmFilterExportExcel.Show();
        }

        private void toolStripImportBangChamCong_Click(object sender, EventArgs e)
        {
            ImportBangChamCongToDataTable();
            AddBangChamCongToCSDL(tableBangChamCong);
        }
        public DataTable tableBangChamCong;
        public DataTable ImportBangChamCongToDataTable()
        {

            string tableName = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2020 Workbook|*.xls*" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.lblStatus.Text = "Import bảng chấm công từ File - " + openFileDialog.SafeFileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            TableCollection = result.Tables;
                            tableName = TableCollection[0].TableName;
                        }
                    }
                    return tableBangChamCong = TableCollection[tableName.ToString()];
                   
                }
                else
                {
                    //MessageBox.Show("Vui lòng chọn file để Import");
                    this.lblStatus.Text = "None Import Excel";
                    return tableBangChamCong = null;
                }
            }

        }
        public void AddBangChamCongToCSDL(DataTable table)
        {
            if (lblStatus.Text.Contains("Import bảng chấm công từ File"))
            {
                DataTable dataGrid = new DataTable();
                BindingSource SBind = new BindingSource();
                SBind.DataSource = table;
                dataGrid = table;
                int ss = dataGrid.Rows.Count;

                //Lấy ra tháng xuất bảng chấm công
                string date;
                date = dataGrid.Rows[5][0].ToString();
                date = date.Substring(date.Length - 7, 7);
                DateTime dateTime = DateTime.Parse(date);
                bool status = false;
                for (int i = 11; i <= dataGrid.Rows.Count - 4; i++)
                {
                    try
                    {
                        int MaNV = Convert.ToInt32(dataGrid.Rows[i][2]);
                        status = ChamCongDAO.Instance.AddNewBangChamCong(Convert.ToInt32(dataGrid.Rows[i][2]), dateTime, dataGrid.Rows[i][4].ToString(), dataGrid.Rows[i][5].ToString(), dataGrid.Rows[i][6].ToString(), dataGrid.Rows[i][7].ToString(), dataGrid.Rows[i][8].ToString(), dataGrid.Rows[i][9].ToString(), dataGrid.Rows[i][10].ToString(), dataGrid.Rows[i][11].ToString(), dataGrid.Rows[i][12].ToString(), dataGrid.Rows[i][13].ToString(), dataGrid.Rows[i][14].ToString(), dataGrid.Rows[i][15].ToString(), dataGrid.Rows[i][16].ToString(), dataGrid.Rows[i][17].ToString(), dataGrid.Rows[i][18].ToString(), dataGrid.Rows[i][19].ToString(), dataGrid.Rows[i][20].ToString(), dataGrid.Rows[i][21].ToString(), dataGrid.Rows[i][22].ToString(), dataGrid.Rows[i][23].ToString(), dataGrid.Rows[i][24].ToString(), dataGrid.Rows[i][25].ToString(), dataGrid.Rows[i][26].ToString(), dataGrid.Rows[i][27].ToString(), dataGrid.Rows[i][28].ToString(), dataGrid.Rows[i][29].ToString(), dataGrid.Rows[i][30].ToString(), dataGrid.Rows[i][31].ToString(), dataGrid.Rows[i][32].ToString(), dataGrid.Rows[i][33].ToString(), dataGrid.Rows[i][34].ToString(), float.Parse(dataGrid.Rows[i][35].ToString()), float.Parse(dataGrid.Rows[i][36].ToString()), Account.UserName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
                if (status)
                {
                    MessageBox.Show("Import bảng chấm công thành công");
                }

            }
        }
    }
}