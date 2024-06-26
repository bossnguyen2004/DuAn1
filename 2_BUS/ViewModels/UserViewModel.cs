﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public  class UserViewModel
    {
        public Guid Id { get; set; }

        public string Ma { get; set; }

        public string Ho { get; set; }

        public string Ten { get; set; }

        public int GioiTinh { get; set; }

        public DateTime? NamSinh { get; set; }

        public string QueQuan { get; set; }

        public string Sdt { get; set; }
        public string MatKhau { get; set; }

        public string Email { get; set; }

        public string CMND { get; set; }
        public Guid? IdCv { get; set; }

        public int? TrangThai { get; set; }

        public byte[] Anh { get; set; }

        public bool IsCutomer { get; set; } = true;
    }
}
