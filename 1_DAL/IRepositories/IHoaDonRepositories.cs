﻿using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IHoaDonRepositories
    {
        bool Them(HoaDon hoaDon);
        bool Sua(HoaDon hoaDon);
        bool Xoa(HoaDon hoaDon);
        List<HoaDon> GetAll();
        List<HoaDon> TimKiem(string Ma);
    }
}
