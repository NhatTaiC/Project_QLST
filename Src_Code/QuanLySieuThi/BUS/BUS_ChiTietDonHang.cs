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
    public class BUS_ChiTietDonHang
    {
        // Fields
        private DAL_ChiTietDonHang dal_ctdh = new DAL_ChiTietDonHang();

        // Methods
        // LayDSCTDH()
        public IQueryable LayDSCTDH() {
            return dal_ctdh.LayDSChiTietDonHang();
        }

        // ThemChiTietDonHang()
        public bool ThemChiTietDonHang(DTO_ChiTietDonHang ctdh) {
            return dal_ctdh.ThemChiTietDonHang(ctdh);
        }

        // XoaChiTietDonHang()
        public bool XoaChiTietDonHang(string ctdh) {
            return dal_ctdh.XoaChiTietDonHang(ctdh);
        }

        // SuaChiTietDonHang()
        public bool SuaChiTietDonHang(DTO_ChiTietDonHang ctdh) {
            return dal_ctdh.SuaChiTietDonHang(ctdh);
        }
    }
}
