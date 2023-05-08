using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.Models
{
    public class UsunRzeczyViewModel
    {
        public int RzeczId { get; set; }
        public int IloscRzeczy { get; set; }
        public decimal? WartoscKoszyka { get; set; }
    }
}
