using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IHoaDonServices
    {
        List<HoaDon> GetAll();
        bool Add(Guid idSp, Guid idNv, string SDT, string diaChi, string moTa, string email, int soLuong);
        bool Buy(Guid idSp, Guid idKh, string SDT, string diaChi, string moTa, string email, int soLuong);
        bool Update(Guid idHoaDon, Guid idNv, string SDT, string diaChi, string moTa, string email, int soLuong);
        bool Delete(Guid id);
    }
}
