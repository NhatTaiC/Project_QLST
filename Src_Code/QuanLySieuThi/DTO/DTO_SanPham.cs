/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 29/04/2024
 * DTO_SanPham.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SanPham
    {
        // Fields
        private string maSP;
        private string tenSP;
        private int giaNhap;
        private int giaBan;
        private int soLuong;
        private string donViTinh;
        private string noiSanXuat;
        private DateTime hanSuDung;
        private string maNCC;
        private string maLoaiSP;

        // Constructors
        public DTO_SanPham(string maSP, string tenSP, int giaNhap, int giaBan, int soLuong, string donViTinh, string noiSanXuat, DateTime hanSuDung, string maNCC, string maLoaiSP)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.giaNhap = giaNhap;
            this.giaBan = giaBan;
            this.soLuong = soLuong;
            this.donViTinh = donViTinh;
            this.noiSanXuat = noiSanXuat;
            this.hanSuDung = hanSuDung;
            this.maNCC = maNCC;
            this.maLoaiSP = maLoaiSP;
        }

        // Properties
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int GiaNhap { get => giaNhap; set => giaNhap = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string NoiSanXuat { get => noiSanXuat; set => noiSanXuat = value; }
        public DateTime HanSuDung { get => hanSuDung; set => hanSuDung = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
    }
}
