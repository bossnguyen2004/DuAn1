using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IHoaDonCTServices
    {
        List<HoaDonChiTiet> GetAll();
        bool Add(HoaDon hoaDon);
        bool Update(HoaDon hoaDon);
        bool Delete(HoaDon hoaDon);
    }
}
