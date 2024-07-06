using Diyet_Deneme_DaLL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.AlçnanBesinGruplarç
{
    public class YemekKategorileriSeedData
    {
        public void YemekKategorisiEkle(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YemekKategorileri>().HasData(

                new YemekKategorileri { ID = 1, YemekAdı = "Kahvaltı" },
                new YemekKategorileri { ID = 2, YemekAdı = "Tahıl Ürünleri" },
                new YemekKategorileri { ID = 3, YemekAdı = "Süt Ürünleri" },
                new YemekKategorileri { ID = 4, YemekAdı = "Sebzeler" },
                new YemekKategorileri { ID = 5, YemekAdı = "Atıştırmalık" },
                new YemekKategorileri { ID = 6, YemekAdı = "Haşlanmış Sebzeler" },
                new YemekKategorileri { ID = 7,  YemekAdı = "Salata" },
                new YemekKategorileri { ID = 8, YemekAdı = "Yağlar" },
                new YemekKategorileri { ID = 9,  YemekAdı = "Çorbalar" }
                );
        }
    }
}
