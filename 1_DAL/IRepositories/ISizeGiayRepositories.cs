using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface ISizeGiayRepositories
    {
        List<SizeGiay> GetAll();
        bool Them(SizeGiay sizeGiay);
        bool Xoa(SizeGiay sizeGiay);
        bool Sua(SizeGiay sizeGiay);
    }
}
