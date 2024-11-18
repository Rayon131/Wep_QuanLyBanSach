using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public MyDbContext(){}
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<NgonNgu> NgonNgus { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<SachCT> SachCTs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonCT> HoaDonCTs { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; } 
        public DbSet<PhieuNhapCT> PhieuNhapCTs { get; set; }
        public DbSet<TacGia> tacGias { get; set; }
        public DbSet<DonHang> donHangs { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<ChiTietDon> chiTietDons { get; set; }
        
        // Cấu hình chuỗi kết nối đến cơ sở dữ liệu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=NOONE\MSSQLSERVER02;Database=BookStore02;Trusted_Connection=True;TrustServerCertificate=True");
        }

        // Cấu hình các mối quan hệ
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships and constraints here

            // TacGia - Sach (1:N)
            modelBuilder.Entity<Sach>()
                .HasOne(s => s.TacGia)
                .WithMany(tg => tg.Sachs)
                .HasForeignKey(s => s.IdTacGia);

            // NhaXuatBan - Sach (1:N)
            modelBuilder.Entity<Sach>()
                .HasOne(s => s.NhaXuatBan)
                .WithMany(nxb => nxb.Sachs)
                .HasForeignKey(s => s.IdNXB);

            // TheLoai - Sach (1:N)
            modelBuilder.Entity<Sach>()
                .HasOne(s => s.TheLoai)
                .WithMany(tl => tl.Sachs)
                .HasForeignKey(s => s.IdTheLoai);

            // NgonNgu - Sach (1:N)
            modelBuilder.Entity<Sach>()
                .HasOne(s => s.NgonNgu)
                .WithMany(nn => nn.Sachs)
                .HasForeignKey(s => s.IdNgonNgu);

            // SachCT - Sach (N:1)
            modelBuilder.Entity<SachCT>()
                .HasOne(sc => sc.Sach)
                .WithMany(s => s.SachCTs)
                .HasForeignKey(sc => sc.IdSach);

            // HoaDon - KhachHang (N:1)
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.KhachHang)
                .WithMany()
                .HasForeignKey(hd => hd.IdKhachHang);

            // HoaDon - NhanVien (N:1)
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.NhanVien)
                .WithMany(nv => nv.HoaDons)
                .HasForeignKey(hd => hd.IdNhanVien);

            // HoaDonCT - HoaDon (N:1)
            modelBuilder.Entity<HoaDonCT>()
                .HasOne(hdct => hdct.HoaDon)
                .WithMany(hd => hd.HoaDonCTs)
                .HasForeignKey(hdct => hdct.IdHoaDon);

            // HoaDonCT - SachCT (N:1)
            modelBuilder.Entity<HoaDonCT>()
                .HasOne(hdct => hdct.SachCT)
                .WithMany(sc => sc.HoaDonCTs)
                .HasForeignKey(hdct => hdct.IdSachCT);

            // DonHang - KhachHang (N:1)
            modelBuilder.Entity<DonHang>()
                .HasOne(dh => dh.KhachHang)
                .WithMany(kh => kh.DonHangs)
                .HasForeignKey(dh => dh.IdKhachHang);

            // DonHang - NhanVien (N:1)
            modelBuilder.Entity<DonHang>()
                .HasOne(dh => dh.NhanVien)
                .WithMany(nv => nv.DonHangs)
                .HasForeignKey(dh => dh.IdNhanVien);

            // ChiTietDon - DonHang (N:1)
            modelBuilder.Entity<ChiTietDon>()
                .HasOne(ctd => ctd.DonHang)
                .WithMany(dh => dh.ChiTietDons)
                .HasForeignKey(ctd => ctd.DonHangId);

            // ChiTietDon - SachCT (N:1)
            modelBuilder.Entity<ChiTietDon>()
                .HasOne(ctd => ctd.SachCT)
                .WithMany()
                .HasForeignKey(ctd => ctd.SachCTId);

            // NhaCungCap - PhieuNhap (1:N)
            modelBuilder.Entity<PhieuNhap>()
                .HasOne(pn => pn.NhaCungCap)
                .WithMany(ncc => ncc.PhieuNhaps)
                .HasForeignKey(pn => pn.IdNhaCungCap);

            // NhanVien - PhieuNhap (N:1)
            modelBuilder.Entity<PhieuNhap>()
                .HasOne(pn => pn.NhanVien)
                .WithMany()
                .HasForeignKey(pn => pn.IdNhanVien);

            // PhieuNhapCT - PhieuNhap (N:1)
            modelBuilder.Entity<PhieuNhapCT>()
                .HasOne(pnct => pnct.PhieuNhap)
                .WithMany(pn => pn.PhieuNhapCTs)
                .HasForeignKey(pnct => pnct.IdPhieuNhap);

            // PhieuNhapCT - SachCT (N:1)
            modelBuilder.Entity<PhieuNhapCT>()
                .HasOne(pnct => pnct.SachCT)
                .WithMany(sc => sc.PhieuNhapCTs)
                .HasForeignKey(pnct => pnct.IdSachCT);

            // VaiTro - NhanVien (1:N)
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.VaiTro)
                .WithMany(vt => vt.NhanViens)
                .HasForeignKey(nv => nv.IdVaiTro);
        }
    }
}
