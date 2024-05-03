/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 23/04/2024
 * DTO_NhanVien.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        // Fields
        private string maNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string soDT;
        private string taiKhoan;

        // Constructors
        public DTO_NhanVien(string maNV, string tenNV, DateTime ngaySinh, string gioiTinh, string diaChi, string soDT, string taiKhoan)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.taiKhoan = taiKhoan;
        }

        // Properties
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
    }
}
