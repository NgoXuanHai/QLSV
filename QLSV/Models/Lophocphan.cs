using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class Lophocphan
    {
       [Key]
        
        public string MaLHP { get; set; }

        [Required(ErrorMessage = "Bat buoc")]
        public int NamHoc { get; set; }

        [Required(ErrorMessage = "Bat buoc")]
        public int HocKy { get; set; }

        [Required(ErrorMessage = "Bat buoc")]
        public string Mon { get; set; }
        public virtual Monhoc Monhocs { get; set; }
        [Required(ErrorMessage = "Bat buoc")]
        public float DiemGK { get; set; }


        [Required(ErrorMessage = "Bat buoc")]
        public float DiemCuoiKy { get; set; }
      
    }
}