using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IKieuDanhMucServices
    {
        List<KieuDanhMucViewModels> GetAll();
        bool Them(int theLoaiGT, int trangThai, string IdDanhMuc, string IdSanPham);
        bool Sua(Guid Id, int theLoaiGT, int trangThai, string IdDanhMuc, string IdSanPham);
        bool Xoa(Guid Id);
        List<KieuDanhMucViewModels> TimKiem(string Ma);
    }
}
