using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisListesiWeb.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
        public string FotoURL { get; set; }
        public int Stok { get; set; }

        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }



    }
}
