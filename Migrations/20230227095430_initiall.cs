using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmy.Migrations
{
    public partial class initiall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmy_kategorie_KategoriaID",
                table: "Filmy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kategorie",
                table: "kategorie");

            migrationBuilder.RenameTable(
                name: "kategorie",
                newName: "Kategorie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategorie",
                table: "Kategorie",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmy_Kategorie_KategoriaID",
                table: "Filmy",
                column: "KategoriaID",
                principalTable: "Kategorie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmy_Kategorie_KategoriaID",
                table: "Filmy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategorie",
                table: "Kategorie");

            migrationBuilder.RenameTable(
                name: "Kategorie",
                newName: "kategorie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_kategorie",
                table: "kategorie",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmy_kategorie_KategoriaID",
                table: "Filmy",
                column: "KategoriaID",
                principalTable: "kategorie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
