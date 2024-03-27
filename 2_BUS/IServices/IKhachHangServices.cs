using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IKhachHangServices
    {
     
        List<KhachHang> GetAll();
        bool Add(string ma, string ten, string sdt, string diaChi, string email, int gioiTinh, DateTime namSinh,string password, int trangThai);
        bool Update(Guid id, string ma, string ten, string sdt, string diaChi, string email, int gioiTinh, DateTime namSinh, string password, int trangThai);
        bool Delete(Guid id);
    }
}
                                        