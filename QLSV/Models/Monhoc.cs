using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class Monhoc
    {
        [Key]
        [Required(ErrorMessage = "Bat buoc")]
        public string MaMon { get; set; }
        [Required(ErrorMessage = "Bat buoc")]
        public string TenMon { get; set; }
        [Required(ErrorMessage = "Bat buoc")]
        public int SoTinChi { get; set; }
        
    }
}