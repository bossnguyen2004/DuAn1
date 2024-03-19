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
    public class NhanVienServices : INhanVienServices
    {
        private INhanVienRepositories _nhanVienrepositories;
        public NhanVienServices()
        {
            _nhanVienrepositories = new NhanVienRepostory();
        }

        public List<NhanVienViewModels> GetAll()
        {
            var lstNhanVienModel = _nhanVienrepositories.GetAll();
            var lstNhanVienViewModel = new List<NhanVienViewModels>();
            foreach (var item in lstNhanVienModel)
            {
                var nhanVien = new NhanVienViewModels
                {
                    Id = item.Id,
                    Ma = item.Ma,
                    Ho = item.Ho,
                    Ten = item.Ten,
                    GioiTinh = item.GioiTinh,
                    NamSinh = item.NamSinh,
                    QueQuan = item.QueQuan,
                    Sdt = item.Sdt,
                    MatKhau = item.MatKhau,
                    Email = item.Email,
                    CMND = item.CMND,
                    IdCv = item.IdCv,
                    TrangThai = item.TrangThai,
                    Anh = item.Anh,
                };
                lstNhanVienViewModel.Add(nhanVien);
            }
            return lstNhanVienViewModel;
        }

        public NhanVienViewModels Login(string ma, string pass)
        {
            var user = _nhanVienrepositories.Login(ma, pass);
            if (user != null)
            {
                return new NhanVienViewModels
                {
                    Id = user.Id,
                    Ho = user.Ho,
                    Ten = user.Ten
                };
            }
            else
                return null;
        }

        public bool Sua(NhanVienViewModels nhanViens)
        {
            var lstnhanVien = new NhanVien
            {
                Id = nhanViens.Id,
                Ma = nhanViens.Ma,
                Ho = nhanViens.Ho,
                Ten = nhanViens.Ten,
                GioiTinh = nhanViens.GioiTinh,
                NamSinh = nhanViens.NamSinh,
                QueQuan = nhanViens.QueQuan,
                Sdt = nhanViens.Sdt,
                MatKhau = nhanViens.MatKhau,
                Email = nhanViens.Email,
                CMND = nhanViens.CMND,
                IdCv = nhanViens.IdCv,
                TrangThai = nhanViens.TrangThai,
                Anh = nhanViens.Anh,

            };
            var reluts = _nhanVienrepositories.Update(lstnhanVien);
            return reluts;
        }

        public bool Them(NhanVienViewModels nhanVien)
        {
            var nhanVenModel = new NhanVien
            {
                Id = Guid.NewGuid(),
                Ma = nhanVien.Ma,
                Ho = nhanVien.Ho,
                Ten = nhanVien.Ten,
                GioiTinh = nhanVien.GioiTinh,
                NamSinh = nhanVien.NamSinh,
                QueQuan = nhanVien.QueQuan,
                Sdt = nhanVien.Sdt,
                MatKhau = nhanVien.MatKhau,
                Email = nhanVien.Email,
                CMND = nhanVien.CMND,
                IdCv = nhanVien.IdCv,
                TrangThai = nhanVien.TrangThai,
                Anh = nhanVien.Anh,

            };
            var relut = _nhanVienrepositories.Create(nhanVenModel);
            return relut;
        }

        public List<NhanVienViewModels> TimKiem(string Ma)
        {
            var lstNhanVienModel = _nhanVienrepositories.Search(Ma);
            var lstNhanVienViewModel = new List<NhanVienViewModels>();
            foreach (var item in lstNhanVienModel)
            {
                var nhanVien = new NhanVienViewModels
                {
                    Id = item.Id,
                    Ma = item.Ma,
                    Ho = item.Ho,
                    Ten = item.Ten,
                    GioiTinh = item.GioiTinh,
                    NamSinh = item.NamSinh,
                    QueQuan = item.QueQuan,
                    Sdt = item.Sdt,
                    MatKhau = item.MatKhau,
                    Email = item.Email,
                    CMND = item.CMND,
                    IdCv = item.IdCv,
                    TrangThai = item.TrangThai,
                    Anh = item.Anh,
                };
                lstNhanVienViewModel.Add(nhanVien);
            }
            return lstNhanVienViewModel;
        }

        public bool Xoa(Guid Id)
        {
           var nhanVien = _nhanVienrepositories.Delete(Id);
            return nhanVien;
        }
    }
}
