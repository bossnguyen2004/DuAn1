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
    public class NhanVienRepostory : INhanVienRepositories
    {
        private ApplicationDBContext _dbContext;
        private List<NhanVien> _lstNhanVien;
        public NhanVienRepostory()
        {
                _dbContext = new ApplicationDBContext();
            _lstNhanVien = new List<NhanVien>();
        }

        public bool Create(NhanVien nhanVien)
        {
            try
            {
                _dbContext.NhanViens.Add(nhanVien);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {

               return false;
            }
        }

        public bool Delete(Guid Id)
        {
            var nhanVien = _dbContext.NhanViens.Find();
            if (nhanVien != null)
            {
                _dbContext.NhanViens.Remove(nhanVien);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<NhanVien> GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }

        public List<NhanVien> Search(string Ma)
        {
            var nhanVien = _dbContext.NhanViens.Where(x => x.Ma.ToLower().Contains(Ma.ToLower()));
            return nhanVien.ToList();
        }

        public bool Update(NhanVien nhanVien)
        {
            try
            {
                var lstnhanVien = _dbContext.NhanViens.Find(nhanVien.Id);
                if (lstnhanVien != null)
                {
                    lstnhanVien.Ma = nhanVien.Ma;
                    lstnhanVien.Ten = nhanVien.Ten;
                    lstnhanVien.Sdt = nhanVien.Sdt;
                    lstnhanVien.Email = nhanVien.Email;
                    lstnhanVien.CMND = nhanVien.CMND;
                    lstnhanVien.GioiTinh = nhanVien.GioiTinh;
                    lstnhanVien.Ho = nhanVien.Ho;
                    lstnhanVien.IdCv = nhanVien.IdCv;
                    lstnhanVien.Anh= nhanVien.Anh;
                    lstnhanVien.NamSinh = nhanVien.NamSinh;
                    lstnhanVien.QueQuan = nhanVien.QueQuan;
                    lstnhanVien.MatKhau = nhanVien.MatKhau;

                    _dbContext.NhanViens.Update(nhanVien);
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
        public NhanVien Login(string userName, string password)
        {
            return _dbContext.NhanViens.Where(x => (x.Email.ToUpper() == userName.ToUpper() & x.MatKhau == password)).FirstOrDefault();
        }
    }
}
