﻿using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ISizeGiayServices
    {
        List<SizeGiayViewModels> GetAll();
        bool Them(SizeGiayViewModels sizeGiay);
        bool Sua(SizeGiayViewModels sizeGiay);
        bool Xoa(Guid Id);
    }
}