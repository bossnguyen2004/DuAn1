using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ISanPhamServices
    {
        List<SanPhamViewModels> GetAll();
        bool Them(string ma, string ten, int trangThai,string idNhaSanXuat, string idChatLieu);
        bool Sua(Guid Id, string ma, string ten, int trangThai, string idNhaSanXuat, string idChatLieum);
        bool Xoa(Guid Id);
        List<SanPhamViewModels> TimKiem(string Ma);
    }
}
