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
    public class LoaiGiayServices : ILoaiGiayServices
    {
        private LoaiGiayRepositoy _repository;

        public LoaiGiayServices()
        {
            _repository = new LoaiGiayRepositoy();
        }

        public List<LoaiGiay> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Sua(Guid Id, string ma, string ten, int trangThai)
        {
            var loaiGiay = new LoaiGiay
            {
                Id = Id,
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai,
            };
            return _repository.Sua(loaiGiay);
        }

        public bool Them(string ma, string ten, int trangThai)
        {
            var loaiGiay = new LoaiGiay
            {
                Id = Guid.NewGuid(),
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai
            };
            return _repository.Them(loaiGiay);
        }

        public bool Xoa(Guid Id)
        {
            var loaiGiay = new LoaiGiay
            {
                Id = Id,
            };
            return _repository.Xoa(loaiGiay);
        }

    }
}
