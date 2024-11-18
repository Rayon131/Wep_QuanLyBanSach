using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class NhaXuatBan
    {
        [Key]
        public int MaNXB { get; set; }
        [Required]
        public string TenNXB { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        // Quan hệ với bảng Sachs (1:N)
        public ICollection<Sach> Sachs { get; set; }
    }

}
