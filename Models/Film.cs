using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Dodaj tytul")]
        [StringLength(50)]
        public string Tytul { get; set; }
        [Required(ErrorMessage = "Dodaj Rezysera")]
        [StringLength(50)]
        public string Rezyser { get; set; }
        [Required(ErrorMessage = "Dodaj Opis")]
        [StringLength(200)]
        public string Opis { get; set; }
        public decimal? Cena { get; set; }
        public DateTime DataDodania { get; set; }
        public int KategoriaID { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}
