using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.Models
{
    public class KategoriaViewModel
    {
        public Kategoria Kategoria { get; set; }
        public IEnumerable<Film> FilmyKategorii { get; set; }
        public IEnumerable<Film> FilmyNajnowsze { get; set; }
    }
}
