/*
Project Quản Lý Siêu Thị
Database [QLST]
Thành viên trong nhóm: Châu Nhật Tài, Lê Văn Toàn
Ngày tạo: 10/05/2024
ALL
*/

/*
CREATE DATABASE [QLST]
*/

--CREATE DATABASE
--DROP DATABASE [QLST]
CREATE DATABASE QLST;
GO

--USE DATABASE
USE [QLST];
GO

SET DATEFORMAT dmy;
GO

--CREATE TABLES
CREATE TABLE [dbo].[TaiKhoan]
(
	[TaiKhoan] varchar(50) not null PRIMARY KEY,
	[MatKhau] varchar(50),
	[HoTen] nvarchar(100),
	[NgayTao] date,
	[ChucVu] nvarchar(100)
);

CREATE TABLE [dbo].[NhaCungCap]
(
	[MaNCC] varchar(50) not null PRIMARY KEY,
	[TenNCC] nvarchar(100),
	[DiaChiNCC] nvarchar(100),
	[SdtNCC] nvarchar(100),
);

CREATE TABLE [dbo].[LoaiSanPham]
(
	[MaLoaiSP] varchar(50) not null PRIMARY KEY,
	[TenLoaiSP] nvarchar(100),
	[MoTa] nvarchar(100)
);

CREATE TABLE [dbo].[SanPham]
(
	[MaSP] varchar(50) not null PRIMARY KEY,
	[TenSP] nvarchar(100),
	[GiaNhap] int,
	[GiaBan] int,
	[SoLuong] int,
	[DonViTinh] nvarchar(100),
	[NoiSanXuat] nvarchar(100),
	[HanSuDung] date,
	[MaNCC] varchar(50) not null,
	[MaLoaiSP] varchar(50) not null,
	CONSTRAINT FK_NhaCungCap_SanPham FOREIGN KEY([MaNCC]) REFERENCES [dbo].[NhaCungCap]([MaNCC]),
	CONSTRAINT FK_LoaiSanPham_SanPham FOREIGN KEY([MaLoaiSP]) REFERENCES [dbo].[LoaiSanPham]([MaLoaiSP])
);

CREATE TABLE [dbo].[NhanVien]
(
	[MaNV] varchar(50) not null PRIMARY KEY,
	[TenNV] nvarchar(100),
	[NgaySinh] date,
	[GioiTinh] nvarchar(100),
	[DiaChi] nvarchar(100),
	[Sdt] nvarchar(100),
	[TaiKhoan] varchar(50) not null,
	CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY([TaiKhoan]) REFERENCES [dbo].[TaiKhoan]([TaiKhoan])
);

CREATE TABLE [dbo].[DonHang]
(
	[MaDon] varchar(50) not null PRIMARY KEY,
	[NgayBan] date,
	[TongGiaTri] int,
	[MaNV] varchar(50) not null,
	CONSTRAINT FK_DonHang_NhanVien FOREIGN KEY([MaNV]) REFERENCES [dbo].[NhanVien]([MaNV])
);

CREATE TABLE [dbo].[ChiTietDonHang]
(
	[MaChiTiet] varchar(50) not null,
	[MaDon] varchar(50) not null,
	[MaSP] varchar(50) not null,
	[TenSP] nvarchar(100),
	[GiaBan] int,
	[SoLuong] int,
	[ThanhTien] int,
	[DonViTinh] nvarchar(100),
	CONSTRAINT PK_ChiTietDonHang PRIMARY KEY([MaChiTiet], [MaDon], [MaSP]),
	CONSTRAINT FK_DonHang_ChiTietDonHang FOREIGN KEY([MaDon]) REFERENCES [dbo].[DonHang]([MaDon]),
	CONSTRAINT FK_SanPham_ChiTietDonHang FOREIGN KEY([MaSP]) REFERENCES [dbo].[SanPham]([MaSP])
);
GO

/*
INSERT DATA FOR [QLST]
*/

USE [QLST];
GO

--Tbl_TaiKhoan
INSERT INTO [dbo].[TaiKhoan]
(
	[TaiKhoan],
	[MatKhau],
	[HoTen],
	[NgayTao],
	[ChucVu]
)
VALUES
	('admin', '123456', N'Admin', N'2024-04-01', N'Admin'),
	('user', '123456', N'User', N'2024-04-01', N'User'),
	('NV001', '123456', N'Hoàng Văn Mạnh', N'2024-04-01', N'Nhân Viên'),
	('NV002', '123456', N'Mai Vân Linh', N'1998-06-18', N'Nhân Viên'),
	('NV003', '123456', N'Trần Hoàng Diệu', N'2000-05-18', N'Nhân Viên'),
	('NV004', '123456', N'Hồ Nhật Tâm', N'1986-04-12', N'Nhân Viên'),
	('NV005', '123456', N'Nguyễn Văn Đức', N'1963-01-16', N'Nhân Viên'),
	('NV006', '123456', N'Phan Văn Bình', N'1984-11-23', N'Nhân Viên'),
	('NV007', '123456', N'Hồ Phan Minh Đăng', N'1966-06-07', N'Nhân Viên'),
	('NV008', '123456', N'Trần Thị Hoàn', N'1961-02-01', N'Nhân Viên'),
	('NV009', '123456', N'Trần Thị Hồng', N'1956-06-08', N'Nhân Viên'),
	('NV010', '123456',  N'Trần Huyến Trang', N'1978-02-03', N'Nhân Viên');
	

--Tbl_NhaCungCap
INSERT INTO [dbo].[NhaCungCap]
(
	[MaNCC],
	[TenNCC],
	[DiaChiNCC],
	[SdtNCC]
)

VALUES
	('NCC001', N'Pepsi', N'20 CMT8, Hồ Chí Minh', N'0123456789'),
	('NCC002', N'Cocacoca', N'12 Dân Chủ, Hồ Chí Minh', N'0123456789'),
	('NCC003', N'Adidas', N'02 Hòa Bình, Hồ Chí Minh', N'0123456789'),
	('NCC004', N'Nike', N'04 Mai Chí Thọ, Hồ Chí Minh', N'0123456789'),
	('NCC005', N'HighLand Coffee', N'109 Hoàng Diệu 2, Hồ Chí Minh', N'0123456789'),
	('NCC006', N'Circle K', N'05 Thống Nhất, Hồ Chí Minh', N'0123456789'),
	('NCC007', N'Family Mart', N'15 Võ Văn Ngân, Hồ Chí Minh', N'0123456789'),
	('NCC008', N'LG', N'10 Điện Biên Phủ, Hồ Chí Minh', N'0123456789'),
	('NCC009', N'Samsung', N'18 Ung Văn Khiêm, Hồ Chí Minh', N'0123456789'),
	('NCC010', N'Asus', N'34 Mạc Đĩnh Chi, Hồ Chí Minh', N'0123456789');

--Tbl_LoaiSP
INSERT INTO [dbo].[LoaiSanPham]
(
	[MaLoaiSP],
	[TenLoaiSP],
	[MoTa]
)
VALUES
	('LSP001', N'Đồ Khô', N'Đồ khô, đồ đóng hộp'),
	('LSP002', N'Đồ Lạnh', N'Đồ đông lạnh'),
	('LSP003', N'Đồ Điện Tử', N'Tivi, màn hình,...'),
	('LSP004', N'Giày Dép', N'Các loại giày dép'),
	('LSP005', N'Quần Áo', N'Các loại quần áo');

--Tbl_SanPham
INSERT INTO [dbo].[SanPham]
(
	[MaSP],
	[TenSP],
	[GiaNhap],
	[GiaBan],
	[SoLuong],
	[DonViTinh],
	[NoiSanXuat],
	[HanSuDung],
	[MaNCC],
	[MaLoaiSP]
)
VALUES
	('MSP001', N'Pepsi Lon 350ml', 4000, 10000, 101, N'Chai', N'Hồ Chí Minh', N'2025-04-01', 'NCC001', 'LSP001'),
	('MSP002', N'Coca Lon 350ml', 4000, 10000, 101, N'Chai', N'Hồ Chí Minh', N'2025-04-01', 'NCC002', 'LSP001'),
	('MSP003', N'Fanta Lon 350ml', 4000, 10000, 101, N'Chai', N'Hồ Chí Minh', N'2025-04-01', 'NCC001', 'LSP001'),
	('MSP004', N'Nike air force 1', 1000000, 1200000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	('MSP005', N'Adidas stan smith', 1500000, 1700000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP004'),
	('MSP006', N'Oreo đá xay', 50000, 60000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	('MSP007', N'Cơm nắm', 10000, 14000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	('MSP008', N'Trà chanh', 10000, 15000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP004'),
	('MSP009', N'TV LG', 15000000, 16000000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	('MSP010', N'Màn hình Asus', 3000000, 3200000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC010', 'LSP003'),
	--adidas
	('MSP011', N'Giày SAMBA OG', 2500000, 2700000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP004'),
	('MSP012', N'Áo thun chạy bộ ADIZERO', 1600000, 1700000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP005'),
	('MSP013', N'Áo gile own the run', 1600000, 1700000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP005'),
	('MSP014', N'Giày ADIZERO PRIME X 2.0 STRUNG', 6500000, 6700000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP004'),
	('MSP015', N'Quần short chạy bộ', 700000, 800000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP005'),
	('MSP016', N'Giày MARVEL DURAMO SL TRẺ EM', 700000, 800000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP004'),
	('MSP017', N'Áo thun 3 lá ADICOLOR', 550000, 650000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP005'),
	('MSP018', N'Áo gió MICKEY MOUSE', 430000, 530000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP005'),
	('MSP019', N'Tất 3 lá ADICOLOR', 100000, 150000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP005'),
	--nike
	('MSP020', N'Dép Nike Calm', 1479000, 1579000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	('MSP021', N'Giày Nike Air Max Isla', 2900000, 3000000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	('MSP022', N'Giày Nike Air Max Koko', 2900000, 3000000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	('MSP023', N'Giày Nike Aqua Swoosh', 1100000, 1149000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	('MSP024', N'Giày Jordan Deja', 2600000, 2649000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	('MSP025', N'Giày Nike Calm', 2000000, 2069000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	('MSP026', N'Dép Nike Offcourt', 1019000, 1100000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	('MSP027', N'Dép Jordan Super Play', 1600000, 1750000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	('MSP028', N'Dép Nike Air More Uptempo', 2500000, 2649000, 101, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	--hightland
	('MSP029', N'Cà phê phin sữa đá', 20000, 29000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	('MSP030', N'Bạc xỉu', 20000, 29000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	('MSP031', N'Cà phê phin đen đá', 19000, 29000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	('MSP032', N'Cà phê phin đen nóng', 19000, 29000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	('MSP033', N'Cà phê Espresso Americano', 30000, 35000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	('MSP034', N'Cà phê Espresso Latte', 50000, 55000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	('MSP035', N'Cà phê Espresso Cappuccino', 50000, 55000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	('MSP036', N'Cà phê Espresso Caramel Macchiato', 51000, 59000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	('MSP037', N'Đá xay Freeze Trà Xanh', 51000, 59000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	--Circle K
	('MSP045', N'Mì xào trứng xúc xích', 30000, 35000, 101, N'Dĩa', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP001'),
	('MSP038', N'Bánh bao trứng cút', 25000, 30000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP001'),
	('MSP039', N'Bánh mì ốp la', 15000, 20000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP001'),
	('MSP040', N'Xôi lá chuối', 25000, 30000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP001'),
	('MSP041', N'Mì trộn Indomie', 25000, 30000, 101, N'Dĩa', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP001'),
	('MSP042', N'Bánh giò', 20000, 25000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP001'),
	('MSP043', N'Sữa tươi cà phê', 20000, 25000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP002'),
	('MSP044', N'Trà đào', 20000, 25000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP002'),
	('MSP046', N'Milo', 15000, 25000, 101, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP002'),
	--family mart
	('MSP047', N'Bánh crepe tiramisu', 15000, 25000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	('MSP048', N'Bánh đậu đỏ', 20000, 25000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	('MSP049', N'Bánh Dorayaki nhân kem sữa Hokkaido', 10000, 15000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	('MSP050', N'Bánh Hawaii Khoai Tây', 20000, 28000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	('MSP051', N'Bánh bao nhân thịt heo trứng muối', 20000, 28000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	('MSP052', N'Bánh giò nhân gà 2 trứng cút', 12000, 17000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	('MSP053', N'Bắp cải cuộn tôm', 4000, 8000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	('MSP054', N'Bánh Mì Que Pate Nướng Cay', 12000, 18000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	('MSP055', N'Bánh Mì truyền thống', 12000, 18000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	--LG
	('MSP056', N'Tủ lạnh LG French Door InstaView 530L màu đen LFB53BLMI', 29000000, 29900000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	('MSP057', N'Máy rửa bát LG TrueSteam màu Be LDT14BGA3', 19000000, 2200000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	('MSP058', N'Máy lọc không khí PuriCare360 Alpha PET Lọc không khí 360 | AS65GDBY0', 25000000, 2590000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	('MSP059', N'Điều hòa LG DUALCOOL Inverter 1 chiều 9.000 BTU (1HP)|V10ENO', 8000000, 8700000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	('MSP060', N'Tivi LG OLED A3 65 inch 2023 4K Smart TV | OLED65A3', 3200000, 32900000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	('MSP061', N'Màn hình chơi game UltraGear Full HD IPS 1ms (GtG) 27'' tương thích với NVIDIA G-SYNC', 4090000, 5200000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	('MSP062', N'Tivi LG OLED Posé Objet Collection LX1 55 inch 4K Smart TV | 55LX1Q', 5400000, 54900000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	('MSP063', N'Tủ lạnh LG Instaview Door-in-door và ngăn lấy nước ngoài UV nano 635L màu be GR-X257BG', 37000000, 37900000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	('MSP064', N'Tủ chăm sóc quần áo thông minh LG Styler 5 móc True Steam Màu xanh lá cây | S5GOC', 54000000, 55000000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	--Samsung
	('MSP065', N'S24 Ultra', 3000000, 37000000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP066', N'Zflip 5', 20000000, 25000000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP067', N'Galaxy A35', 7500000, 7900000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP068', N'Galaxy A55', 11000000, 11400000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP069', N'Galaxy A05s', 3200000, 3650000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP070', N'Galaxy A15', 5000000, 5250000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP071', N'Galaxy A25', 6000000, 6550000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP072', N'Galaxy A23', 3500000, 3700000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP073', N'Galaxy A34', 8100000, 8489000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	--Asus
	('MSP074', N'ASUS Zenbook Pro 14 Duo OLED UX8402VU-P1028W', 54000000, 54690000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP075', N'ASUS Zenbook 14 OLED UX3405MA-PP152W', 32000000, 32490000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP076', N'ASUS Zenbook 14 OLED UX3402VA-KM203W', 22000000, 22900000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP077', N'ASUS Zenbook 14 Flip OLED', 25000000, 25400000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP078', N'ASUS ZenScreen MB166C- 16 inch', 4000000, 4990000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP079', N'ASUS Zenbook 14 OLED UX3405MA-PP588W', 26000000, 26990000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP080', N'ASUS ZenScreen OLED MQ16AH – 16 inch', 3000000, 3900000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP081', N'ASUS ZenScreen MB166C Portable Monitor- 16 inch', 4000000, 4990000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003'),
	('MSP082', N'ASUS ZenScreen MB16AH Portable USB- 16 inch', 5000000, 5990000, 101, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC009', 'LSP003');

--Tbl_NhanVien
INSERT INTO [dbo].[NhanVien]
(
	[MaNV],
	[TenNV],
	[NgaySinh],
	[GioiTinh],
	[DiaChi],
	[Sdt],
	[TaiKhoan]
)
VALUES
	('NV001', N'Hoàng Văn Mạnh', N'1996-06-05', N'Nam', N'Ngõ 6 Phù Đổng, Hồ Chí Minh', N'0963852741', 'NV001'),
	('NV002', N'Mai Vân Linh', N'1998-06-18', N'Nữ', N'10 Hoàng Mai, Hà Nội', N'0963852741', 'NV002'),
	('NV003', N'Trần Hoàng Diệu', N'2000-05-18', N'Nữ', N'10 Lò Đúc, Hà Nội', N'0123456789', 'NV003'),
	('NV004', N'Hồ Nhật Tâm', N'1986-04-12', N'Nam', N'23 Trần Duy Hưng, Hà Nội', N'0789456123', 'NV004'),
	('NV005', N'Nguyễn Văn Đức', N'1963-01-16', N'Nam', N'50 Phan Văn Trị, TP HCM', N'0123456987', 'NV005'),
	('NV006', N'Phan Văn Bình', N'1984-11-23', N'Nam', N'7 D2, TP HCM', N'0456123987', 'NV006'),
	('NV007', N'Hồ Phan Minh Đăng', N'1966-06-07', N'Nam', N'16 Võ Văn Ngân, TP HCM', N'0321456987', 'NV007'),
	('NV008', N'Trần Thị Hoàn', N'1961-02-01', N'Nữ', N'23 Nguyễn Thái Học, TP HCM', N'0112365478', 'NV008'),
	('NV009', N'Trần Thị Hồng', N'1956-06-08', N'Nữ', N'11 Đặng Văn Bi, TP HCM', N'0123665489', 'NV009'),
	('NV010', N'Trần Huyến Trang', N'1978-02-03', N'Nữ', N'2 Lý Thường Kiệt, TP HCM', N'0321554789', 'NV010');

--Tbl_DonHang
INSERT INTO [dbo].[DonHang]
(
	[MaDon],
	[NgayBan],
	[TongGiaTri],
	[MaNV]
)
VALUES 
	(N'DH001', N'2024-04-01', 100000, 'NV001'),
	(N'DH002', N'2024-04-01', 50000, 'NV002');

--Tbl_ChiTietDonHang
INSERT INTO [dbo].[ChiTietDonHang]
(
	[MaChiTiet],
	[MaDon],
	[MaSP],
	[TenSP],
	[GiaBan],
	[SoLuong],
	[ThanhTien],
	[DonViTinh]
)
VALUES
	('MCT001','DH001', 'MSP001', N'Pepsi Lon 350ml', 10000, 10, 100000, N'Chai'),
	('MCT002','DH002', 'MSP002', N'Coca Lon 350ml', 10000, 5, 50000, N'Chai');
GO

/*
STORE PROCEDURE FOR [QLST]
*/

USE [QLST];
GO

-- LayDSSP_TheoTenSP
CREATE PROC sp_LayDSSP_TheoTenSP(@tenSP nvarchar(100))
AS
	SELECT sp.MaSP, sp.TenSP, sp.GiaNhap, sp.GiaBan, sp.SoLuong, sp.DonViTinh, sp.NoiSanXuat, sp.HanSuDung FROM [dbo].[SanPham] AS sp
	WHERE sp.TenSP LIKE '%' + @tenSP + '%'
GO

--exec sp_LayDSSP_TheoTenSP 'Nike';

--DROP proc sp_LayDSSP_TheoTenSP;

-- LayDSDH_TheoTenNV
CREATE PROC sp_LayDSDH_TheoTenNV(@tenNV nvarchar(100))
AS
	SELECT dh.MaDon, dh.NgayBan, dh.TongGiaTri, nv.TenNV FROM [dbo].[NhanVien] AS nv
	JOIN [dbo].[DonHang] AS dh
	ON nv.MaNV = dh.MaNV
	WHERE nv.TenNV LIKE '%' + @tenNV + '%'
GO

--exec sp_LayDSDH_TheoTenNV 'Mai Vân Linh';

--DROP proc sp_LayDSDH_TheoTenNV;

-- LayDSDH_TheoNgayBan
CREATE PROC sp_LayDSDH_TheoNgayBan(@ngayBan date)
AS
	SELECT dh.MaDon, dh.NgayBan, dh.TongGiaTri, nv.TenNV FROM [dbo].[NhanVien] AS nv
	JOIN [dbo].[DonHang] AS dh
	ON nv.MaNV = dh.MaNV
	WHERE dh.NgayBan = @ngayBan
GO

--exec sp_LayDSDH_TheoNgayBan '2024-04-01';

--DROP proc sp_LayDSDH_TheoNgayBan;

/*
SELECT DATA FROM [QLST]
*/

USE [QLST];
GO

SELECT * FROM TaiKhoan;

SELECT * FROM NhaCungCap;

SELECT * FROM LoaiSanPham;

SELECT * FROM SanPham;

SELECT * FROM NhanVien;

SELECT * FROM DonHang;

SELECT * FROM ChiTietDonHang;

GO