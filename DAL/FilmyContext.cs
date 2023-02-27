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
                    Opis = "",
                },
                new Kategoria()
                {
                    Id = 2,
                    Nazwa = "Komedia",
                    Opis = "",
                },
                new Kategoria()
                {
                    Id = 3,
                    Nazwa = "Horror",
                    Opis = "",
                },
                new Kategoria()
                {
                    Id = 4,
                    Nazwa = "Thriller",
                    Opis = "",
                },
                new Kategoria()
                {
                    Id = 5,
                    Nazwa = "Akcja",
                    Opis = "",
                }
                );

            modelBuilder.Entity<Film>().HasData(
                new Film() { Id = 1,
                    KategoriaID = 1,
                    Tytul = "Joker",
                    Opis = "abc",
                    Cena = 10,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 2,
                    KategoriaID = 1,
                    Tytul = "Siedem",
                    Opis = "abc",
                    Cena = 15,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 3,
                    KategoriaID = 2,
                    Tytul = "Nietykalni",
                    Opis = "abc",
                    Cena = 20,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 4,
                    KategoriaID = 2,
                    Tytul = "Życie jest piękne",
                    Opis = "abc",
                    Cena = 25,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 5,
                    KategoriaID = 3,
                    Tytul = "Obcy - 8. pasażer Nostromo",
                    Opis = "abc",
                    Cena = 30,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 6,
                    KategoriaID = 3,
                    Tytul = "Lśnienie",
                    Opis = "abc",
                    Cena = 5,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 7,
                    KategoriaID = 4,
                    Tytul = "Podziemny krąg",
                    Opis = "abc",
                    Cena = 15,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 8,
                    KategoriaID = 4,
                    Tytul = "Incepcja",
                    Opis = "abc",
                    Cena = 12,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 9,
                    KategoriaID = 5,
                    Tytul = "Top Gun: Maverick",
                    Opis = "abc",
                    Cena = 14,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 10,
                    KategoriaID = 5,
                    Tytul = "Avengers: Wojna bez granic",
                    Opis = "abc",
                    Cena = 21,
                    DataDodania = new DateTime(2020, 5, 13)
                }
                );
        }
    }
}
