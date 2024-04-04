using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PL.Helpers
{
    public class AccountHelper
    {
        private static AccountHelper _instance;
        private static UserViewModel _userLoged;
        //private static NhanVienViewModels _userLogeds;
        public AccountHelper()
        {
                
        }

        public static AccountHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccountHelper();
                }
                return _instance;
            }
        }
     

        public UserViewModel GetUserLoged()
        {
            return _userLoged;
        }

        public void SetUserLogin(UserViewModel user)
        {
            _userLoged = user;
        }

        //public UserViewModel GetUserLogeds()
        //{
        //    return _userLoged;
        //}

    }
}
