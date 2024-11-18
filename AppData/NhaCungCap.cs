using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class NhaCungCap
    {
        public int Id { get; set; }
        public string TenNhaCungCap { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        // Quan hệ với bảng PhieuNhap (1:N)
        public ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }

}
