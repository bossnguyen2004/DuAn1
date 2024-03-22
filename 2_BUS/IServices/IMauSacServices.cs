using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IMauSacServices
    {
        List<MauSacViewModels> GetAll();
        bool Them(MauSacViewModels mauSac);
        bool Sua(MauSacViewModels mauSac);
        bool Xoa(Guid Id);
    }
}
