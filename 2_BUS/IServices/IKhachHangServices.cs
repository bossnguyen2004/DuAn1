using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IKhachHangServices
    {
        List<KhachHangViewModels> GetAll();
        bool Them(KhachHangViewModels khachHang);
        bool Sua(KhachHangViewModels khachHang);
        bool Xoa(Guid Id);
        public List<KhachHangViewModels> GetKhachHang();
        List<KhachHangViewModels> TimKiem(string Ma);
    }
}
