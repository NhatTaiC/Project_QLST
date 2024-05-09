/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 29/04/2024
* BUS_SanPham.cs
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
    public class BUS_SanPham
    {
        // Fields
        private DAL_SanPham dal_sp = new DAL_SanPham();

        // Methods
        // LayDSSP()
        public IQueryable LayDSSP()
        {
            return dal_sp.LayDSSP();
        }

        // LayDSSP_TheoMaSP()
        public IQueryable LayDSSP_TheoMaSP(string maSP)
        {
            return dal_sp.LayDSSP_TheoMaSP(maSP);
        }

        // ThemSP()
        public bool ThemSP(DTO_SanPham sp)
        {
            return dal_sp.ThemSP(sp);
        }

        // XoaSP()
        public bool XoaSP(string maSP)
        {
            return dal_sp.XoaSP(maSP);
        }

        // SuaSP()
        public bool SuaSP(DTO_SanPham sp)
        {
            return dal_sp.SuaSP(sp);
        }

        // TimSP_TheoTenSP()
        public IQueryable TimSP_TheoTenSP(string tenSP)
        {
            return dal_sp.TimSP_TheoTenSP(tenSP);
        }

        // TimSP_TheoMaSP()
        public IQueryable TimSP_TheoMaSP(string maSP)
        {
            return dal_sp.TimSP_TheoMaSP(maSP);
        }

        // NhomSP_TheoGiaBan()
        public IQueryable NhomSP_TheoGiaBan()
        {
            return dal_sp.NhomSP_TheoGiaBan();
        }

        // NhomSP_TheoDonViTinh()
        public IQueryable NhomSP_TheoDonViTinh()
        {
            return dal_sp.NhomSP_TheoDonViTinh();
        }

        // TimSP_TheoGiaBan()
        public IQueryable TimSP_TheoGiaBan(string giaBan)
        {
            return dal_sp.TimSP_TheoGiaBan(giaBan);
        }

        // TimSP_TheoDonViTinh()
        public IQueryable TimSP_TheoDonViTinh(string donViTinh)
        {
            return dal_sp.TimSP_TheoDonViTinh(donViTinh);
        }

        // LayDSSP_2()
        public IQueryable LayDSSP_2()
        {
            return dal_sp.LayDSSP_2();
        }

        // TimSP_TheoTenSP_2()
        public IQueryable TimSP_TheoTenSP_2(string tenSP)
        {
            return dal_sp.TimSP_TheoTenSP_2(tenSP);
        }

        // TimSP_TheoMaSP_2()
        public IQueryable TimSP_TheoMaSP_2(string maSP)
        {
            return dal_sp.TimSP_TheoMaSP_2(maSP);
        }

        // TimSP_TheoMaSP_3()
        public int TimSP_TheoMaSP_3(string maSP)
        {
            return dal_sp.TimSP_TheoMaSP_3(maSP);
        }

        // TimSP_TheoTenSP_3()
        public int TimSP_TheoTenSP_3(string tenSP)
        {
            return dal_sp.TimSP_TheoTenSP_3(tenSP);
        }

        // CheckSP_TheoMaSP()
        public int CheckSP_TheoMaSP(string maSP) {
            return dal_sp.CheckSP_TheoMaSP(maSP);
        }
    }
}
