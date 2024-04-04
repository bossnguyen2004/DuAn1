using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ISanPhamChiTietServices
    {
        List<SanPhamCTViewModels> GetAll();
        List<SanPhamChiTiet> GetAllChiTiet();
        bool Them(SanPhamCTViewModels spct);
        bool Sua(Guid Id, int namBH, string mota, int soluongTon, decimal giaNhap, decimal giaBan, int trangThai, string idSP, string idAnh, string idloaiGiay, string idsizeGiay, string idmauSac);
        bool Xoa(Guid Id);
        List<SanPhamCTViewModels> TimKiem(string Ma);
    }
}
