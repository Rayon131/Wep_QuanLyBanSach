using System;
using System.Collections.Generic;

namespace AppData;

public class DonHang
{
    public int DonHangId { get; set; }
    public DateTime? NgayDatHang { get; set; }
    public decimal? TongTien { get; set; }
    public bool? TrangThai { get; set; }
    public string PhuongThucThanhToan { get; set; }
    public string DiaChi { get; set; }

    public int? IdKhachHang { get; set; }
    public KhachHang KhachHang { get; set; }

    public int? IdNhanVien { get; set; }
    public NhanVien NhanVien { get; set; }

    // Quan hệ với bảng chiTietDons (1:N)
    public ICollection<ChiTietDon> ChiTietDons { get; set; }
}

