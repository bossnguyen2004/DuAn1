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
    public class SanPhamCTRepository : ISanPhamCTRepositories
    {
        private ApplicationDBContext _dbContext;

        public SanPhamCTRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        public List<SanPhamChiTiet> GetAll()
        {
            return _dbContext.SanPhamChiTiets.ToList();
        }

        public bool Sua(SanPhamChiTiet sanPhamCT)
        {
            try
            {
                var SP = _dbContext.SanPhamChiTiets.Find(sanPhamCT.Id);
                if (SP != null)
                {
                    _dbContext.SanPhamChiTiets.Update(SP);
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

        public bool Them(SanPhamChiTiet sanPhamCT)
        {
            try
            {
                _dbContext.SanPhamChiTiets.Add(sanPhamCT);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<SanPhamChiTiet> TimKiem(string Ma)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(SanPhamChiTiet sanPhamCT)
        {
            try
            {
                var SP = _dbContext.SanPhamChiTiets.Find(sanPhamCT.Id);
                if (SP != null)
                {
                    _dbContext.SanPhamChiTiets.Update(SP);
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
    }
}
