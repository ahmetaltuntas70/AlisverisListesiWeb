using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisListesiWeb.Models
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        [Required(ErrorMessage="Kategori adı boş olamaz!!!")]

        public string KategoriAd { get; set; }
        public string KategoriAciklama { get; set; }
        public bool Durum { get; set; }

        public List<Urun> Uruns { get; set; }
    }
}
