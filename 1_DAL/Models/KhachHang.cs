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
    [Table("KhachHang")]
    [Index(nameof(Ma), Name = "UQ_KhachHang", IsUnique = true)]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tối da 50 kí tự")]
        public string Ma { get; set; }
        [StringLength(50, ErrorMessage = "Tên phải có tối da 50 kí tự")]
        public string Ten { get; set; }
        public int GioiTinh { get; set; }
        [EmailAddress(ErrorMessage = "Định dạng email không hợp lệ")]
        public string? Email { get; set; }
        public string Password { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NamSinh { get; set; }
        [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Số điện thoại phải có từ 10 đến 12 chữ số")]
        public string Sdt { get; set; }
        [StringLength(200, ErrorMessage = "Dia chi phải có tối da 200 kí tự")]
        public string? DiaChi { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }

    }
}


