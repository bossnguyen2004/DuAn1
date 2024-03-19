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
        private static NhanVienViewModels _userLoged;

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
     

        public NhanVienViewModels GetUserLoged()
        {
            return _userLoged;
        }

        public void SetUserLogin(NhanVienViewModels nhanVien)
        {
            _userLoged = nhanVien;
        }



    }
}
