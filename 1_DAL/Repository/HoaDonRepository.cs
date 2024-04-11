using _1_DAL.DBContext;
using _1_DAL.IRepositories;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class HoaDonRepository : IHoaDonRepositories
    {
        private ApplicationDBContext context;
        public HoaDonRepository()
        {
            context = new ApplicationDBContext();
        }

        public List<HoaDon> GetAll()
        {
            return context.HoaDons.ToList();
        }

        public bool Sua(HoaDon hoaDon)
        {
            context.HoaDons.Update(hoaDon);
            context.SaveChanges();
            return true;
        }

        public bool Them(HoaDon hoaDon)
        {
            context.HoaDons.Add(hoaDon);
            context.SaveChanges();
            return true;
        }

        public List<HoaDon> TimKiem(string Ma)
        {
            throw new NotImplementedException();
        }

        public bool Xoa(HoaDon hoaDon)
        {
            context.HoaDons.Remove(hoaDon);
            context.SaveChanges();
            return true;
        }
    }
}
