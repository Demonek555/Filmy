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
    public class KoszykControler : Controller
    {
        FilmyContext db;
        public KoszykControler(FilmyContext db)
        {
            this.db = db;
        }
        [Route("Koszyk")]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<KoszykRzeczy>>(HttpContext.Session, Consts.koszykSessionKey);
            ViewBag.CenaCalkowita = cart.Sum(item => item.Ilosc * item.Film.Cena);
            return View(cart);
        }
        [Route("Dodaj/{id}")]
        public IActionResult DodajDoKoszyka(int id)
        {
            var film = db.Filmy.Find(id);
            if (SessionHelper.GetObjectFromJson<List<KoszykRzeczy>>(HttpContext.Session, Consts.koszykSessionKey) == null)
            {
                List<KoszykRzeczy> cart = new List<KoszykRzeczy>();
                cart.Add(new KoszykRzeczy { Film = film, Ilosc = 1, Wartosc = film.Cena });
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.koszykSessionKey, cart);
            }
            else
            {
                List<KoszykRzeczy> cart = SessionHelper.GetObjectFromJson<List<KoszykRzeczy>>(HttpContext.Session, Consts.koszykSessionKey);
                int index = PobierzIndeks(id);
                if (index != -1)
                {
                    cart[index].Ilosc++;
                }
                else
                {
                    cart.Add(new KoszykRzeczy { Film = film, Ilosc = 1, Wartosc = film.Cena });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.koszykSessionKey, cart);
            }
            return RedirectToAction("Index");
        }

        private int PobierzIndeks(int id)
        {
            List<KoszykRzeczy> cart = SessionHelper.GetObjectFromJson<List<KoszykRzeczy>>(HttpContext.Session, Consts.koszykSessionKey);
            for(int i = 0; i < cart.Count(); i++)
            {
                if (cart[i].Film.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
