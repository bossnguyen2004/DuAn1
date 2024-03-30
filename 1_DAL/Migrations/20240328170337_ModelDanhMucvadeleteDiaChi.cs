using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL.Migrations
{
    public partial class ModelDanhMucvadeleteDiaChi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DanhMuc_DanhMuc_IdDanhMucKhac",
                table: "DanhMuc");

            migrationBuilder.DropTable(
                name: "DiaChi");

            migrationBuilder.DropIndex(
                name: "IX_DanhMuc_IdDanhMucKhac",
                table: "DanhMuc");

            migrationBuilder.DropColumn(
                name: "IdDanhMucKhac",
                table: "DanhMuc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdDanhMucKhac",
                table: "DanhMuc",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DiaChi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DuongPho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Huyen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ma = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    Xa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_DanhMuc_IdDanhMucKhac",
                table: "DanhMuc",
                column: "IdDanhMucKhac");

            migrationBuilder.CreateIndex(
                name: "IX_DiaChi_IdKhachHang",
                table: "DiaChi",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "UQ_DiaChi",
                table: "DiaChi",
                column: "Ma",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DanhMuc_DanhMuc_IdDanhMucKhac",
                table: "DanhMuc",
                column: "IdDanhMucKhac",
                principalTable: "DanhMuc",
                principalColumn: "Id");
        }
    }
}
