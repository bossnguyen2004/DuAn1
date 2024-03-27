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
    public class ThanhToanRepository : IThanhToanRepositories
    {
        public ThanhToanRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        private ApplicationDBContext _dbContext;

        public List<ThanhToan> GetAll()
        {
            return _dbContext.ThanhToans.ToList();
        }

        public bool Sua(ThanhToan thanhToan)
        {
            try
            {
                var TT = _dbContext.ThanhToans.Find(thanhToan.Id);
                if (TT != null)
                {
                    TT.Ma = thanhToan.Ma;
                    TT.Ten = thanhToan.Ten;
                    _dbContext.ThanhToans.Update(TT);
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

        public bool Them(ThanhToan thanhToan)
        {
            try
            {
                _dbContext.ThanhToans.Add(thanhToan);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Xoa(ThanhToan thanhToan)
        {
            try
            {
                var TT = _dbContext.ThanhToans.Find(thanhToan.Id);
                if (TT != null)
                {
                    _dbContext.ThanhToans.Remove(TT);
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
