using Filmy.DAL;
using Filmy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;
        public FilmyController(FilmyContext db)
        {
            this.db = db;
        }

        public IActionResult Lista(string nazwaKategorii)
        {
            var kategoria = db.Kategorie.Include("Filmy").Where(kategoria => kategoria.Nazwa.ToUpper() == nazwaKategorii).Single();
            var topFilmy = db.Filmy.OrderByDescending(f => f.DataDodania).Take(3);
            var filmy = kategoria.Filmy.ToList();
            var model = new KategoriaViewModel()
            {
                Kategoria = kategoria,
                FilmyKategorii = filmy,
                FilmyNajnowsze = topFilmy
            };
            ViewBag.nazwa = nazwaKategorii;
            return View(model);
        }
    }
}
