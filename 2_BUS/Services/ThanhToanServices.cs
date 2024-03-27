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
    public class ThanhToanServices : IThanhToanServices
    {
        private ThanhToanRepository _repository;

        public ThanhToanServices()
        {
            _repository = new ThanhToanRepository();
        }

        public List<ThanhToan> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Sua(Guid Id, string ma, string ten, int trangThai)
        {
            var TT = new ThanhToan
            {
                Id = Id,
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai,
            };
            return _repository.Sua(TT);
        }

        public bool Them(string ma, string ten, int trangThai)
        {
            var TT = new ThanhToan
            {
                Id = Guid.NewGuid(),
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai
            };
            return _repository.Them(TT);
        }

        public bool Xoa(Guid Id)
        {

            var TT = new ThanhToan
            {
                Id = Id,
            };
            return _repository.Xoa(TT);
        }
    }
}
