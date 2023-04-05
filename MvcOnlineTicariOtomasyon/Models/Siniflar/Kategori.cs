using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public String KategoriAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }
        //Kategori Tablosunda ürünleri görmek için 
        //Aynı kategoride birden fazla ürün olabilir ama bir ürünün ancak bir kategorisi olur.
        //Yani Kategori-Urun arasında 1 den çoğa bir ilişki vardır.


    }
}