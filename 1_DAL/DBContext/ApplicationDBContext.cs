using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.DBContext
{
    public partial class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext()
        {
                
        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }


        public virtual DbSet<SanPhamChiTiet> SanPhamChiTiets { get; set; } 
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiGiay> LoaiGiays { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SizeGiay> SizeGiays { get; set; }
        public virtual DbSet<DiaChi> DiaChis { get; set; }
        public virtual DbSet<KieuDanhMuc> KieuDanhMucs { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<ChatLieu> ChatLieus { get; set; }
        public virtual DbSet<Voucher> Sales { get; set; }
        public virtual DbSet<Anh> Anhs { get; set; }
        public virtual DbSet<GiaoCa> GiaoCas { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseSqlServer("Data Source=NGUYEN\\SQLEXPRESS;Initial Catalog=DuAn1;Integrated Security=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.GiamGia).HasDefaultValueSql("((0))");
                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdHoaDonNavigation)
                      .WithMany(g => g.HoaDonChiTiets)
                      .OnDelete(DeleteBehavior.ClientSetNull); 
                entity.HasOne(d => d.IdChiTietSPNavigation)
                      .WithMany(g => g.HoaDonChiTiets)
                      .OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<KieuDanhMuc>(entity =>
            {

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdDanhMucNavigation)
                      .WithMany(g => g.KieuDanhMucs)
                      .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.IdHangHoaNavigation)
                      .WithMany(g => g.KieuDanhMucs)
                      .OnDelete(DeleteBehavior.ClientSetNull);



            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.Sdt).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
                entity.Property(e => e.Sdt).IsRequired(false);


            });
            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            });
            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.MaGiamGia).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            });
            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");


                entity.HasOne(d => d.IdNhaSanXuatNavigation)
                   .WithMany(g => g.SanPhams)
                   .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdChatLieuNavigation)
                     .WithMany(g => g.SanPhams)
                     .OnDelete(DeleteBehavior.ClientSetNull);

            });
            modelBuilder.Entity<LoaiGiay>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            });
            modelBuilder.Entity<ThanhToan>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            });
            modelBuilder.Entity<NhaSanXuat>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            });
            modelBuilder.Entity<Anh>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("(newid())");
                entity.Property(e => e.MaAnh).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");
                entity.Property(e => e.TongTienNvTrongCa).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhNavigation)
                     .WithMany(g => g.HoaDons)
                     .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdNvNavigation)
                     .WithMany(g => g.HoaDons)
                     .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdVoucherNavigration)
                     .WithMany(g => g.HoaDons)
                     .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdThanhToanNavigration)
                     .WithMany(g => g.HoaDons)
                     .OnDelete(DeleteBehavior.ClientSetNull);

            });
            modelBuilder.Entity<SanPhamChiTiet>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.SoLuongTon).HasDefaultValueSql("((0))");
                entity.Property(e => e.NamBh).HasDefaultValueSql("((0))");
                entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");
                entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdSanPhamNavigation)
                   .WithMany(g => g.SanPhamChiTiets)
                   .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdLoaiGiayNavigation)
                  .WithMany(g => g.SanPhamChiTiets)
                  .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdSizeGiayNavigation)
                  .WithMany(g => g.SanPhamChiTiets)
                  .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdAnhNavigation)
                  .WithMany(g => g.SanPhamChiTiets)
                  .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdMauSacNavigation)
                  .WithMany(g => g.SanPhamChiTiets)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            });
            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");
                entity.Property(e => e.IdDanhMucKhac).IsRequired(false);

            });
            modelBuilder.Entity<SizeGiay>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoSize).HasDefaultValueSql("((0))");
            });
            modelBuilder.Entity<ChatLieu>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");


            });
            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");


            });
            modelBuilder.Entity<DiaChi>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdKhachHangNavigation)
                      .WithMany(g => g.DiaChis)
                      .OnDelete(DeleteBehavior.ClientSetNull);


            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
                entity.Property(e => e.Ma).IsUnicode(false);
                entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");


                entity.HasOne(d => d.IdChucVuNavigation)
                      .WithMany(g => g.NhanViens)
                      .OnDelete(DeleteBehavior.ClientSetNull);
            });
            

        }
    }
}
