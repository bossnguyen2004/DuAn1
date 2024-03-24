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
    public class NhaSanXuatServices : INhaSanXuatServices
    {
        private NhaSanXuatRepository _repository;

        public NhaSanXuatServices()
        {
            _repository = new NhaSanXuatRepository();
        }

        public List<NhaSanXuat> GetAll()
        {
           return _repository.GetAll();
        }

        public bool Sua(Guid Id, string ma, string ten, int trangThai)
        {
            var NSX = new NhaSanXuat
            {
                Id = Id,
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai,
            };
            return _repository.Sua(NSX);
        }

        public bool Them(string ma, string ten, int trangThai)
        {
            var NSX = new NhaSanXuat
            {
                Id = Guid.NewGuid(),
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai
            };
            return _repository.Them(NSX);
        }

        public bool Xoa(Guid Id)
        {
            var NSX = new NhaSanXuat
            {
                Id = Id,
            };
            return _repository.Xoa(NSX);
        }
    }
}
