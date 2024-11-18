using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppData.Migrations
{
    /// <inheritdoc />
    public partial class Bookstore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NgonNgus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNgonNgu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgonNgus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaCungCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhaXuatBans",
                columns: table => new
                {
                    MaNXB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNXB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaXuatBans", x => x.MaNXB);
                });

            migrationBuilder.CreateTable(
                name: "tacGias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenTacGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tacGias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VaiTros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenVaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tongtap = table.Column<int>(type: "int", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true),
                    IdTacGia = table.Column<int>(type: "int", nullable: true),
                    IdNXB = table.Column<int>(type: "int", nullable: true),
                    IdTheLoai = table.Column<int>(type: "int", nullable: true),
                    IdNgonNgu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sachs_NgonNgus_IdNgonNgu",
                        column: x => x.IdNgonNgu,
                        principalTable: "NgonNgus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sachs_NhaXuatBans_IdNXB",
                        column: x => x.IdNXB,
                        principalTable: "NhaXuatBans",
                        principalColumn: "MaNXB");
                    table.ForeignKey(
                        name: "FK_Sachs_TheLoais_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoais",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sachs_tacGias_IdTacGia",
                        column: x => x.IdTacGia,
                        principalTable: "tacGias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    IdVaiTro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanViens_VaiTros_IdVaiTro",
                        column: x => x.IdVaiTro,
                        principalTable: "VaiTros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SachCTs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSachCT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tap = table.Column<int>(type: "int", nullable: true),
                    IdSach = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SachCTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SachCTs_Sachs_IdSach",
                        column: x => x.IdSach,
                        principalTable: "Sachs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhanVienId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_accounts_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhaps",
                columns: table => new
                {
                    MaPhieuNhap = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IdNhanVien = table.Column<int>(type: "int", nullable: true),
                    IdNhaCungCap = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhaps", x => x.MaPhieuNhap);
                    table.ForeignKey(
                        name: "FK_PhieuNhaps_NhaCungCaps_IdNhaCungCap",
                        column: x => x.IdNhaCungCap,
                        principalTable: "NhaCungCaps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PhieuNhaps_NhanViens_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhachHangs_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhapCTs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    IdSachCT = table.Column<int>(type: "int", nullable: true),
                    IdPhieuNhap = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhapCTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuNhapCTs_PhieuNhaps_IdPhieuNhap",
                        column: x => x.IdPhieuNhap,
                        principalTable: "PhieuNhaps",
                        principalColumn: "MaPhieuNhap");
                    table.ForeignKey(
                        name: "FK_PhieuNhapCTs_SachCTs_IdSachCT",
                        column: x => x.IdSachCT,
                        principalTable: "SachCTs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "donHangs",
                columns: table => new
                {
                    DonHangId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayDatHang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true),
                    PhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdKhachHang = table.Column<int>(type: "int", nullable: true),
                    IdNhanVien = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donHangs", x => x.DonHangId);
                    table.ForeignKey(
                        name: "FK_donHangs_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_donHangs_NhanViens_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayXuatHang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IdKhachHang = table.Column<int>(type: "int", nullable: true),
                    IdNhanVien = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanViens_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "chiTietDons",
                columns: table => new
                {
                    ChiTietDonHangId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonHangId = table.Column<int>(type: "int", nullable: false),
                    SachCTId = table.Column<int>(type: "int", nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietDons", x => x.ChiTietDonHangId);
                    table.ForeignKey(
                        name: "FK_chiTietDons_SachCTs_SachCTId",
                        column: x => x.SachCTId,
                        principalTable: "SachCTs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chiTietDons_donHangs_DonHangId",
                        column: x => x.DonHangId,
                        principalTable: "donHangs",
                        principalColumn: "DonHangId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCTs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    IdHoaDon = table.Column<int>(type: "int", nullable: true),
                    IdSachCT = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonCTs_HoaDons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDonCTs_SachCTs_IdSachCT",
                        column: x => x.IdSachCT,
                        principalTable: "SachCTs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_accounts_NhanVienId",
                table: "accounts",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietDons_DonHangId",
                table: "chiTietDons",
                column: "DonHangId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietDons_SachCTId",
                table: "chiTietDons",
                column: "SachCTId");

            migrationBuilder.CreateIndex(
                name: "IX_donHangs_IdKhachHang",
                table: "donHangs",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_donHangs_IdNhanVien",
                table: "donHangs",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCTs_IdHoaDon",
                table: "HoaDonCTs",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCTs_IdSachCT",
                table: "HoaDonCTs",
                column: "IdSachCT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdKhachHang",
                table: "HoaDons",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdNhanVien",
                table: "HoaDons",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHangs_AccountId",
                table: "KhachHangs",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_IdVaiTro",
                table: "NhanViens",
                column: "IdVaiTro");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhapCTs_IdPhieuNhap",
                table: "PhieuNhapCTs",
                column: "IdPhieuNhap");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhapCTs_IdSachCT",
                table: "PhieuNhapCTs",
                column: "IdSachCT");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhaps_IdNhaCungCap",
                table: "PhieuNhaps",
                column: "IdNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhaps_IdNhanVien",
                table: "PhieuNhaps",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_SachCTs_IdSach",
                table: "SachCTs",
                column: "IdSach");

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_IdNgonNgu",
                table: "Sachs",
                column: "IdNgonNgu");

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_IdNXB",
                table: "Sachs",
                column: "IdNXB");

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_IdTacGia",
                table: "Sachs",
                column: "IdTacGia");

            migrationBuilder.CreateIndex(
                name: "IX_Sachs_IdTheLoai",
                table: "Sachs",
                column: "IdTheLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chiTietDons");

            migrationBuilder.DropTable(
                name: "HoaDonCTs");

            migrationBuilder.DropTable(
                name: "PhieuNhapCTs");

            migrationBuilder.DropTable(
                name: "donHangs");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "PhieuNhaps");

            migrationBuilder.DropTable(
                name: "SachCTs");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhaCungCaps");

            migrationBuilder.DropTable(
                name: "Sachs");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "NgonNgus");

            migrationBuilder.DropTable(
                name: "NhaXuatBans");

            migrationBuilder.DropTable(
                name: "TheLoais");

            migrationBuilder.DropTable(
                name: "tacGias");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "VaiTros");
        }
    }
}
