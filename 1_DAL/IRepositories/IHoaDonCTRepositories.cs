using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IHoaDonCTRepositories
    {
        bool Them(HoaDonChiTiet hoaDonCT);
        bool Sua(HoaDonChiTiet hoaDonCT);
        bool Xoa(Guid Id);
        List<HoaDonChiTiet> GetAll();
        List<HoaDonChiTiet> TimKiem(string Ma);
    }
}
