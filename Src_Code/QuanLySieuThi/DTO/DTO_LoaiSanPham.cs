/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 29/04/2024
 * DTO_LoaiSanPham.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiSanPham
    {
        // Fields
        private string maLoaiSP;
        private string tenLoaiSP;
        private string moTa;

        // Constructors
        public DTO_LoaiSanPham(string maLoaiSP, string tenLoaiSP, string moTa)
        {
            this.maLoaiSP = maLoaiSP;
            this.tenLoaiSP = tenLoaiSP;
            this.moTa = moTa;
        }

        // Properties
        public string MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public string TenLoaiSP { get => tenLoaiSP; set => tenLoaiSP = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
