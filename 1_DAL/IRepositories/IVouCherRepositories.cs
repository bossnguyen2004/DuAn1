using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IVouCherRepositories
    {
        List<Voucher> GetAll();

        bool Them(Voucher sale);
        bool Xoa(Voucher id);
        bool Sua(Voucher sale);
    }
}
