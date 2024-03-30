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
    public class KieuDanhMucServices : IKieuDanhMucServices
    {
        private IKieuDanhMucRepositories _kieuDanhMucRepositories;
        private IDanhMucRepositories _danhMucRepositories;
        private ISanPhamRepositories _sanPhamRepositories;

        public KieuDanhMucServices()
        {
            _kieuDanhMucRepositories = new KieuDanhMucRepository();
            _danhMucRepositories = new DanhMucRepository();
            _sanPhamRepositories = new SanPhamRepository();
        }

        public List<KieuDanhMucViewModels> GetAll()
        {
            List<KieuDanhMucViewModels> lstKieuDanhMuc = (from a in _kieuDanhMucRepositories.GetAll().OrderBy(c => c.Id)
                                                  join b in _danhMucRepositories.GetAll() on a.IdDanhMuc equals b.Id
                                                  join c in _sanPhamRepositories.GetAll() on a.IdSanPham equals c.Id
                                                  select new KieuDanhMucViewModels()
                                                  {
                                                      Id = a.Id.GetValueOrDefault(),
                                                      TheLoaiGioiTinh = a.TheLoaiGioiTinh,
                                                      TrangThai = a.TrangThai,
                                                      IdDanhMuc= b.Id,
                                                     IdSanPham = c.Id,

                                                  }).ToList();
            return lstKieuDanhMuc;

        }

        public bool Sua(Guid Id, int theLoaiGT, int trangThai, string IdDanhMuc, string IdSanPham)
        {

            // Chuyển đổi idNhaSanXuat và idChatLieu thành dạng Guid
            Guid? parseIdDanhMuc = Guid.TryParse(IdDanhMuc, out Guid tempIdDanhMuc) ? tempIdDanhMuc : Guid.Empty;
            Guid? parsedIdSanPham = Guid.TryParse(IdSanPham, out Guid tempIdSanPham) ? tempIdSanPham : Guid.Empty;

            // Tạo đối tượng SanPham mới để cập nhật thông tin
            var kieuDanhMuc = new KieuDanhMuc
            {
                Id = Id,
                TheLoaiGioiTinh = theLoaiGT,
                TrangThai = trangThai,
                IdDanhMuc = parseIdDanhMuc,
                IdSanPham = parsedIdSanPham
            };

            // Gọi phương thức Sua từ repository để thực hiện cập nhật thông tin sản phẩm
            return _kieuDanhMucRepositories.Sua(kieuDanhMuc);
        }

        public bool Them(int theLoaiGT, int trangThai, string IdDanhMuc, string IdSanPham)
        {
        
            Guid? parseIdDanhMuc = Guid.Empty;
            Guid? parsedIdSanPham = Guid.Empty;

            Guid tempIdDanhMuc, tempIdSanPham;
            if (Guid.TryParse(IdDanhMuc, out tempIdDanhMuc))
            {
                parseIdDanhMuc = tempIdDanhMuc;
            }
            if (Guid.TryParse(IdSanPham, out tempIdSanPham))
            {
                parsedIdSanPham = tempIdSanPham;
            }

            var kieuDanhMuc = new KieuDanhMuc
            {
                Id = Guid.NewGuid(),
                TheLoaiGioiTinh = theLoaiGT,
                TrangThai = trangThai,
                IdDanhMuc = parseIdDanhMuc,
                IdSanPham = parsedIdSanPham
            };
            return _kieuDanhMucRepositories.Them(kieuDanhMuc);
        }

        public List<KieuDanhMucViewModels> TimKiem(string Ma)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(Guid Id)
        {
            var kieuDanhMuc = new KieuDanhMuc
            {
                Id = Id,
            };
            return _kieuDanhMucRepositories.Xoa(kieuDanhMuc);
        }
    }
}
