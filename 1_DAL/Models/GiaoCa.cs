using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace _1_DAL.Models
{
    [Table("GiaoCa")]
    [Index(nameof(Ma), Name = "UQ_GiaoCa", IsUnique = true)]

    public partial class GiaoCa
    {
       
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid Id { get; set; }
        [StringLength(20, ErrorMessage = "Ma phải có tối da 50 kí tự")]
        public string Ma { get; set; }
        [StringLength(50)]
        public DateTime ThoiGianNhanCa { get; set; }
        public DateTime ThoiGianGiaoCa { get; set; }
        public Guid? IdNvNhanCaTiep { get; set; }
        public Guid? IdNvTrongCa { get; set; }
        public decimal? TienBanDau { get; set; }
        public decimal? TongTienTrongCa { get; set; }
        public decimal? TongTienMat { get; set; }
        public decimal? TongTienKhac { get; set; }
        public decimal? TienPhatSinh { get; set; }
        public string? GhiChuPhatSinh { get; set; }
        public decimal? TongTienCaTruoc { get; set; }
        public int? Time { get; set; }
        public decimal? TongTienMatRut { get; set; }

        public int TrangThai { get; set; }
        [ForeignKey(nameof(IdNvNhanCaTiep))]
        [InverseProperty(nameof(NhanVien.GiaoCas))]
        public virtual NhanVien NhanVienNavigation { get; set; }
    }
}
