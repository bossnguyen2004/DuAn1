﻿using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IDanhMucRepositories
    {
        List<DanhMuc> GetAll();
        bool Them(DanhMuc danhmuc);
        bool Xoa(DanhMuc danhmuc);
        bool Sua(DanhMuc danhmuc);
    }
}
