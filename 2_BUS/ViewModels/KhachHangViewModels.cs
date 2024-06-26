﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class KhachHangViewModels
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public int GioiTinh { get; set; }
        public string? Email { get; set; }
        public DateTime? NamSinh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string Password { get; set; }
        public int? TrangThai { get; set; }

    }
}
