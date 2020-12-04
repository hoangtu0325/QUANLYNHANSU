using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DTO
{
    class NhanVien
    {
        public NhanVien(string TenNV, string CMND, DateTime NgayCap, int MaTinhThanh, DateTime NgaySinh, bool GioiTinh, string DiaChi, string EMail)
        {

        }

        private int maNV;
        private string tenNV;
        private string cmnd;
        private DateTime ngayCap;
        private string tenTinhThanh;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string diaChi;
        private string email;
        private string sdt;
        private string tenChucVu;
        private int thamNien;
        private float heSoLuong;
        private string tinhTrangLamViec;
        private string hinhAnh;
        private string soBHXH;
        private string soBHYT;
        private string taiKhoanNH;
        private string tenPhongBan;
        private string danToc;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;

        public int Manv { get => maNV; set => maNV = value; }
        public string Tennv { get => tenNV; set => tenNV = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime Ngaycap { get => ngayCap; set => ngayCap = value; }
        public string Tentinhthanh { get => tenTinhThanh; set => tenTinhThanh = value; }
        public DateTime Ngaysinh { get => ngaySinh; set => ngaySinh = value; }
        public bool Gioitinh { get => gioiTinh; set => gioiTinh = value; }
        public string Diachi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Tenchucvu { get => tenChucVu; set => tenChucVu = value; }
        public float Hesoluong { get => heSoLuong; set => heSoLuong = value; }
        public int ThamNien { get => thamNien; set => thamNien = value; }
        public string TinhTrangLamViec { get => tinhTrangLamViec; set => tinhTrangLamViec = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string SoBHXH { get => soBHXH; set => soBHXH = value; }
        public string SoBHYT { get => soBHYT; set => soBHYT = value; }
        public string TaiKhoanNH { get => taiKhoanNH; set => taiKhoanNH = value; }
        public string TenPhongBan { get => tenPhongBan; set => tenPhongBan = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}
