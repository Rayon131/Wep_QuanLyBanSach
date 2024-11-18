using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class SachCT
    {
        public int Id { get; set; }
        public string MaSachCT { get; set; }
        public int SoLuong { get; set; }
        public bool? TrangThai { get; set; }
        public decimal? GiaBan { get; set; }
        public int? Tap { get; set; }

        // Quan hệ với bảng Sach (N:1)
        public int? IdSach { get; set; }
        public Sach Sach { get; set; }

        // Quan hệ với bảng HoaDonCTs (1:N)
        public ICollection<HoaDonCT> HoaDonCTs { get; set; }

        // Quan hệ với bảng PhieuNhapCTs (1:N)
        public ICollection<PhieuNhapCT> PhieuNhapCTs { get; set; }
    }

}
