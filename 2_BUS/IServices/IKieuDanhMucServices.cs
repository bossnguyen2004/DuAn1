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
        bool Them(KieuDanhMucViewModels kieuDanhMuc);
        bool Sua(KieuDanhMucViewModels kieuDanhMuc);
        bool Xoa(Guid Id);
        public List<KieuDanhMucViewModels> GetChucVu();
        List<KieuDanhMucViewModels> TimKiem(string TenDM,string TenSP);
    }
}
