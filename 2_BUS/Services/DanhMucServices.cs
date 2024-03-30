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
    public class DanhMucServices : IDanhMucServices
    {
        private IDanhMucRepositories _repository;

        public DanhMucServices()
        {
            _repository = new DanhMucRepository();

        }

        public List<DanhMuc> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Sua(Guid Id, string ma, string ten, int trangThai)
        {

            var DM = new DanhMuc
            {
                Id = Id,
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai,
            };
            return _repository.Sua(DM);
        }

        public bool Them(string ma, string ten, int trangThai)
        {
            var DM = new DanhMuc
            {
                Id = Guid.NewGuid(),
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai
            };
            return _repository.Them(DM);
        }

        public bool Xoa(Guid Id)
        {
            var DM = new DanhMuc
            {
                Id = Id,
            };
            return _repository.Xoa(DM);
        }
    }
}
