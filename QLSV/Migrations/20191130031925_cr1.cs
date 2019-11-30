using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLSV.Migrations
{
    public partial class cr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoas",
                columns: table => new
                {
                    MaKhoa = table.Column<string>(nullable: false),
                    TenKhoa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoas", x => x.MaKhoa);
                });

            migrationBuilder.CreateTable(
                name: "Monhocs",
                columns: table => new
                {
                    MaMon = table.Column<string>(nullable: false),
                    TenMon = table.Column<string>(nullable: false),
                    SoTinChi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monhocs", x => x.MaMon);
                });

            migrationBuilder.CreateTable(
                name: "Lophocphans",
                columns: table => new
                {
                    MaLHP = table.Column<string>(nullable: false),
                    NamHoc = table.Column<int>(nullable: false),
                    HocKy = table.Column<int>(nullable: false),
                    Mon = table.Column<string>(nullable: false),
                    MonhocsMaMon = table.Column<string>(nullable: true),
                    DiemGK = table.Column<float>(nullable: false),
                    DiemCuoiKy = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lophocphans", x => x.MaLHP);
                    table.ForeignKey(
                        name: "FK_Lophocphans_Monhocs_MonhocsMaMon",
                        column: x => x.MonhocsMaMon,
                        principalTable: "Monhocs",
                        principalColumn: "MaMon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    MaSinhVien = table.Column<string>(nullable: false),
                    HoTen = table.Column<string>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    DienThoai = table.Column<string>(nullable: false),
                    MaKhoa = table.Column<string>(nullable: true),
                    MaLHP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.MaSinhVien);
                    table.ForeignKey(
                        name: "FK_SinhViens_Khoas_MaKhoa",
                        column: x => x.MaKhoa,
                        principalTable: "Khoas",
                        principalColumn: "MaKhoa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SinhViens_Lophocphans_MaLHP",
                        column: x => x.MaLHP,
                        principalTable: "Lophocphans",
                        principalColumn: "MaLHP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lophocphans_MonhocsMaMon",
                table: "Lophocphans",
                column: "MonhocsMaMon");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_MaKhoa",
                table: "SinhViens",
                column: "MaKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_MaLHP",
                table: "SinhViens",
                column: "MaLHP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "Khoas");

            migrationBuilder.DropTable(
                name: "Lophocphans");

            migrationBuilder.DropTable(
                name: "Monhocs");
        }
    }
}
