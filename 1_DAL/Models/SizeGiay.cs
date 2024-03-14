using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace _1_DAL.Models
{
    [Table("SizeGiay")]
    [Index(nameof(Ma), Name = "UQ_SizeGiay", IsUnique = true)]
    public partial class SizeGiay
    {
        public SizeGiay()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tôi đa 20 kí tự")]
        public string Ma { get; set; }
        [StringLength(30)]
        public int SoSize { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }

    }
}