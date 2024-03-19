using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface INhanVienRepositories
    {
        bool Create(NhanVien nhanVien);
        bool Update(NhanVien nhanVien);
        bool Delete(Guid Id);
        List<NhanVien> GetAll();
        List<NhanVien> Search(string Ma);
        NhanVien Login(string userName, string password);
    }
}
