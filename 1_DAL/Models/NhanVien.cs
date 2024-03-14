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
    [Table("NhanVien")]
    [Index(nameof(Ma), Name = "UQ_NhanVien", IsUnique = true)]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            GiaoCas = new HashSet<GiaoCa>();
        }
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid Id { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tôi đa 20 kí tự")]
        public string Ma { get; set; }
        [StringLength(50, ErrorMessage = "Họ phải có tối da 50 kí tự")]
        public string Ho { get; set; }
        [StringLength(50, ErrorMessage = "Tên phải có tối da 50 kí tự")]
        public string Ten { get; set; }
        
        public int GioiTinh { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NamSinh { get; set; }
        [StringLength(200, ErrorMessage = "Quê quán phải có tối da 200 kí tự")]
        public string QueQuan { get; set; }
        [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Số điện thoại phải có từ 10 đến 12 chữ số")]
        public string Sdt { get; set; }
       
        public string MatKhau { get; set; }
        [EmailAddress(ErrorMessage = "Định dạng email không hợp lệ")]
        public string Email { get; set; }

        [RegularExpression(@"^\d{9,12}$", ErrorMessage = "Số CMND phải chứa từ 9 đến 12 chữ số.")]
        public string CMND { get; set; }

        [Column("TrangThai")]
        public int? TrangThai { get; set; }

        [Column("img", TypeName = "image")]
        public byte[]? Anh { get; set; }
        public string? MaOTP { get; set; }
        [Column("IdCV")]
        public Guid? IdCv { get; set; }

        [ForeignKey(nameof(IdCv))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu IdChucVuNavigation { get; set; }
        //   
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<GiaoCa> GiaoCas { get; set; }

    }
}







    