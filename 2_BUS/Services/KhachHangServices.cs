using _1_DAL.IRepositories;
using _1_DAL.Models;
using _1_DAL.Repository;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class KhachHangServices : IKhachHangServices
    {
        private IKhachHangRepositories _repository;

        public KhachHangServices()
        {
            _repository = new KhachHangRepository();
        }

        public List<KhachHang> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Add(string ma, string ten, string sdt, string diaChi, string email, int gioiTinh, DateTime namSinh, int trangThai)
        {
            var khachHang = new KhachHang
            {
                Id = Guid.NewGuid(),
                Ma = ma,
                Ten = ten,
                Sdt = sdt,
                DiaChi = diaChi,
                Email = email,
                GioiTinh = gioiTinh,
                NamSinh = namSinh,
                TrangThai = trangThai
            };
            return _repository.Add(khachHang);
        }

        public bool Update(Guid id, string ma, string ten, string sdt, string diaChi, string email, int gioiTinh, DateTime namSinh, int trangThai)
        {
            var khachHang = new KhachHang
            {
                Id = id,
                Ma = ma,
                Ten = ten,
                Sdt = sdt,
                DiaChi = diaChi,
                Email = email,
                GioiTinh = gioiTinh,
                NamSinh = namSinh,
                TrangThai = trangThai
            };
            return _repository.Update(khachHang);
        }

        public bool Delete(Guid id)
        {
            var khachHang = new KhachHang
            {

                Id = id
            };
            return _repository.Delete(khachHang);
        }
    }
}
