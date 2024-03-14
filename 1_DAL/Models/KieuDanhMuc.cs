using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    [Table("KieuDanhMuc")]
    public partial class KieuDanhMuc
    {
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }

        [Column("IdDanhMuc")]
        public Guid? IdDanhMuc { get; set; }

        [Column("IdSanPham")]
        public Guid? IdSanPham { get; set; }
        public int TheLoaiGioiTinh { get; set; }
        public int TrangThai { get; set; }
        [ForeignKey(nameof(IdDanhMuc))]
        [InverseProperty(nameof(DanhMuc.KieuDanhMucs))]
        public virtual DanhMuc IdDanhMucNavigation { get; set; }
        [ForeignKey(nameof(IdSanPham))]
        [InverseProperty(nameof(SanPham.KieuDanhMucs))]
        public virtual SanPham IdHangHoaNavigation { get; set; }
    }
}