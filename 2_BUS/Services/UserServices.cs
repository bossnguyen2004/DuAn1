using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.IRepositories;
using _1_DAL.Repository;

namespace _2_BUS.Services
{
    public class UserServices : IUserServices
    {
        private IUserRepositories userRepositories;

        public UserServices()
        {
            userRepositories = new UserRepositories();
        }

        public object Login(string username, string password)
        {
            return userRepositories.Login(username, password);
        }
    }
}
