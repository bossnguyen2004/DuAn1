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
    public class AnhServices : IAnhServices
    {
        private AnhRepository _repository;

        public AnhServices()
        {
            _repository = new AnhRepository();
        }
        public List<Anh> GetAll()
        {
            return _repository.GetAll();
        }

        public Guid Id(AnhViewModels img)
        {
            throw new NotImplementedException();
        }

        public bool Sua(Guid Id, string ma, string ten, string duongdan, int trangThai)
        {
            var anh = new Anh
            {
               ID = Id,
               MaAnh = ma,
               Ten = ten,
                DuongDan = duongdan,
                TrangThai = trangThai,
            };
            return _repository.Sua(anh);
        }

        public bool Them(string ma, string ten, string duongdan, int trangThai)
        {
            var anh = new Anh
            {
                ID = Guid.NewGuid(),
                MaAnh = ma,
                Ten = ten,
                DuongDan = duongdan,
                TrangThai = trangThai,
            };
            return _repository.Them(anh);
        }

        public bool Xoa(Guid Id)
        {
            var anh = new Anh
            {
                ID = Id,
            };
            return _repository.Xoa(anh);
        }
        public bool timKiem(string ten)
        {
            return true;
        }
    }
}
