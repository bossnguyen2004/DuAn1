using _1_DAL.Models;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class ThongKeServices : IThongKeServices
    {
        private List<ThongKe> _lstdoanhthu;
        private string manv;
        private double tong;
        private NhanVien _nv;
        private ThongKe _viewdoanhthu;
        private DateTime? day;
        private DateTime? nam;
        private string mon;
        private string year;
        private INhanVienServices _invser;
        private IHoaDonServices _ihdser;
        IHoaDonCTServices _hdctser;
        public ThongKeServices()
        {
            _ihdser = new HoaDonServices();
            _invser = new NhanVienServices();
            _nv = new NhanVien();
            _lstdoanhthu = new List<ThongKe>();
            _hdctser = new HoaDonChiTietServices();
        }
        public List<ThongKe> GetList()
        {
            var listcommit = (from a in _invser.GetAll()
                              join b in _ihdser.GetAll() on a.Id equals b.IdNv
                              join c in _hdctser.GetAll() on b.IdKh equals c.IdHoaDon // ddang sai o day   
                              select new { a.Ma, a.Ten, c.ThanhTien, b.NgayThanhToan, b.TinhTrang }).ToList();
            // gán giá trị
            foreach (var x in listcommit)
            {
                tong = Convert.ToDouble(_ihdser.GetAll().Where(c => c.IdNv == _nv.Id).Select(c => c.TongTienTrongCa).Sum());
                day = x.NgayThanhToan;
                nam = x.NgayThanhToan;
                if (day != null)
                {
                    mon = day.Value.Month.ToString();
                }
                if (year != null)
                {
                    year = nam.Value.Year.ToString();
                }
                _viewdoanhthu = new ThongKe(manv, x.Ten, tong, mon, year, x.NgayThanhToan);
                _lstdoanhthu.Add(_viewdoanhthu);
            }

            var lisfinal = listcommit.Where(c => c.TinhTrang == 1).GroupBy(c => c.Ma)
                .Select(g => new ThongKe(g.Key, g.Where(c => c.Ma == g.Key).Select(c => c.Ten).FirstOrDefault(), Convert.ToDouble(g.Sum(c => c.ThanhTien)), mon, year, g.Where(c => c.Ma == g.Key).Select(c => c.NgayThanhToan).FirstOrDefault())).ToList();


            return lisfinal;
        }
    }
}
