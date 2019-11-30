using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class SinhVien
    {
        [Key]
        [Required(ErrorMessage = "Bat buoc")]
        public string MaSinhVien { get; set; }
        [Required(ErrorMessage = "Bat buoc")]
        public string HoTen { get; set; }
        [Required(ErrorMessage = "Bat buoc")]
        public DateTime NgaySinh { get; set; }
        [Required(ErrorMessage = "Bat buoc")]
        public string DienThoai { get; set; }
        public string MaKhoa { get; set; }
        [ForeignKey("MaKhoa")]
        public virtual Khoa Khoas {get; set;} 
        public string MaLHP { get; set; }
        [ForeignKey("MaLHP")]
        public virtual Lophocphan Lophocphans { get; set; }
    }
}