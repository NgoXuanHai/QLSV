using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class Khoa
    {   
       [Key]
       [Required(ErrorMessage ="Bat buoc")]
        public string MaKhoa { get; set; }
        [Required(ErrorMessage = "Bat buoc")]
        public string TenKhoa { get; set; }
        
    }
}