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
    public class DanhMucRepository : IDanhMucRepositories
    {
        public DanhMucRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        private ApplicationDBContext _dbContext;

        public List<DanhMuc> GetAll()
        {
            return _dbContext.DanhMucs.ToList();
        }

        public bool Sua(DanhMuc danhmuc)
        {
            try
            {
                var DM = _dbContext.DanhMucs.Find(danhmuc.Id);
                if (DM != null)
                {
                    DM.Ma = danhmuc.Ma;
                    DM.Ten = danhmuc.Ten;
                    _dbContext.DanhMucs.Update(DM);
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

        public bool Them(DanhMuc danhmuc)
        {
            try
            {
                _dbContext.DanhMucs.Add(danhmuc);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Xoa(DanhMuc danhmuc)
        {
            try
            {
                var DM = _dbContext.DanhMucs.Find(danhmuc.Id);
                if (DM != null)
                {
                    _dbContext.DanhMucs.Remove(DM);
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
