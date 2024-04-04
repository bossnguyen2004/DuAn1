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
    public class SanPhamCTServices : ISanPhamChiTietServices
    {
        private INhaSanXuatRepositories _nhaSanXuatRepositories;
        private IChatLieuRepositories _chatLieuRepositories;
        private ISanPhamRepositories _sanPhamRepositories;
        private ILoaiGiayRepositories _loaiGiayRepositories;
        private IAnhRepositories _anhRepositories;
        private ISizeGiayRepositories _sizeGiayRepositories;
        private IMauSacRepositories _manauSacRepositories;
        private ISanPhamCTRepositories _sanPhamCTRepositories;

        public SanPhamCTServices()
        {
            _sanPhamCTRepositories = new SanPhamCTRepository();
            _nhaSanXuatRepositories = new NhaSanXuatRepository();
            _chatLieuRepositories = new ChatLieuRepository();
            _sanPhamRepositories = new SanPhamRepository();
            _loaiGiayRepositories = new LoaiGiayRepositoy();
            _anhRepositories = new AnhRepository();
            _manauSacRepositories = new MauSacRepository();
            _sizeGiayRepositories = new SizeGiayRepository();
        }

        public List<SanPhamCTViewModels> GetAll()
        {
            List<SanPhamCTViewModels> lstSanPhamCT = (from a in _sanPhamCTRepositories.GetAll().OrderBy(x => x.Id)
                                                      join b in _sanPhamRepositories.GetAll() on a.IdSanPham equals b.Id
                                                      join c in _anhRepositories.GetAll() on a.IdAnh equals c.ID
                                                      join d in _loaiGiayRepositories.GetAll() on a.IdLoaiGiay equals d.Id
                                                      join h in _manauSacRepositories.GetAll() on a.IdMauSac equals h.Id
                                                      join f in _sizeGiayRepositories.GetAll() on a.IdSizeGiay equals f.Id
                                                      join k in _nhaSanXuatRepositories.GetAll() on b.IdNhaSanXuat equals k.Id
                                                      join m in _chatLieuRepositories.GetAll() on b.IdChatLieu equals m.Id

                                                      select new SanPhamCTViewModels()
                                                      {
                                                          Id = a.Id.GetValueOrDefault(),
                                                          IdSp = b.Id,
                                                          IdAnh = c.ID,
                                                          IdLoaiGiay = d.Id,
                                                          IdMauSac = h.Id,
                                                          IdSizeGiay = f.Id,
                                                          IdNsx = k.Id,
                                                          IdChatLieu = m.Id,
                                                          Ma = b.Ma,
                                                          Ten = b.Ten,
                                                          TenSp = b.Ten,
                                                          TrangThai = b.TrangThai,
                                                          SoLuongTon = a.SoLuongTon,
                                                          GiaBan = a.GiaBan,
                                                          GiaNhap = a.GiaNhap,
                                                          NamBh = a.NamBh,
                                                          SoSize = f.SoSize,
                                                          TenChatLieu = m.Ten,
                                                          TenNsx = k.Ten,
                                                          TenLoaiGiay = d.Ten,
                                                          DuongDanAnh = c.DuongDan,


                                                      }).ToList();
            return lstSanPhamCT;

        }

        public List<SanPhamChiTiet> GetAllChiTiet()
        {
            return _sanPhamCTRepositories.GetAll().ToList();
        }

        public bool Sua(Guid Id, int namBH, string mota, int soluongTon, decimal giaNhap, decimal giaBan, int trangThai, string idSP, string idAnh, string idloaiGiay, string idsizeGiay, string idmauSac)
        {
            throw new NotImplementedException();
        }

        public bool Them(SanPhamCTViewModels spct)
        {
            SanPhamChiTiet sanPhamCTViewModels = new SanPhamChiTiet();
            sanPhamCTViewModels.IdSanPham = spct.IdSp;
            sanPhamCTViewModels.IdAnh = spct.IdAnh;
            sanPhamCTViewModels.IdLoaiGiay = spct.IdLoaiGiay;
            sanPhamCTViewModels.IdMauSac = spct.IdMauSac;
            sanPhamCTViewModels.IdSizeGiay = spct.IdSizeGiay;
            sanPhamCTViewModels.NamBh = spct.NamBh;
            sanPhamCTViewModels.MoTa = spct.MoTa;
            sanPhamCTViewModels.SoLuongTon = spct.SoLuongTon;
            sanPhamCTViewModels.GiaNhap = spct.GiaNhap;
            sanPhamCTViewModels.GiaBan = spct.GiaBan;
            sanPhamCTViewModels.TrangThai = spct.TrangThai;
            if (_sanPhamCTRepositories.Them(sanPhamCTViewModels))
            {
                return true;
            }
            else { return false; }
        }

        public List<SanPhamCTViewModels> TimKiem(string Ma)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
