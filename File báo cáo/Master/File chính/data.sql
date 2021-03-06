USE [master]
GO
/****** Object:  Database [QuanLyNhanSu]    Script Date: 30/11/2020 9:33:26 CH ******/
CREATE DATABASE QuanLyNhanSu

GO
ALTER DATABASE [QuanLyNhanSu] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhanSu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhanSu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhanSu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhanSu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhanSu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyNhanSu] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyNhanSu]
GO
/****** Object:  Table [dbo].[BangChamCong]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangChamCong](
	[MaNV] [int] NOT NULL,
	[ThangChamCong] [date] NULL,
	[Ngay1] [varchar](2) NULL,
	[Ngay2] [varchar](2) NULL,
	[Ngay3] [varchar](2) NULL,
	[Ngay4] [varchar](2) NULL,
	[Ngay5] [varchar](2) NULL,
	[Ngay6] [varchar](2) NULL,
	[Ngay7] [varchar](2) NULL,
	[Ngay8] [varchar](2) NULL,
	[Ngay9] [varchar](2) NULL,
	[Ngay10] [varchar](2) NULL,
	[Ngay11] [varchar](2) NULL,
	[Ngay12] [varchar](2) NULL,
	[Ngay13] [varchar](2) NULL,
	[Ngay14] [varchar](2) NULL,
	[Ngay15] [varchar](2) NULL,
	[Ngay16] [varchar](2) NULL,
	[Ngay17] [varchar](2) NULL,
	[Ngay18] [varchar](2) NULL,
	[Ngay19] [varchar](2) NULL,
	[Ngay20] [varchar](2) NULL,
	[Ngay21] [varchar](2) NULL,
	[Ngay22] [varchar](2) NULL,
	[Ngay23] [varchar](2) NULL,
	[Ngay24] [varchar](2) NULL,
	[Ngay25] [varchar](2) NULL,
	[Ngay26] [varchar](2) NULL,
	[Ngay27] [varchar](2) NULL,
	[Ngay28] [varchar](2) NULL,
	[Ngay29] [varchar](2) NULL,
	[Ngay30] [varchar](2) NULL,
	[Ngay31] [varchar](2) NULL,
	[TongSoNgay] [int] NULL,
	[NgayDiLam] [int] NULL,
	[Vang] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangChiLuong]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangChiLuong](
	[MaNV] [int] NOT NULL,
	[ThangChi] [date] NULL,
	[SoNgaylamviec] [float] NULL,
	[LuongThang] [float] NULL,
	[TruLuong] [float] NULL,
	[TroCapTrachNhiem] [float] NULL,
	[TongLuong] [float] NULL,
	[BHXH] [float] NULL,
	[BHYT] [float] NULL,
	[ThucLanh] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK__ChucVu__D463953310E5468A] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[UserName] [varchar](100) NOT NULL,
	[Password] [varchar](1000) NOT NULL,
	[Email] [nvarchar](200) NULL,
	[ID] [int] NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
	[CodeXacThuc] [int] NULL,
 CONSTRAINT [PK__NguoiDun__C9F28457000ED8BE] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL,
	[TenNV] [nvarchar](100) NULL,
	[Cmnd] [varchar](15) NOT NULL,
	[NgayCap] [date] NULL,
	[MaTinhThanh] [int] NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [ntext] NULL,
	[Email] [nvarchar](50) NULL,
	[Sdt] [varchar](15) NULL,
	[MaChucVu] [int] NOT NULL,
	[ThamNien] [int] NULL,
	[HeSoLuong] [nvarchar](10) NULL,
	[TinhTrangLamViec] [nvarchar](20) NULL,
	[HinhAnh] [nvarchar](50) NULL,
	[SoBHXH] [varchar](20) NULL,
	[SoBHYT] [varchar](20) NULL,
	[TaikhoanNH] [varchar](20) NULL,
	[MaPhongBan] [int] NOT NULL,
	[DanToc] [nvarchar](50) NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
 CONSTRAINT [PK__NhanVien__2725D70A71B52EDF] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [int] NOT NULL,
	[TenPhongBan] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK__PhongBan__D0910CC8362E9B85] PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhThanh]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhThanh](
	[MaTinhThanh] [int] NOT NULL,
	[TenTinhThanh] [nvarchar](50) NULL,
 CONSTRAINT [PK_TinhThanh] PRIMARY KEY CLUSTERED 
(
	[MaTinhThanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangChamCong] ([MaNV], [ThangChamCong], [Ngay1], [Ngay2], [Ngay3], [Ngay4], [Ngay5], [Ngay6], [Ngay7], [Ngay8], [Ngay9], [Ngay10], [Ngay11], [Ngay12], [Ngay13], [Ngay14], [Ngay15], [Ngay16], [Ngay17], [Ngay18], [Ngay19], [Ngay20], [Ngay21], [Ngay22], [Ngay23], [Ngay24], [Ngay25], [Ngay26], [Ngay27], [Ngay28], [Ngay29], [Ngay30], [Ngay31], [TongSoNgay], [NgayDiLam], [Vang]) VALUES (101, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[BangChiLuong] ([MaNV], [ThangChi], [SoNgaylamviec], [LuongThang], [TruLuong], [TroCapTrachNhiem], [TongLuong], [BHXH], [BHYT], [ThucLanh]) VALUES (2005001, CAST(N'1900-01-02' AS Date), 30, 8000000, NULL, NULL, 8000000, 500000, 500000, 7000000)
INSERT [dbo].[BangChiLuong] ([MaNV], [ThangChi], [SoNgaylamviec], [LuongThang], [TruLuong], [TroCapTrachNhiem], [TongLuong], [BHXH], [BHYT], [ThucLanh]) VALUES (2005002, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (101, N'Nhân viên', NULL)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (103, N'Trưởng phòng', NULL)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (104, N'Thực tập sinh', NULL)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (105, N'Giám đốc', NULL)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (106, N'Phó giám đốc', NULL)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (107, N'Thư kí', NULL)
GO
INSERT [dbo].[NguoiDung] ([UserName], [Password], [Email], [ID], [Role], [CodeXacThuc]) VALUES (N'admin', N'76xMiWBVxAw=', N'hoangtu0325@gmail.com', 1, N'Admin', 8125)
INSERT [dbo].[NguoiDung] ([UserName], [Password], [Email], [ID], [Role], [CodeXacThuc]) VALUES (N'admin1', N'xtySoDxutfM=', N'tranthai2258@gmail.com', 2, N'Admin', 4680)
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005001, N'Nguyễn Hoàng Tú', N'254124163', CAST(N'2012-11-05' AS Date), 1, CAST(N'1995-06-24' AS Date), 1, N'33 Trương Công Định, Phường 14, Tân Bình, Thành phố Hồ Chí Minh, Việt Nam', N'hoangtu325@gmail.com', N'0335604816', 105, 1, N'1', N'Đang làm', NULL, N'5194862655', N'2598658562', N'49586253', 106, N'Kinh', CAST(N'2019-01-05' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005002, N'Lê Văn Luyện', N'251198566', CAST(N'2011-02-24' AS Date), 1, CAST(N'1993-05-13' AS Date), 1, NULL, N'vanluyen@gmail.com', N'0985221451', 101, 0, N'1', N'Đang làm ', NULL, N'5468168265', N'5986258635', N'1658492825', 101, N'Kinh', CAST(N'2020-05-15' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005003, N'Dương Văn Thanh', N'256159824', CAST(N'2013-01-15' AS Date), 1, CAST(N'1996-04-26' AS Date), 0, NULL, N'vanthanh121@gmail.com', N'0332542366', 101, 0, N'1', N'Đang làm', NULL, N'4869578592', N'4968523581', N'1658947895', 101, N'Kinh', CAST(N'2020-05-25' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005004, N'Đoàn Thị Hoa', N'251685945', CAST(N'2011-08-18' AS Date), 1, CAST(N'1994-05-07' AS Date), 0, NULL, N'hoadoan232@gmail.com', N'0986532654', 101, 0, N'1', N'Đang làm', NULL, N'3562894567', N'4958615294', N'2658974872', 101, N'Kinh', CAST(N'2020-06-12' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005005, N'Lê Văn Luyện', N'251198566', CAST(N'2011-02-24' AS Date), 62, CAST(N'1993-05-13' AS Date), 1, NULL, N'vanluyen@gmail.com', N'0985221451', 105, 0, N'1', N'Đang làm ', NULL, N'5468168265', N'5986258635', N'1658492825', 101, N'Kinh', CAST(N'2020-05-15' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005007, N'Nguyễn Ngọc', N'', CAST(N'1900-01-01' AS Date), 50, CAST(N'1900-01-01' AS Date), 0, N'', N'', N'', 101, 0, N'0', N'Đã nghỉ', N'', N'', N'', N'', 103, N'Kinh', CAST(N'2020-05-15' AS Date), CAST(N'2020-10-30' AS Date))
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005008, N'Nguyễn Ngọc', N'251198566', CAST(N'2011-02-24' AS Date), 62, CAST(N'1993-05-13' AS Date), 1, NULL, N'vanluyen@gmail.com', N'0985221451', 105, 0, N'1', N'Đang làm ', NULL, N'5468168265', N'5986258635', N'1658492825', 101, N'Kinh', CAST(N'2020-05-15' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005009, N'Nguyễn Ngọc', N'', CAST(N'1900-01-01' AS Date), 50, CAST(N'1900-01-01' AS Date), 1, N'', N'', N'', 101, 0, N'1', N'Đang làm ', NULL, N'5468168265', N'5986258635', N'1658492825', 103, N'Kinh', CAST(N'2020-05-15' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005010, N'Nguyễn Ngọc', N'', CAST(N'1900-01-01' AS Date), 50, CAST(N'1900-01-01' AS Date), 1, N'', N'', N'', 101, 0, N'1', N'Đang làm', N'', N'', N'', N'', 103, N'Kinh', CAST(N'2020-11-29' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005011, N'Nguyễn Thái', N'', CAST(N'1900-01-01' AS Date), 49, CAST(N'1900-01-01' AS Date), 1, N'', N'', N'', 101, 0, N'1', N'Đang làm', N'', N'', N'', N'', 104, N'Kinh', CAST(N'2020-11-29' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005012, N'Nguyễn Thái', N'', CAST(N'1900-01-01' AS Date), 49, CAST(N'1900-01-01' AS Date), 1, N'', N'', N'', 101, NULL, N'', N'Đang làm', N'', N'', N'', N'', 104, N'Kinh', CAST(N'2020-11-30' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005013, N'Nguyễn Thái', N'', CAST(N'1900-01-01' AS Date), 62, CAST(N'1900-01-01' AS Date), 1, N'', N'', N'', 101, NULL, N'', N'Đang làm', N'', N'', N'', N'', 104, N'Kinh', CAST(N'2020-11-30' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005014, N'Nguyễn Thái', N'', CAST(N'1900-01-01' AS Date), 62, CAST(N'1900-01-01' AS Date), 1, N'', N'', N'', 101, NULL, N'', N'Đang làm', N'', N'', N'', N'', 104, N'Kinh', CAST(N'2020-11-30' AS Date), NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu], [ThamNien], [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) VALUES (2005015, N'Nguyễn Thái', N'', CAST(N'1900-01-01' AS Date), 62, CAST(N'1900-01-01' AS Date), 1, N'', N'', N'', 101, NULL, N'', N'Đang làm', N'', N'', N'', N'', 104, N'Kinh', CAST(N'2020-11-30' AS Date), NULL)
GO
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [GhiChu]) VALUES (101, N'Phòng nhân sự', NULL)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [GhiChu]) VALUES (102, N'Phòng kinh doanh', NULL)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [GhiChu]) VALUES (103, N'Phòng kết toán ', NULL)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [GhiChu]) VALUES (104, N'Phòng kĩ thuật', NULL)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [GhiChu]) VALUES (105, N'Phòng Maketing', NULL)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [GhiChu]) VALUES (106, N'Phòng Giám Đốc', NULL)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [GhiChu]) VALUES (107, N'Phòng Phó Giám Đốc', NULL)
GO
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (1, N'An Giang')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (2, N'Bà Rịa - Vũng Tàu')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (3, N'Bắc Giang')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (4, N'Bắc Kạn')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (5, N'Bạc Liêu')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (6, N'Bắc Ninh')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (7, N'Bến Tre')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (8, N'Bình Định')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (9, N'Bình Dương')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (10, N'Bình Phước')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (11, N'Bình Thuận')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (12, N'Cà Mau')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (13, N'Cao Bằng')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (14, N'Đắk Lắk')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (15, N'Đắk Nông')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (16, N'Điện Biên')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (17, N'Đồng Nai')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (18, N'Đồng Tháp')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (19, N'Gia Lai')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (20, N'Hà Giang')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (21, N'Hà Nam')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (22, N'Hà Tĩnh')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (23, N'Hải Dương')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (24, N'Hậu Giang
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (25, N'Hòa Bình
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (26, N'Hưng Yên
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (27, N'Khánh Hòa
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (28, N'Kiên Giang
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (29, N'Kon Tum
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (30, N'Lai Châu
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (31, N'Lâm Đồng
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (32, N'Lạng Sơn
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (33, N'Lào Cai
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (34, N'Long An
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (35, N'Nam Định
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (36, N'Nghệ An
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (37, N'Ninh Bình
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (38, N'Ninh Thuận
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (39, N'Phú Thọ
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (40, N'Quảng Bình
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (41, N'Quảng Nam
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (42, N'Quảng Ngãi
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (43, N'Quảng Ninh
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (44, N'Quảng Trị
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (45, N'Sóc Trăng
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (46, N'Sơn La
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (47, N'Tây Ninh
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (48, N'Thái Bình
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (49, N'Thái Nguyên
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (50, N'Thanh Hóa
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (51, N'Thừa Thiên Huế
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (52, N'Tiền Giang
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (53, N'Trà Vinh
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (54, N'Tuyên Quang
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (55, N'Vĩnh Long
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (56, N'Vĩnh Phúc
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (57, N'Yên Bái
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (58, N'Phú Yên
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (59, N'Cần Thơ
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (60, N'Đà Nẵng
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (61, N'Hải Phòng
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (62, N'Hà Nội
')
INSERT [dbo].[TinhThanh] ([MaTinhThanh], [TenTinhThanh]) VALUES (63, N'TP HCM
')
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[PhongBan] ([MaPhongBan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
/****** Object:  StoredProcedure [dbo].[SP_AddNewImployee]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_AddNewImployee]

	@TenNV nvarchar(100), @Cmnd varchar(15) = '', @NgayCap date = '', @TenTinhThanh nvarchar(50) = N'TP HCM', @NgaySinh date = '',
	@GioiTinh nvarchar(10) = N'Nam', @DiaChi ntext = '', @Email nvarchar(50) = '', @Sdt varchar(15) = '', @TenChucVu nvarchar(50) = N'Nhân viên',
	 @HeSoLuong nvarchar(10) = '', @TinhTrangLamViec nvarchar(20) = N'Đang làm', @HinhAnh nvarchar(50) = '',
	@SoBHXH varchar(20) = '', @SoBHYT varchar(20) = '', @TaiKhoanNH varchar(20) = '', @TenPhongBan nvarchar(50) = N'Phòng kĩ thuật',
	@DanToc nvarchar(50) = N'Kinh'
AS
BEGIN
	DECLARE @str1 NVARCHAR(50), @str2 nvarchar(50), @str3 varchar(15), @Date date, @str4 nvarchar(20), @str5 nvarchar(50), @str6 nvarchar(50), @str7 nvarchar(50), @str8 nvarchar(50)
	SET @Date = GETDATE()
	SET @str1=N'' + @TenNV 
	SET @str2=N'' + @Email 
	SET @str3=N'' + @Sdt 
	SET @str4=N'' + @TinhTrangLamViec
	SET @str5=N'' + @Dantoc
	SET @str6= CONCAT(N'%',@TenTinhThanh,'%')
	SET @str7= CONCAT(N'%',@TenChucVu,'%')
	SET @str8= CONCAT(N'%',@TenPhongBan,'%')
	INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [Cmnd], [NgayCap], [MaTinhThanh], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Sdt], [MaChucVu],  [HeSoLuong], [TinhTrangLamViec], [HinhAnh], [SoBHXH], [SoBHYT], [TaikhoanNH], [MaPhongBan], [DanToc], [NgayBatDau], [NgayKetThuc]) 
	VALUES ((select max(MaNV) + 1 from NhanVien), @str1 , N'' + @Cmnd, @NgayCap, (select MaTinhThanh from TinhThanh where TenTinhThanh like @str6), @NgaySinh, (CASE @GioiTinh WHEN N'Nam' THEN 1 ELSE 0 END), @DiaChi, @str2, @str3,(select MaChucVu from ChucVu where TenChucVu like @str7), @HeSoLuong,@str4, @HinhAnh, @SoBHXH,@SoBHYT, @TaiKhoanNH, (select MaPhongBan from PhongBan where TenPhongBan like @str8),@str5, @Date, NULL)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ChangePassFromUserName]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_ChangePassFromUserName]
	@userName nvarchar(100),  @passWord nvarchar(100)
as
begin
	update NguoiDung  set Password  = @passWord
	where UserName = @userName
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteImployee]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_DeleteImployee]
	@MaNV int
as 
begin 
	Delete from NhanVien
	where MaNV = @MaNV
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GetUserFromUserName]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_GetUserFromUserName]
	@userName nvarchar(100)
as
begin
	select * from NguoiDung where UserName = @userName
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Login]
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.NguoiDung WHERE UserName = @userName AND PassWord = @passWord
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateImployee]    Script Date: 30/11/2020 9:33:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_UpdateImployee]
	@MaNV int, @TenNV nvarchar(100) = '', @Cmnd varchar(15) = '', @NgayCap date = '',
	@TenTinhThanh nvarchar(50) = '', @NgaySinh date = '', @GioiTinh nvarchar(10) = '',
	@DiaChi ntext = '', @Email nvarchar(50) = '', @Sdt varchar(15) = '', @TenChucVu nvarchar(50) = N'Nhân viên', 
	@HeSoLuong float = '',@TinhTrangLamViec nvarchar(20)  = '',@HinhAnh image = '',
	@SoBHXH varchar(20) = '',  @SoBHYT varchar(20) = '',  @TaiKhoanNH varchar(20) = '',
	@TenPhongBan nvarchar(50) = N'Nhân sự', @DanToc nvarchar(50) = N'Kinh', @NgayKetThuc date = ''
AS
BEGIN

	update [dbo].[NhanVien]
	set TenNV  = @TenNV, Cmnd = @Cmnd, NgayCap = @NgayCap, 
	MaTinhThanh = (select MaTinhThanh from TinhThanh where TenTinhThanh like CONCAT(N'%',@TenTinhThanh,'%')),
	NgaySinh = @NgaySinh, GioiTinh =  (CASE @GioiTinh WHEN N'Nam' THEN 1 ELSE 0 END),
	DiaChi = @DiaChi, Email = @Email, Sdt = @Sdt, MaChucVu = (select MaChucVu from ChucVu where TenChucVu like CONCAT(N'%',@TenChucVu,'%')),
	HeSoLuong = @HeSoLuong, TinhTrangLamViec = @TinhTrangLamViec, HinhAnh = @HinhAnh, SoBHXH = @SoBHXH, SoBHYT = @SoBHYT,
	TaiKhoanNH = @TaiKhoanNH, MaPhongBan = (select MaPhongBan from PhongBan where TenPhongBan like CONCAT(N'%',@TenPhongBan,'%')),
	DanToc = @DanToc, NgayKetThuc = @NgayKetThuc
	where MaNV = @MaNV
END
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhanSu] SET  READ_WRITE 
GO
