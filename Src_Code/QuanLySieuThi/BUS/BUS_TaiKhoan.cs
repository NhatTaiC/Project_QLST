/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 22/04/2024
 * BUS_TaiKhoan.cs
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
    public class BUS_TaiKhoan
    {
        // Fields
        private DAL_TaiKhoan dal_tk = new DAL_TaiKhoan();

        // Methods
        // LayDSTK()
        public IQueryable LayDSTK()
        {
            return dal_tk.LayDSTK();
        }

        // ThemTK()
        public bool ThemTK(DTO_TaiKhoan tk)
        {
            return dal_tk.ThemTK(tk);
        }

        // XoaTK()
        public bool XoaTK(string tk)
        {
            return dal_tk.XoaTK(tk);
        }

        // SuaTK()
        public bool SuaTK(DTO_TaiKhoan tk)
        {
            return dal_tk.SuaTK(tk);
        }

        // LayDSTK_TheoTK()
        public IQueryable LayDSTK_TheoTK(string tk)
        {
            return dal_tk.LayDSTK_TheoTK(tk);
        }

        // LayDSTK_TheoChucVuAll()
        public IQueryable LayDSTK_TheoChucVuAll()
        {
            return dal_tk.LayDSTK_TheoChucVuAll();
        }

        // TimTaiKhoan_TheoTenNV()
        public IQueryable TimTaiKhoan_TheoTenNV(string tenNV)
        {
            return dal_tk.TimTaiKhoan_TheoTenNV(tenNV);
        }

        // TimTaiKhoan_TheoTaiKhoan()
        public IQueryable TimTaiKhoan_TheoTaiKhoan(string taiKhoan)
        {
            return dal_tk.TimTaiKhoan_TheoTaiKhoan(taiKhoan);
        }

        // TimTaiKhoan_TheoChucVu()
        public IQueryable TimTaiKhoan_TheoChucVu(string chucVu)
        {
            return dal_tk.TimTaiKhoan_TheoChucVu(chucVu);
        }

        // CheckTaiKhoan()
        public bool CheckTaiKhoan(string taiKhoan, string matKhau, string chucVu)
        {
            return dal_tk.CheckTaiKhoan(taiKhoan, matKhau, chucVu);
        }

        // CheckTaiKhoan_2()
        public int CheckTaiKhoan_2(string taiKhoan) {
            return dal_tk.CheckTaiKhoan_2(taiKhoan);
        }
    }
}
