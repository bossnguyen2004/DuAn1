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
    public class SizeGiayRepository : ISizeGiayRepositories
    {
        public SizeGiayRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        private ApplicationDBContext _dbContext;


        public List<SizeGiay> GetAll()
        {
            return _dbContext.SizeGiays.ToList();
        }


        public bool Them(SizeGiay sizeGiay)
        {
            try
            {
                _dbContext.SizeGiays.Add(sizeGiay);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Sua(SizeGiay sizeGiay)
        {
            try
            {
                var CL = _dbContext.SizeGiays.Find(sizeGiay.Id);
                if (CL != null)
                {
                    CL.Ma = sizeGiay.Ma;
                    CL.SoSize = sizeGiay.SoSize;
                    CL.TrangThai = sizeGiay.TrangThai;
                    _dbContext.SizeGiays.Update(CL);
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

        public bool Xoa(SizeGiay sizeGiay)
        {
            try
            {
                var CL = _dbContext.SizeGiays.Find(sizeGiay.Id);
                if (CL != null)
                {
                    _dbContext.SizeGiays.Remove(CL);
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
