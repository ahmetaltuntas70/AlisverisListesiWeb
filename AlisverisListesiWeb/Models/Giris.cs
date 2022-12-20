using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisListesiWeb.Models
{
    public class Giris
    {
        [Key]
        public int GirisID { get; set; }
        [StringLength(20)]
        public string KullaniciAdi { get; set; }
        [StringLength(20)]
        public string Sifre { get; set; }
        [StringLength(1)]
        public string GirisRole { get; set; }
    }
}
