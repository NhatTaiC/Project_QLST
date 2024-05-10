/*
Project Quản Lý Siêu Thị
Database [QLST]
Thành viên trong nhóm: Châu Nhật Tài, Lê Văn Toàn
Ngày tạo: 06/05/2024
STORE PROCEDURE
*/

USE QLST;
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
	
