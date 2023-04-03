using Filmy.DAL;
using Filmy.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.Controllers
{
    public class FilmyController : Controller
    {
        FilmyContext db;
        IWebHostEnvironment hostingEnvironment;
        public FilmyController(FilmyContext db, IWebHostEnvironment hostingEnvironment)
        {
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;
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
        public IActionResult Szczegoly(int Id)
        {
            var film = db.Filmy.Find(Id);
            return View(film);
        }
        [HttpGet]
        public ActionResult DodajFilm()
        {
            DodawanieFilmowViewModel dodaj = new DodawanieFilmowViewModel();
            var kategoria = db.Kategorie.ToList();
            dodaj.kategoria = kategoria;
            return View(dodaj);
        }
        [HttpPost]
        public ActionResult DodajFilm(DodawanieFilmowViewModel obj)
        {
            obj.film.DataDodania = System.DateTime.Now;
            var plakatFolderPath = Path.Combine(hostingEnvironment.WebRootPath, "grafiki");
            var unikatNazwaPlakatu = Guid.NewGuid() + "_" + obj.Plakat.FileName;
            var plakatPath = Path.Combine(plakatFolderPath, unikatNazwaPlakatu);
            obj.Plakat.CopyTo(new FileStream(plakatPath, FileMode.Create));
            obj.film.Plakat = unikatNazwaPlakatu;
            db.Filmy.Add(obj.film);
            db.SaveChanges();

            return RedirectToAction("DodajFilm");
        }
    }
}
