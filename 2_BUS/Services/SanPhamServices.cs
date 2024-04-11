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
    public class SanPhamServices : ISanPhamServices
    {

        private INhaSanXuatRepositories _nhaSanXuatRepositories;
        private IChatLieuRepositories _chatLieuRepositories;
        private ISanPhamRepositories _sanPhamRepositories;
        private ILoaiGiayRepositories _loaiGiayRepositories;
        private IAnhRepositories _anhRepositories;
        private ISizeGiayRepositories _sizeGiayRepositories;
        private IMauSacRepositories _manauSacRepositories;
        private ISanPhamCTRepositories _sanPhamCTRepositories;
        private IKieuDanhMucRepositories  _kieuDanhMucRepositories;
        private IHoaDonRepositories _hoaDonRepositories;
        private IHoaDonCTRepositories _hoaDonCTRepositories;

        public SanPhamServices()
        {
            _nhaSanXuatRepositories = new NhaSanXuatRepository();
            _chatLieuRepositories = new ChatLieuRepository();
            _sanPhamRepositories = new SanPhamRepository();
            _loaiGiayRepositories = new LoaiGiayRepositoy();
            _anhRepositories = new AnhRepository();
            _manauSacRepositories = new MauSacRepository();
            _sizeGiayRepositories = new SizeGiayRepository();
            _sanPhamCTRepositories = new SanPhamCTRepository();
            _kieuDanhMucRepositories = new KieuDanhMucRepository();
            _hoaDonRepositories = new HoaDonRepository();
            _hoaDonCTRepositories = new HoaDonCTRepository();
        }

        public List<SanPhamViewModels> GetAll()
        {
            List<SanPhamViewModels> lstSanPham = (from a in _sanPhamRepositories.GetAll().OrderBy(c => c.Id)
                                                  join b in _nhaSanXuatRepositories.GetAll() on a.IdNhaSanXuat equals b.Id
                                                  join c in _chatLieuRepositories.GetAll() on a.IdChatLieu equals c.Id
                                                  select new SanPhamViewModels()
                                                  {
                                                      Id = a.Id.GetValueOrDefault(),
                                                      Ma = a.Ma,
                                                      Ten = a.Ten,
                                                      TrangThai = a.TrangThai,
                                                      IdNhaSanXuat = b.Id,
                                                      idChatLieu = c.Id,

                                                  }).ToList();
            return lstSanPham;


        }

        public List<SanPham> GetAllSanPham()
        {
            return _sanPhamRepositories.GetAll().ToList();
        }

        public List<ProductsViewModel> GetProducts()
        {
            List<ProductsViewModel> lstSanPham = (from s in _sanPhamRepositories.GetAll().OrderBy(c => c.Id)
                                                  join ct in _sanPhamCTRepositories.GetAll() on s.Id equals ct.IdSanPham
                                                  join b in _nhaSanXuatRepositories.GetAll() on s.IdNhaSanXuat equals b.Id
                                                  join c in _chatLieuRepositories.GetAll() on s.IdChatLieu equals c.Id
                                                  join a in _anhRepositories.GetAll() on ct.IdAnh equals a.ID
                                                  join l in _loaiGiayRepositories.GetAll() on ct.IdLoaiGiay equals l.Id
                                                  join m in _manauSacRepositories.GetAll() on ct.IdMauSac equals m.Id
                                                  join k in _sizeGiayRepositories.GetAll() on ct.IdSizeGiay equals k.Id
                                                  select new ProductsViewModel()
                                                  {
                                                      Id = s.Id.GetValueOrDefault(),
                                                      TenSanPham = s.Ten,
                                                      MaSanPham = s.Ma,
                                                      TrangThai = s.TrangThai,
                                                      IdNSX = b.Id,
                                                      TenNSX = b.Ten,
                                                      IdChatLieu = c.Id,
                                                      TenChatLieu = c.Ten,
                                                      IdSize = k.Id,
                                                      Size = k.SoSize,
                                                      IdMauSac = m.Id

                                                  }).ToList();
            return lstSanPham;
        }

        public bool Sua(Guid Id, string ma, string ten, int trangThai, string idNhaSanXuat, string idChatLieum)
        {
            // Chuyển đổi idNhaSanXuat và idChatLieu thành dạng Guid
            Guid? parsedIdNhaSanXuat = Guid.TryParse(idNhaSanXuat, out Guid tempIdNhaSanXuat) ? tempIdNhaSanXuat : Guid.Empty;
            Guid? parsedIdChatLieu = Guid.TryParse(idChatLieum, out Guid tempIdChatLieu) ? tempIdChatLieu : Guid.Empty;

            // Tạo đối tượng SanPham mới để cập nhật thông tin
            var sanPham = new SanPham
            {
                Id = Id,
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai,
                IdNhaSanXuat = parsedIdNhaSanXuat,
                IdChatLieu = parsedIdChatLieu
            };

            // Gọi phương thức Sua từ repository để thực hiện cập nhật thông tin sản phẩm
            return _sanPhamRepositories.Sua(sanPham);

        }

        public bool Them(string ma, string ten, int trangThai, string idNhaSanXuat, string idChatLieu)
        {
            Guid? parsedIdNhaSanXuat = Guid.Empty;
            Guid? parsedIdChatLieu = Guid.Empty;

            Guid tempIdNhaSanXuat, tempIdChatLieu;
            if (Guid.TryParse(idNhaSanXuat, out tempIdNhaSanXuat))
            {
                parsedIdNhaSanXuat = tempIdNhaSanXuat;
            }
            if (Guid.TryParse(idChatLieu, out tempIdChatLieu))
            {
                parsedIdChatLieu = tempIdChatLieu;
            }

            var sanPham = new SanPham
            {
                Id = Guid.NewGuid(),
                Ma = ma,
                Ten = ten,
                TrangThai = trangThai,
                IdChatLieu = parsedIdChatLieu,
                IdNhaSanXuat = parsedIdNhaSanXuat
            };
            return _sanPhamRepositories.Them(sanPham);
        }

        public bool Add(string ma, string ten, int trangThai, string anh, decimal giaBan, Guid idChatLieu, Guid idNSX, Guid idLoai, Guid idSize, Guid idMauSac)
        {
            bool ketQua = false;
            // luu san pham
            var sp = new SanPham()
            {
                Id = Guid.NewGuid(),
                Ten = ten,
                Ma = ma,
                TrangThai = trangThai,
                IdChatLieu = idChatLieu,
                IdNhaSanXuat = idNSX
            };
            ketQua = _sanPhamRepositories.Them(sp);

            // luu anh
            var anhSp = new Anh()
            {
                ID = Guid.NewGuid(),
                DuongDan = anh,
                MaAnh = "IMG_" + ma,
            };
            ketQua = _anhRepositories.Them(anhSp);

            // luu san pham chi tiet
            var chiTiet = new SanPhamChiTiet()
            {
                Id = Guid.NewGuid(),
                IdAnh = anhSp.ID,
                IdLoaiGiay = idLoai,
                IdMauSac = idMauSac,
                IdSanPham = sp.Id,
                IdSizeGiay = idSize,
                GiaBan = giaBan,
                TrangThai = trangThai
            };
            ketQua = _sanPhamCTRepositories.Them(chiTiet);
            return ketQua;
        }

        public bool Update(Guid id, string ma, string ten, int trangThai, string anh, decimal giaBan, Guid idChatLieu, Guid idNSX, Guid idLoai, Guid idSize, Guid idMauSac)
        {
            bool ketQua = false;
            var sp = _sanPhamRepositories.GetAll().Where(x => x.Id == id).FirstOrDefault();
            sp.Ten = ten;
            sp.Ma = ma;
            sp.TrangThai = trangThai;
            sp.IdChatLieu = idChatLieu;
            sp.IdNhaSanXuat = idNSX;
            ketQua = _sanPhamRepositories.Sua(sp);

            var lstChiTiet = _sanPhamCTRepositories.GetAll().Where(x => x.IdSanPham == id).ToList();
            foreach (var item in lstChiTiet)
            {
                var lstAnh = _anhRepositories.GetAll().Where(x => x.ID == item.IdAnh).ToList();
                foreach (var itemAnh in lstAnh)
                {
                    itemAnh.DuongDan = anh;
                    itemAnh.MaAnh = "IMG_" + ma;
                    ketQua = _anhRepositories.Sua(itemAnh);
                }
                item.IdSizeGiay = idSize;
                item.IdMauSac = idMauSac;
                item.GiaBan = giaBan;
                item.TrangThai = trangThai;
                item.IdLoaiGiay = idLoai;
                ketQua = _sanPhamCTRepositories.Sua(item);
            }
            return ketQua;
        }

        public List<SanPhamViewModels> TimKiem(string Ma)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            bool ketQua = false;
            var lstChiTiet = _sanPhamCTRepositories.GetAll();
            var lstDelete = lstChiTiet.Where(x => x.IdSanPham == id);
            foreach ( var x in lstChiTiet)
            {
                ketQua = _sanPhamCTRepositories.Xoa(x);
            }
            // xoa kieu danh muc
            var kieuDanhMuc = _kieuDanhMucRepositories.GetAll();
            var lstDanhMucDelete = kieuDanhMuc.Where(x => x.IdSanPham == id);
            foreach(var danhMuc in lstDanhMucDelete)
            {
                ketQua = _kieuDanhMucRepositories.Xoa(danhMuc);
            }
            // xoa san pham
            var sanPham = new SanPham()
            {
                Id = id
            };
            ketQua = _sanPhamRepositories.Xoa(sanPham);
            return ketQua;
        }

        public bool Xoa(Guid Id)
        {
            var sanPham = new SanPham
            {
                Id = Id,
            };
            return _sanPhamRepositories.Xoa(sanPham);
        }

        public bool AddCart(UserViewModel user, Guid? idNv, Guid idSp)
        {
            var hoaDon = new HoaDon()
            {
                Id = Guid.NewGuid()
            };
            if(idNv != null)
            {
                hoaDon.IdNv = idNv;
            }
            else
            {
                hoaDon.IdNv = Guid.Parse("2547B172-DB0E-423F-9BF9-5304547410B5") ;
            }
            hoaDon.IdThanhToan = Guid.Parse("58e29ffc-7e68-44c2-8e9e-947ae81c74c0");
            hoaDon.IdVouCher = Guid.Parse("c62f84bd-e1a4-4a75-afd9-e67f53c3260f");
            hoaDon.IdKh = user.Id;
            hoaDon.DiaChi = user.QueQuan;
            hoaDon.SDT = user.Sdt;
            hoaDon.TinhTrang = 0;
            var ranDom = new Random();
            hoaDon.Ma = "GH_" + ranDom.Next(0, 9999);
            var ketQua = _hoaDonRepositories.Them(hoaDon);

            var hoaDonChiTiet = new HoaDonChiTiet()
            {
                Id = Guid.NewGuid(),
                IdHoaDon = hoaDon.Id,
                SoLuong = 1
            };
            var chiTietSp = _sanPhamCTRepositories.GetAll().Where(s => s.IdSanPham == idSp).FirstOrDefault();
            if (chiTietSp != null)
            {
                hoaDonChiTiet.IdChiTietSanPham = chiTietSp.Id;
                hoaDonChiTiet.ThanhTien = chiTietSp.GiaBan * 1;
            }
            ketQua = _hoaDonCTRepositories.Them(hoaDonChiTiet);
            return ketQua;
        }
    }

}
