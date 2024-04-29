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
        public IQueryable LayDSSP() {
            return dal_sp.LayDSSP();
        }

        // LayDSSP_TheoMaSP()
        public IQueryable LayDSSP_TheoMaSP(string maSP) {
            return dal_sp.LayDSSP_TheoMaSP(maSP);
        }

        // ThemSP()
        public bool ThemSP(DTO_SanPham sp) {
            return dal_sp.ThemSP(sp);
        }

        // XoaSP()
        public bool XoaSP(string maSP) {
            return dal_sp.XoaSP(maSP);
        }

        // SuaSP()
        public bool SuaSP(DTO_SanPham sp) {
            return dal_sp.SuaSP(sp);
        }
    }
}
