using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class TacGia
    {
        public int Id { get; set; }
        public string MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

        // Quan hệ với bảng Sachs (1:N)
        public ICollection<Sach> Sachs { get; set; }
    }

}
