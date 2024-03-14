using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    [Table("SanPhamChiTiet")]
    public class SanPhamChiTiet
    {
        public SanPhamChiTiet()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }
        [Column("IdSanPham")]
        public Guid? IdSanPham { get; set; }
        [Column("IdLoaiGiay")]
        public Guid? IdLoaiGiay { get; set; }
        [Column("IdSizeGiay")]
        public Guid? IdSizeGiay { get; set; }
        [Column("IdAnh")]
        public Guid? IdAnh { get; set; }
        [Column("IdMauSac")]
        public Guid? IdMauSac { get; set; }

        [Column("NamBH")]
        public int? NamBh { get; set; }
        [StringLength(200, ErrorMessage = "Tên phải có tối da 200 kí tự")]
        public string? MoTa { get; set; }
        [Required(ErrorMessage = "Số lượng tồn không được để trống")]
        public int? SoLuongTon { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? GiaNhap { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        [Required(ErrorMessage = "Giá bán không được để trống")]
        public decimal? GiaBan { get; set; }
        

        public int TrangThai { get; set; }
        //
        [ForeignKey(nameof(IdSanPham))]
        [InverseProperty(nameof(SanPham.SanPhamChiTiets))]
        public virtual SanPham IdSanPhamNavigation { get; set; }
        //
        [ForeignKey(nameof(IdLoaiGiay))]
        [InverseProperty(nameof(LoaiGiay.SanPhamChiTiets))]
        public virtual LoaiGiay IdLoaiGiayNavigation { get; set; }

        //
        [ForeignKey(nameof(IdSizeGiay))]
        [InverseProperty(nameof(SizeGiay.SanPhamChiTiets))]
        public virtual SizeGiay IdSizeGiayNavigation { get; set; }
        //
        [ForeignKey(nameof(IdAnh))]
        [InverseProperty(nameof(Anh.SanPhamChiTiets))]
        public virtual Anh IdAnhNavigation { get; set; }
        //
        [ForeignKey(nameof(IdMauSac))]
        [InverseProperty(nameof(MauSac.SanPhamChiTiets))]
        public virtual MauSac IdMauSacNavigation { get; set; }

        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}








