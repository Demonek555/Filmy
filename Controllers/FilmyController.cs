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

            if (obj.film.Cena == null)
            {
                obj.film.Cena = 0.00m;
            }
            if (TryValidateModel(obj.film, "Film") && ModelState.IsValid)
            {
                obj.film.DataDodania = System.DateTime.Now;
                var plakatFolderPath = Path.Combine(hostingEnvironment.WebRootPath, "grafiki");
                var unikatNazwaPlakatu = Guid.NewGuid() + "_" + obj.Plakat.FileName;
                var plakatPath = Path.Combine(plakatFolderPath, unikatNazwaPlakatu);
                obj.Plakat.CopyTo(new FileStream(plakatPath, FileMode.Create));
                obj.film.Plakat = unikatNazwaPlakatu;
                db.Filmy.Add(obj.film);
                db.SaveChanges();
                TempData["Dodaj"] = "Dodano film";
                return RedirectToAction("DodajFilm");
            }
            
            var kategoria = db.Kategorie.ToList();
            obj.kategoria = kategoria;
            return View(obj);

        }
        [HttpPost]
        public IActionResult Szukaj(string tekst)
        {
            if (!String.IsNullOrEmpty(tekst))
            {
                var filmy = db.Filmy.Where(f => f.Tytul.Contains(tekst));
                ViewBag.Fraza = tekst;
                filmy.ToList();
                return View(filmy);
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult EdytujFilm(int id)
        {
            var film = db.Filmy
                .Where(film => film.Id == id)
                .SingleOrDefault();

            return View(film);
        }
        [HttpPost]
        public IActionResult EdytujFilm(Film model)
        {
            if (TryValidateModel(model, "Film") && ModelState.IsValid)
            {
                var film = db.Filmy
                    .Where(film => film.Id == model.Id)
                    .SingleOrDefault();

                if (model.Cena == null)
                {
                    model.Cena = 0.00m;
                }

                film.Rezyser = model.Rezyser;
                film.Tytul = model.Tytul;
                film.Opis = model.Opis;
                film.Cena = model.Cena;
                film.DataDodania = model.DataDodania;

                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Szczegoly", new { id = model.Id });
            }

            return View(model);
        }
    }
}
