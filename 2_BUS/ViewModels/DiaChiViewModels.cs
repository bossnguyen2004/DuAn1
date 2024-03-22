using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class DiaChiViewModels
    {
        public Guid Id { get; set; }
        public Guid? IdKhachHang { get; set; }
        public string Ma { get; set; }
        public string DuongPho { get; set; }
        public string Xa { get; set; }
        public string Huyen { get; set; }
        public string ThanhPho { get; set; }
        public int TrangThai { get; set; }
    }
}
