using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmy.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rezyser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DataDodania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategoriaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmy_kategorie_KategoriaID",
                        column: x => x.KategoriaID,
                        principalTable: "kategorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[,]
                {
                    { 1, "Kryminal", "Film o tematyce kryminalnej" },
                    { 2, "Komedia", "Film o tematyce komediowej" },
                    { 3, "Horror", "Film grozy" },
                    { 4, "Thriller", "Dreszczowiec" },
                    { 5, "Akcja", "Film Akcji" }
                });

            migrationBuilder.InsertData(
                table: "Filmy",
                columns: new[] { "Id", "Cena", "DataDodania", "KategoriaID", "Opis", "Rezyser", "Tytul" },
                values: new object[,]
                {
                    { 1, 10m, new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Strudzony życiem komik popada w obłęd i staje się psychopatycznym mordercą.", "Todd Phillips", "Joker" },
                    { 2, 15m, new DateTime(1995, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Dwóch policjantów stara się złapać seryjnego mordercę wybierającego swoje ofiary według specjalnego klucza - siedmiu grzechów głównych.", "David Fincher", "Siedem" },
                    { 3, 20m, new DateTime(2011, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sparaliżowany milioner zatrudnia do opieki młodego chłopaka z przedmieścia, który właśnie wyszedł z więzienia.", "Olivier Nakache, Éric Toledano", "Nietykalni" },
                    { 4, 25m, new DateTime(1997, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Zamknięty w obozie koncentracyjnym wraz z synem Guido próbuje przekonać chłopca, że okrutna rzeczywistość jest jedynie formą zabawy dla dorosłych.", "Roberto Benigni, Vincenzo Cerami", "Życie jest piękne" },
                    { 5, 30m, new DateTime(1979, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Zamknięty w obozie koncentracyjnym wraz z synem Guido próbuje przekonać chłopca, że okrutna rzeczywistość jest jedynie formą zabawy dla dorosłych.", "Ridley Scott", "Obcy - 8. pasażer Nostromo" },
                    { 6, 5m, new DateTime(1980, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Jack podejmuje pracę stróża odciętego od świata hotelu Overlook. Wkrótce idylla zamienia się w koszmar.", "Stanley Kubrick", "Lśnienie" },
                    { 7, 15m, new DateTime(1999, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Cierpiący na bezsenność mężczyzna poznaje gardzącego konsumpcyjnym stylem życia Tylera Durdena, który jest jego zupełnym przeciwieństwem.", "David Fincher", "Podziemny krąg" },
                    { 8, 12m, new DateTime(2010, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Czasy, gdy technologia pozwala na wchodzenie w świat snów. Złodziej Cobb ma za zadanie wszczepić myśl do śpiącego umysłu.", "Christopher Nolan", "Incepcja" },
                    { 9, 14m, new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Po ponad 20 latach służby w lotnictwie marynarki wojennej, Pete Maverick Mitchell zostaje wezwany do legendarnej szkoły Top Gun. Ma wyszkolić nowe pokolenie pilotów do niezwykle trudnej misji.", "Joseph Kosinski", "Top Gun: Maverick" },
                    { 10, 21m, new DateTime(2018, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Potężny Thanos zbiera Kamienie Nieskończoności w celu narzucenia swojej woli wszystkim istnieniom we wszechświecie. Tylko drużyna superbohaterów znanych jako Avengers może go powstrzymać.", "Anthony Russo, Joe Russo", "Avengers: Wojna bez granic" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmy_KategoriaID",
                table: "Filmy",
                column: "KategoriaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmy");

            migrationBuilder.DropTable(
                name: "kategorie");
        }
    }
}
