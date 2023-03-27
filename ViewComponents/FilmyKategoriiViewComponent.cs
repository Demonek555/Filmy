using Filmy.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.ViewComponents
{
    public class FilmyKategoriiViewComponent:ViewComponent
    {
        FilmyContext db;
        public FilmyKategoriiViewComponent(FilmyContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync (string nazwaKategorii)
        {
            var model= db.Kategorie.Include("Filmy").Where(kategoria => kategoria.Nazwa.ToUpper() == nazwaKategorii.ToUpper()).Single().Filmy.ToList();
           
            return await Task.FromResult((IViewComponentResult)View("_FilmyKategorie", model));
        }
    }
}
