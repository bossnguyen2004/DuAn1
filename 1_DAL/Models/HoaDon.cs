using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_DAL.Models
{
    [Table("HoaDon")]
    [Index(nameof(Ma), Name = "UQ_HoaDon", IsUnique = true)]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
          
        }
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }
        [Column("IdKH")]
        public Guid? IdKh { get; set; }
        [Column("IdNV")]
        public Guid? IdNv { get; set; }
        [Column("IdVouCher")]
        public Guid? IdVouCher { get; set; }
        [Column("IdThanhToan")]
        public Guid? IdThanhToan { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tối da 50 kí tự")]
        public string Ma { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayThanhToan { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayShip { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayNhan { get; set; }
        public int? TinhTrang { get; set; }
        [StringLength(100)]
        public string? SDTShip { get; set; }
        public string? TenShip { get; set; }
        public string? MoTa { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public string? MaGiamGia { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal TienKhachDua { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal TienChuyenKhoan { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal TongTienNvTrongCa { get; set; }
      

        [ForeignKey(nameof(IdKh))]
        [InverseProperty(nameof(KhachHang.HoaDons))]
        public virtual KhachHang IdKhNavigation { get; set; }

        [ForeignKey(nameof(IdNv))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien IdNvNavigation { get; set; }

        [ForeignKey(nameof(IdVouCher))]
        [InverseProperty(nameof(Voucher.HoaDons))]
        public virtual Voucher IdVoucherNavigration { get; set; }

        [ForeignKey(nameof(IdThanhToan))]
        [InverseProperty(nameof(ThanhToan.HoaDons))]
        public virtual ThanhToan IdThanhToanNavigration { get; set; }

        [InverseProperty(nameof(HoaDonChiTiet.IdHoaDonNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        
    }
}







