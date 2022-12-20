using AlisverisListesiWeb.Models;
using AlisverisListesiWeb.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace AlisverisListesiWeb.Controllers
{
    public class UrunController : Controller
    {
        Context c = new Context();
        UrunRepository urunRepository = new UrunRepository();
        public IActionResult Index(int page = 1)
        {

            return View(urunRepository.TList("Kategori").ToPagedList(page, 5));
        }
        [HttpGet]
        public IActionResult UrunEkle()
        {
            List<SelectListItem> values = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult UrunEkle(Urun p)
        {
            urunRepository.TEkle(p);
            return RedirectToAction("Index");
        }
        public IActionResult UrunSil(int id)
        {
            urunRepository.TSil(new Urun { UrunID = id });
            return RedirectToAction("Index");
        }
        public IActionResult UrunGetir(int id)
        {
            var x = urunRepository.TGetir(id);
            List<SelectListItem> values = (from z in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = z.KategoriAd,
                                               Value = z.KategoriID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            Urun u = new Urun()
            {
                UrunID = x.UrunID,
                KategoriID = x.KategoriID,
                Ad = x.Ad,
                Fiyat = x.Fiyat,
                Stok = x.Stok,
                Aciklama = x.Aciklama,
                FotoURL = x.FotoURL
            };
            return View(u);
        }
        public IActionResult UrunGuncelle(Urun p)
        {
            var x = urunRepository.TGetir(p.UrunID);
            x.Ad = p.Ad;
            x.Stok = p.Stok;
            x.Fiyat = p.Fiyat;
            x.FotoURL = p.FotoURL;
            x.Aciklama = p.Aciklama;
            x.KategoriID = p.KategoriID;
            urunRepository.TGuncelle(x);
            return RedirectToAction("Index");
        }
    }
}
