Create table NhanVien
(
	manv varchar(10) primary key not null,
	tennv nvarchar(50)null,
	bidanh nvarchar(50)null,
	cmnd varchar(15)not null,
	ngaycap datetime not null,
	matinhthanh varchar(10) not null/*FOREIGN KEY*/ ,
	ngaysinh datetime null,
	gioitinh bit null,
	diachi nvarchar(50)null,
	email nvarchar(50)null,
	sdtcty varchar(15)null,
	sdtrieng varchar(15)null,
	sdtnha varchar(15)null,
	tinhtranghonnhan nvarchar(50)null,
	phongban varchar(10)not null /*FOREIGN KEY*/,
	tophutrach varchar(10)null /*FOREIGN KEY*/,
	machucvu varchar(10) not null/*FOREIGN KEY*/,
	ngayvaolam datetime null,
	thamnien int null,
	heso float null,
	tinhtranglamviec nvarchar(20) null,
	hinhanh image null,
	hinhthuctuyen nvarchar(50) null,
	matinhoc varchar(10)null /*FOREIGN KEY*/,
	mangoaingu varchar(10)null /*FOREIGN KEY*/,
	mabangcap varchar(10)not null /*FOREIGN KEY*/,
	soBHXH varchar(20) null,
	soBHYT varchar(20) null,
	cannang int null,
	cao float null,
	nhommau varchar (2) null,
	tinhtrangsuckhoe nvarchar(20) null,
	taikhoanNH varchar(20) null
)
INSERT INTO NhanVien (manv, tennv ,bidanh,cmnd,ngaycap,matinhthanh,ngaysinh,gioitinh,diachi,email,sdtcty,sdtrieng,sdtnha,tinhtranghonnhan,phongban,tophutrach,machucvu,ngayvaolam,thamnien,heso,tinhtranglamviec,tinhtrangsuckhoe,taikhoanNH)
VALUES ('001', 'Đào Nguyên An','AN','2346247','12/10/2016','TayNinh','08/01/1994','1','TP.TayNinh','qwehqwuih@gmail.com','1238712','1234124','3567434','Doc Than','KinhDoanh','1','NV','1/1/1998','2','01','danglam','Tot','123124');
INSERT INTO NhanVien (manv, tennv ,bidanh,cmnd,ngaycap,matinhthanh,ngaysinh,gioitinh,diachi,email,sdtcty,sdtrieng,sdtnha,tinhtranghonnhan,phongban,tophutrach,machucvu,ngayvaolam,thamnien,heso,tinhtranglamviec,tinhtrangsuckhoe,taikhoanNH)
VALUES ('002', 'Đào Nguyên An Thu','AN','2346247','12/10/2016','TayNinh','08/01/1994','1','TP.TayNinh','qwehqwuih@gmail.com','1238712','1234124','3567434','Doc Than','KinhDoanh','1','NV','1/1/1998','2','01','danglam','Tot','123124');
INSERT INTO NhanVien (manv, tennv ,bidanh,cmnd,ngaycap,matinhthanh,ngaysinh,gioitinh,diachi,email,sdtcty,sdtrieng,sdtnha,tinhtranghonnhan,phongban,tophutrach,machucvu,ngayvaolam,thamnien,heso,tinhtranglamviec,tinhtrangsuckhoe,taikhoanNH)
VALUES ('003', 'Đào Nguyên Binh','AN','2346247','12/10/2016','TayNinh','08/01/1994','1','TP.TayNinh','qwehqwuih@gmail.com','1238712','1234124','3567434','Doc Than','KinhDoanh','1','NV','1/1/1998','2','01','danglam','Tot','123124');





Create table TinHoc
(	
	matinhoc varchar(10) primary key not null,
	tentinhoc nvarchar(50)null
)
INSERT INTO TinHoc(matinhoc,tentinhoc)
VALUES ('001','Tin Hoc A')
INSERT INTO TinHoc(matinhoc,tentinhoc)
VALUES ('002','Tin Hoc B')
Create table NgoaiNgu
(
	mangoaingu varchar(10) primary key not null,
	tenngoaingu nvarchar(50)null
)
INSERT INTO NgoaiNgu(mangoaingu,tenngoaingu)
VALUES ('001','Ngoai Ngu A')
INSERT INTO NgoaiNgu(mangoaingu,tenngoaingu)
VALUES ('002','Ngoai Ngu B')
Create table BangCap
(	
	mabangcap varchar(10) primary key not null,
	tenbangcap nvarchar(50) null,
	ngayratruong datetime null
)
INSERT INTO BangCap(mabangcap,tenbangcap,ngayratruong)
VALUES ('001','Cao Dang','1/1/2020')
INSERT INTO BangCap(mabangcap,tenbangcap,ngayratruong)
VALUES ('002','Cao Dang','1/1/2019')
Create table QuaTrinhLapViec
(
	maquatrinh varchar(10) primary key not null,
	tenquatrinh nvarchar(50) null,
	manv varchar(10)not null /*FOREIGN KEY*/,
	macongviec varchar(10)not null /*FOREIGN KEY*/,
	ngaybatdau datetime null,
	ngayketthuc datetime null,
	madiadiem varchar(10)not null /*FOREIGN KEY*/,
	ghichu nvarchar(100) null
)
INSERT INTO QuaTrinhLapViec(maquatrinh,tenquatrinh,macongviec,ngaybatdau,ngayketthuc,madiadiem,ghichu)
VALUES ('001','ABC','01','1/1/2019','1.2.2019','A','asdasdas')
INSERT INTO QuaTrinhLapViec(maquatrinh,tenquatrinh,macongviec,ngaybatdau,ngayketthuc,madiadiem,ghichu)
VALUES ('002','ABSDC','02','1/1/2019','1.2.2019','A','asdasdas')
Create table DiaDiem
(
	madiadiem varchar(10) primary key,
	tendiadiem nvarchar(50)null
)
INSERT INTO DiaDiem(madiadiem,tendiadiem)
VALUES ('001','TPHCM')
INSERT INTO DiaDiem(madiadiem,tendiadiem)
VALUES ('002','TPHCM')
Create table QuaTrinhBoiDuong
(	
	maboiduong varchar(10) primary key not null,
	tenboiduong nvarchar(50)null,
	manv varchar(10) not null/*FOREIGN KEY*/,
	masoquyetdinh varchar(10)not null /*FOREIGN KEY*/,
	ngaybatdau datetime null,
	ngayketthuc datetime null, 
	chuyennghanh nvarchar(50)not null,
	madiadiem varchar(10)not null /*FOREIGN KEY*/,
	ghichu nvarchar(100)null
)
INSERT INTO QuaTrinhBoiDuong(maboiduong,tenboiduong,manv,masoquyetdinh,ngaybatdau,ngayketthuc,chuyennghanh,madiadiem,ghichu)
VALUES ('001','Benh','01','123','1/1/2019','2/1/2019','LapTrinh','TPHCM','asdasdqweqwedasdas')
INSERT INTO QuaTrinhBoiDuong(maboiduong,tenboiduong,manv,masoquyetdinh,ngaybatdau,ngayketthuc,chuyennghanh,madiadiem,ghichu)
VALUES ('002','Benh','01','123','1/1/2019','2/1/2019','LapTrinh','TPHCM','asdasdqweqwedasdas')
Create table SoQuyetDinh
(
	masoquyetdinh varchar(10) primary key not null,
	loaiquyetdinh nvarchar(50)null,
	ngayquyetdinh datetime null,
	noidung nvarchar(50)null,
	nguoiquyetdinh varchar(10)not null,
	ghichu nvarchar(100)null
)
INSERT INTO SoQuyetDinh(masoquyetdinh,loaiquyetdinh,ngayquyetdinh,noidung,nguoiquyetdinh,ghichu)
VALUES ('001','ABC','1/1/2019','asdasdsadsa','An','asdasdasqweqwewq awds')
INSERT INTO SoQuyetDinh(masoquyetdinh,loaiquyetdinh,ngayquyetdinh,noidung,nguoiquyetdinh,ghichu)
VALUES ('002','ABC','1/1/2019','asdasdsadsa','An','asdasdasqweqwewq awds')
Create table CongViec
(
	macongviec varchar(10) primary key not null,
	tencongviec nvarchar(50)null,
	mota nvarchar(100)null
)
INSERT INTO CongViec(macongviec,tencongviec,mota)
VALUES ('01','IT','ACBVVD')
INSERT INTO CongViec(macongviec,tencongviec,mota)
VALUES ('02','IT','ACBVVD')
Create table ChucVu
(	
	machucvu varchar(10) primary key not null,
	tenchucvu nvarchar(50)null,
	macongviec varchar(10)not null /*FOREIGN KEY*/,
	hesophucap float null,
	ghichu nvarchar(100)null
)
INSERT INTO ChucVu(machucvu,tenchucvu,macongviec,hesophucap,ghichu)
VALUES ('001','Truong Phong','ACD','121','asdqweqwrv qwdqwc qwe')
INSERT INTO ChucVu(machucvu,tenchucvu,macongviec,hesophucap,ghichu)
VALUES ('002','Truong Phong','ACD','121','asdqweqwrv qwdqwc qwe')
Create table NghiViec
(
	manghiviec varchar(10) primary key not null,
	masoquyetdinh varchar(10)not null/*FOREIGN KEY*/,
	manv varchar(10) not null/*FOREIGN KEY*/,
	ngayquyetdinh datetime null,
	ngayhieuluc datetime null,
	lydo nvarchar(50) null,
	tienboithuong float null,
	tienkhac float null,
	lydotienkhac nvarchar(50) null,
	ghichu nvarchar(100)null

)
INSERT INTO NghiViec(manghiviec,masoquyetdinh,manv,ngayquyetdinh,ngayhieuluc,lydo,tienboithuong,tienkhac,lydotienkhac,ghichu)
VALUES ('001','123','ACD','1/1/2019','1/2/2019','asdasfasfdas','100000','123123123','qweqweqwewqead','asdasweqwe weqweq')
INSERT INTO NghiViec(manghiviec,masoquyetdinh,manv,ngayquyetdinh,ngayhieuluc,lydo,tienboithuong,tienkhac,lydotienkhac,ghichu)
VALUES ('002','123','ACD','1/1/2019','1/2/2019','asdasfasfdas','100000','123123123','qweqweqwewqead','asdasweqwe weqweq')
Create table NghiDaiHan
(
	manghiviec varchar(10) primary key not null,
	mosoquyetdinh varchar(10) not null/*FOREIGN KEY*/,
	manv varchar(10) not null/*FOREIGN KEY*/,
	ngaybatdau datetime null,
	ngayketthuc datetime null,
	lydonghi nvarchar(50) null,
	ghichu nvarchar(100)null
)
INSERT INTO NghiDaiHan(manghiviec,mosoquyetdinh,manv,ngaybatdau,ngayketthuc,lydonghi,ghichu)
VALUES ('001','212','12112','1/1/2019','2/1/2019','asdasdasd','asdasdasd')
Create table ChuyenNhanVien
(
	machuyennv varchar(10) primary key not null,
	manv varchar(10) not null/*FOREIGN KEY*/,
	mosoquyetdinh varchar(10)not null/*FOREIGN KEY*/,
	ngaychuyen datetime null,
	tronghayngoai datetime null,
	madiadiem varchar(10) null/*FOREIGN KEY*/,
	maphongmoi varchar(10)null/*FOREIGN KEY*/,
	ghichu nvarchar(100)null 
)
INSERT INTO ChuyenNhanVien(machuyennv,manv,mosoquyetdinh,ngaychuyen,tronghayngoai,madiadiem,maphongmoi,ghichu)
VALUES ('001','212','12112','1/1/2019','2/1/2019','asdasdasd','asdasdasd','asdasdasfasfas')
Create table HopDong
(
	mahopdong varchar(10) primary key not null,
	manv varchar(10) not null/*FOREIGN KEY*/,
	ngaybatdau datetime null,
	ngayketthuc datetime null,
	lanky int null,
	noidung nvarchar(50) null,
	ngayky datetime null,
	manguoiky varchar(10) not null/*FOREIGN KEY*/,
	ghichu nvarchar(100)null
)
INSERT INTO HopDong(mahopdong,manv,ngaybatdau,ngayketthuc,lanky,noidung,ngayky,manguoiky,ghichu)
VALUES ('001','212','1/1/2019','1/2/2019','1','asdasdasd',16/1/2019,'AC','')
Create table KyLuatPhat
(
	makyluat varchar(10) primary key not null,
	masoquyetdinh varchar(10)not null/*FOREIGN KEY*/,
	manv varchar(10)not null,
	lydo nvarchar(50)null,
	hinhthuc nvarchar(50)null,
	ngaykyluat datetime null,
	ghichu nvarchar(100)null
)
INSERT INTO KyLuatPhat(makyluat,masoquyetdinh,manv,lydo,hinhthuc,ngaykyluat,ghichu)
VALUES ('001','212','12112','','','1/1/2019','')
INSERT INTO KyLuatPhat(makyluat,masoquyetdinh,manv,lydo,hinhthuc,ngaykyluat,ghichu)
VALUES ('002','212','12112','','','1/1/2019','')
