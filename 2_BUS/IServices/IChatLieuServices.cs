using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IChatLieuServices
    {
        bool Them(ChatLieuViewModels chatLieuViewModels);
        bool Xoa(Guid Id);
        bool Sua(ChatLieuViewModels chatLieuViewModels);
        List<ChatLieuViewModels> GetAll();
    }
}
