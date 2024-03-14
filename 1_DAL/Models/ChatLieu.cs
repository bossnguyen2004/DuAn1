using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _1_DAL.Models
{
    [Table("ChatLieu")]
    [Index(nameof(Ma), Name = "UQ_ChatLieu", IsUnique = true)]
    public partial class ChatLieu
    {
        public ChatLieu()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid Id { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tôi đa 20 kí tự")]
        public string Ma { get; set; }
        [StringLength(50, ErrorMessage = "Tên phải có tối da 50 kí tự")]
        public string Ten { get; set; }
        public int TrangThai { get; set; }
        [InverseProperty(nameof(SanPham.IdChatLieuNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}

