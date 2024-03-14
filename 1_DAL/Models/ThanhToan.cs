using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_DAL.Models
{
    [Table("ThanhToan")]
    [Index(nameof(Ma), Name = "UQ_ThanhToan", IsUnique = true)]
    public partial class ThanhToan
    {
        public ThanhToan()
        {
            HoaDons = new HashSet<HoaDon>();
        }
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tôi đa 20 kí tự")]
        public string Ma { get; set; }
        [StringLength(50, ErrorMessage = "Tên phải có tối da 50 kí tự")]
        public string Ten { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
