using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.Models
{
    public class Koszyk
    {
        public Film Film { get; set; }
        public int Ilosc { get; set; }
        public decimal? Wartosc { get; set; }
    }
}
