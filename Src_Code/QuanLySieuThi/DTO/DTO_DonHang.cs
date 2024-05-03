/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 28/04/2024
 * DTO_DonHang.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonHang
    {
        // Fields
        private string maDon;
        private DateTime ngayBan;
        private int tongGiaTri;
        private string maNV;

        // Constructors
        public DTO_DonHang(string maDon, DateTime ngayBan, int tongGiaTri, string maNV)
        {
            this.maDon = maDon;
            this.ngayBan = ngayBan;
            this.tongGiaTri = tongGiaTri;
            this.maNV = maNV;
        }

        // Properties
        public string MaDon { get => maDon; set => maDon = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }
        public int TongGiaTri { get => tongGiaTri; set => tongGiaTri = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
