using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace _1_DAL.Models
{

    [Table("Anh")]
    [Index(nameof(MaAnh), Name = "UQ_Anh", IsUnique = true)]
    public partial class Anh
    {
        public Anh()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid ID { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tôi đa 20 kí tự ")]
        public string MaAnh { get; set; }
        [StringLength(50, ErrorMessage = "Ten  phải có tôi đa 50 kí tự")]
        public string? Ten { get; set; }
        [Required(ErrorMessage = "DuongDan bắt buộc")]
        public string DuongDan { get; set; }
        public int TrangThai { get; set; }
        [InverseProperty(nameof(SanPhamChiTiet.IdAnhNavigation))]
        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}




