using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IDiaChiServices
    {
        List<DiaChiViewModels> GetAll();
        bool Them(DiaChiViewModels diaChi);
        bool Sua(DiaChiViewModels diaChi);
        bool Xoa(Guid Id);

        List<DiaChiViewModels> TimKiem(string Ma);
    }
}
