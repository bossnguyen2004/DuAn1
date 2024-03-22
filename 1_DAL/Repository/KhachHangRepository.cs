using _1_DAL.IRepositories;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class KhachHangRepository : IKhachHangRepositories
    {
        public List<KhachHang> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Sua(KhachHang khachHang)
        {
            throw new NotImplementedException();
        }

        public bool Them(KhachHang khachHang)
        {
            throw new NotImplementedException();
        }

        public List<KhachHang> TimKiem(string Ma)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
