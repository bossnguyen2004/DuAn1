using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IDanhMucServices
    {
        List<DanhMucViewModels> GetAll();
        bool Them(DanhMucViewModels danhMuc);
        bool Sua(DanhMucViewModels danhMuc);
        bool Xoa(Guid Id);
    }
}
