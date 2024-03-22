using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface INhaSanXuatRepositories
    {
        List<NhaSanXuat> GetAll();
        bool Them(MauSac mauSac);
        bool Xoa(Guid Id);
        bool Sua(MauSac mauSac);
    }
}
