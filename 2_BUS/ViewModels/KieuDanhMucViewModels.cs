using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class KieuDanhMucViewModels
    {
        public Guid? Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public Guid? IdDanhMuc { get; set; }
        public Guid? IdSanPham { get; set; }
        public int TheLoaiGioiTinh { get; set; }
        public int TrangThai { get; set; }
    }
}
