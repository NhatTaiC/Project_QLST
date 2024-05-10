/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 22/04/2024
 * BUS_NhanVien.cs
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
    public class BUS_NhanVien
    {
        // Fields
        private DAL_NhanVien dal_nv = new DAL_NhanVien();

        // Methods
        // LayDSNV()
        public IQueryable LayDSNV()
        {
            return dal_nv.LayDSNV();
        }

        // ThemNV()
        public bool ThemNV(DTO_NhanVien nv)
        {
            return dal_nv.ThemNV(nv);
        }

        // XoaNV()
        public bool XoaNV(string nv, string tk)
        {
            return dal_nv.XoaNV(nv, tk);
        }

        // SuaNV()
        public bool SuaNV(DTO_NhanVien nv)
        {
            return dal_nv.SuaNV(nv);
        }

        // LayDSNV_TheoMaNV()
        public IQueryable LayDSNV_TheoMaNV(string nv)
        {
            return dal_nv.LayDSNV_TheoMaNV(nv);
        }

        // LayDSNV_TheoMaNV2()
        public int LayDSNV_TheoMaNV2(string nv)
        {
            return dal_nv.LayDSNV_TheoMaNV2(nv);
        }

        // TimNV_TheoTenNV()
        public IQueryable TimNV_TheoTenNV(string tenNV)
        {
            return dal_nv.TimNV_TheoTenNV(tenNV);
        }

        // TimNV_TheoMaNV()
        public IQueryable TimNV_TheoMaNV(string maNV)
        {
            return dal_nv.TimNV_TheoMaNV(maNV);
        }

        // TimNV_TheoGioiTinh()
        public IQueryable TimNV_TheoGioiTinh(string gioiTinh)
        {
            return dal_nv.TimNV_TheoGioiTinh(gioiTinh);
        }

        // TimNV_TheoNamSinh()
        public IQueryable TimNV_TheoNamSinh(string namSinh) {
            return dal_nv.TimNV_TheoNamSinh(namSinh);
        }

        // TimNV_TheoTenNV_2()
        public IQueryable TimNV_TheoTenNV_2(string tenNV)
        {
            return dal_nv.TimNV_TheoTenNV_2(tenNV);
        }

        // TimNV_TheoMaNV_2()
        public IQueryable TimNV_TheoMaNV_2(string maNV)
        {
            return dal_nv.TimNV_TheoMaNV_2(maNV);
        }

        // CheckNV_TheoMaNV()
        public int CheckNV_TheoMaNV(string maNV) {
            return dal_nv.CheckNV_TheoMaNV(maNV);
        }

    }
}
