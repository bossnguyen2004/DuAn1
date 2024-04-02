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
    public class AnhRepository : IAnhRepositories
    {
        public AnhRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        private ApplicationDBContext _dbContext;

        public List<Anh> GetAll()
        {
            return _dbContext.Anhs.ToList();
        }

        public bool Sua(Anh image)
        {
            try
            {
                var anh = _dbContext.Anhs.Find(image.ID);
                if (anh != null)
                {
                    anh.MaAnh = image.MaAnh;
                    anh.Ten = image.Ten;
                    anh.DuongDan = image.DuongDan;
                    anh.TrangThai= image.TrangThai;
                    _dbContext.Anhs.Update(anh);
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

        public bool Them(Anh image)
        {
            try
            {
                _dbContext.Anhs.Add(image);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Xoa(Anh image)
        {
            try
            {
                var anh = _dbContext.Anhs.Find(image.ID);
                if (anh != null)
                {
                    _dbContext.Anhs.Remove(anh);
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

        public bool timKiem(Anh image)
        {
            //return _dbContext.Anhs.Where(x => x.Ten.ToLower().Contains(ten)).ToList();
            return false;
        }
    }
}
