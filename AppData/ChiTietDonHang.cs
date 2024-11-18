using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppData;
public class ChiTietDon
{
    [Key]
    public int ChiTietDonHangId { get; set; }
    [Required]
    public int? DonHangId { get; set; }
    public DonHang DonHang { get; set; }

    public int? SachCTId { get; set; }
    public SachCT SachCT { get; set; }

    public decimal? Gia { get; set; }
}
