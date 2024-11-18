using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class KhachHang
    {
        public int Id { get; set; }
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public int? AccountId { get; set; }
        public Account Account { get; set; }

        // Quan hệ với bảng DonHangs (1:N)
        public ICollection<DonHang> DonHangs { get; set; }
    }

}
