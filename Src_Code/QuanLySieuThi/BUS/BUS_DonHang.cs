/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 28/04/2024
 * BUS_DonHang.cs
 */
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DonHang
    {
        // Fields
        private DAL_DonHang dal_dh = new DAL_DonHang();

        // Methods
        // LayDSDH()
        public IQueryable LayDSDH()
        {
            return dal_dh.LayDSDonHang();
        }

        // ThemDH()
        public bool ThemDH(DTO_DonHang dh)
        {
            return dal_dh.ThemDonHang(dh);
        }

        // XoaDH()
        public bool XoaDH(string maDonHang)
        {
            return dal_dh.XoaDonHang(maDonHang);
        }

        // SuaDH()
        public bool SuaDH(DTO_DonHang dh)
        {
            return dal_dh.SuaDonHang(dh);
        }

        // TimDonHang_TheoMaDonHang()
        public IQueryable TimDonHang_TheoMaDonHang(string maDH)
        {
            return dal_dh.TimDonHang_TheoMaDH(maDH);
        }

        // TimDonHang_TheoMaNV()
        public IQueryable TimDonHang_TheoMaNV(string maNV)
        {
            return dal_dh.TimDonHang_TheoMaNV(maNV);
        }

        // TimDonHang_TheoNgayBan()
        public int TimDonHang_TheoNgayBan(DateTime ngayBan)
        {
            return dal_dh.TimDonHang_TheoNgayBan(ngayBan);
        }

        // TimDonHang_TheoTenNV()
        public int TimDonHang_TheoTenNV(string tenNV)
        {
            return dal_dh.TimDonHang_TheoTenNV(tenNV);
        }

        // TimDonHang_TheoMaDH_2()
        public int TimDonHang_TheoMaDH_2(string maDH) {
            return dal_dh.TimDonHang_TheoMaDH_2(maDH);
        }

        // CheckDH_TheoMaDH()
        public int CheckDH_TheoMaDH(string maDon) {
            return dal_dh.CheckDH_TheoMaDH(maDon);
        }
    }
}
