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
    public class KhachHangRepository : IKhachHangRepositories
    {
        private ApplicationDBContext _dbContext;

        public KhachHangRepository()
        {
                _dbContext = new ApplicationDBContext();
        }

        public bool Add(KhachHang khachHang)
        {
            try
            {
                _dbContext.KhachHangs.Add(khachHang);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       

        public List<KhachHang> GetAll()
        {
            return _dbContext.KhachHangs.ToList();
        }

        public bool Update(KhachHang khachHang)
        {
            try
            {
                var kh = _dbContext.KhachHangs.Find(khachHang.Id);
                if (kh != null)
                {
                    kh.Ma = khachHang.Ma;
                    kh.Ten = khachHang.Ten;
                    kh.DiaChi = khachHang.DiaChi;
                    kh.Sdt = khachHang.Sdt;
                    kh.Email = khachHang.Email;
                    kh.GioiTinh = khachHang.GioiTinh;
                    kh.NamSinh = khachHang.NamSinh;
                    kh.Password = khachHang.Password;
                    kh.TrangThai = khachHang.TrangThai;
                    _dbContext.KhachHangs.Update(kh);
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

        public bool Delete(KhachHang khachHang)
        {
            try
            {
                var kh = _dbContext.KhachHangs.Find(khachHang.Id);
                if (kh != null)
                {
                   _dbContext.KhachHangs.Remove(kh);
                    _dbContext.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

       

    }
}
