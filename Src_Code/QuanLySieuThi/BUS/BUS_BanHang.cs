/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 09/05/2024
 * BUS_BanHang.cs
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
    public class BUS_BanHang
    {
        // Fields
        private DAL_BanHang dal_bh = new DAL_BanHang();

        // Methods
        // LayDSSP()
        public IQueryable LayDSSP()
        {
            return dal_bh.LayDSSP();
        }

        // LayDSSP_TheoMaSP
        public IQueryable LayDSSP_TheoMaSP(string maSP)
        {
            return dal_bh.LayDSSP_TheoMaSP(maSP);
        }

        // ThemChiTietDonHang
        public bool ThemChiTietDonHang(DTO_ChiTietDonHang ctdh)
        {
            return dal_bh.ThemChiTietDonHang(ctdh);
        }

        // XoaChiTietDonHang()
        public bool XoaChiTietDonHang(DTO_ChiTietDonHang ctdh)
        {
            return dal_bh.XoaChiTietDonHang(ctdh);
        }

        // LayDSCTDH
        public IQueryable LayDSCTDH(string maDon)
        {
            return dal_bh.LayDSChiTietDonHang(maDon);
        }

        // SuaChiTietDonHang()
        public bool SuaChiTietDonHang(DTO_ChiTietDonHang ctdh)
        {
            return dal_bh.SuaChiTietDonHang(ctdh);
        }

        // CapNhatGiaTriTongTien
        public void CapNhatGiaTriTongTien(string maDon, string tongTien)
        {
            dal_bh.CapNhatGiaTriTongTien(maDon, tongTien);
        }
    }
}
