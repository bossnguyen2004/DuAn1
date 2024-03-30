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
    public class MauSacServices : IMauSacServices
    {
        private MauSacRepository _repository;

        public MauSacServices()
        {
            _repository = new MauSacRepository();
        }

        public List<MauSac> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Sua(Guid Id, string ma, string ten, int trangThai)
        {
            var mauSac = new MauSac
            {
                Id = Id,
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai,
            };
            return _repository.Sua(mauSac);
        }

        public bool Them(string ma, string ten, int trangThai)
        {
            var mauSac = new MauSac
            {
                Id = Guid.NewGuid(),
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai
            };
            return _repository.Them(mauSac);
        }

        public bool Xoa(Guid Id)
        {
            var mauSac = new MauSac
            {
                Id = Id,
            };
            return _repository.Xoa(mauSac);
        }
    }
}
