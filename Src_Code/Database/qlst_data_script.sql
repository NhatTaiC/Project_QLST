USE [master]
GO
/****** Object:  Database [QLST]    Script Date: 5/13/2024 9:34:47 PM ******/
CREATE DATABASE [QLST]
 ON  PRIMARY 
( NAME = N'QLST', FILENAME = N'D:\PROGRAM\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLST.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLST_log', FILENAME = N'D:\PROGRAM\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLST_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLST] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLST].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLST] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLST] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLST] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLST] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLST] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLST] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLST] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLST] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLST] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLST] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLST] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLST] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLST] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLST] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLST] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLST] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLST] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLST] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLST] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLST] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLST] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLST] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLST] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLST] SET  MULTI_USER 
GO
ALTER DATABASE [QLST] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLST] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLST] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLST] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLST] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLST] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLST] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLST] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLST]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaChiTiet] [varchar](50) NOT NULL,
	[MaDon] [varchar](50) NOT NULL,
	[MaSP] [varchar](50) NOT NULL,
	[TenSP] [nvarchar](100) NULL,
	[GiaBan] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
	[DonViTinh] [nvarchar](100) NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC,
	[MaDon] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDon] [varchar](50) NOT NULL,
	[NgayBan] [date] NULL,
	[TongGiaTri] [int] NULL,
	[MaNV] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSP] [varchar](50) NOT NULL,
	[TenLoaiSP] [nvarchar](100) NULL,
	[MoTa] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](50) NOT NULL,
	[TenNCC] [nvarchar](100) NULL,
	[DiaChiNCC] [nvarchar](100) NULL,
	[SdtNCC] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[TenNV] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Sdt] [nvarchar](100) NULL,
	[TaiKhoan] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [varchar](50) NOT NULL,
	[TenSP] [nvarchar](100) NULL,
	[GiaNhap] [int] NULL,
	[GiaBan] [int] NULL,
	[SoLuong] [int] NULL,
	[DonViTinh] [nvarchar](100) NULL,
	[NoiSanXuat] [nvarchar](100) NULL,
	[HanSuDung] [date] NULL,
	[MaNCC] [varchar](50) NOT NULL,
	[MaLoaiSP] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[HoTen] [nvarchar](100) NULL,
	[NgayTao] [date] NULL,
	[ChucVu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT001', N'DH001', N'MSP001', N'Pepsi Lon 350ml', 10000, 10, 100000, N'Chai')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT002', N'DH001', N'MSP002', N'Coca Lon 350ml', 10000, 10, 100000, N'Chai')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT003', N'DH001', N'MSP003', N'Fanta Lon 350ml', 10000, 10, 100000, N'Chai')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT004', N'DH001', N'MSP004', N'Nike Air Force 1', 1200000, 1, 1200000, N'Đôi')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT005', N'DH001', N'MSP005', N'Adidas Stan Smith', 1200000, 1, 1200000, N'Đôi')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT006', N'DH001', N'MSP006', N'Oreo Đá Xay', 60000, 2, 120000, N'Ly')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT007', N'DH001', N'MSP007', N'Cơm Nắm', 14000, 10, 140000, N'Cái')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT008', N'DH001', N'MSP008', N'Trà Chanh', 15000, 10, 150000, N'Ly')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT009', N'DH001', N'MSP009', N'TV LG', 16000000, 1, 16000000, N'Cái')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT010', N'DH001', N'MSP010', N'Màn Hình Asus', 3200000, 1, 3200000, N'Cái')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT011', N'DH001', N'MSP011', N'Giày SAMBA OG', 2700000, 1, 2700000, N'Đôi')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT012', N'DH001', N'MSP012', N'Áo Thun Chạy Bộ ADIZERO', 1700000, 1, 1700000, N'Cái')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT013', N'DH001', N'MSP013', N'Áo Gile Own The Run', 1700000, 1, 1700000, N'Cái')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT014', N'DH001', N'MSP014', N'Giày ADIZERO PRIME X 2.0 STRUNG', 6700000, 1, 6700000, N'Đôi')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT015', N'DH001', N'MSP015', N'Quần Short Chạy Bộ', 800000, 2, 1600000, N'Cái')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT016', N'DH001', N'MSP016', N'Giày MARVEL DURAMO SL TRẺ EM', 800000, 1, 800000, N'Đôi')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT017', N'DH001', N'MSP017', N'Áo Thun 3 Lá ADICOLOR', 650000, 1, 650000, N'Cái')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT018', N'DH001', N'MSP018', N'Áo Gió MICKEY MOUSE', 530000, 1, 530000, N'Cái')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT019', N'DH001', N'MSP019', N'Tất 3 Lá ADICOLOR', 150000, 1, 150000, N'Cái')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT020', N'DH001', N'MSP020', N'Dép Nike Calm', 1579000, 1, 1579000, N'Đôi')
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDon], [MaSP], [TenSP], [GiaBan], [SoLuong], [ThanhTien], [DonViTinh]) VALUES (N'MCT021', N'DH002', N'MSP002', N'Coca Lon 350ml', 10000, 5, 50000, N'Chai')
GO
INSERT [dbo].[DonHang] ([MaDon], [NgayBan], [TongGiaTri], [MaNV]) VALUES (N'DH001', CAST(N'2024-04-01' AS Date), 40419000, N'NV001')
INSERT [dbo].[DonHang] ([MaDon], [NgayBan], [TongGiaTri], [MaNV]) VALUES (N'DH002', CAST(N'2024-04-01' AS Date), 50000, N'NV002')
GO
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP], [MoTa]) VALUES (N'LSP001', N'Đồ Khô', N'Đồ Khô, Đồ Đóng Hộp')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP], [MoTa]) VALUES (N'LSP002', N'Đồ Lạnh', N'Đồ Đông Lạnh')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP], [MoTa]) VALUES (N'LSP003', N'Đồ Điện Tử', N'Tivi, Màn Hình,...')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP], [MoTa]) VALUES (N'LSP004', N'Giày Dép', N'Các Loại Giày Dép')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSP], [TenLoaiSP], [MoTa]) VALUES (N'LSP005', N'Quần Áo', N'Các Loại Quần Áo')
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'NCC001', N'Pepsi', N'20 CMT8, Hồ Chí Minh', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'NCC002', N'Cocacoca', N'12 Dân Chủ, Hồ Chí Minh', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'NCC003', N'Adidas', N'02 Hòa Bình, Hồ Chí Minh', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'NCC004', N'Nike', N'04 Mai Chí Thọ, Hồ Chí Minh', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'NCC005', N'HighLand Coffee', N'109 Hoàng Diệu 2, Hồ Chí Minh', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'NCC006', N'Circle K', N'05 Thống Nhất, Hồ Chí Minh', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'NCC007', N'Family Mart', N'15 Võ Văn Ngân, Hồ Chí Minh', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'NCC008', N'LG', N'10 Điện Biên Phủ, Hồ Chí Minh', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'NCC009', N'Samsung', N'18 Ung Văn Khiêm, Hồ Chí Minh', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNCC], [SdtNCC]) VALUES (N'NCC010', N'Asus', N'34 Mạc Đĩnh Chi, Hồ Chí Minh', N'0123456789')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Sdt], [TaiKhoan]) VALUES (N'NV001', N'Hoàng Văn Mạnh', CAST(N'1996-06-05' AS Date), N'Nam', N'Ngõ 6 Phù Đổng, Hồ Chí Minh', N'0963852741', N'NV001')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Sdt], [TaiKhoan]) VALUES (N'NV002', N'Mai Vân Linh', CAST(N'1998-06-18' AS Date), N'Nữ', N'10 Hoàng Mai, Hà Nội', N'0963852741', N'NV002')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Sdt], [TaiKhoan]) VALUES (N'NV003', N'Trần Hoàng Diệu', CAST(N'2000-05-18' AS Date), N'Nữ', N'10 Lò Đúc, Hà Nội', N'0123456789', N'NV003')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Sdt], [TaiKhoan]) VALUES (N'NV004', N'Hồ Nhật Tâm', CAST(N'1986-04-12' AS Date), N'Nam', N'23 Trần Duy Hưng, Hà Nội', N'0789456123', N'NV004')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Sdt], [TaiKhoan]) VALUES (N'NV005', N'Nguyễn Văn Đức', CAST(N'1963-01-16' AS Date), N'Nam', N'50 Phan Văn Trị, TP HCM', N'0123456987', N'NV005')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Sdt], [TaiKhoan]) VALUES (N'NV006', N'Phan Văn Bình', CAST(N'1984-11-23' AS Date), N'Nam', N'7 D2, TP HCM', N'0456123987', N'NV006')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Sdt], [TaiKhoan]) VALUES (N'NV007', N'Hồ Phan Minh Đăng', CAST(N'1966-06-07' AS Date), N'Nam', N'16 Võ Văn Ngân, TP HCM', N'0321456987', N'NV007')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Sdt], [TaiKhoan]) VALUES (N'NV008', N'Trần Thị Hoàn', CAST(N'1961-02-01' AS Date), N'Nữ', N'23 Nguyễn Thái Học, TP HCM', N'0112365478', N'NV008')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Sdt], [TaiKhoan]) VALUES (N'NV009', N'Trần Thị Hồng', CAST(N'1956-06-08' AS Date), N'Nữ', N'11 Đặng Văn Bi, TP HCM', N'0123665489', N'NV009')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Sdt], [TaiKhoan]) VALUES (N'NV010', N'Trần Huyến Trang', CAST(N'1978-02-03' AS Date), N'Nữ', N'2 Lý Thường Kiệt, TP HCM', N'0321554789', N'NV010')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP001', N'Pepsi Lon 350ml', 4000, 10000, 101, N'Chai', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC001', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP002', N'Coca Lon 350ml', 4000, 10000, 101, N'Chai', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC002', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP003', N'Fanta Lon 350ml', 4000, 10000, 101, N'Chai', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC001', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP004', N'Nike Air Force 1', 1000000, 1200000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC004', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP005', N'Adidas Stan Smith', 1500000, 1700000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC003', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP006', N'Oreo Đá xay', 50000, 60000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC005', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP007', N'Cơm Nắm', 10000, 14000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC007', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP008', N'Trà Chanh', 10000, 15000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC006', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP009', N'TV LG', 15000000, 16000000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC008', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP010', N'Màn Hình Asus', 3000000, 3200000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC010', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP011', N'Giày SAMBA OG', 2500000, 2700000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC003', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP012', N'Áo Thun Chạy Bộ ADIZERO', 1600000, 1700000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC003', N'LSP005')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP013', N'Áo Gile Own The Run', 1600000, 1700000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC003', N'LSP005')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP014', N'Giày ADIZERO PRIME X 2.0 STRUNG', 6500000, 6700000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC003', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP015', N'Quần Short Chạy Bộ', 700000, 800000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC003', N'LSP005')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP016', N'Giày MARVEL DURAMO SL TRẺ EM', 700000, 800000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC003', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP017', N'Áo Thun 3 Lá ADICOLOR', 550000, 650000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC003', N'LSP005')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP018', N'Áo Gió MICKEY MOUSE', 430000, 530000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC003', N'LSP005')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP019', N'Tất 3 Lá ADICOLOR', 100000, 150000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC003', N'LSP005')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP020', N'Dép Nike Calm', 1479000, 1579000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC004', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP021', N'Giày Nike Air Max Isla', 2900000, 3000000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC004', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP022', N'Giày Nike Air Max Koko', 2900000, 3000000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC004', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP023', N'Giày Nike Aqua Swoosh', 1100000, 1149000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC004', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP024', N'Giày Jordan Deja', 2600000, 2649000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC004', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP025', N'Giày Nike Calm', 2000000, 2069000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC004', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP026', N'Dép Nike Offcourt', 1019000, 1100000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC004', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP027', N'Dép Jordan Super Play', 1600000, 1750000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC004', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP028', N'Dép Nike Air More Uptempo', 2500000, 2649000, 101, N'Đôi', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC004', N'LSP004')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP029', N'Cà Phê Phin Sữa Đá', 20000, 29000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC005', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP030', N'Bạc Xỉu', 20000, 29000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC005', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP031', N'Cà Phê Phin Đen Đá', 19000, 29000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC005', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP032', N'Cà Phê Phin Đen Nóng', 19000, 29000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC005', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP033', N'Cà Phê Espresso Americano', 30000, 35000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC005', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP034', N'Cà Phê Espresso Latte', 50000, 55000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC005', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP035', N'Cà Phê Espresso Cappuccino', 50000, 55000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC005', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP036', N'Cà Phê Espresso Caramel Macchiato', 51000, 59000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC005', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP037', N'Đá Xay Freeze Trà Xanh', 51000, 59000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC005', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP038', N'Bánh Bao Trứng Cút', 25000, 30000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC006', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP039', N'Bánh Mì Ốp La', 15000, 20000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC006', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP040', N'Xôi Lá Chuối', 25000, 30000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC006', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP041', N'Mì Trộn Indomie', 25000, 30000, 101, N'Phần', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC006', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP042', N'Bánh Giò', 20000, 25000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC006', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP043', N'Sữa Tươi Cà Phê', 20000, 25000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC006', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP044', N'Trà Đào', 20000, 25000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC006', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP045', N'Mì Xào Trứng Xúc Xích', 30000, 35000, 101, N'Phần', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC006', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP046', N'Milo', 15000, 25000, 101, N'Ly', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC006', N'LSP002')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP047', N'Bánh Crepe Tiramisu', 15000, 25000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC007', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP048', N'Bánh Đậu Đỏ', 20000, 25000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC007', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP049', N'Bánh Dorayaki Nhân Kem Sữa Hokkaido', 10000, 15000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC007', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP050', N'Bánh Hawaii Khoai Tây', 20000, 28000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC007', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP051', N'Bánh Bao Nhân Thịt Heo Trứng Muối', 20000, 28000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC007', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP052', N'Bánh Giò Nhân Gà 2 Trứng Cút', 12000, 17000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC007', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP053', N'Bắp Cải Cuộn Tôm', 4000, 8000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC007', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP054', N'Bánh Mì Que Pate Nướng Cay', 12000, 18000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC007', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP055', N'Bánh Mì Truyền Thống', 12000, 18000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC007', N'LSP001')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP056', N'Tủ Lạnh LG French Door InstaView 530L Màu Đen LFB53BLMI', 29000000, 29900000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC008', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP057', N'Máy Rửa Bát LG TrueSteam Màu Be LDT14BGA3', 19000000, 2200000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC008', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP058', N'Máy Lọc Không Khí PuriCare360 Alpha PET Lọc Không Khí 360 | AS65GDBY0', 25000000, 2590000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC008', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP059', N'Điều Hòa LG DUALCOOL Inverter 1 chiều 9.000 BTU (1HP)|V10ENO', 8000000, 8700000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC008', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP060', N'Tivi LG OLED A3 65 inch 2023 4K Smart TV | OLED65A3', 3200000, 32900000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC008', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP061', N'Màn Hình ChơiGgame UltraGear Full HD IPS 1ms (GtG) 27''Tương Thích Với NVIDIA G-SYNC', 4090000, 5200000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC008', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP062', N'Tivi LG OLED Posé Objet Collection LX1 55 Inch 4K Smart TV | 55LX1Q', 5400000, 54900000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC008', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP063', N'Tủ Lạnh LG Instaview Door-in-door Và Ngăn Lấy Nước Ngoài UV Nano 635L Màu Be GR-X257BG', 37000000, 37900000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC008', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP064', N'Tủ Chăm Sóc Quần Áo Thông Minh LG Styler 5 Móc True Steam Màu Xanh Lá Cây | S5GOC', 54000000, 55000000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC008', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP065', N'S24 Ultra', 3000000, 37000000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC009', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP066', N'Zflip 5', 20000000, 25000000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC009', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP067', N'Galaxy A35', 7500000, 7900000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC009', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP068', N'Galaxy A55', 11000000, 11400000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC009', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP069', N'Galaxy A05s', 3200000, 3650000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC009', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP070', N'Galaxy A15', 5000000, 5250000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC009', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP071', N'Galaxy A25', 6000000, 6550000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC009', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP072', N'Galaxy A23', 3500000, 3700000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC009', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP073', N'Galaxy A34', 8100000, 8489000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC009', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP074', N'ASUS Zenbook Pro 14 Duo OLED UX8402VU-P1028W', 54000000, 54690000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC010', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP075', N'ASUS Zenbook 14 OLED UX3405MA-PP152W', 32000000, 32490000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC010', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP076', N'ASUS Zenbook 14 OLED UX3402VA-KM203W', 22000000, 22900000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC010', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP077', N'ASUS Zenbook 14 Flip OLED', 25000000, 25400000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC010', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP078', N'ASUS ZenScreen MB166C- 16 Inch', 4000000, 4990000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC010', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP079', N'ASUS Zenbook 14 OLED UX3405MA-PP588W', 26000000, 26990000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC010', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP080', N'ASUS ZenScreen OLED MQ16AH – 16 Inch', 3000000, 3900000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC010', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP081', N'ASUS ZenScreen MB166C Portable Monitor- 16 Inch', 4000000, 4990000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC010', N'LSP003')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaNhap], [GiaBan], [SoLuong], [DonViTinh], [NoiSanXuat], [HanSuDung], [MaNCC], [MaLoaiSP]) VALUES (N'MSP082', N'ASUS ZenScreen MB16AH Portable USB- 16 Inch', 5000000, 5990000, 101, N'Cái', N'Hồ Chí Minh', CAST(N'2025-04-01' AS Date), N'NCC010', N'LSP003')
GO
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'admin', N'123456', N'Admin', CAST(N'2024-04-01' AS Date), N'Admin')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'NV001', N'123456', N'Hoàng Văn Mạnh', CAST(N'2024-04-01' AS Date), N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'NV002', N'123456', N'Mai Vân Linh', CAST(N'1998-06-18' AS Date), N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'NV003', N'123456', N'Trần Hoàng Diệu', CAST(N'2000-05-18' AS Date), N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'NV004', N'123456', N'Hồ Nhật Tâm', CAST(N'1986-04-12' AS Date), N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'NV005', N'123456', N'Nguyễn Văn Đức', CAST(N'1963-01-16' AS Date), N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'NV006', N'123456', N'Phan Văn Bình', CAST(N'1984-11-23' AS Date), N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'NV007', N'123456', N'Hồ Phan Minh Đăng', CAST(N'1966-06-07' AS Date), N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'NV008', N'123456', N'Trần Thị Hoàn', CAST(N'1961-02-01' AS Date), N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'NV009', N'123456', N'Trần Thị Hồng', CAST(N'1956-06-08' AS Date), N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'NV010', N'123456', N'Trần Huyến Trang', CAST(N'1978-02-03' AS Date), N'Nhân Viên')
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [HoTen], [NgayTao], [ChucVu]) VALUES (N'user', N'123456', N'User', CAST(N'2024-04-01' AS Date), N'User')
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_ChiTietDonHang] FOREIGN KEY([MaDon])
REFERENCES [dbo].[DonHang] ([MaDon])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_DonHang_ChiTietDonHang]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_ChiTietDonHang] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_SanPham_ChiTietDonHang]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([TaiKhoan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_LoaiSanPham_SanPham] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_LoaiSanPham_SanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap_SanPham] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_NhaCungCap_SanPham]
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDH_TheoMaDon]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--EXEC sp_LayDSDH_TheoNgayBan '2024-04-01';

--DROP PROC sp_LayDSDH_TheoNgayBan;

-- LayDH_TheoMaDon
CREATE PROC [dbo].[sp_LayDH_TheoMaDon](@maDon varchar(50))
AS
	SELECT dh.MaDon, dh.NgayBan, dh.TongGiaTri, nv.TenNV, ctdh.TenSP, ctdh.GiaBan, ctdh.SoLuong, ctdh.ThanhTien
	FROM [dbo].[ChiTietDonHang] AS ctdh
	JOIN [dbo].[DonHang] AS dh
	ON ctdh.MaDon = dh.MaDon
	JOIN [dbo].[NhanVien] AS nv
	ON dh.MaNV = nv.MaNV
	WHERE dh.MaDon = @maDon
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSDH_TheoNgayBan]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--EXEC sp_LayDSDH_TheoTenNV 'Mai Vân Linh';

--DROP PROC sp_LayDSDH_TheoTenNV;

-- LayDSDH_TheoNgayBan
CREATE PROC [dbo].[sp_LayDSDH_TheoNgayBan](@ngayBan date)
AS
	SELECT dh.MaDon, dh.NgayBan, dh.TongGiaTri, nv.TenNV FROM [dbo].[NhanVien] AS nv
	JOIN [dbo].[DonHang] AS dh
	ON nv.MaNV = dh.MaNV
	WHERE dh.NgayBan = @ngayBan
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSDH_TheoTenNV]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--EXEC sp_LayDSSP_TheoTenSP 'Nike';

--DROP PROC sp_LayDSSP_TheoTenSP;

-- LayDSDH_TheoTenNV
CREATE PROC [dbo].[sp_LayDSDH_TheoTenNV](@tenNV nvarchar(100))
AS
	SELECT dh.MaDon, dh.NgayBan, dh.TongGiaTri, nv.TenNV FROM [dbo].[NhanVien] AS nv
	JOIN [dbo].[DonHang] AS dh
	ON nv.MaNV = dh.MaNV
	WHERE nv.TenNV LIKE '%' + @tenNV + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDSSP_TheoTenSP]    Script Date: 5/13/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- LayDSSP_TheoTenSP
CREATE PROC [dbo].[sp_LayDSSP_TheoTenSP](@tenSP nvarchar(100))
AS
	SELECT sp.MaSP, sp.TenSP, sp.GiaNhap, sp.GiaBan, sp.SoLuong, sp.DonViTinh, sp.NoiSanXuat, sp.HanSuDung FROM [dbo].[SanPham] AS sp
	WHERE sp.TenSP LIKE '%' + @tenSP + '%'
GO
USE [master]
GO
ALTER DATABASE [QLST] SET  READ_WRITE 
GO
