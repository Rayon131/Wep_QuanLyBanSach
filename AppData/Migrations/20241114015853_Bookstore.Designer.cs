﻿// <auto-generated />
using System;
using AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppData.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241114015853_Bookstore")]
    partial class Bookstore
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppData.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NhanVienId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("AppData.ChiTietDon", b =>
                {
                    b.Property<int>("ChiTietDonHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChiTietDonHangId"));

                    b.Property<int?>("DonHangId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<decimal?>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SachCTId")
                        .HasColumnType("int");

                    b.HasKey("ChiTietDonHangId");

                    b.HasIndex("DonHangId");

                    b.HasIndex("SachCTId");

                    b.ToTable("chiTietDons");
                });

            modelBuilder.Entity("AppData.DonHang", b =>
                {
                    b.Property<int>("DonHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonHangId"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdKhachHang")
                        .HasColumnType("int");

                    b.Property<int?>("IdNhanVien")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayDatHang")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhuongThucThanhToan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("DonHangId");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("donHangs");
                });

            modelBuilder.Entity("AppData.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdKhachHang")
                        .HasColumnType("int");

                    b.Property<int?>("IdNhanVien")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayXuatHang")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("AppData.HoaDonCT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("IdHoaDon")
                        .HasColumnType("int");

                    b.Property<int?>("IdSachCT")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHoaDon");

                    b.HasIndex("IdSachCT");

                    b.ToTable("HoaDonCTs");
                });

            modelBuilder.Entity("AppData.KhachHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("AppData.NgonNgu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TenNgonNgu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NgonNgus");
                });

            modelBuilder.Entity("AppData.NhaCungCap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhaCungCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NhaCungCaps");
                });

            modelBuilder.Entity("AppData.NhaXuatBan", b =>
                {
                    b.Property<int>("MaNXB")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNXB"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNXB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNXB");

                    b.ToTable("NhaXuatBans");
                });

            modelBuilder.Entity("AppData.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<int?>("IdVaiTro")
                        .HasColumnType("int");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdVaiTro");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("AppData.PhieuNhap", b =>
                {
                    b.Property<int>("MaPhieuNhap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPhieuNhap"));

                    b.Property<int?>("IdNhaCungCap")
                        .HasColumnType("int");

                    b.Property<int?>("IdNhanVien")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayNhap")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaPhieuNhap");

                    b.HasIndex("IdNhaCungCap");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("PhieuNhaps");
                });

            modelBuilder.Entity("AppData.PhieuNhapCT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Gia")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("IdPhieuNhap")
                        .HasColumnType("int");

                    b.Property<int?>("IdSachCT")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPhieuNhap");

                    b.HasIndex("IdSachCT");

                    b.ToTable("PhieuNhapCTs");
                });

            modelBuilder.Entity("AppData.Sach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdNXB")
                        .HasColumnType("int");

                    b.Property<int?>("IdNgonNgu")
                        .HasColumnType("int");

                    b.Property<int?>("IdTacGia")
                        .HasColumnType("int");

                    b.Property<int?>("IdTheLoai")
                        .HasColumnType("int");

                    b.Property<string>("MaSach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<string>("TenSach")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Tongtap")
                        .HasColumnType("int");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdNXB");

                    b.HasIndex("IdNgonNgu");

                    b.HasIndex("IdTacGia");

                    b.HasIndex("IdTheLoai");

                    b.ToTable("Sachs");
                });

            modelBuilder.Entity("AppData.SachCT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("IdSach")
                        .HasColumnType("int");

                    b.Property<string>("MaSachCT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int?>("Tap")
                        .HasColumnType("int");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdSach");

                    b.ToTable("SachCTs");
                });

            modelBuilder.Entity("AppData.TacGia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaTacGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTacGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tacGias");
                });

            modelBuilder.Entity("AppData.TheLoai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TenTheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TheLoais");
                });

            modelBuilder.Entity("AppData.VaiTro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TenVaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("VaiTros");
                });

            modelBuilder.Entity("AppData.Account", b =>
                {
                    b.HasOne("AppData.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("NhanVienId");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("AppData.ChiTietDon", b =>
                {
                    b.HasOne("AppData.DonHang", "DonHang")
                        .WithMany("ChiTietDons")
                        .HasForeignKey("DonHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppData.SachCT", "SachCT")
                        .WithMany()
                        .HasForeignKey("SachCTId");

                    b.Navigation("DonHang");

                    b.Navigation("SachCT");
                });

            modelBuilder.Entity("AppData.DonHang", b =>
                {
                    b.HasOne("AppData.KhachHang", "KhachHang")
                        .WithMany("DonHangs")
                        .HasForeignKey("IdKhachHang");

                    b.HasOne("AppData.NhanVien", "NhanVien")
                        .WithMany("DonHangs")
                        .HasForeignKey("IdNhanVien");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("AppData.HoaDon", b =>
                {
                    b.HasOne("AppData.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKhachHang");

                    b.HasOne("AppData.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNhanVien");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("AppData.HoaDonCT", b =>
                {
                    b.HasOne("AppData.HoaDon", "HoaDon")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("IdHoaDon");

                    b.HasOne("AppData.SachCT", "SachCT")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("IdSachCT");

                    b.Navigation("HoaDon");

                    b.Navigation("SachCT");
                });

            modelBuilder.Entity("AppData.KhachHang", b =>
                {
                    b.HasOne("AppData.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("AppData.NhanVien", b =>
                {
                    b.HasOne("AppData.VaiTro", "VaiTro")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdVaiTro");

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("AppData.PhieuNhap", b =>
                {
                    b.HasOne("AppData.NhaCungCap", "NhaCungCap")
                        .WithMany("PhieuNhaps")
                        .HasForeignKey("IdNhaCungCap");

                    b.HasOne("AppData.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNhanVien");

                    b.Navigation("NhaCungCap");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("AppData.PhieuNhapCT", b =>
                {
                    b.HasOne("AppData.PhieuNhap", "PhieuNhap")
                        .WithMany("PhieuNhapCTs")
                        .HasForeignKey("IdPhieuNhap");

                    b.HasOne("AppData.SachCT", "SachCT")
                        .WithMany("PhieuNhapCTs")
                        .HasForeignKey("IdSachCT");

                    b.Navigation("PhieuNhap");

                    b.Navigation("SachCT");
                });

            modelBuilder.Entity("AppData.Sach", b =>
                {
                    b.HasOne("AppData.NhaXuatBan", "NhaXuatBan")
                        .WithMany("Sachs")
                        .HasForeignKey("IdNXB");

                    b.HasOne("AppData.NgonNgu", "NgonNgu")
                        .WithMany("Sachs")
                        .HasForeignKey("IdNgonNgu");

                    b.HasOne("AppData.TacGia", "TacGia")
                        .WithMany("Sachs")
                        .HasForeignKey("IdTacGia");

                    b.HasOne("AppData.TheLoai", "TheLoai")
                        .WithMany("Sachs")
                        .HasForeignKey("IdTheLoai");

                    b.Navigation("NgonNgu");

                    b.Navigation("NhaXuatBan");

                    b.Navigation("TacGia");

                    b.Navigation("TheLoai");
                });

            modelBuilder.Entity("AppData.SachCT", b =>
                {
                    b.HasOne("AppData.Sach", "Sach")
                        .WithMany("SachCTs")
                        .HasForeignKey("IdSach");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("AppData.DonHang", b =>
                {
                    b.Navigation("ChiTietDons");
                });

            modelBuilder.Entity("AppData.HoaDon", b =>
                {
                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("AppData.KhachHang", b =>
                {
                    b.Navigation("DonHangs");
                });

            modelBuilder.Entity("AppData.NgonNgu", b =>
                {
                    b.Navigation("Sachs");
                });

            modelBuilder.Entity("AppData.NhaCungCap", b =>
                {
                    b.Navigation("PhieuNhaps");
                });

            modelBuilder.Entity("AppData.NhaXuatBan", b =>
                {
                    b.Navigation("Sachs");
                });

            modelBuilder.Entity("AppData.NhanVien", b =>
                {
                    b.Navigation("DonHangs");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("AppData.PhieuNhap", b =>
                {
                    b.Navigation("PhieuNhapCTs");
                });

            modelBuilder.Entity("AppData.Sach", b =>
                {
                    b.Navigation("SachCTs");
                });

            modelBuilder.Entity("AppData.SachCT", b =>
                {
                    b.Navigation("HoaDonCTs");

                    b.Navigation("PhieuNhapCTs");
                });

            modelBuilder.Entity("AppData.TacGia", b =>
                {
                    b.Navigation("Sachs");
                });

            modelBuilder.Entity("AppData.TheLoai", b =>
                {
                    b.Navigation("Sachs");
                });

            modelBuilder.Entity("AppData.VaiTro", b =>
                {
                    b.Navigation("NhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
