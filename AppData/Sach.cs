using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class Sach
    {
        public int Id { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuongTon { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public int? Tongtap { get; set; }
        public bool? TrangThai { get; set; }

        // Quan hệ với các bảng
        public int? IdTacGia { get; set; }
        public TacGia TacGia { get; set; }

        public int? IdNXB { get; set; }
        public NhaXuatBan NhaXuatBan { get; set; }

        public int? IdTheLoai { get; set; }
        public TheLoai TheLoai { get; set; }

        public int? IdNgonNgu { get; set; }
        public NgonNgu NgonNgu { get; set; }

        // Quan hệ với bảng SachCT (1:N)
        public ICollection<SachCT> SachCTs { get; set; }
    }

}
