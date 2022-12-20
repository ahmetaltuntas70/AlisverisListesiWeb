using AlisverisListesiWeb.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisListesiWeb.ViewComponents
{
    public class UrunListByKategori : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            UrunRepository urunRepository = new UrunRepository();
            var urunliste = urunRepository.List(x => x.KategoriID == id);
            return View(urunliste);
        }
    }
}
