/*
 * Châu Nhật Tài, Lê Văn Toàn
 * Project CN.NET
 * Quản Lý Siêu Thị
 * 29/04/2024
 * DTO_NhaCungCap.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCungCap
    {
        // Fields
        private string maNCC;
        private string tenNCC;
        private string diaChiNCC;
        private string sdtNCC;

        // Constructors
        public DTO_NhaCungCap(string maNCC, string tenNCC, string diaChiNCC, string sdtNCC)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChiNCC = diaChiNCC;
            this.sdtNCC = sdtNCC;
        }

        // Properties
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChiNCC { get => diaChiNCC; set => diaChiNCC = value; }
        public string SdtNCC { get => sdtNCC; set => sdtNCC = value; }
    }
}
