using Filmy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.DAL
{
    public class FilmyContext : DbContext
    {
        public DbSet<Film>Filmy { get; set; }
        public DbSet <Kategoria> kategorie { get; set; }

        public FilmyContext(DbContextOptions<FilmyContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Kategoria>().HasData(
                new Kategoria()
                {
                    Id = 1,
                    Nazwa = "Kryminal",
                    Opis = "Film o tematyce kryminalnej",
                },
                new Kategoria()
                {
                    Id = 2,
                    Nazwa = "Komedia",
                    Opis = "Film o tematyce komediowej",
                },
                new Kategoria()
                {
                    Id = 3,
                    Nazwa = "Horror",
                    Opis = "Film grozy",
                },
                new Kategoria()
                {
                    Id = 4,
                    Nazwa = "Thriller",
                    Opis = "Dreszczowiec",
                },
                new Kategoria()
                {
                    Id = 5,
                    Nazwa = "Akcja",
                    Opis = "Film Akcji",
                }
                );

            modelBuilder.Entity<Film>().HasData(
                new Film() { Id = 1,
                    KategoriaID = 1,
                    Tytul = "Joker",
                    Opis = "Strudzony życiem komik popada w obłęd i staje się psychopatycznym mordercą.",
                    Cena = 10,
                    DataDodania = new DateTime(2019, 8, 31),
                    Rezyser=""
                },
                new Film()
                {
                    Id = 2,
                    KategoriaID = 1,
                    Tytul = "Siedem",
                    Opis = "Dwóch policjantów stara się złapać seryjnego mordercę wybierającego swoje ofiary według specjalnego klucza - siedmiu grzechów głównych.",
                    Cena = 15,
                    DataDodania = new DateTime(1995, 9, 15),
                    Rezyser = ""
                },
                new Film()
                {
                    Id = 3,
                    KategoriaID = 2,
                    Tytul = "Nietykalni",
                    Opis = "Sparaliżowany milioner zatrudnia do opieki młodego chłopaka z przedmieścia, który właśnie wyszedł z więzienia.",
                    Cena = 20,
                    DataDodania = new DateTime(2011, 9, 23),
                    Rezyser = ""
                },
                new Film()
                {
                    Id = 4,
                    KategoriaID = 2,
                    Tytul = "Życie jest piękne",
                    Opis = "Zamknięty w obozie koncentracyjnym wraz z synem Guido próbuje przekonać chłopca, że okrutna rzeczywistość jest jedynie formą zabawy dla dorosłych.",
                    Cena = 25,
                    DataDodania = new DateTime(1997, 12, 20),
                    Rezyser = ""
                },
                new Film()
                {
                    Id = 5,
                    KategoriaID = 3,
                    Tytul = "Obcy - 8. pasażer Nostromo",
                    Opis = "Zamknięty w obozie koncentracyjnym wraz z synem Guido próbuje przekonać chłopca, że okrutna rzeczywistość jest jedynie formą zabawy dla dorosłych.",
                    Cena = 30,
                    DataDodania = new DateTime(1979, 5, 25),
                    Rezyser = ""
                },
                new Film()
                {
                    Id = 6,
                    KategoriaID = 3,
                    Tytul = "Lśnienie",
                    Opis = "Jack podejmuje pracę stróża odciętego od świata hotelu Overlook. Wkrótce idylla zamienia się w koszmar.",
                    Cena = 5,
                    DataDodania = new DateTime(1980, 5, 23),
                    Rezyser = ""
                },
                new Film()
                {
                    Id = 7,
                    KategoriaID = 4,
                    Tytul = "Podziemny krąg",
                    Opis = "Cierpiący na bezsenność mężczyzna poznaje gardzącego konsumpcyjnym stylem życia Tylera Durdena, który jest jego zupełnym przeciwieństwem.",
                    Cena = 15,
                    DataDodania = new DateTime(1999, 9, 10),
                    Rezyser = ""
                },
                new Film()
                {
                    Id = 8,
                    KategoriaID = 4,
                    Tytul = "Incepcja",
                    Opis = "Czasy, gdy technologia pozwala na wchodzenie w świat snów. Złodziej Cobb ma za zadanie wszczepić myśl do śpiącego umysłu.",
                    Cena = 12,
                    DataDodania = new DateTime(2010, 7, 8),
                    Rezyser = ""
                },
                new Film()
                {
                    Id = 9,
                    KategoriaID = 5,
                    Tytul = "Top Gun: Maverick",
                    Opis = "Po ponad 20 latach służby w lotnictwie marynarki wojennej, Pete Maverick Mitchell zostaje wezwany do legendarnej szkoły Top Gun. Ma wyszkolić nowe pokolenie pilotów do niezwykle trudnej misji.",
                    Cena = 14,
                    DataDodania = new DateTime(2022, 5, 18),
                    Rezyser = ""
                },
                new Film()
                {
                    Id = 10,
                    KategoriaID = 5,
                    Tytul = "Avengers: Wojna bez granic",
                    Opis = "Potężny Thanos zbiera Kamienie Nieskończoności w celu narzucenia swojej woli wszystkim istnieniom we wszechświecie. Tylko drużyna superbohaterów znanych jako Avengers może go powstrzymać.",
                    Cena = 21,
                    DataDodania = new DateTime(2018, 4, 23),
                    Rezyser = ""
                }
                );;
        }
    }
}
