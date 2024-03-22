using _1_DAL.IRepositories;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class SanPhamRepository : ISanPhamRepositories
    {
        public List<SanPham> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Sua(SanPham sanPham)
        {
            throw new NotImplementedException();
        }

        public bool Them(SanPham sanPham)
        {
            throw new NotImplementedException();
        }

        public List<SanPham> TimKiem(string Ma)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
