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
    public class LoaiGiayRepositoy : ILoaiGiayRepositories
    {
        public LoaiGiayRepositoy()
        {
            _dbContext = new ApplicationDBContext();
        }
        private ApplicationDBContext _dbContext;

        public List<LoaiGiay> GetAll()
        {
            return _dbContext.LoaiGiays.ToList();
        }

        public bool Sua(LoaiGiay loaiGiay)
        {
            try
            {
                var CL = _dbContext.LoaiGiays.Find(loaiGiay.Id);
                if (CL != null)
                {
                    CL.Ma = loaiGiay.Ma;
                    CL.Ten = loaiGiay.Ten;
                    CL.TrangThai = loaiGiay.TrangThai;
                    _dbContext.LoaiGiays.Update(CL);
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

        public bool Them(LoaiGiay loaiGiay)
        {
            try
            {
                _dbContext.LoaiGiays.Add(loaiGiay);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Xoa(LoaiGiay loaiGiay)
        {
            try
            {
                var CL = _dbContext.LoaiGiays.Find(loaiGiay.Id);
                if (CL != null)
                {
                    _dbContext.LoaiGiays.Remove(CL);
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
