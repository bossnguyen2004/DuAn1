﻿using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ISizeGiayServices
    {
        bool Them(string ma, int size, int trangThai);
        bool Xoa(Guid Id);
        bool Sua(Guid Id, string ma, int size, int trangThai);
        List<SizeGiay> GetAll();
    }
}
