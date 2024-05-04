/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 28/04/2024
 * BUS_ChiTietDonHang.cs
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
        private DAL_BanHang dal_bh = new DAL_BanHang();

        public IQueryable LayDSSP()
        {
            return dal_bh.LayDSSP();
        }

        public IQueryable TimSP_TheoMaSP(string maSP)
        {
            return dal_bh.LayDSSP_TheoMaSP(maSP);
        }

        public bool ThemChiTietDonHang(DTO_ChiTietDonHang ctdh)
        {
            return dal_bh.ThemChiTietDonHang(ctdh);
        }

        // XoaChiTietDonHang()
        public bool XoaChiTietDonHang(DTO_ChiTietDonHang ctdh)
        {
            return dal_bh.XoaChiTietDonHang(ctdh);
        }

        public IQueryable LayDSCTDH()
        {
            return dal_bh.LayDSChiTietDonHang();
        }

        // SuaChiTietDonHang()
        public bool SuaChiTietDonHang(DTO_ChiTietDonHang ctdh)
        {
            return dal_bh.SuaChiTietDonHang(ctdh);
        }
    }
}
