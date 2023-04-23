using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.Models
{
    public class DodawanieFilmowViewModel
    {
        public Film film { get; set; }
        [Required(ErrorMessage = "Dodaj plakat!")]
        public IFormFile Plakat { get; set; }
        public List<Kategoria> kategoria { get; set; }
    }
}
