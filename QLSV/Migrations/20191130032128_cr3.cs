using Microsoft.EntityFrameworkCore.Migrations;

namespace QLSV.Migrations
{
    public partial class cr3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KQHTs",
                columns: table => new
                {
                    MaKQHT = table.Column<string>(nullable: false),
                    MaSV = table.Column<string>(nullable: true),
                    MaLHP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KQHTs", x => x.MaKQHT);
                    table.ForeignKey(
                        name: "FK_KQHTs_Lophocphans_MaLHP",
                        column: x => x.MaLHP,
                        principalTable: "Lophocphans",
                        principalColumn: "MaLHP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KQHTs_SinhViens_MaSV",
                        column: x => x.MaSV,
                        principalTable: "SinhViens",
                        principalColumn: "MaSinhVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KQHTs_MaLHP",
                table: "KQHTs",
                column: "MaLHP");

            migrationBuilder.CreateIndex(
                name: "IX_KQHTs_MaSV",
                table: "KQHTs",
                column: "MaSV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KQHTs");
        }
    }
}
