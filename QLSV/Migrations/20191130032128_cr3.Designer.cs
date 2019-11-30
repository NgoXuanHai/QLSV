﻿// <auto-generated />
using System;
using D06_EFCoreCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace QLSV.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20191130032128_cr3")]
    partial class cr3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanLySinhVien.Models.KQHT", b =>
                {
                    b.Property<string>("MaKQHT")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MaLHP");

                    b.Property<string>("MaSV");

                    b.HasKey("MaKQHT");

                    b.HasIndex("MaLHP");

                    b.HasIndex("MaSV");

                    b.ToTable("KQHTs");
                });

            modelBuilder.Entity("QuanLySinhVien.Models.Khoa", b =>
                {
                    b.Property<string>("MaKhoa")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TenKhoa")
                        .IsRequired();

                    b.HasKey("MaKhoa");

                    b.ToTable("Khoas");
                });

            modelBuilder.Entity("QuanLySinhVien.Models.Lophocphan", b =>
                {
                    b.Property<string>("MaLHP")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("DiemCuoiKy");

                    b.Property<float>("DiemGK");

                    b.Property<int>("HocKy");

                    b.Property<string>("Mon")
                        .IsRequired();

                    b.Property<string>("MonhocsMaMon");

                    b.Property<int>("NamHoc");

                    b.HasKey("MaLHP");

                    b.HasIndex("MonhocsMaMon");

                    b.ToTable("Lophocphans");
                });

            modelBuilder.Entity("QuanLySinhVien.Models.Monhoc", b =>
                {
                    b.Property<string>("MaMon")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SoTinChi");

                    b.Property<string>("TenMon")
                        .IsRequired();

                    b.HasKey("MaMon");

                    b.ToTable("Monhocs");
                });

            modelBuilder.Entity("QuanLySinhVien.Models.SinhVien", b =>
                {
                    b.Property<string>("MaSinhVien")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DienThoai")
                        .IsRequired();

                    b.Property<string>("HoTen")
                        .IsRequired();

                    b.Property<string>("MaKhoa");

                    b.Property<string>("MaLHP");

                    b.Property<DateTime>("NgaySinh");

                    b.HasKey("MaSinhVien");

                    b.HasIndex("MaKhoa");

                    b.HasIndex("MaLHP");

                    b.ToTable("SinhViens");
                });

            modelBuilder.Entity("QuanLySinhVien.Models.KQHT", b =>
                {
                    b.HasOne("QuanLySinhVien.Models.Lophocphan", "Lophocphans")
                        .WithMany()
                        .HasForeignKey("MaLHP");

                    b.HasOne("QuanLySinhVien.Models.SinhVien", "SinhViens")
                        .WithMany()
                        .HasForeignKey("MaSV");
                });

            modelBuilder.Entity("QuanLySinhVien.Models.Lophocphan", b =>
                {
                    b.HasOne("QuanLySinhVien.Models.Monhoc", "Monhocs")
                        .WithMany()
                        .HasForeignKey("MonhocsMaMon");
                });

            modelBuilder.Entity("QuanLySinhVien.Models.SinhVien", b =>
                {
                    b.HasOne("QuanLySinhVien.Models.Khoa", "Khoas")
                        .WithMany()
                        .HasForeignKey("MaKhoa");

                    b.HasOne("QuanLySinhVien.Models.Lophocphan", "Lophocphans")
                        .WithMany()
                        .HasForeignKey("MaLHP");
                });
#pragma warning restore 612, 618
        }
    }
}
