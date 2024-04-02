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

        public bool Sua(Guid Id, int namBH, string mota, int soluongTon, decimal giaNhap, decimal giaBan, int trangThai, string idSP, string idAnh, string idloaiGiay, string idsizeGiay, string idmauSac)
        {
            throw new NotImplementedException();
        }

        public bool Them(int namBH, string mota, int soluongTon, decimal giaNhap, decimal giaBan, int trangThai, string idSP, string idAnh, string idloaiGiay, string idsizeGiay, string idmauSac)
        {
            Guid? parsedIdSanPham = Guid.Empty;
            Guid? parsedIdAnh = Guid.Empty;
            Guid? parsedIdLoaiGiay = Guid.Empty;
            Guid? parsedIdSizeGiay = Guid.Empty;
            Guid? parsedIdMausac = Guid.Empty;
            Guid tempIdSanPham,tempIdAnh,tempLoaiGiay,tempSizeGiay,tempIdMausac;
            if (Guid.TryParse(idSP, out tempIdSanPham))
            {
                parsedIdSanPham = tempIdSanPham;
            }
            if (Guid.TryParse(idAnh, out tempIdAnh))
            {
                parsedIdAnh = tempIdAnh;
            }
            if (Guid.TryParse(idloaiGiay, out tempLoaiGiay))
            {
                parsedIdLoaiGiay= tempLoaiGiay;
            }
            if (Guid.TryParse(idsizeGiay, out tempSizeGiay))
            {
                parsedIdSizeGiay = tempSizeGiay;
            }
            if (Guid.TryParse(idmauSac, out tempIdMausac))
            {
                parsedIdMausac = tempIdMausac;
            }

            var sanphamct = new SanPhamChiTiet
            {
                Id = Guid.NewGuid(),
                NamBh = namBH,
                MoTa = mota,
                SoLuongTon = soluongTon,
                GiaBan = giaBan,
                GiaNhap = giaNhap,
                TrangThai = trangThai,
                IdSanPham = parsedIdSanPham,
                IdAnh = parsedIdAnh,
                IdLoaiGiay = parsedIdLoaiGiay,
                IdMauSac = parsedIdMausac,
                IdSizeGiay = parsedIdSizeGiay
            };
            return _sanPhamCTRepositories.Them(sanphamct);

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
