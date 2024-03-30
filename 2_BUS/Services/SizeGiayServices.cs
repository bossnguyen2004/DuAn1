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
    public class SizeGiayServices : ISizeGiayServices
    {
        private SizeGiayRepository _repository;

        public SizeGiayServices()
        {
            _repository = new SizeGiayRepository();
        }

        public List<SizeGiay> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Sua(Guid Id, string ma, int size, int trangThai)
        {
            var sizeGiay = new SizeGiay
            {
                Id = Id,
                Ma = ma,
                SoSize = size,
                TrangThai = trangThai,
            };
            return _repository.Sua(sizeGiay);
        }

        public bool Them(string ma, int size, int trangThai)
        {
            var sizeGiay = new SizeGiay
            {
                Id = Guid.NewGuid(),
                Ma = ma,
                SoSize = size,
                TrangThai = trangThai
            };
            return _repository.Them(sizeGiay);
        }

        public bool Xoa(Guid Id)
        {
            var sizeGiay = new SizeGiay
            {
                Id = Id,
            };
            return _repository.Xoa(sizeGiay);
        }
    }
}
