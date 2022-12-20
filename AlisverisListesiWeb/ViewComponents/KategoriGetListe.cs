using AlisverisListesiWeb.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisListesiWeb.ViewComponents
{
    public class KategoriGetListe:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            KategoriRepository kategoriRepository = new KategoriRepository();
            var kategoriliste = kategoriRepository.TList();
            return View(kategoriliste);
        }
    }
}
