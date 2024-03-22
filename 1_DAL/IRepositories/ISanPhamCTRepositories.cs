using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface ISanPhamCTRepositories
    {
        bool Them(SanPhamChiTiet sanPhamCT);
        bool Sua(SanPhamChiTiet sanPhamCT);
        bool Xoa(Guid Id);
        List<SanPhamChiTiet> GetAll();
        List<SanPhamChiTiet> TimKiem(string Ma);
    }
}
