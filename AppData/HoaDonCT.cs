using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class HoaDonCT
    {
        public int Id { get; set; }
        public decimal? Gia { get; set; }
        public int? SoLuong { get; set; }
        public int? IdHoaDon { get; set; }
        public HoaDon HoaDon { get; set; }

        public int? IdSachCT { get; set; }
        public SachCT SachCT { get; set; }
    }

}
