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
    public class HoaDonServices : IHoaDonServices
    {
        private IHoaDonRepositories _hoaDonRepositories;
        private IHoaDonCTRepositories _hoaDonCTRepositories;
        private ISanPhamRepositories _sanPhamRepositories;
        private ISanPhamCTRepositories _sanPhamCTRepositories;
        private IKhachHangRepositories _khachHangRepositories;

        public HoaDonServices()
        {
            _hoaDonRepositories = new HoaDonRepository();
            _hoaDonCTRepositories = new HoaDonCTRepository();
            _sanPhamRepositories = new SanPhamRepository();
            _sanPhamCTRepositories = new SanPhamCTRepository();
            _khachHangRepositories = new KhachHangRepository();
        }

        public bool Add(Guid idSp, Guid idNv, string SDT, string diaChi, string moTa, string email, int soLuong)
        {
            var hoaDon = new HoaDon()
            {
                Id = Guid.NewGuid()
            };
            if (idNv != null)
            {
                hoaDon.IdNv = idNv;
            }
            else
            {
                idNv = Guid.Parse("6dc73067-fc7d-4ff2-95b7-23ac6dbf4db8");
            }
            hoaDon.IdThanhToan = Guid.Parse("58e29ffc-7e68-44c2-8e9e-947ae81c74c0") ;
            hoaDon.IdVouCher = Guid.Parse("c62f84bd-e1a4-4a75-afd9-e67f53c3260f");
            var kh = _khachHangRepositories.GetAll().Where(x => x.Email != null && x.Email.ToLower().Equals(email.ToLower()) || x.Sdt.Equals(SDT)).FirstOrDefault();
            if (kh != null)
            {
                hoaDon.IdKh = kh.Id;
            }
            else
            {
                hoaDon.IdKh = Guid.Parse("e7b052c1-9c3e-46df-920a-e0f03f46374d");
            }
            hoaDon.DiaChi = diaChi;
            hoaDon.SDT = SDT;
            hoaDon.TinhTrang = 1;
            hoaDon.MoTa = moTa;
            var ranDom = new Random();
            hoaDon.Ma = "HD_" + ranDom.Next(0, 1000);
            var ketQua = _hoaDonRepositories.Them(hoaDon);

            var hoaDonChiTiet = new HoaDonChiTiet()
            {
                Id = Guid.NewGuid(),
                IdHoaDon = hoaDon.Id,
                SoLuong = soLuong
            };
            var chiTietSp = _sanPhamCTRepositories.GetAll().Where(s => s.IdSanPham == idSp).FirstOrDefault();
            if (chiTietSp != null)
            {
                hoaDonChiTiet.IdChiTietSanPham = chiTietSp.Id;
                hoaDonChiTiet.ThanhTien = chiTietSp.GiaBan * soLuong;
            }
            ketQua = _hoaDonCTRepositories.Them(hoaDonChiTiet);
            return ketQua;
        }

        public bool Buy(Guid idSp, Guid idKh, string SDT, string diaChi, string moTa, string email, int soLuong)
        {
            var hoaDon = new HoaDon()
            {
                Id = Guid.NewGuid()
            };
            if (idKh != null)
            {
                hoaDon.IdKh = idKh;
            }
            else
            {
                hoaDon.IdKh = Guid.NewGuid();
            }
            hoaDon.IdNv = Guid.Parse("2547B172-DB0E-423F-9BF9-5304547410B5");
            hoaDon.IdThanhToan = Guid.Parse("58e29ffc-7e68-44c2-8e9e-947ae81c74c0");
            hoaDon.IdVouCher = Guid.Parse("c62f84bd-e1a4-4a75-afd9-e67f53c3260f");
            hoaDon.DiaChi = diaChi;
            hoaDon.SDT = SDT;
            hoaDon.TinhTrang = 1;
            hoaDon.MoTa = moTa;
            var ranDom = new Random();
            hoaDon.Ma = "HD_" + ranDom.Next(0, 1000);
            var ketQua = _hoaDonRepositories.Them(hoaDon);

            var hoaDonChiTiet = new HoaDonChiTiet()
            {
                Id = Guid.NewGuid(),
                IdHoaDon = hoaDon.Id,
                SoLuong = soLuong
            };
            var chiTietSp = _sanPhamCTRepositories.GetAll().Where(s => s.IdSanPham == idSp).FirstOrDefault();
            if (chiTietSp != null)
            {
                hoaDonChiTiet.IdChiTietSanPham = chiTietSp.Id;
                hoaDonChiTiet.ThanhTien = chiTietSp.GiaBan * soLuong;
            }
            ketQua = _hoaDonCTRepositories.Them(hoaDonChiTiet);
            return ketQua;
        }

        public bool Delete(Guid id)
        {
            var hoaDonCT = _hoaDonCTRepositories.GetAll().Where(x => x.IdHoaDon == id).ToList();
            foreach (var item in hoaDonCT)
            {
                _hoaDonCTRepositories.Xoa(item);
            }
            var hoaDon = _hoaDonRepositories.GetAll().Where(a => a.Id == id).FirstOrDefault();
            if(hoaDon != null)
            {
                return _hoaDonRepositories.Xoa(hoaDon);
            }
            return false;
        }

        public List<HoaDon> GetAll()
        {
            return _hoaDonRepositories.GetAll();
        }

        public bool Update(Guid idHoaDon, Guid idNv, string SDT, string diaChi, string moTa, string email, int soLuong)
        {

            var hoaDon = _hoaDonRepositories.GetAll().Where(x => x.Id == idHoaDon).FirstOrDefault();
            if(hoaDon != null)
            {
                hoaDon.SDT = SDT;
                hoaDon.MoTa = moTa;
                hoaDon.DiaChi = diaChi;
            }
            if (idNv != null)
            {
                hoaDon.IdNv = idNv;
            }
            else
            {
                idNv = Guid.Parse("6dc73067-fc7d-4ff2-95b7-23ac6dbf4db8");
            }
            var ketQua = _hoaDonRepositories.Sua(hoaDon);

            var hoaDonChiTiet = _hoaDonCTRepositories.GetAll().Where(x => x.IdHoaDon == idHoaDon).ToList();
            foreach (var hdChiTiet in hoaDonChiTiet)
            {
                hdChiTiet.SoLuong = soLuong;
                _hoaDonCTRepositories.Sua(hdChiTiet);
            }
            return ketQua;
        }
    }
}
