using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmy.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "czasTrwania",
                table: "Filmy",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "czasTrwania",
                table: "Filmy");
        }
    }
}
