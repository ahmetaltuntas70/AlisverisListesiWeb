using Microsoft.EntityFrameworkCore.Migrations;

namespace AlisverisListesiWeb.Migrations
{
    public partial class CreateDurumColumnInKategorisTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "KategoriAd",
                table: "Kategoris",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Durum",
                table: "Kategoris",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Kategoris");

            migrationBuilder.AlterColumn<string>(
                name: "KategoriAd",
                table: "Kategoris",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
