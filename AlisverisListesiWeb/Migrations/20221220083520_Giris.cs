using Microsoft.EntityFrameworkCore.Migrations;

namespace AlisverisListesiWeb.Migrations
{
    public partial class Giris : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Girises",
                columns: table => new
                {
                    GirisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(maxLength: 20, nullable: true),
                    Sifre = table.Column<string>(maxLength: 20, nullable: true),
                    GirisRole = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Girises", x => x.GirisID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Girises");
        }
    }
}
