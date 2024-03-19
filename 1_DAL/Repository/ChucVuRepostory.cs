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
    public class ChucVuRepostory:IChucVuRepositories
    {
        private ApplicationDBContext _DBcontext;
        private List<ChucVu> _lstChucVu;
        public ChucVuRepostory()
        {
            _DBcontext = new ApplicationDBContext();
            _lstChucVu = new List<ChucVu>();

        }

        public List<ChucVu> GetAll()
        {
            return _DBcontext.ChucVus.ToList();
        }

        public bool Sua(ChucVu chucVu)
        {
            try
            {
                var daTaCv = _DBcontext.ChucVus.Find(chucVu.Id);
                if (daTaCv != null)
                {
                    daTaCv.Id = chucVu.Id;
                    daTaCv.Ma = chucVu.Ma;
                    daTaCv.Ten = chucVu.Ten;
                    _DBcontext.ChucVus.Update(daTaCv);
                    _DBcontext.SaveChanges();
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

        public bool Them(ChucVu chucVu)
        {
            try
            {
                _DBcontext.ChucVus.Add(chucVu);
                _DBcontext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<ChucVu> TimKiem(string Ma)
        {
            var danhSachChucVu = _DBcontext.ChucVus.Where(x => x.Ma.ToLower().Contains(Ma.ToLower()));

            return danhSachChucVu.ToList();
        }

        public bool Xoa(Guid Id)
        {
            var cv1 = _DBcontext.ChucVus.Find(Id);
            if (cv1 != null)
            {
                _DBcontext.ChucVus.Remove(cv1);
                _DBcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
