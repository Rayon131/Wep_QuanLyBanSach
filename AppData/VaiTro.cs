namespace AppData
{
    public class VaiTro
    {
        public int Id { get; set; }
        public string TenVaiTro { get; set; }
        public bool? TrangThai { get; set; }

        // Quan hệ với bảng NhanVien (1:N)
        public ICollection<NhanVien> NhanViens { get; set; }
    }

}
