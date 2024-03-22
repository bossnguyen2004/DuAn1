using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class KieuDanhMucServices : IKieuDanhMucServices
    {
        public List<KieuDanhMucViewModels> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<KieuDanhMucViewModels> GetChucVu()
        {
            throw new NotImplementedException();
        }

        public bool Sua(KieuDanhMucViewModels kieuDanhMuc)
        {
            throw new NotImplementedException();
        }

        public bool Them(KieuDanhMucViewModels kieuDanhMuc)
        {
            throw new NotImplementedException();
        }

        public List<KieuDanhMucViewModels> TimKiem(string TenDM, string TenSP)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
