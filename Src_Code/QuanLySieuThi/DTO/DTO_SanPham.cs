using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_SanPham
    {
        private string maSP, tenSP, donViTinh, noiSanXuat, maNCC, maLoaiSP, hanSuDung;
        private int giaNhap, giaBan, soLuong;

        public DTO_SanPham(string maSP, string tenSP, int giaNhap, int giaBan, int soLuong, string donViTinh, string noiSanXuat, string hanSuDung, string maNCC, string maLoaiSP)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donViTinh = donViTinh;
            this.noiSanXuat = noiSanXuat;
            this.maNCC = maNCC;
            this.maLoaiSP = maLoaiSP;
            this.hanSuDung = hanSuDung;
            this.giaNhap = giaNhap;
            this.giaBan = giaBan;
            this.soLuong = soLuong;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string NoiSanXuat { get => noiSanXuat; set => noiSanXuat = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public string HanSuDung { get => hanSuDung; set => hanSuDung = value; }
        public int GiaNhap { get => giaNhap; set => giaNhap = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
