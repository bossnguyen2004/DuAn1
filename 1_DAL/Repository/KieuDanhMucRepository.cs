using _1_DAL.DBContext;
using _1_DAL.IRepositories;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class KieuDanhMucRepository : IKieuDanhMucRepositories
    {
        public KieuDanhMucRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        private ApplicationDBContext _dbContext;

        public List<KieuDanhMuc> GetAll()
        {
            return _dbContext.KieuDanhMucs.ToList();
        }

        public bool Sua(KieuDanhMuc kieuDanhMuc)
        {
            try
            {
                var KDM = _dbContext.KieuDanhMucs.Find(kieuDanhMuc.Id);
                if (KDM != null)
                {
                    KDM.TheLoaiGioiTinh = kieuDanhMuc.TheLoaiGioiTinh;
                    KDM.TrangThai = kieuDanhMuc.TrangThai;
                    _dbContext.KieuDanhMucs.Update(KDM);
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

        public bool Them(KieuDanhMuc kieuDanhMuc)
        {
            try
            {
                _dbContext.KieuDanhMucs.Add(kieuDanhMuc);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Xoa(KieuDanhMuc kieuDanhMuc)
        {
            try
            {
                var KDM = _dbContext.KieuDanhMucs.Find(kieuDanhMuc.Id);
                if (KDM != null)
                {
                    _dbContext.KieuDanhMucs.Remove(KDM);
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
