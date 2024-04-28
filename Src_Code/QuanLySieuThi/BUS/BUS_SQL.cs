/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 22/04/2024
 * BUS_SQL.cs
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
    public class BUS_SQL
    {
        // Fields
        private DbSql db = new DbSql();

        // Methods
        // LayDSTK()
        public IQueryable LayDSTK()
        {
            return db.LayDSTK();
        }

        // ThemTK()
        public bool ThemTK(DTO_TaiKhoan tk) {
            return db.ThemTK(tk);
        }

        // XoaTK()
        public bool XoaTK(string tk) {
            return db.XoaTK(tk);
        }

        // SuaTK()
        public bool SuaTK(DTO_TaiKhoan tk) {
            return db.SuaTK(tk);
        }

        // LayDSTK_TheoTK()
        public IQueryable LayDSTK_TheoTK(string tk) {
            return db.LayDSTK_TheoTK(tk);
        }

        //LoaiSP
        //Lay DS loai SP
        public IQueryable LayDSLoaiSP()
        {
            return db.LayDSLoaiSP();
        }

        // ThemLoaiSP()
        public bool ThemLoaiSP(DTO_LoaiSP lsp)
        {
            return db.ThemLoaiSP(lsp);
        }

        // XoaLoaiTK()
        public bool XoaLoaiSP(string maLoaiSP)
        {
            return db.XoaLoaiSP(maLoaiSP);
        }

        // SuaLoaiTK)
        public bool SuaLoaiSP(DTO_LoaiSP lsp)
        {
            return db.SuaLoaiSP(lsp);
        }

        // LayDSLSP_TheoMaSP()
        public IQueryable LayDSLSP_TheoMaLSP(string maLoaiSP)
        {
            return db.LayDSLSP_TheoMaLSP(maLoaiSP);
        }


        //NCC
        //Lay DS NCC
        public IQueryable LayDSNCC()
        {
            return db.LayDSNCC();
        }

        // ThemLoaiSP()
        public bool ThemNCC(DTO_NCC ncc)
        {
            return db.ThemNCC(ncc);
        }

        // XoaLoaiTK()
        public bool XoaNCC(string maNCC)
        {
            return db.XoaNCC(maNCC);
        }

        // SuaLoaiTK)
        public bool SuaNCC(DTO_NCC ncc)
        {
            return db.SuaNCC(ncc);
        }

        // LayDSLSP_TheoMaSP()
        public IQueryable LayDSNCC_TheoMaNCC(string maNCC)
        {
            return db.LayDSNCC_TheoMaNCC(maNCC);
        }


        //NCC
        //Lay DS NCC
        public IQueryable LayDSSP()
        {
            return db.LayDSSP();
        }

        // ThemLoaiSP()
        public bool ThemSP(DTO_SanPham sp)
        {
            return db.ThemSP(sp);
        }

        // XoaLoaiTK()
        public bool XoaSP(string maSP)
        {
            return db.XoaSP(maSP);
        }

        // SuaLoaiTK)
        public bool SuaSP(DTO_SanPham sp)
        {
            return db.SuaSP(sp);
        }

        // LayDSLSP_TheoMaSP()
        public IQueryable LayDSSP_TheoMaSP(string maSP)
        {
            return db.LayDSSP_TheoMaSP(maSP);
        }
    }
}
