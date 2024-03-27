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
    public class SanPhamRepository : ISanPhamRepositories
    {
        public SanPhamRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        private ApplicationDBContext _dbContext;

        public List<SanPham> GetAll()
        {
            return _dbContext.SanPhams.ToList();
        }

        public bool Sua(SanPham sanPham)
        {
            try
            {
                var SP = _dbContext.SanPhams.Find(sanPham.Id);
                if (SP != null)
                {
                    SP.Ma = sanPham.Ma;
                    SP.Ten = sanPham.Ten;
                    _dbContext.SanPhams.Update(SP);
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

        public bool Them(SanPham sanPham)
        {

            try
            {
                _dbContext.SanPhams.Add(sanPham);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<SanPham> TimKiem(string Ma)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(SanPham sanPham)
        {
            try
            {
                var SP = _dbContext.SanPhams.Find(sanPham.Id);
                if (SP != null)
                {
                    _dbContext.SanPhams.Remove(SP);
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
