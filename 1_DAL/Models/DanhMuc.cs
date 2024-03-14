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
    [Table("DanhMuc")]
    [Index(nameof(Ma), Name = "UQ_DanhMuc", IsUnique = true)]
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            KieuDanhMucs = new HashSet<KieuDanhMuc>();
        }

        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }

        [Column("IdDanhMucKhac")]
        public Guid? IdDanhMucKhac { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tôi đa 20 kí tự")]
        public string Ma { get; set; }
        [StringLength(50, ErrorMessage = "Tên phải có tối da 50 kí tự")]
        public string Ten { get; set; }
        public int? TrangThai { get; set; }
        [ForeignKey(nameof(IdDanhMucKhac))]
        public virtual ICollection<DanhMuc> IdDanhMucNavigation { get; set; }
        public virtual ICollection<KieuDanhMuc> KieuDanhMucs { get; set; }

    }
}




