using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface ILoaiGiayRepositories
    {
        List<LoaiGiay> GetAll();
        bool Them(LoaiGiay loaiGiay);
        bool Xoa(LoaiGiay loaiGiay);
        bool Sua(LoaiGiay loaiGiay);
    }
}
