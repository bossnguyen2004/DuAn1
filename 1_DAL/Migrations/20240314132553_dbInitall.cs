using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL.Migrations
{
    public partial class dbInitall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anh",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    MaAnh = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DuongDan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anh", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ChatLieu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DanhMuc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdDanhMucKhac = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMuc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DanhMuc_DanhMuc_IdDanhMucKhac",
                        column: x => x.IdDanhMucKhac,
                        principalTable: "DanhMuc",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamSinh = table.Column<DateTime>(type: "date", nullable: true),
                    Sdt = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiGiay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhaSanXuat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaSanXuat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SizeGiay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    SoSize = table.Column<int>(type: "int", maxLength: 30, nullable: false, defaultValueSql: "((0))"),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeGiay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThanhToan",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    MaGiamGia = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TenChuongTrinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    GiaTriVoucher = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SoTienGiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    NamSinh = table.Column<DateTime>(type: "date", nullable: true),
                    QueQuan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMND = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    img = table.Column<byte[]>(type: "image", nullable: true),
                    MaOTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCV = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdCV",
                        column: x => x.IdCV,
                        principalTable: "ChucVu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DiaChi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DuongPho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Xa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Huyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaChi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiaChi_KhachHang_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    IdNhaSanXuat = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_ChatLieu_IdChatLieu",
                        column: x => x.IdChatLieu,
                        principalTable: "ChatLieu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SanPham_NhaSanXuat_IdNhaSanXuat",
                        column: x => x.IdNhaSanXuat,
                        principalTable: "NhaSanXuat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GiaoCa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ThoiGianNhanCa = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    ThoiGianGiaoCa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdNvNhanCaTiep = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNvTrongCa = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TienBanDau = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TongTienTrongCa = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TongTienMat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TongTienKhac = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TienPhatSinh = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GhiChuPhatSinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongTienCaTruoc = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Time = table.Column<int>(type: "int", nullable: true),
                    TongTienMatRut = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoCa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiaoCa_NhanVien_IdNvNhanCaTiep",
                        column: x => x.IdNvNhanCaTiep,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVouCher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdThanhToan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NgayTao = table.Column<DateTime>(type: "date", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "date", nullable: true),
                    NgayShip = table.Column<DateTime>(type: "date", nullable: true),
                    NgayNhan = table.Column<DateTime>(type: "date", nullable: true),
                    TinhTrang = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SDTShip = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TenShip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaGiamGia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TienKhachDua = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    TienChuyenKhoan = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    TongTienNvTrongCa = table.Column<decimal>(type: "decimal(18,0)", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDon_ThanhToan_IdThanhToan",
                        column: x => x.IdThanhToan,
                        principalTable: "ThanhToan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDon_Voucher_IdVouCher",
                        column: x => x.IdVouCher,
                        principalTable: "Voucher",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KieuDanhMuc",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdDanhMuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TheLoaiGioiTinh = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuDanhMuc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KieuDanhMuc_DanhMuc_IdDanhMuc",
                        column: x => x.IdDanhMuc,
                        principalTable: "DanhMuc",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KieuDanhMuc_SanPham_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SanPhamChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdLoaiGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSizeGiay = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAnh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamBH = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    MoTa = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValueSql: "((0))"),
                    GiaBan = table.Column<decimal>(type: "decimal(18,0)", nullable: false, defaultValueSql: "((0))"),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_Anh_IdAnh",
                        column: x => x.IdAnh,
                        principalTable: "Anh",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_LoaiGiay_IdLoaiGiay",
                        column: x => x.IdLoaiGiay,
                        principalTable: "LoaiGiay",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_SanPham_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPham",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_SizeGiay_IdSizeGiay",
                        column: x => x.IdSizeGiay,
                        principalTable: "SizeGiay",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    ThanhTien = table.Column<decimal>(type: "decimal(20,0)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    GiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_SanPhamChiTiet_IdChiTietSP",
                        column: x => x.IdChiTietSP,
                        principalTable: "SanPhamChiTiet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "UQ_Anh",
                table: "Anh",
                column: "MaAnh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_ChatLieu",
                table: "ChatLieu",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_ChucVu",
                table: "ChucVu",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_IdDanhMucKhac",
                table: "DanhMuc",
                column: "IdDanhMucKhac");

            migrationBuilder.CreateIndex(
                name: "UQ_DanhMuc",
                table: "DanhMuc",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiaChi_IdKhachHang",
                table: "DiaChi",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "UQ_DiaChi",
                table: "DiaChi",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GiaoCa_IdNvNhanCaTiep",
                table: "GiaoCa",
                column: "IdNvNhanCaTiep");

            migrationBuilder.CreateIndex(
                name: "UQ_GiaoCa",
                table: "GiaoCa",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKH",
                table: "HoaDon",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNV",
                table: "HoaDon",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdThanhToan",
                table: "HoaDon",
                column: "IdThanhToan");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdVouCher",
                table: "HoaDon",
                column: "IdVouCher");

            migrationBuilder.CreateIndex(
                name: "UQ_HoaDon",
                table: "HoaDon",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdChiTietSP",
                table: "HoaDonChiTiet",
                column: "IdChiTietSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdHoaDon",
                table: "HoaDonChiTiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "UQ_KhachHang",
                table: "KhachHang",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KieuDanhMuc_IdDanhMuc",
                table: "KieuDanhMuc",
                column: "IdDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_KieuDanhMuc_IdSanPham",
                table: "KieuDanhMuc",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "UQ_LoaiGiay",
                table: "LoaiGiay",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_MauSac",
                table: "MauSac",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCV",
                table: "NhanVien",
                column: "IdCV");

            migrationBuilder.CreateIndex(
                name: "UQ_NhanVien",
                table: "NhanVien",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_NhaSanXuat",
                table: "NhaSanXuat",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IdChatLieu",
                table: "SanPham",
                column: "IdChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IdNhaSanXuat",
                table: "SanPham",
                column: "IdNhaSanXuat");

            migrationBuilder.CreateIndex(
                name: "UQ_SanPham",
                table: "SanPham",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IdAnh",
                table: "SanPhamChiTiet",
                column: "IdAnh");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IdLoaiGiay",
                table: "SanPhamChiTiet",
                column: "IdLoaiGiay");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IdMauSac",
                table: "SanPhamChiTiet",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IdSanPham",
                table: "SanPhamChiTiet",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_IdSizeGiay",
                table: "SanPhamChiTiet",
                column: "IdSizeGiay");

            migrationBuilder.CreateIndex(
                name: "UQ_SizeGiay",
                table: "SizeGiay",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_ThanhToan",
                table: "ThanhToan",
                column: "Ma",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_MaGiamGia",
                table: "Voucher",
                column: "MaGiamGia",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaChi");

            migrationBuilder.DropTable(
                name: "GiaoCa");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "KieuDanhMuc");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPhamChiTiet");

            migrationBuilder.DropTable(
                name: "DanhMuc");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ThanhToan");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "Anh");

            migrationBuilder.DropTable(
                name: "LoaiGiay");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "SizeGiay");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "ChatLieu");

            migrationBuilder.DropTable(
                name: "NhaSanXuat");
        }
    }
}
