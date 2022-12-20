using AlisverisListesiWeb.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlisverisListesiWeb.Models;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;

namespace AlisverisListesiWeb.Controllers
{
    public class KategoriController : Controller
    {
        KategoriRepository kategoriRepository = new KategoriRepository();
        //[Authorize]
        public IActionResult Index(string p)
        {
            if( !string.IsNullOrEmpty(p))
            {
                return View(kategoriRepository.List(x=> x.KategoriAd == p));
            }
            return View(kategoriRepository.TList());
        }
        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(Kategori p)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriEkle");
            }
            kategoriRepository.TEkle(p);
            return RedirectToAction("Index");
        }
        public IActionResult KategoriGetir(int id)
        {
            var x = kategoriRepository.TGetir(id);
            Kategori kt = new Kategori()
            {
                KategoriAd = x.KategoriAd,
                KategoriAciklama = x.KategoriAciklama,
                KategoriID = x.KategoriID
            };
            return View(kt);
        }
        [HttpPost]
        public IActionResult KategoriGuncelle(Kategori p)
        {
            var x = kategoriRepository.TGetir(p.KategoriID);
            x.KategoriAd = p.KategoriAd;
            x.KategoriAciklama = p.KategoriAciklama;
            x.Durum = true;
            kategoriRepository.TGuncelle(x);
            return RedirectToAction("Index");
        }
        public IActionResult KategoriSil(int id)
        {
            var x = kategoriRepository.TGetir(id);
            x.Durum = false;
            kategoriRepository.TGuncelle(x);
            return RedirectToAction("Index");
        }
    }
}
