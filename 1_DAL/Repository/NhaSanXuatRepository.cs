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
    public class NhaSanXuatRepository : INhaSanXuatRepositories
    {
        public NhaSanXuatRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        private ApplicationDBContext _dbContext;

        public List<NhaSanXuat> GetAll()
        {
            return _dbContext.NhaSanXuats.ToList();
        }

        public bool Sua(NhaSanXuat nhaSanXuat)
        {
            try
            {
                var CL = _dbContext.NhaSanXuats.Find(nhaSanXuat.Id);
                if (CL != null)
                {
                    CL.Ma = nhaSanXuat.Ma;
                    CL.Ten = nhaSanXuat.Ten;
                    _dbContext.NhaSanXuats.Update(CL);
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

        public bool Them(NhaSanXuat nhaSanXuat)
        {
            try
            {
                _dbContext.NhaSanXuats.Add(nhaSanXuat);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Xoa(NhaSanXuat nhaSanXuat)
        {
            try
            {
                var CL = _dbContext.NhaSanXuats.Find(nhaSanXuat.Id);
                if (CL != null)
                {
                    _dbContext.NhaSanXuats.Remove(CL);
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
