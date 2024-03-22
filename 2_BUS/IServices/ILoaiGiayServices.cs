using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ILoaiGiayServices
    {
        List<LoaiGiayViewModels> GetAll();
        bool Them(LoaiGiayViewModels loaiGiay);
        bool Sua(LoaiGiayViewModels loaiGiay);
        bool Xoa(Guid Id);
    }
}
