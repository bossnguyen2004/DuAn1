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
        bool Them(NhaSanXuat nhaSanXuat);
        bool Xoa(NhaSanXuat nhaSanXuat);
        bool Sua(NhaSanXuat nhaSanXuat);
    }
}
