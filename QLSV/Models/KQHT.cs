using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class KQHT
    {
        [Key]
        [Required(ErrorMessage = "Bat buoc")]
        public string MaKQHT { get; set; }
        public string MaSV { get; set; }
        [ForeignKey("MaSV")]
        public virtual SinhVien SinhViens { get; set; }
        public string MaLHP { get; set; }
        [ForeignKey("MaLHP")]
        public virtual Lophocphan Lophocphans { get; set; }
    }
}