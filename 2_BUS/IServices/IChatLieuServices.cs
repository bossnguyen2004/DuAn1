﻿using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IChatLieuServices
    {
        bool Them(string ma, string ten, int trangThai );
        bool Xoa(Guid Id);
        bool Sua(Guid Id, string ma, string ten, int trangThai);
        List<ChatLieu> GetAll();
    }
}
