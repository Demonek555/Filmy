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
    }
}
