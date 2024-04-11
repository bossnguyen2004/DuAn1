using _1_DAL.IRepositories;
using _1_DAL.Models;
using _1_DAL.Repository;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class HoaDonChiTietServices : IHoaDonCTServices
    {
        private IHoaDonCTRepositories _hoaDonCTRepositories;

        public HoaDonChiTietServices()
        {
                _hoaDonCTRepositories = new HoaDonCTRepository();
        }

        public bool Add(HoaDon hoaDon)
        {
            throw new NotImplementedException();
        }

        public bool Delete(HoaDon hoaDon)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _hoaDonCTRepositories.GetAll();
        }

        public bool Update(HoaDon hoaDon)
        {
            throw new NotImplementedException();
        }
    }
}
