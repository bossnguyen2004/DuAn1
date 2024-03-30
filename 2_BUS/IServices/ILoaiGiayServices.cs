using _1_DAL.Models;
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
        bool Them(string ma, string ten, int trangThai);
        bool Xoa(Guid Id);
        bool Sua(Guid Id, string ma, string ten, int trangThai);
        List<LoaiGiay> GetAll();
    }
}
