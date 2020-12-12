using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu_Master.DTO
{
    class NhanVien
    {
        public NhanVien(DataRow row)
        {
            this.MaNV = (int)row["MaNV"];
            this.TenNV = (string)row["TenNV"];
            this.Cmnd = (string)row["Cmnd"];
            this.NgayCap = ((DateTime)row["NgayCap"]).ToString("dd/MM/yyyy");
            this.TenTinhThanh = (string)row["TenTinhThanh"];
            this.NgaySinh = ((DateTime)row["NgaySinh"]).ToString("dd/MM/yyyy");
            this.GioiTinh = (string)row["GioiTinh"];
            this.DiaChi = row["DiaChi"].ToString();
            this.Email = (string)row["Email"];
            this.HinhAnh = row["HinhAnh"].ToString();
            this.Sdt = (string)row["Sdt"];
            this.TenChucVu = (string)row["TenChucVu"];
            this.MaBacLuong = float.Parse(row["MaBacLuong"].ToString());
            this.ThamNien = (int)row["ThamNien"];
            this.TinhTrangLamViec = (string)row["TinhTrangLamViec"];
            this.SoBHXH = (string)row["SoBHXH"];
            this.SoBHYT = (string)row["SoBHYT"];
            this.TaiKhoanNH = (string)row["TaiKhoanNH"];
            this.TenPhongBan = (string)row["TenPhongBan"];
            this.DanToc = (string)row["DanToc"];
            this.NgayBatDau = ((DateTime)row["NgayBatDau"]).ToString("dd/MM/yyyy");
            //this.NgayBatDau = (DateTime.Parse(row["NgayKetThuc"].ToString())).ToString("dd/MM/yyyy");
            //this.NgayKetThuc = (row["NgayKetThuc"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["NgayKetThuc"].ToString("dd/MM/yyyy")));
        }

        private int maNV;
        private string tenNV;
        private string cmnd;
        private string ngayCap;
        private string tenTinhThanh;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string email;
        private string sdt;
        private string tenChucVu;
        private int thamNien;
        private float maBacLuong;
        private string tinhTrangLamViec;
        private string hinhAnh;
        private string soBHXH;
        private string soBHYT;
        private string taiKhoanNH;
        private string tenPhongBan;
        private string danToc;
        private string ngayBatDau;
        private string ngayKetThuc;

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string NgayCap { get => ngayCap; set => ngayCap = value; }
        public string TenTinhThanh { get => tenTinhThanh; set => tenTinhThanh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi {
            get { return diaChi; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    diaChi = "";
                }
                else
                {
                    diaChi = value;
                }
            }
        }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public float MaBacLuong { get => maBacLuong; set => maBacLuong = value; }
        public int ThamNien { get => thamNien; set => thamNien = value; }
        public string TinhTrangLamViec { get => tinhTrangLamViec; set => tinhTrangLamViec = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string SoBHXH { get => soBHXH; set => soBHXH = value; }
        public string SoBHYT { get => soBHYT; set => soBHYT = value; }
        public string TaiKhoanNH { get => taiKhoanNH; set => taiKhoanNH = value; }
        public string TenPhongBan { get => tenPhongBan; set => tenPhongBan = value; }
        public string DanToc { get => danToc; set => danToc = value; }
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string NgayKetThuc
        {
            get { return ngayKetThuc; }
            set
            {
                if (value == DateTime.MinValue.ToString())
                {
                    ngayKetThuc = "";
                }
                else
                {
                    ngayKetThuc = value;
                }
            }
        }
    }
}
