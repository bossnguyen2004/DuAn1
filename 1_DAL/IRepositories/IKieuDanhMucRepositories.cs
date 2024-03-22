using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IKieuDanhMucRepositories
    {
        bool Them(KieuDanhMuc kieuDanhMuc);
        bool Sua(KieuDanhMuc kieuDanhMuc);
        bool Xoa(Guid Id);
        List<KieuDanhMuc> GetAll();
    }
}
