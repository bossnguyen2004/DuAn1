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
    public class GiaoCaServices : IGiaoCaServices
    {
        private IGiaoCaRepositories _giaoCaRepositories;
        public GiaoCaServices()
        {
                _giaoCaRepositories = new GiaoCaRepository();
        }

        public List<GiaoCaViewModels> GetAll()
        {
            var lstGiaoCaModel = _giaoCaRepositories.GetAll();
            var lstGiaoCaViewModel = new List<GiaoCaViewModels>();
            foreach (var item in lstGiaoCaModel)
            {
                var gC2 = new GiaoCaViewModels
                {
                    Id = item.Id,
                    Ma = item.Ma,
                    ThoiGianNhanCa = item.ThoiGianNhanCa,
                    ThoiGianGiaoCa = item.ThoiGianGiaoCa,
                    IdNvNhanCaTiep = item.IdNvNhanCaTiep,
                    IdNvTrongCa = item.IdNvTrongCa,
                    TienBanDau = item.TienBanDau,
                    TongTienTrongCa = item.TongTienTrongCa,
                    TongTienMat = item.TongTienMat,
                    TongTienKhac = item.TongTienKhac,
                    TienPhatSinh = item.TienPhatSinh,
                    GhiChuPhatSinh = item.GhiChuPhatSinh,
                    TongTienCaTruoc = item.TongTienCaTruoc,
                    Time = item.Time,
                    TongTienMatRut = item.TongTienMatRut,
                    TrangThai = item.TrangThai,

                };
                lstGiaoCaViewModel.Add(gC2);
            }
            return lstGiaoCaViewModel;
        }

        public Guid GetId(GiaoCaViewModels giaoCa)
        {
            var GiaoCaModel = new GiaoCa
            {
                Id = new Guid(),
                Ma = giaoCa.Ma,
                ThoiGianNhanCa = giaoCa.ThoiGianNhanCa,
                ThoiGianGiaoCa = giaoCa.ThoiGianGiaoCa,
                IdNvNhanCaTiep = giaoCa.IdNvNhanCaTiep,
                IdNvTrongCa = giaoCa.IdNvTrongCa,
                TienBanDau = giaoCa.TienBanDau,
                TongTienTrongCa = giaoCa.TongTienTrongCa,
                TongTienMat = giaoCa.TongTienMat,
                TongTienKhac = giaoCa.TongTienKhac,
                TienPhatSinh = giaoCa.TienPhatSinh,
                GhiChuPhatSinh = giaoCa.GhiChuPhatSinh,
                TongTienCaTruoc = giaoCa.TongTienCaTruoc,
                Time = giaoCa.Time,
                TongTienMatRut = giaoCa.TongTienMatRut,
                TrangThai = giaoCa.TrangThai,
            };
            if (_giaoCaRepositories.Them(GiaoCaModel))
            {
                return GiaoCaModel.Id;
            }
            else return Guid.Empty;
        }

        public bool Sua(GiaoCaViewModels giaoCaViewModels)
        {
            throw new NotImplementedException();
        }

        public bool Them(GiaoCaViewModels giaoCa)
        {
            var GiaoCaModel = new GiaoCa
            {
                Id = new Guid(),
                Ma = giaoCa.Ma,
                ThoiGianNhanCa = giaoCa.ThoiGianNhanCa,
                ThoiGianGiaoCa = giaoCa.ThoiGianGiaoCa,
                IdNvNhanCaTiep = giaoCa.IdNvNhanCaTiep,
                IdNvTrongCa = giaoCa.IdNvTrongCa,
                TienBanDau = giaoCa.TienBanDau,
                TongTienTrongCa = giaoCa.TongTienTrongCa,
                TongTienMat = giaoCa.TongTienMat,
                TongTienKhac = giaoCa.TongTienKhac,
                TienPhatSinh = giaoCa.TienPhatSinh,
                GhiChuPhatSinh = giaoCa.GhiChuPhatSinh,
                TongTienCaTruoc = giaoCa.TongTienCaTruoc,
                Time = giaoCa.Time,
                TongTienMatRut = giaoCa.TongTienMatRut,
                TrangThai = giaoCa.TrangThai,

            };
            var relut = _giaoCaRepositories.Them(GiaoCaModel);
            return relut;

        }

        public List<GiaoCaViewModels> TimKiem(string Ma)
        {
            var lstGiaoCaModel =_giaoCaRepositories.TimKiem(Ma);
            var lstGiaoCaViewModel = new List<GiaoCaViewModels>();
            foreach (var item in lstGiaoCaModel)
            {
                var gC2 = new GiaoCaViewModels
                {
                    Id = item.Id,
                    Ma = item.Ma,
                    ThoiGianNhanCa = item.ThoiGianNhanCa,
                    ThoiGianGiaoCa = item.ThoiGianGiaoCa,
                    IdNvNhanCaTiep = item.IdNvNhanCaTiep,
                    IdNvTrongCa = item.IdNvTrongCa,
                    TienBanDau = item.TienBanDau,
                    TongTienTrongCa = item.TongTienTrongCa,
                    TongTienMat = item.TongTienMat,
                    TongTienKhac = item.TongTienKhac,
                    TienPhatSinh = item.TienPhatSinh,
                    GhiChuPhatSinh = item.GhiChuPhatSinh,
                    TongTienCaTruoc = item.TongTienCaTruoc,
                    Time = item.Time,
                    TongTienMatRut = item.TongTienMatRut,
                    TrangThai = item.TrangThai,

                };
                lstGiaoCaViewModel.Add(gC2);
            }
            return lstGiaoCaViewModel;

        }

        public bool Xoa(Guid Id)
        {
            var kq = _giaoCaRepositories.Xoa(Id);
            return kq;
        }
    }
}
