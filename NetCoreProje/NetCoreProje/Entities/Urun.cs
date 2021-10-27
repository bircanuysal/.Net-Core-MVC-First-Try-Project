using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NetCoreProje.Entities
{
    [Dapper.Contrib.Extensions.Table("Urunler")]
    public class Urun
    {
        [Dapper.Contrib.Extensions.ExplicitKey]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Resim { get; set; }
        public decimal Fiyat { get; set; }
        public List<UrunKategori> UrunKategoriler { get; set; }
    }
}
