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
        public bool ThemTK(DTO_TaiKhoan tk)
        {
            return db.ThemTK(tk);
        }

        // XoaTK()
        public bool XoaTK(string tk)
        {
            return db.XoaTK(tk);
        }

        // SuaTK()
        public bool SuaTK(DTO_TaiKhoan tk)
        {
            return db.SuaTK(tk);
        }

        // LayDSTK_TheoTK()
        public IQueryable LayDSTK_TheoTK(string tk)
        {
            return db.LayDSTK_TheoTK(tk);
        }

        // LayDSNV()
        public IQueryable LayDSNV()
        {
            return db.LayDSNV();
        }

        // ThemNV()
        public bool ThemNV(DTO_NhanVien nv)
        {
            return db.ThemNV(nv);
        }

        // XoaNV()
        public bool XoaNV(string nv, string tk)
        {
            return db.XoaNV(nv, tk);
        }

        // SuaNV()
        public bool SuaNV(DTO_NhanVien nv)
        {
            return db.SuaNV(nv);
        }

        // LayDSNV_TheoMaNV()
        public IQueryable LayDSNV_TheoMaNV()
        {
            return db.LayDSNV_TheoMaNV();
        }
    }
}
