using AlisverisListesiWeb.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisListesiWeb.ViewComponents
{
    public class UrunGetListe:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            UrunRepository urunRepository = new UrunRepository();
            var urunliste = urunRepository.TList();
            return View(urunliste);
        }
    }
}
