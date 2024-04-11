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
    public class HoaDonCTRepository : IHoaDonCTRepositories
    {
        private ApplicationDBContext context;

        public HoaDonCTRepository() 
        {
            context = new ApplicationDBContext();
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return context.HoaDonChiTiets.ToList();
        }

        public bool Sua(HoaDonChiTiet hoaDonCT)
        {
            context.HoaDonChiTiets.Update(hoaDonCT);
            context.SaveChanges();
            return true;
        }

        public bool Them(HoaDonChiTiet hoaDonCT)
        {
            context.HoaDonChiTiets.Add(hoaDonCT);
            context.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> TimKiem(string Ma)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(HoaDonChiTiet hoaDonCT)
        {
            context.HoaDonChiTiets.Remove(hoaDonCT);
            context.SaveChanges();
            return true;
        }
    }
}
