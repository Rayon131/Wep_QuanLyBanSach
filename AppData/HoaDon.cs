using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class HoaDon
    {
        public int Id { get; set; }
        public DateTime? NgayXuatHang { get; set; }
        public decimal? TongTien { get; set; }
        public int? IdKhachHang { get; set; }
        public KhachHang KhachHang { get; set; }

        public int? IdNhanVien { get; set; }
        public NhanVien NhanVien { get; set; }

        // Quan hệ với bảng HoaDonCTs (1:N)
        public ICollection<HoaDonCT> HoaDonCTs { get; set; }
    }

}
