using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IThanhToanServices
    {
        bool Them(ThanhToanViewModels obj);
        bool Sua(ThanhToanViewModels obj);
        bool Xoa(Guid Id);
        List<ThanhToanViewModels> GetAll();
    }
}
