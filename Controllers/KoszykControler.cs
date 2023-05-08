using Filmy.DAL;
using Filmy.Infrastructure;
using Filmy.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.Controllers
{
    public class KoszykController : Controller
    {
        private readonly FilmyContext filmyContext;
        public KoszykController(FilmyContext filmyContext)
        {
            this.filmyContext = filmyContext;
        }

        [Route("Koszyk")]
        public IActionResult Index()
        {
            var koszyk = SessionHelper.GetObjectFromJson<List<Koszyk>>(HttpContext.Session, Consts.KoszykSessionKey);

            if (koszyk == null)
            {
                koszyk = new List<Koszyk>();
            }

            ViewBag.CenaCalkowita = koszyk.Sum(item => item.Ilosc * item.Film.Cena);

            return View(koszyk);
        }

        [Route("Dodaj/{id}")]
        public IActionResult DodajDoKoszyka(int id)
        {
            var film = filmyContext.Filmy.Find(id);
            var koszyk = SessionHelper.GetObjectFromJson<List<Koszyk>>(HttpContext.Session, Consts.KoszykSessionKey);

            if (koszyk == null)
            {
                koszyk = new List<Koszyk>();
                koszyk.Add(new Koszyk
                {
                    Film = film,
                    Ilosc = 1,
                    Wartosc = film.Cena
                });
            }
            else
            {
                int index = PobierzIndeks(id, koszyk);

                if (index != -1)
                {
                    koszyk[index].Ilosc++;
                    koszyk[index].Wartosc = koszyk[index].Wartosc+koszyk[index].Film.Cena;
                }
                else
                {
                    koszyk.Add(new Koszyk
                    {
                        Film = film,
                        Ilosc = 1,
                        Wartosc = film.Cena
                    });
                }
            }

            SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.KoszykSessionKey, koszyk);

            return RedirectToAction("Index");
        }

        private int PobierzIndeks(int id, List<Koszyk> koszyk)
        {
            for (int i = 0; i < koszyk.Count; i++)
            {
                if (koszyk[i].Film.Id == id)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
