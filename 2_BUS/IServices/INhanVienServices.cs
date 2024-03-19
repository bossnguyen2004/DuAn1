using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface INhanVienServices
    {
        List<NhanVienViewModels> GetAll();
        bool Them(NhanVienViewModels nhanVien);
        bool Sua(NhanVienViewModels nhanViens);
        bool Xoa(Guid Id);
        List<NhanVienViewModels> TimKiem(string Ma);
        NhanVienViewModels Login(string ma, string pass);
    }
}
