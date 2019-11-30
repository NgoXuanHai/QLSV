using Microsoft.EntityFrameworkCore;
using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D06_EFCoreCodeFirst.DataModels
{
    public class MyDbContext : DbContext
    {
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Monhoc> Monhocs { get; set; }
        public DbSet<Lophocphan> Lophocphans { get; set; }

        public DbSet<KQHT> KQHTs { get; set; }

        public MyDbContext(DbContextOptions option):base(option)
        {
        }
        
    }
}
