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
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }
        [Column("IdHoaDon")]
        public Guid? IdHoaDon { get; set; }
        [Column("IdChiTietSP")]
        public Guid? IdChiTietSanPham { get; set; }
        public int? SoLuong { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal? ThanhTien { get; set; }
        public int TrangThai { get; set; }
        public decimal? GiamGia { get; set; }


        [ForeignKey(nameof(IdHoaDon))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiets))]
        public virtual HoaDon IdHoaDonNavigation { get; set; }

        [ForeignKey(nameof(IdChiTietSanPham))]
        [InverseProperty(nameof(SanPhamChiTiet.HoaDonChiTiets))]
        public virtual SanPhamChiTiet IdChiTietSPNavigation { get; set; }
    }
}






