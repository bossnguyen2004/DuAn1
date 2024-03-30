using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IMauSacRepositories
    {
        List<MauSac> GetAll();
        bool Them(MauSac mauSac);
        bool Xoa(MauSac mauSac);
        bool Sua(MauSac mauSac);
    }
}
