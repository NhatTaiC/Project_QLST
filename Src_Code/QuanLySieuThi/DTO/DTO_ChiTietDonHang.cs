/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 28/04/2024
 * DTO_ChiTietDonHang.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietDonHang
    {
        // Fields
        private string maChiTiet;
        private string maDon;
        private string maSP;
        private string tenSP;
        private int giaBan;
        private int soLuong;
        private int thanhTien;
        private string donViTinh;

        // Constructors
        public DTO_ChiTietDonHang(string maChiTiet, string maDon, string maSP, string tenSP, int giaBan, int soLuong, int thanhTien, string donViTinh)
        {
            this.maChiTiet = maChiTiet;
            this.maDon = maDon;
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.giaBan = giaBan;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
            this.donViTinh = donViTinh;
        }

        // Properties
        public string MaChiTiet { get => maChiTiet; set => maChiTiet = value; }
        public string MaDon { get => maDon; set => maDon = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
    }
}
