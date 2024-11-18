using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class TheLoai
    {
        public int Id { get; set; }
        public string TenTheLoai { get; set; }

        // Quan hệ với bảng Sachs (1:N)
        public ICollection<Sach> Sachs { get; set; }
    }

}
