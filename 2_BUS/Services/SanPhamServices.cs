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

        public SanPhamServices()
        {
            _nhaSanXuatRepositories = new NhaSanXuatRepository();
            _chatLieuRepositories = new ChatLieuRepository();
            _sanPhamRepositories = new SanPhamRepository();
        }

        public List<SanPhamViewModels> GetAll()
        {
            List<SanPhamViewModels> lstSanPham = (from a in _sanPhamRepositories.GetAll().OrderBy(c => c.Id)
                                                  join b in _nhaSanXuatRepositories.GetAll() on a.IdNhaSanXuat equals b.Id
                                                  join c in _chatLieuRepositories.GetAll() on a.IdChatLieu equals c.Id
                                                  select new SanPhamViewModels()
                                                  {
                                                      Id = a.Id.GetValueOrDefault(),
                                                      Ma= a.Ma,
                                                      Ten = a.Ten,
                                                      TrangThai = a.TrangThai,
                                                      IdNhaSanXuat = b.Id,
                                                      idChatLieu = c.Id,

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

        public List<SanPhamViewModels> TimKiem(string Ma)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(Guid Id)
        {
            var sanPham = new SanPham
            {
                Id = Id,
            };
            return _sanPhamRepositories.Xoa(sanPham);
        }
    }
    
}
