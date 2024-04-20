/*
Project Quản Lý Siêu Thị
Database [QLST]
Thành viên trong nhóm: Châu Nhật Tài, Lê Văn Toàn
Ngày tạo: 01/04/2024
INSERT 
*/

USE [QLST];
go

SET DATEFORMAT dmy;
go

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
	('admin', '123456', N'Admin', N'2024-04-01', 0),
	('user', '123456', N'User', N'2024-04-01', 1),
	('NV001', '123456', N'Hoàng Văn Mạnh', N'2024-04-01', 1),
	('NV002', '123456', N'Mai Vân Linh', N'2024-04-01', 1);

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
	('MSP001', N'Pepsi Lon 350ml', 4000, 10000, 20, N'Chai', N'Hồ Chí Minh', N'2025-04-01', 'NCC001', 'LSP001'),
	('MSP002', N'Coca Lon 350ml', 4000, 10000, 10, N'Chai', N'Hồ Chí Minh', N'2025-04-01', 'NCC002', 'LSP001'),
	('MSP003', N'Fanta Lon 350ml', 4000, 10000, 30, N'Chai', N'Hồ Chí Minh', N'2025-04-01', 'NCC001', 'LSP001'),
	('MSP004', N'Nike air force 1', 1000000, 1200000, 10, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC004', 'LSP004'),
	('MSP005', N'Adidas stan smith', 1500000, 1700000, 20, N'Đôi', N'Hồ Chí Minh', N'2025-04-01', 'NCC003', 'LSP004'),
	('MSP006', N'Oreo đá xay', 50000, 60000, 10, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC005', 'LSP002'),
	('MSP007', N'Cơm nắm', 10000, 14000, 10, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC007', 'LSP001'),
	('MSP008', N'Trà chanh', 10000, 15000, 20, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC006', 'LSP004'),
	('MSP009', N'TV LG', 15000000, 16000000, 20, N'Cái', N'Hồ Chí Minh', N'2025-04-01', 'NCC008', 'LSP003'),
	('MSP0010', N'Màn hình Asus', 3000000, 3200000, 10, N'Ly', N'Hồ Chí Minh', N'2025-04-01', 'NCC0010', 'LSP003');

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
	('NV002', N'Mai Vân Linh', N'1998-06-18', N'Nữ', N'10 Hoàng Mai, Hà Nội', N'0963852741', 'NV002');

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
	[MaDon],
	[MaSP],
	[TenSP],
	[GiaBan],
	[SoLuong],
	[ThanhTien],
	[DonViTinh]
)
VALUES
	('DH001', 'MSP001', N'Pepsi Lon 350ml', 10000, 10, 100000, N'Chai'),
	('DH002', 'MSP002', N'Coca Lon 350ml', 10000, 5, 50000, N'Chai');
go