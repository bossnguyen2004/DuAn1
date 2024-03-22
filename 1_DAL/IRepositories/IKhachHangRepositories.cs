using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IKhachHangRepositories
    {
        bool Them(KhachHang khachHang);
        bool Sua(KhachHang khachHang);
        bool Xoa(Guid Id);
        List<KhachHang> GetAll();
        List<KhachHang> TimKiem(string Ma);
    }
}
