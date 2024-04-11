using _1_DAL.IRepositories;
using _1_DAL.Models;
using _1_DAL.Repository;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class SaleServices: ISaleService
    {
        IVouCherRepositories vouCherRepositories;
        public SaleServices()
        {
            vouCherRepositories = new VouCherRepository();
        }
        public List<SaleViewModel> GetAll()
        {
            return (from a in vouCherRepositories.GetAll()
                    select new SaleViewModel
                    {
                        Id = a.Id.GetValueOrDefault(),
                        MaGiamGia = a.MaGiamGia,
                        TenChuongTrinh = a.TenChuongTrinh,
                        NgayBatDau = a.NgayBatDau,
                        NgayKetThuc = a.NgayKetThuc,
                        SoTienGiamGia = (decimal)a.SoTienGiamGia,
                        TrangThai = a.TrangThai,
                        GiaTriVoucher = a.GiaTriVoucher
                    }).ToList();
        }

        public bool Sua(SaleViewModel sale)
        {
            var addSale = vouCherRepositories.GetAll().FirstOrDefault(p => p.Id == sale.Id);
            addSale.MaGiamGia = sale.MaGiamGia;
            addSale.TenChuongTrinh = sale.TenChuongTrinh;
            addSale.NgayBatDau = sale.NgayBatDau;
            addSale.NgayKetThuc = sale.NgayKetThuc;
            addSale.SoTienGiamGia = sale.SoTienGiamGia;
            addSale.TrangThai = sale.TrangThai;
            addSale.GiaTriVoucher = sale.GiaTriVoucher;
            if (vouCherRepositories.Sua(addSale))
                return true;
            return false;
        }

        public bool Them(SaleViewModel sale)
        {
            var addSale = new Voucher();
            addSale.Id = sale.Id;
            addSale.MaGiamGia = sale.MaGiamGia;
            addSale.TenChuongTrinh = sale.TenChuongTrinh;
            addSale.NgayBatDau = sale.NgayBatDau;
            addSale.NgayKetThuc = sale.NgayKetThuc;
            addSale.SoTienGiamGia = sale.SoTienGiamGia;
            addSale.TrangThai = sale.TrangThai;
            addSale.GiaTriVoucher = sale.GiaTriVoucher;
            if (vouCherRepositories.Them(addSale))
                return true;
            return false;
        }

        public bool Xoa(SaleViewModel sale)
        {
            if (sale == null) return true;
            int a = 0;
            var x = new Voucher()
            {
                Id = sale.Id
            };
            var list = vouCherRepositories.GetAll();
            foreach (var i in list)
            {
                if (sale.Id == i.Id) a++;
            }
            if (vouCherRepositories.Xoa(x)) return true;
            return false;
        }
    }
}
