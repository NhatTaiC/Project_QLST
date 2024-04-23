using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NCC
    {
        private string maNCC, tenNCC, diaChiNCC, sdtNCC;

        public DTO_NCC(string maNCC, string tenNCC, string diaChiNCC, string sdtNCC)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChiNCC = diaChiNCC;
            this.sdtNCC = sdtNCC;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChiNCC { get => diaChiNCC; set => diaChiNCC = value; }
        public string SdtNCC { get => sdtNCC; set => sdtNCC = value; }
    }
}
