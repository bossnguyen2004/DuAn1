using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IAnhRepositories
    {
        List<Anh> GetAll();
        bool Them(Anh image);
        bool Xoa(Anh image);
        bool Sua(Anh image);
        bool timKiem(Anh image);
    }
}
