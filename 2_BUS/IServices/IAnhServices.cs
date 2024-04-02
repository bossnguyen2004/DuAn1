using _1_DAL.Models;
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
        bool timKiem(string ten);
        bool Them(string ma, string ten,string duongdan, int trangThai);
        bool Xoa(Guid Id);
        bool Sua(Guid Id, string ma, string ten, string duongdan, int trangThai);
        public Guid Id(AnhViewModels img);
        List<Anh> GetAll();
    }
}
