using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IAnhServices
    {
        bool Them(AnhViewModels img);
        bool Xoa(Guid Id);
        bool Sua(AnhViewModels img);
        public Guid Id(AnhViewModels img);
        List<AnhViewModels> GetAll();
    }
}
