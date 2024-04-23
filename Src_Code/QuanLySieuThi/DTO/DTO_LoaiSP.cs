using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiSP
    {
        private string maLSP, tenLSP, moTa;

        public DTO_LoaiSP(string maLSP, string tenLSP, string moTa)
        {
            this.maLSP = maLSP;
            this.tenLSP = tenLSP;
            this.moTa = moTa;
        }

        public string MaLSP { get => maLSP; set => maLSP = value; }
        public string TenLSP { get => tenLSP; set => tenLSP = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
