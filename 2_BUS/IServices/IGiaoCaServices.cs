using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IGiaoCaServices
    {
        List<GiaoCaViewModels> GetAll();
        bool Them(GiaoCaViewModels giaoCa);
        bool Sua(GiaoCaViewModels giaoCaViewModels);
        bool Xoa(Guid Id);
        Guid GetId(GiaoCaViewModels giaoCa);
        List<GiaoCaViewModels> TimKiem(string Ma);

    }
}
