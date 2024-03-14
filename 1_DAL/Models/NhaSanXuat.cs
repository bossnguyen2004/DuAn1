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
    [Table("NhaSanXuat")]
    [Index(nameof(Ma), Name = "UQ_NhaSanXuat", IsUnique = true)]
    public partial class NhaSanXuat
    {
        public NhaSanXuat()
        {
            SanPhams = new HashSet<SanPham>();
        }
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tôi đa 20 kí tự")]
        public string Ma { get; set; }
        [StringLength(100, ErrorMessage = "Tên phải có tối da 100 kí tự")]
        public string Ten { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }

    }
}



