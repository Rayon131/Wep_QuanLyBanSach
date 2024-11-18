using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class PhieuNhapCT
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal? Gia { get; set; }
        public int? SoLuong { get; set; }

        public int? IdSachCT { get; set; }
        public SachCT SachCT { get; set; }

        public int? IdPhieuNhap { get; set; }
        public PhieuNhap PhieuNhap { get; set; }
    }

}
