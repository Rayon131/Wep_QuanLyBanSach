using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class NhanVien
    {
        public int Id { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string CCCD { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public bool? GioiTinh { get; set; }
        public int? IdVaiTro { get; set; }
        public VaiTro VaiTro { get; set; }

        // Quan hệ với bảng HoaDons (1:N)
        public ICollection<HoaDon> HoaDons { get; set; }

        // Quan hệ với bảng DonHangs (1:N)
        public ICollection<DonHang> DonHangs { get; set; }
    }


}
