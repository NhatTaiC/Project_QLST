/*
* Châu Nhật Tài, Lê Văn Toàn
* Project CN.NET
* Quản Lý Siêu Thị
* 29/04/2024
* BUS_NhaCungCap.cs
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
    public class BUS_NhaCungCap
    {
        // Fields
        private DAL_NhaCungCap dal_ncc = new DAL_NhaCungCap();

        // Methods
        // LayDSNCC()
        public IQueryable LayDSNCC() {
            return dal_ncc.LayDSNCC();
        }

        // LayDSNCC_TheoMaNCC()
        public IQueryable LayDSNCC_TheoMaNCC(string maNCC) {
            return dal_ncc.LayDSNCC_TheoMaNCC(maNCC);
        }

        // ThemNCC()
        public bool ThemNCC(DTO_NhaCungCap ncc) {
            return dal_ncc.ThemNCC(ncc);
        }

        // XoaNCC()
        public bool XoaNCC(string maNCC) {
            return dal_ncc.XoaNCC(maNCC);
        }

        // SuaNCC()
        public bool SuaNCC(DTO_NhaCungCap ncc) {
            return dal_ncc.SuaNCC(ncc);
        }

        // LayDSNCC_TheoTenNCC()
        public IQueryable LayDSNCC_TheoTenNCC(string maNCC) {
            return dal_ncc.LayDSNCC_TheoTenNCC(maNCC);
        }

        // TimNCC_TheoTenNCC()
        public IQueryable TimNCC_TheoTenNCC(string tenNCC) {
            return dal_ncc.TimNCC_TheoTenNCC(tenNCC);
        }

        // TimNCC_TheoMaNCC()
        public IQueryable TimNCC_TheoMaNCC(string maNCC) {
            return dal_ncc.TimNCC_TheoMaNCC(maNCC);
        }
    }
}
