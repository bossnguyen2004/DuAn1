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
        bool Them(int namBH, string mota, int soluongTon, decimal giaNhap, decimal giaBan, int trangThai, string idSP, string idAnh, string idloaiGiay, string idsizeGiay, string idmauSac);
        bool Sua(Guid Id, int namBH, string mota, int soluongTon, decimal giaNhap, decimal giaBan, int trangThai, string idSP, string idAnh, string idloaiGiay, string idsizeGiay, string idmauSac);
        bool Xoa(Guid Id);
        List<SanPhamCTViewModels> TimKiem(string Ma);
    }
}
