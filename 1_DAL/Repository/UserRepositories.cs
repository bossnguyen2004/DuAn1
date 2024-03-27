using _1_DAL.DBContext;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class UserRepositories : IUserRepositories
    {
        private ApplicationDBContext _dbContext;

        public UserRepositories() {
            _dbContext = new ApplicationDBContext();
        }

        public object Login(string userName, string pass)
        {
            try
            {
                var nv = _dbContext.NhanViens.Where(x => x.Email.Equals(userName)).Where(x => x.MatKhau.Equals(pass)).FirstOrDefault();
                if (nv != null)
                {
                    return nv;
                }
                else
                {
                    var kh = _dbContext.KhachHangs.Where(x => x.Email.Equals(userName)).Where(x => x.Password.Equals(pass)).FirstOrDefault();
                    if (kh != null)
                        return kh;
                }
            }
            catch (Exception)
            {
                return null;
            }
            
            return null;
        }
    }
}
