using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IDiaChiRepositories
    {
        bool Them(DiaChi diaChi);
        bool Sua(DiaChi diaChi);
        bool Xoa(Guid Id);
        List<DiaChi> GetAll();
    }
}
