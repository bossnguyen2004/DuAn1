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
    public class VouCherRepository : IVouCherRepositories
    {
        private ApplicationDBContext _dbContext;
        public VouCherRepository()
        {
            _dbContext = new ApplicationDBContext();
        }
        public List<Voucher> GetAll()
        {
            return _dbContext.Sales.ToList();
        }

        public bool Sua(Voucher sale)
        {
            if (sale == null) return false;
            var tempsale = _dbContext.Sales.FirstOrDefault(p => p.Id == sale.Id);
            tempsale.MaGiamGia = sale.MaGiamGia;
            tempsale.TenChuongTrinh = sale.TenChuongTrinh;
            tempsale.NgayBatDau = sale.NgayBatDau;
            tempsale.NgayKetThuc = sale.NgayKetThuc;
            tempsale.SoTienGiamGia = sale.SoTienGiamGia;
            tempsale.GiaTriVoucher = sale.GiaTriVoucher;
            tempsale.TrangThai = sale.TrangThai;
            _dbContext.Sales.Update(tempsale);
            _dbContext.SaveChanges();
            return true;
        }


        public bool Them(Voucher sale)
        {
            if (sale == null) return false;
            _dbContext.Sales.Add(sale);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Xoa(Voucher id)
        {
            throw new NotImplementedException();
        }
    }
}
