using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class ProductsViewModel
    {
        public ProductsViewModel() { }

        public Guid Id { get; set; }
        public string TenSanPham { get; set; }
        public string MaSanPham { get; set; }
        public int TrangThai {  get; set; }
        public Guid? IdNSX {  get; set; }
        public string TenNSX { get; set; }
        public Guid? IdChatLieu { get; set; }
        public string TenChatLieu { get; set; }
        public Guid? IdSize { get; set; }
        public int Size { get; set; }
        public Guid? IdMauSac { get; set; }
        public string TenMauSac { get; set; }
        public Guid? IdLoaiSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public Guid? IdAnh { get; set; }
        public string Anh { get; set; }
    }
}
