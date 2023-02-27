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

            modelBuilder.Entity<Film>().HasData(
                new Film() { Id = 1,
                    KategoriaID = 1,
                    Tytul = "Film1",
                    Opis = "abc",
                    Cena = 10,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 2,
                    KategoriaID = 1,
                    Tytul = "Film2",
                    Opis = "abc",
                    Cena = 15,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 3,
                    KategoriaID = 1,
                    Tytul = "Film3",
                    Opis = "abc",
                    Cena = 20,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 4,
                    KategoriaID = 1,
                    Tytul = "Film4",
                    Opis = "abc",
                    Cena = 25,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 5,
                    KategoriaID = 1,
                    Tytul = "Film5",
                    Opis = "abc",
                    Cena = 30,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 6,
                    KategoriaID = 1,
                    Tytul = "Film6",
                    Opis = "abc",
                    Cena = 5,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 7,
                    KategoriaID = 1,
                    Tytul = "Film7",
                    Opis = "abc",
                    Cena = 15,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 8,
                    KategoriaID = 1,
                    Tytul = "Film8",
                    Opis = "abc",
                    Cena = 12,
                    DataDodania = new DateTime(2020, 5, 13)
                },,
                new Film()
                {
                    Id = 9,
                    KategoriaID = 1,
                    Tytul = "Film9",
                    Opis = "abc",
                    Cena = 14,
                    DataDodania = new DateTime(2020, 5, 13)
                },
                new Film()
                {
                    Id = 10,
                    KategoriaID = 1,
                    Tytul = "Film10",
                    Opis = "abc",
                    Cena = 21,
                    DataDodania = new DateTime(2020, 5, 13)
                }
                );
        }
    }
}
