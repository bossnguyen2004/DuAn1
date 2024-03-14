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
    [Table("DiaChi")]
    [Index(nameof(Ma), Name = "UQ_DiaChi", IsUnique = true)]
    public partial class DiaChi
    {
       
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }

        [Column("IdKhachHang")]
        public Guid? IdKhachHang { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tôi đa 20 kí tự")]
        public string Ma { get; set; }
        [StringLength(50, ErrorMessage = "Tên phải có tối da 50 kí tự")]
        public string DuongPho { get; set; }
        [StringLength(50, ErrorMessage = "Tên phải có tối da 50 kí tự")]
        public string Xa { get; set; }
        [StringLength(50, ErrorMessage = "Tên phải có tối da 50 kí tự")]
        public string Huyen { get; set; }
        [StringLength(50, ErrorMessage = "Tên phải có tối da 50 kí tự")]
        public string ThanhPho { get; set; }
        public int TrangThai { get; set; }
       
        [ForeignKey(nameof(IdKhachHang))]
        [InverseProperty(nameof(KhachHang.DiaChis))]
        public virtual KhachHang IdKhachHangNavigation { get; set; }
    }
}
