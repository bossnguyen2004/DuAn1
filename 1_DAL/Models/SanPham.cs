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
    [Table("SanPham")]
    [Index(nameof(Ma), Name = "UQ_SanPham", IsUnique = true)]
    public partial class SanPham
    {
        public SanPham()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
            KieuDanhMucs = new HashSet<KieuDanhMuc>();
        }
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tối da 50 kí tự")]
        public string Ma { get; set; }
        [StringLength(50, ErrorMessage = "Tên phải có tối da 50 kí tự")]
        public string Ten { get; set; }
        public int TrangThai { get; set; }
        [Column("IdNhaSanXuat")]
        public Guid? IdNhaSanXuat { get; set; }
        [Column("IdChatLieu")]
        public Guid? IdChatLieu { get; set; }
        //
        [ForeignKey(nameof(IdNhaSanXuat))]
        [InverseProperty(nameof(NhaSanXuat.SanPhams))]
        public virtual NhaSanXuat IdNhaSanXuatNavigation { get; set; }
        //
        [ForeignKey(nameof(IdChatLieu))]
        [InverseProperty(nameof(ChatLieu.SanPhams))]
        public virtual ChatLieu IdChatLieuNavigation { get; set; }
        //
        public virtual ICollection<KieuDanhMuc> KieuDanhMucs { get; set; }
        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
