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
    public class MauSacRepository : IMauSacRepositories
    {
        public MauSacRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        private ApplicationDBContext _dbContext;


        public List<MauSac> GetAll()
        {
            return _dbContext.MauSacs.ToList();
        }


        public bool Them(MauSac mauSac)
        {
            try
            {
                _dbContext.MauSacs.Add(mauSac);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Sua(MauSac mauSac)
        {
            try
            {
                var CL = _dbContext.MauSacs.Find(mauSac.Id);
                if (CL != null)
                {
                    CL.Ma = mauSac.Ma;
                    CL.Ten = mauSac.Ten;
                    CL.TrangThai = mauSac.TrangThai;
                    _dbContext.MauSacs.Update(CL);
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

        public bool Xoa(MauSac mauSac)
        {
            try
            {
                var CL = _dbContext.MauSacs.Find(mauSac.Id);
                if (CL != null)
                {
                    _dbContext.MauSacs.Remove(CL);
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
