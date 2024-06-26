﻿using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_DAL.Models
{
    [Table("Voucher")]
    [Index(nameof(MaGiamGia), Name = "UQ_MaGiamGia", IsUnique = true)]
    public partial class Voucher
    {
        public Voucher()
        {
            HoaDons = new HashSet<HoaDon>();
        }
        [Key]
        [Required(ErrorMessage = "ID bắt buộc")]
        public Guid? Id { get; set; }

        [StringLength(20)]
        public string MaGiamGia { get; set; }

        [StringLength(200, ErrorMessage = "Tên phải có tối da 200 kí tự")]
        public string TenChuongTrinh { get; set; }
        public int TrangThai { get; set; }
        public decimal? GiaTriVoucher { get; set; }
        public decimal? SoTienGiamGia { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}