using QuanLyNhanSu_Master.DAO;
using QuanLyNhanSu_Master.DTO;
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

namespace QuanLyNhanSu_Master.Module
{
    public partial class frmInfoNhanVien : Form
    {
        public frmInfoNhanVien(int ID)
        {
            InitializeComponent();
            BindingDataToTextBox(ID);
        }
        private string base64Image;
        private void BindingDataToTextBox(int id)
        {
            List<NhanVien> nhanVien = HoSoNhanVienDAO.Instance.GetNhanVienToList(id);
            List<TinhThanh> tinhThanh = HoSoNhanVienDAO.Instance.GetListTinhThanh();
            List<ChucVu> chucVu = HoSoNhanVienDAO.Instance.GetListChucVu();
            List<PhongBan> phongBan = HoSoNhanVienDAO.Instance.GetAllPhongBan();

            txtTenNV.DataBindings.Add(new Binding("Text", nhanVien, "TenNV", false));
            txtMaNV.DataBindings.Add(new Binding("Text", nhanVien, "MaNV", false));
            txtMaBacLuong.DataBindings.Add(new Binding("Text", nhanVien, "MaBacLuong", false));
            txtNgaySinh.DataBindings.Add(new Binding("Text", nhanVien, "NgaySinh", false));
            txtGioiTinh.DataBindings.Add(new Binding("Text", nhanVien, "GioiTinh", false));
            txtSoDienThoai.DataBindings.Add(new Binding("Text", nhanVien, "Sdt", false));
            txtEmail.DataBindings.Add(new Binding("Text", nhanVien, "Email", false));
            txtCmnd.DataBindings.Add(new Binding("Text", nhanVien, "Cmnd", false));
            txtTinhTrangLamViec.DataBindings.Add(new Binding("Text", nhanVien, "TinhTrangLamViec", false));
            txtDanToc.DataBindings.Add(new Binding("Text", nhanVien, "DanToc", false));
            txtDiaChi.DataBindings.Add(new Binding("Text", nhanVien, "DiaChi", false));
            txtNgayCap.DataBindings.Add(new Binding("Text", nhanVien, "NgayCap", false));
            txtSoBHXH.DataBindings.Add(new Binding("Text", nhanVien, "SoBHXH", false));
            txtSoBHYT.DataBindings.Add(new Binding("Text", nhanVien, "SoBHYT", false));
            txtTaiKhoanNH.DataBindings.Add(new Binding("Text", nhanVien, "TaiKhoanNH", false));

            cbListPhongBan.DataSource = phongBan;
            cbListPhongBan.DisplayMember = "TenPhongBan";
            cbListPhongBan.ValueMember = "TenPhongBan";
            cbListPhongBan.Text = nhanVien[0].TenPhongBan.ToString();

            cbListTinhThanh.DataSource = tinhThanh;
            cbListTinhThanh.DisplayMember = "TenTinhThanh";
            cbListTinhThanh.ValueMember = "TenTinhThanh";
            cbListTinhThanh.Text = nhanVien[0].TenTinhThanh.ToString();

            cbListChucVu.DataSource = chucVu;
            cbListChucVu.DisplayMember = "TenChucVu";
            cbListChucVu.ValueMember = "TenChucVu";
            cbListChucVu.Text = nhanVien[0].TenChucVu.ToString();
            if (nhanVien[0].HinhAnh != null)
            {
                Image image = Base64ToImage(nhanVien[0].HinhAnh);
                btnImageNhanVien.Image = image;
            }
        }
        public System.Data.DataTable GetNhanVien(int MaNhanVien)
        {
            return HoSoNhanVienDAO.Instance.GetNhanVien(MaNhanVien);
        }

        private void frminfonhanvien_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btnChangeImage_MouseEnter(object sender, EventArgs e)
        {
            btnChangeImage.ForeColor = Color.Red;
        }

        private void btnChangeImage_MouseLeave(object sender, EventArgs e)
        {
            btnChangeImage.ForeColor = Color.Black;
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image (*.jpg *.png)|*.jpg;*.png|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog.FileName;
                Image image = Image.FromFile(name);
                string ss = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                image.Save(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Template\\image.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                btnImageNhanVien.Image = Image.FromFile(name);
            }

        }
        public byte[] ImageToByte(Image image)
        {
            if (image != null)
            {
                MemoryStream ms = new MemoryStream();
                using (ms)
                {
                    return ms.ToArray();
                }
            }
            else
            {
                return null;
            }
        }
        public Image Base64ToImage(string base64String)
        {
            if (base64String != "")
            {
                // Convert base 64 string to byte[]
                byte[] imageBytes = Convert.FromBase64String(base64String);
                // Convert byte[] to Image
                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    Image image = Image.FromStream(ms, true);
                    string ss = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                    image.Save(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Template\\image.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    return image;
                }
            }
            else
            {
                string name = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Template\\user.jpg";
                Image image = Image.FromFile(name);
                return image;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ss = btnImageNhanVien.ImageLocation;
            if (NotNullTextBox())
            {
                byte[] imageArray = System.IO.File.ReadAllBytes(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Template\\image.jpeg");
                base64Image = Convert.ToBase64String(imageArray);
                string LastModified = DateTime.Now.ToString("yyyy-MM-dd");
                string TinhThanh = cbListTinhThanh.SelectedValue.ToString().Trim();
                string PhongBan = cbListPhongBan.SelectedValue.ToString().Trim();
                string ChucVu = cbListChucVu.SelectedValue.ToString().Trim();
               
                int result = HoSoNhanVienDAO.Instance.UpdateInfoNhanVien(Convert.ToInt32(txtMaNV.Text), txtTenNV.Text, DateTime.Parse(txtNgaySinh.Text), txtGioiTinh.Text, txtDiaChi.Text, txtEmail.Text, txtSoDienThoai.Text, txtCmnd.Text, DateTime.Parse(txtNgayCap.Text), TinhThanh, txtDanToc.Text, PhongBan, ChucVu, Convert.ToSingle(txtMaBacLuong.Text), txtTinhTrangLamViec.Text, txtSoBHXH.Text, txtSoBHYT.Text, txtTaiKhoanNH.Text, LastModified, Account.UserName, base64Image);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Thông tin nhân viên không chính xác");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
        }
        private bool NotNullTextBox()
        {
            bool ressult = true;
            if (txtTenNV.Text == null && string.IsNullOrWhiteSpace(txtTenNV.Text))
                return ressult = false;
            if (txtMaNV.Text == null && string.IsNullOrWhiteSpace(txtMaNV.Text))
                return ressult = false;
            if (txtNgaySinh.Text == null && string.IsNullOrWhiteSpace(txtNgaySinh.Text))
                return ressult = false;
            if (txtGioiTinh.Text == null && string.IsNullOrWhiteSpace(txtGioiTinh.Text))
                return ressult = false;
            if (txtHonNhan.Text == null && string.IsNullOrWhiteSpace(txtHonNhan.Text))
                return ressult = false;
            if (txtSoDienThoai.Text == null && string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
                return ressult = false;
            if (txtEmail.Text == null && string.IsNullOrWhiteSpace(txtEmail.Text))
                return ressult = false;
            if (txtDanToc.Text == null && string.IsNullOrWhiteSpace(txtDanToc.Text))
                return ressult = false;
            if (txtCmnd.Text == null && string.IsNullOrWhiteSpace(txtCmnd.Text))
                return ressult = false;
            if (txtNgayCap.Text == null && string.IsNullOrWhiteSpace(txtNgayCap.Text))
                return ressult = false;
            if (txtDiaChi.Text == null && string.IsNullOrWhiteSpace(txtDiaChi.Text))
                return ressult = false;

            return ressult;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void btnDeleteNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
