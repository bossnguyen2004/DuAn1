using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface ISanPhamRepositories
    {
        bool Them(SanPham sanPham);
        bool Sua(SanPham sanPham);
        bool Xoa(SanPham sanPham);
        List<SanPham> GetAll();
        List<SanPham> TimKiem(string Ma);
    }
}
