using _1_DAL.IRepositories;
using _1_DAL.Models;
using _1_DAL.Repository;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class ChatLieuServices : IChatLieuServices
    {
        private ChatLieuRepository _repository;

        public ChatLieuServices()
        {
            _repository = new ChatLieuRepository();
        }

        public List<ChatLieu> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Sua(Guid Id, string ma, string ten, int trangThai)
        {
            var chatLieu = new ChatLieu
            {
                Id = Id,
                Ma = ma,
                Ten = ten,
               TrangThai = trangThai,
            };
            return _repository.Sua(chatLieu);
        }

        public bool Them(string ma, string ten, int trangThai)
        {
            var chatLieu = new ChatLieu
            {
                Id = Guid.NewGuid(),
                Ma = ma,
                Ten = ten,
               TrangThai = trangThai
            };
            return _repository.Them(chatLieu);
        }

        public bool Xoa(Guid Id)
        {
            var chatLieu = new ChatLieu
            {
                Id = Id,
            };
            return _repository.Xoa(chatLieu);
        }
    }
}
