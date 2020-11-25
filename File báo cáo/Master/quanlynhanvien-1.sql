create database QuanLyNhanSu
go
Create table NhanVien
(
	MaNV varchar(10) primary key not null,
	TenNV nvarchar(50)null,
	BiDanh nvarchar(50)null,
	Cmnd varchar(15)not null,
	NgayCap datetime not null,
	MaTinhThanh varchar(10) not null/*FOREIGN KEY*/ ,
	NgaySinh datetime null,
	GioiTinh bit null,
	DiaChi nvarchar(50)null,
	Email nvarchar(50)null,
	SdtCty varchar(15)null,
	SdtRieng varchar(15)null,
	SdtNha varchar(15)null,
	TinhTrangHonNhan nvarchar(50)null,
	PhongBan varchar(10)not null /*FOREIGN KEY*/,
	ToPhuTrach varchar(10)null /*FOREIGN KEY*/,
	MaChucVu varchar(10) not null/*FOREIGN KEY*/,
	NgayVaoLam datetime null,
	ThamNien int null,
	HeSo float null,
	TinhTrangLamViec nvarchar(20) null,
	HinhAnh image null,
	HinhThucTuyen nvarchar(50) null,
	MaTinHoc varchar(10)null /*FOREIGN KEY*/,
	MaNgoaiNgu varchar(10)null /*FOREIGN KEY*/,
	MaBangCap varchar(10)not null /*FOREIGN KEY*/,
	SoBHXH varchar(20) null,
	SoBHYT varchar(20) null,
	CanNang int null,
	Cao float null,
	NhomMau varchar (2) null,
	TinhTrangSucKhoe nvarchar(20) null,
	TaikhoanNH varchar(20) null
)
go




Create table TinHoc
(	
	MaTinHoc varchar(10) primary key not null,
	TenTinHoc nvarchar(50)null
)
go
Create table NgoaiNgu
(
	MaNgoaiNgu varchar(10) primary key not null,
	TenNgoaiNgu nvarchar(50)null
)

Create table BangCap
(	
	MaBangCap varchar(10) primary key not null,
	TenBangCap nvarchar(50) null,
	NgayRaTruong datetime null
)
go
Create table QuaTrinhLapViec
(
	MaQuaTrinh varchar(10) primary key not null,
	TenQuaTrinh nvarchar(50) null,
	MaNV varchar(10) not null /*FOREIGN KEY*/,
	MaCongViec varchar(10)not null /*FOREIGN KEY*/,
	NgayBatDau datetime null,
	NgayKetThuc datetime null,
	MaDiaDiem varchar(10)not null /*FOREIGN KEY*/,
	GhiChu nvarchar(100) null
)
go
Create table DiaDiem
(
	MaDiaDiem varchar(10) primary key,
	TenDiaDiem nvarchar(50)null
)
go
Create table QuaTrinhBoiDuong
(	
	MaBoiDuong varchar(10) primary key not null,
	TenBoiDuong nvarchar(50)null,
	MaNV varchar(10) not null/*FOREIGN KEY*/,
	MaSoQuyetDinh varchar(10)not null /*FOREIGN KEY*/,
	NgayBatDau datetime null,
	NgayKetThuc datetime null, 
	ChuyenNghanh nvarchar(50)not null,
	MaDiaDiem varchar(10)not null /*FOREIGN KEY*/,
	GhiChu nvarchar(100)null
)
go
Create table SoQuyetDinh
(
	MaSoQuyetDinh varchar(10) primary key not null,
	LoaiQuyetDinh nvarchar(50)null,
	NgayQuyetDinh datetime null,
	NoiDung nvarchar(50)null,
	NguoiQuyetDinh varchar(10)not null,
	GhiChu nvarchar(100)null
)
go
Create table CongViec
(
	MaCongViec varchar(10) primary key not null,
	TenCongViec nvarchar(50)null,
	MoTa nvarchar(100)null
)
go
Create table ChucVu
(	
	MaChucVu varchar(10) primary key not null,
	TenChucVu nvarchar(50)null,
	MaCongViec varchar(10)not null /*FOREIGN KEY*/,
	HeSophucap float null,
	GhiChu nvarchar(100)null
)
go	
Create table NghiViec
(
	MaNghiViec varchar(10) primary key not null,
	MaSoQuyetDinh varchar(10)not null/*FOREIGN KEY*/,
	MaNV varchar(10) not null/*FOREIGN KEY*/,
	NgayQuyetDinh datetime null,
	NgayHieuLuc datetime null,
	LyDo nvarchar(50) null,
	TienBoiThuong float null,
	TienKhac float null,
	LyDoTienKhac nvarchar(50) null,
	GhiChu nvarchar(100)null

)
go
Create table NghiDaiHan
(
	MaNghiViec varchar(10) primary key not null,
	MaSoQuyetDinh varchar(10) not null/*FOREIGN KEY*/,
	MaNV varchar(10) not null/*FOREIGN KEY*/,
	NgayBatDau datetime null,
	NgayKetThuc datetime null,
	LyDonghi nvarchar(50) null,
	GhiChu nvarchar(100)null
)
go
Create table ChuyenNhanVien
(
	MaChuyenNV varchar(10) primary key not null,
	MaNV varchar(10) not null/*FOREIGN KEY*/,
	MaSoQuyetDinh varchar(10)not null/*FOREIGN KEY*/,
	NgayChuyen datetime null,
	TrongHayNgoai datetime null,
	MaDiaDiem varchar(10) null/*FOREIGN KEY*/,
	MaPhongMoi varchar(10)null/*FOREIGN KEY*/,
	GhiChu nvarchar(100)null 
)
go
Create table HopDong
(
	MaHopDong varchar(10) primary key not null,
	MaNV varchar(10) not null/*FOREIGN KEY*/,
	NgayBatDau datetime null,
	NgayKetThuc datetime null,
	LanKy int null,
	NoiDung nvarchar(50) null,
	NgayKy datetime null,
	MaNguoiKy varchar(10) not null/*FOREIGN KEY*/,
	GhiChu nvarchar(100)null
)
go
Create table KyLuatPhat
(
	MaKyLuat varchar(10) primary key not null,
	MaSoQuyetDinh varchar(10)not null/*FOREIGN KEY*/,
	MaNV varchar(10)not null,
	LyDo nvarchar(50)null,
	HinhThuc nvarchar(50)null,
	NgayKyluat datetime null,
	GhiChu nvarchar(100)null
)
go
Create table KhenThuong
(
	MaKhenThuong varchar(10) primary key not null,
	MaSoQuyetDinh varchar(10)not null/*FOREIGN KEY*/,
	MaNV varchar(10)null,
	LyDo nvarchar(50)null,
	HinhThuc nvarchar(50)null,
	NgayKhen datetime null,
	GhiChu nvarchar(100)null,
)
go
Create table DotDaoTao
(
	MaDaoTao varchar(10) primary key not null,
	Ten varchar(10)null,
	MaSoQuyetDinh varchar(10)not null/*FOREIGN KEY*/,
	NgayBatDau datetime null,
	NgayKetThuc datetime null,
	MaDiaDiem varchar(10) not null/*FOREIGN KEY*/,
	NganhDaoTao nvarchar(50) null,
	ChuyenNganh nvarchar(50) null,
	HinhThuc nvarchar(50) null,
)
go
Create table BangChamCong
(
	MaChamCong varchar(10) primary key not null,
	ThangChamCong datetime null,
	MaNV varchar(10) not null/*FOREIGN KEY*/,
	Ngay1 varchar(2)null,
	Ngay2 varchar(2)null,
	Ngay3 varchar(2)null,
	Ngay4 varchar(2)null,
	Ngay5 varchar(2)null,
	Ngay6 varchar(2)null,
	Ngay7 varchar(2)null,
	Ngay8 varchar(2)null,
	Ngay9 varchar(2)null,
	Ngay10 varchar(2)null,
	Ngay11 varchar(2)null,
 	Ngay12 varchar(2)null,
	Ngay13 varchar(2)null,
	Ngay14 varchar(2)null,
	Ngay15 varchar(2)null,
	Ngay16 varchar(2)null,
	Ngay17 varchar(2)null,
	Ngay18 varchar(2)null,
	Ngay19 varchar(2)null,
	Ngay20 varchar(2)null,
	Ngay21 varchar(2)null,
	Ngay22 varchar(2)null,
	Ngay23 varchar(2)null,
	Ngay24 varchar(2)null,
	Ngay25 varchar(2)null,
	Ngay26 varchar(2)null,
	Ngay27 varchar(2)null,
	Ngay28 varchar(2)null,
	Ngay29 varchar(2)null,
	Ngay30 varchar(2)null,
	Ngay31 varchar(2)null,
	TongSoNgay int,
	NgayDiLam int null,
	Vang int null,

)
Create table BangChiLuongDot1
(	
	MaLuong varchar(10) primary key not null,
	ThangChi datetime null,
	MaNV varchar(10) not null/*FOREIGN KEY*/,
	LuongThang float null,
	NhanDot1 float null,
	GhiChu varchar(100),
)
Create table BangChiLuong
(
	MaLuong varchar(10) primary key not null,
	ThangChi datetime null,
	MaNV varchar(10)not null/*FOREIGN KEY*/,
	Ngaylamviec float null,
	LuongThang float null,
	TruLuong float null,
	PhuCapChucVu float null,
	PhuCapDocHai float null,
	TroCapTrachNhiem float null,
	TroCapAnTrua float null,
	TroCapXaNha float null,
	TroCapQLDN float null,
	TongLuong float null,
	BHXH float null,
	BHYT float null,
	DoanPhi float null,
	ThucLanh float null,
)
Create table ThanNhan
(
	MaThanNhan varchar(10) primary key not null,
	TenThanNhan nvarchar(50) null,
	MaNV varchar(10) not null /*FOREIGN KEY*/,
	QuanHe nvarchar(10) null,
	TrongHayNgoai bit null,
	MaQuocGia varchar(10) null /*FOREIGN KEY*/,
	GhiChu nvarchar(100) null,
)
Create table QuocGia
(
	MaQuocGia varchar(10)primary key not null,
	Tenquocgia nvarchar(50)null,
)
Create table UngVien
(
	MaUngVien varchar(10) primary key not null,
	TenUngVien nvarchar(50)null,
	Cmnd varchar(9) null,
	NgayCapCmnd datetime null,
	MaTinhThanh varchar(10) null,
	NgaySinh datetime null,
	GioiTinh bit null,
	DiaChi nvarchar(50) null,
	Email nvarchar(50) null,
	SdtRieng varchar(20) null,
	SdtNha varchar(20) null,
	TinhTrangHonNhan bit,
	MaDanToc varchar(10) null /*FOREIGN KEY*/,
	MaTonGiao varchar(10) null /*FOREIGN KEY*/, 
	MaBangCap varchar(10) null /*FOREIGN KEY*/,
	MaNgoaiNgu varchar(10) null /*FOREIGN KEY*/,
	MaTinHoc varchar(10) null /*FOREIGN KEY*/,
	NamKinhNghiem int null,
	NgayNopHoSo datetime null,
	TrangThai nvarchar(20) null,
	MaDotPhongVan varchar(10) null /*FOREIGN KEY*/,
	HinhAnh image null,
	GhiChu nvarchar(100) null,
)
Create table TonGiao
(
	MaTonGiao varchar(10) primary key not null,
	TenTonGiao nvarchar(50) null,
)

Create table DanToc
(
	MaDanToc varchar(10) primary key not null,
	TenDanToc nvarchar(50) null,
)

Create table DotTuyenDung
(
	MaDotTuyenDung varchar(10) primary key not null,
	Ten nvarchar(50) null,
	MaSoQuyetDinh varchar(10) not null/*FOREIGN KEY*/,
	MaPhongBan varchar(10) not null/*FOREIGN KEY*/,
	MaNguoiPhuTrach varchar(10) not null/*FOREIGN KEY*/,
	MaBangCap varchar(10) not null /*FOREIGN KEY*/,
	CapBac varchar(10)not null/*FOREIGN KEY*/,
	DoTuoi int null,
	GioiTinh int null,
	SoLuong int null,
	TrangThai nvarchar(20) null,
	GhiChu nvarchar(100) null,
)
Create table DotPhongVan
(
	MaDotPhongVan varchar(10) primary key not null,
	Ten nvarchar(50) null,
	MaDotTuyenDung varchar(10) not null /*FOREIGN KEY*/,
	MaNguoiPhongVan varchar(10)not null/*FOREIGN KEY*/,
	NgayBatDau datetime null,
	NgayKetThuc datetime null,
	ChuDe nvarchar(100)null,
	MaDiaDiem varchar(10) not null/*FOREIGN KEY*/,
	TinhTrang nvarchar(20) null,
	GhiChu nvarchar(100) null,
)

Create table ToLamViec
(
	MaTo varchar(10) primary key not null,
	Tento nvarchar(50) null,
	MaTotruong varchar(10) not null/*FOREIGN KEY*/,
	MaPhongBan varchar(10) not null/*FOREIGN KEY*/,
	GhiChu nvarchar(100)null,
)

Create table PhongBan
(
	MaPhongBan varchar(10) primary key not null,
	Ten nvarchar(50)null,
	MaTruongPhong varchar(10)not null/*FOREIGN KEY*/,
	NgayNhamChuc datetime null,
	GhiChu nvarchar(100) null,
)

Create table NguoiDung
(
	UserName varchar(30) primary key not null,
	Password varchar(20) not null /*FOREIGN KEY*/,
	GhiChu nvarchar(200) not null,
)
INSERT INTO NguoiDung(UserName,Password,GhiChu) 		VALUES('001','002','1/1/2014')

INSERT INTO PhongBan(MaPhongBan,Ten,MaTruongPhong,NgayNhamChuc,GhiChu) 		VALUES('001','002','1/1/2014','','')
	
--INSERT INTO Tolamviec(MaTo,Tento,MaTotruong,MaPhongBan,GhiChu) VALUES('','','','1/1/2014')



INSERT INTO DotPhongVan(MaDotPhongVan,Ten,MaDotTuyenDung,MaNguoiPhongVan,NgayBatDau,NgayKetThuc,ChuDe,MaDiaDiem,TinhTrang,GhiChu)
VALUES ('','','1/1/2014','','001')

INSERT INTO DotTuyenDung(MaDotTuyenDung,Ten,MaSoQuyetDinh,MaPhongBan,MaNguoiPhuTrach,MaBangCap,CapBac,DoTuoi,GioiTinh,SoLuong,TrangThai,GhiChu)
VALUES ('001','002','020','1/1/2014')

INSERT INTO UngVien(MaUngVien,TenUngVien,Cmnd,NgayCapCmnd,MaTinhThanh,NgaySinh,GioiTinh,DiaChi,Email,SdtRieng,SdtNha,TinhTrangHonNhan,MaDanToc,MaTonGiao,MaBangCap,
MaNgoaiNgu,MaTinHoc,NamKinhNghiem,NgayNopHoSo,TrangThai,MaDotPhongVan,HinhAnh,GhiChu) VALUES('001','002','002',000,'',1/1/2014)
INSERT INTO DotDaoTao(MaDaoTao,Ten,MaSoQuyetDinh,NgayBatDau,NgayKetThuc,MaDiaDiem,NganhDaoTao,ChuyenNganh,HinhThuc) VALUES('001','002','','','1/1/2014')
INSERT INTO DotDaoTao(MaDaoTao,Ten,MaSoQuyetDinh,NgayBatDau,NgayKetThuc,MaDiaDiem,NganhDaoTao,ChuyenNganh,HinhThuc) VALUES('001','002','','','1/1/2014')



INSERT INTO DanToc(MaDanToc,TenDanToc) VALUES ('001','Kinh')	
INSERT INTO TonGiao(MaTonGiao,TenTonGiao) VALUES('001', N'Không')
INSERT INTO TonGiao(MaTonGiao,TenTonGiao) VALUES('002',N'Phật Giáo') 
INSERT INTO TonGiao(MaTonGiao,TenTonGiao) VALUES('003',N'Thiên Chúa Giáo') 
INSERT INTO QuocGia(MaQuocGia,Tenquocgia) VALUES('001', N'Việt Nam')
INSERT INTO ThanNhan(MaThanNhan,TenThanNhan,MaNV,QuanHe,TrongHayNgoai,MaQuocGia,GhiChu) VALUES('001','Nguyễn Thái Thịnh','001','Cha',1,'001','')
INSERT INTO ThanNhan(MaThanNhan,TenThanNhan,MaNV,QuanHe,TrongHayNgoai,MaQuocGia,GhiChu) VALUES('002','Phạm Thị Ngọc','001','Mẹ',1,'001','')
GO

INSERT INTO BangChiLuong(MaLuong,ThangChi,MaNV,Ngaylamviec,LuongThang,TruLuong,PhuCapChucVu,PhuCapDocHai,TroCapTrachNhiem,TroCapAnTrua,TroCapXaNha,TroCapQLDN,
BHXH,BHYT,DoanPhi)  VALUES('001',1,'001','','7000000','','500000','','','200000','','','50000','50000', '50000')
INSERT INTO BangChiLuongDot1(MaLuong,ThangChi,MaNV,LuongThang,NhanDot1,GhiChu) VALUES('001',1,'001','700000','1','')
go

INSERT INTO KhenThuong(MaKhenThuong,MaSoQuyetDinh,MaNV,LyDo,HinhThuc,NgayKhen,GhiChu) VALUES ('001','QDKT01','001',N'Hoàn thành xuất sắc nhiệm vụ',N'Thưởng tiền',31/12/2019,'')
go

INSERT INTO NhanVien (MaNV, TenNV ,BiDanh,Cmnd,NgayCap,MaTinhThanh,NgaySinh,GioiTinh,DiaChi,Email,SdtCty,SdtRieng,SdtNha,TinhTrangHonNhan,PhongBan,ToPhuTrach,MaChucVu,NgayVaoLam,ThamNien,HeSo,TinhTrangLamViec,TinhTrangSucKhoe,TaikhoanNH)
VALUES ('001', N'Trịnh Thị Đào', N'Đào','2346247','12/10/2016','001','08/01/1994','0', N' 33 Trương Công Định, Phường 14, Tân Bình, Thành phố Hồ Chí Minh, Việt Nam','thidao@gmail.com','','0865.528.179','', N'Độc thân',N'Kinh Doanh','001','001','15/01/2005','','01',N'Đang làm',N'Tốt','123124');
INSERT INTO NhanVien (MaNV, TenNV ,BiDanh,Cmnd,NgayCap,MaTinhThanh,NgaySinh,GioiTinh,DiaChi,Email,SdtCty,SdtRieng,SdtNha,TinhTrangHonNhan,PhongBan,ToPhuTrach,MaChucVu,NgayVaoLam,ThamNien,HeSo,TinhTrangLamViec,TinhTrangSucKhoe,TaikhoanNH)
VALUES ('002', N'Nguyễn Thái Bình', N'Bình','2346248','22/11/2014','002','24/05/1995','1',N'Ấp Bắc, Phường 10, Thành phố Mỹ Tho, Tiền Giang, Việt Nam','thaibinh@gmail.com','','0976.58.57.50','', N'Có gia đình',N'Kinh Doanh','001','001','01/05/2010','','01',N'Đang làm',N'Tốt','123124');
INSERT INTO NhanVien (MaNV, TenNV ,BiDanh,Cmnd,NgayCap,MaTinhThanh,NgaySinh,GioiTinh,DiaChi,Email,SdtCty,SdtRieng,SdtNha,TinhTrangHonNhan,PhongBan,ToPhuTrach,MaChucVu,NgayVaoLam,ThamNien,HeSo,TinhTrangLamViec,TinhTrangSucKhoe,TaikhoanNH)
VALUES ('003', N'Nguyễn Văn Khiêm', N'Khiêm','2346249','15/5/2015','003','21/06/1990','1', N'14 Nguyễn Thị Nhỏ, Phường 4, Tân An, Long An, Việt Nam','vankhiem@gmail.com','','0862.733.234','', N'Độc thân',N'Kinh Doanh','001','001','24/10/2014','','01',N'Đang làm',N'Tốt','123124');



INSERT INTO TinHoc(MaTinHoc,TenTinHoc)
VALUES ('001',N'Tin Học A')
INSERT INTO TinHoc(MaTinHoc,TenTinHoc)
VALUES ('002',N'Tin Học B')

INSERT INTO NgoaiNgu(MaNgoaiNgu,TenNgoaiNgu)
VALUES ('001',N'Ngoại Ngữ A')
INSERT INTO NgoaiNgu(MaNgoaiNgu,TenNgoaiNgu)
VALUES ('002','Ngoại Ngữ B')


INSERT INTO BangCap(MaBangCap,TenBangCap,NgayRaTruong)
VALUES ('001',N'Cao Đẳng','1/1/2020')
INSERT INTO BangCap(MaBangCap,TenBangCap,NgayRaTruong)
VALUES ('002',N'Cao Đẳng','1/1/2019')


INSERT INTO QuaTrinhLapViec(MaQuaTrinh,TenQuaTrinh,MaCongViec,NgayBatDau,NgayKetThuc,MaDiaDiem,GhiChu)
VALUES ('001',N'Bắt đầu làm','01',1/1/2019,1/2/2019,'001','')
INSERT INTO QuaTrinhLapViec(MaQuaTrinh,TenQuaTrinh,MaCongViec,NgayBatDau,NgayKetThuc,MaDiaDiem,GhiChu)
VALUES ('002',N'Bắt đầu làm','02',1/1/2019,1/2/2019,'001','')

INSERT INTO DiaDiem(MaDiaDiem,TenDiaDiem)
VALUES ('001',N'TP Hồ Chí Minh')
INSERT INTO DiaDiem(MaDiaDiem,TenDiaDiem)
VALUES ('002',N'TP Hà Nội')

INSERT INTO QuaTrinhBoiDuong(MaBoiDuong,TenBoiDuong,MaNV,MaSoQuyetDinh,NgayBatDau,NgayKetThuc,ChuyenNghanh,MaDiaDiem,GhiChu)
VALUES ('001',N'Bồi dưỡng nâng cấp hệ thống','001','001',1/1/2019,2/1/2019,N'Lập trình hệ thống','001','')
INSERT INTO QuaTrinhBoiDuong(MaBoiDuong,TenBoiDuong,MaNV,MaSoQuyetDinh,NgayBatDau,NgayKetThuc,ChuyenNghanh,MaDiaDiem,GhiChu)
VALUES ('002',N'Bồi dưỡng bảo trì hệ thống','001','001',1/1/2019,2/1/2019,N'Bảo mật hệ thống','002','')
go


INSERT INTO SoQuyetDinh(MaSoQuyetDinh,LoaiQuyetDinh,NgayQuyetDinh,NoiDung,NguoiQuyetDinh,GhiChu)
VALUES ('001',N'Bồi dưỡng nhân viên',1/1/2019,'',N'Giám Đốc','')
INSERT INTO SoQuyetDinh(MaSoQuyetDinh,LoaiQuyetDinh,NgayQuyetDinh,NoiDung,NguoiQuyetDinh,GhiChu)
VALUES ('002',N'Đào tạo nhân viên',1/1/2019,'',N'Giám Đốc','')

INSERT INTO CongViec(MaCongViec,TenCongViec,MoTa)
VALUES ('001',N'Bảo trì hệ thống','')
INSERT INTO CongViec(MaCongViec,TenCongViec,MoTa)
VALUES ('002',N'Chăm sóc khách hàng','')

INSERT INTO ChucVu(MaChucVu,TenChucVu,MaCongViec,HeSophucap,GhiChu)
VALUES ('001',N'Nhân viên','001','1','')
INSERT INTO ChucVu(MaChucVu,TenChucVu,MaCongViec,HeSophucap,GhiChu)
VALUES ('002',N'Trưởng phòng','002','2','')

INSERT INTO NghiViec(MaNghiViec,MaSoQuyetDinh,MaNV,NgayQuyetDinh,NgayHieuLuc,LyDo,TienBoiThuong,TienKhac,LyDoTienKhac,GhiChu)
VALUES ('001','001','001',1/1/2019,1/2/2019,'Không hợp công việc','2000000','','Không','')
INSERT INTO NghiViec(MaNghiViec,MaSoQuyetDinh,MaNV,NgayQuyetDinh,NgayHieuLuc,LyDo,TienBoiThuong,TienKhac,LyDoTienKhac,GhiChu)
VALUES ('002','002','002',1/1/2019,1/2/2019,'Áp lực công việc','1000000','','Không','')
go

INSERT INTO NghiDaiHan(MaNghiViec,MaSoQuyetDinh,MaNV,NgayBatDau,NgayKetThuc,LyDonghi,GhiChu)
VALUES ('001','212','12112','1/1/2019','2/1/2019','asdasdasd','asdasdasd')

INSERT INTO ChuyenNhanVien(MaChuyenNV,MaNV,MaSoQuyetDinh,NgayChuyen,TrongHayNgoai,MaDiaDiem,MaPhongMoi,GhiChu)
VALUES ('001','212','12112','1/1/2019','2/1/2019','asdasdasd','asdasdasd','asdasdasfasfas')

INSERT INTO HopDong(MaHopDong,MaNV,NgayBatDau,NgayKetThuc,LanKy,NoiDung,NgayKy,MaNguoiKy,GhiChu)
VALUES ('001','212','1/1/2019','1/2/2019','1','asdasdasd',16/1/2019,'AC','')


INSERT INTO KyLuatPhat(MaKyLuat,MaSoQuyetDinh,MaNV,LyDo,HinhThuc,NgayKyluat,GhiChu)
VALUES ('001','212','12112','','','1/1/2019','')
INSERT INTO KyLuatPhat(MaKyLuat,MaSoQuyetDinh,MaNV,LyDo,HinhThuc,NgayKyluat,GhiChu)
VALUES ('002','212','12112','','','1/1/2019','')