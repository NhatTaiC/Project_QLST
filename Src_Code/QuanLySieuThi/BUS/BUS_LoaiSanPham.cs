/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 29/04/2024
* BUS_LoaiSanPham.cs
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
    public class BUS_LoaiSanPham
    {
        // Fields
        private DAL_LoaiSanPham dal_lsp = new DAL_LoaiSanPham();

        //Methods
        // LayDSLSP()
        public IQueryable LayDSLSP() {
            return dal_lsp.LayDSLSP();
        }

        // LayDSLSP_TheoMaLSP()
        public IQueryable LayDSLSP_TheoMaLSP(string maLSP) {
            return dal_lsp.LayDSLSP_TheoMaLSP(maLSP);
        }

        // ThemLSP()
        public bool ThemLSP(DTO_LoaiSanPham lsp) {
            return dal_lsp.ThemLSP(lsp);
        }

        // XoaLSP()
        public bool XoaLSP(string maLSP) {
            return dal_lsp.XoaLSP(maLSP);
        }

        // SuaLSP()
        public bool SuaLSP(DTO_LoaiSanPham lsp) {
            return dal_lsp.SuaLSP(lsp);
        }

        // LayDSLSP_TheoTenLSP()
        public IQueryable LayDSLSP_TheoTenLSP(string maLSP) {
            return dal_lsp.LayDSLSP_TheoTenLSP(maLSP);
        }

        // TimLSP_TheoTenLSP()
        public IQueryable TimLSP_TheoTenLSP(string tenLSP) {
            return dal_lsp.TimLSP_TheoTenLSP(tenLSP);
        }

        // TimLSP_TheoMaLSP()
        public IQueryable TimLSP_TheoMaLSP(string maLSP) {
            return dal_lsp.TimLSP_TheoMaLSP(maLSP);
        }
    }
}
