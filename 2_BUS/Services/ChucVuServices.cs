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
    public class ChucVuServices : IChucVuServices
    {
        private IChucVuRepositories _chucVurepository;
        private INhanVienRepositories _nhanVienRepository;

        public ChucVuServices()
        {
            _chucVurepository = new ChucVuRepostory();
            _nhanVienRepository = new NhanVienRepostory();
        }



        public List<ChucVuViewModels> GetAll()
        {
            var lstchucVuModel = _chucVurepository.GetAll();
            var lstchucVuVM = new List<ChucVuViewModels>();
            foreach (var item in lstchucVuModel)
            {
                var chucVu = new ChucVuViewModels
                {
                    Id = item.Id.GetValueOrDefault(),
                    Ma = item.Ma,
                    Ten = item.Ten,
                    TrangThai = item.TrangThai,
                };
                lstchucVuVM.Add(chucVu);
            }
            return lstchucVuVM;
        }

       
        public List<ChucVuViewModels> GetChucVu()
        {
            return (from a in _chucVurepository.GetAll()
                    join b in _nhanVienRepository.GetAll() on a.Id equals b.IdCv
                    select new ChucVuViewModels
                    {
                        Id = a.Id.GetValueOrDefault(),
                        IdNv = b.Id,
                        Ten = a.Ten,
                    }).ToList();
        }


        public bool Sua(ChucVuViewModels chucVu)
        {
            var lstchucVu = new ChucVu
            {
                Id = chucVu.Id,
                Ma = chucVu.Ma,
                Ten = chucVu.Ten,
                TrangThai = chucVu.TrangThai,
            };
            var reluts = _chucVurepository.Sua(lstchucVu);
            return reluts;
        }

      

        public bool Them(ChucVuViewModels chucVu)
        {
            var lstchucvu = new ChucVu
            {
                Id = Guid.NewGuid(),
                Ma = chucVu.Ma,
                Ten = chucVu.Ten,
                TrangThai = chucVu.TrangThai,
            };
            var reluts = _chucVurepository.Them(lstchucvu);
            return reluts;
        }

        public List<ChucVuViewModels> TimKiem(string Ma)
        {
           var lstchucVuModel = _chucVurepository.TimKiem(Ma);
            var lstchucVuVM = new List<ChucVuViewModels>();
            foreach (var item in lstchucVuModel)
            {
                var chucVu = new ChucVuViewModels
                {
                    Id = item.Id.GetValueOrDefault(),
                    Ma = item.Ma,
                    Ten = item.Ten,
                    TrangThai = item.TrangThai,
                };
                lstchucVuVM.Add(chucVu);
            }
            return lstchucVuVM;
        }

        public bool Xoa(Guid Id)
        {
            var lstchucvu = _chucVurepository.Xoa(Id);
            return lstchucvu;
        }

       

       
    }
}
