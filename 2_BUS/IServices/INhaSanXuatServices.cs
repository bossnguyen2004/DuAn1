﻿using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface INhaSanXuatServices 
    { 
       List<NhaSanXuatViewModels> GetAll();
       bool Them(NhaSanXuatViewModels nhaSanXuat);
       bool Sua(NhaSanXuatViewModels nhaSanXuat);
       bool Xoa(Guid Id);
    }
}
