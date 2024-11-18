using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class PhieuNhap
    {
        [Key]
        public int MaPhieuNhap { get; set; }
        [Required]
        public DateTime? NgayNhap { get; set; }
        public decimal? TongTien { get; set; }
        public int? IdNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }

        public int? IdNhaCungCap { get; set; }
        public NhaCungCap NhaCungCap { get; set; }

        // Quan hệ với bảng PhieuNhapCTs (1:N)
        public ICollection<PhieuNhapCT> PhieuNhapCTs { get; set; }
    }

}
