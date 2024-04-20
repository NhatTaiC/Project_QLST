/*
Project Quản Lý Siêu Thị
Database [QLST]
Thành viên trong nhóm: Châu Nhật Tài, Lê Văn Toàn
Ngày tạo: 01/04/2024
CREATE
*/

--CREATE DATABASE
--DROP DATABASE [QLST]
CREATE DATABASE QLST;
go

--USE DATABASE
USE [QLST];
go

SET DATEFORMAT dmy;
go

--CREATE TABLES
CREATE TABLE [dbo].[TaiKhoan]
(
	[TaiKhoan] varchar(50) not null PRIMARY KEY,
	[MatKhau] varchar(50),
	[HoTen] nvarchar(100),
	[NgayTao] date,
	[ChucVu] int
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
go
