using _1_DAL.DBContext;
using _1_DAL.IRepositories;
using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class GiaoCaRepository : IGiaoCaRepositories
    {
        private ApplicationDBContext _dbContext;
        public GiaoCaRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        public List<GiaoCa> GetAll()
        {
            return _dbContext.GiaoCas.ToList();
        }

        public bool Sua(GiaoCa giaoCa)
        {
            try
            {
                var lstGiaoCa = _dbContext.GiaoCas.Find(giaoCa.Id);
                if (lstGiaoCa != null)
                {
                    lstGiaoCa.Ma = giaoCa.Ma;
                    lstGiaoCa.ThoiGianNhanCa = giaoCa.ThoiGianNhanCa;
                    lstGiaoCa.ThoiGianGiaoCa = giaoCa.ThoiGianGiaoCa;
                    lstGiaoCa.IdNvNhanCaTiep = giaoCa.IdNvNhanCaTiep;
                    lstGiaoCa.IdNvTrongCa = giaoCa.IdNvTrongCa;
                    lstGiaoCa.TienBanDau = giaoCa.TienBanDau;
                    lstGiaoCa.TongTienTrongCa = giaoCa.TongTienTrongCa;
                    lstGiaoCa.TongTienMat = giaoCa.TongTienMat;
                    lstGiaoCa.TongTienKhac = giaoCa.TongTienKhac;
                    lstGiaoCa.TienPhatSinh = giaoCa.TienPhatSinh;
                    lstGiaoCa.GhiChuPhatSinh = giaoCa.GhiChuPhatSinh;
                    lstGiaoCa.TongTienCaTruoc = giaoCa.TongTienCaTruoc;
                    lstGiaoCa.Time = giaoCa.Time;
                    lstGiaoCa.TongTienMatRut = giaoCa.TongTienMat;
                    lstGiaoCa.TrangThai = giaoCa.TrangThai;
                    _dbContext.GiaoCas.Update(lstGiaoCa);
                    _dbContext.SaveChanges();
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool Them(GiaoCa giaoCa)
        {
            try
            {
                _dbContext.GiaoCas.Add(giaoCa);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<GiaoCa> TimKiem(string Ma)
        {
            var danhSachGiaoCa = _dbContext.GiaoCas.Where(x => x.Ma.ToLower().Contains(Ma.ToLower()));

            return danhSachGiaoCa.ToList();
        }

        public bool Xoa(Guid Id)
        {
            var giaoCa = _dbContext.GiaoCas.Find(Id);
            if (giaoCa != null)
            {
                _dbContext.GiaoCas.Remove(giaoCa);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
