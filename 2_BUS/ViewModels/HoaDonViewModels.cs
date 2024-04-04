using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class HoaDonViewModels 
    {
        public Guid Id { get; set; }

        public Guid? IdKh { get; set; }
        public Guid? IdNv { get; set; }
        public string? Ma { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public DateTime? NgayShip { get; set; }
        public DateTime? NgayNhan { get; set; }
        public int? TinhTrang { get; set; }
        public string? SDTShip { get; set; }
        public string? TenShip { get; set; }
        public string? MaGiamGia { get; set; }
        public string? MoTa { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public Guid? IdMaGiamGia { get; set; }
        public decimal TienKhachDua { get; set; }
        public decimal TienChuyenKhoan { get; set; }

        public decimal TongTienTrongCa { get; set; }

    }
}





