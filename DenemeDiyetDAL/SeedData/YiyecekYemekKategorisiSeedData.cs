using DiyetDenemeDATA.TemelOgeler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Deneme_DaLL.Seed
{
    public class YiyecekYemekKategorileriSeedData
    {
        public void YiyecekYemekKategoriEkle(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YiyecekYemekKategori>().HasData(
           new YiyecekYemekKategori { YiyecekID = 1, YemekKategorileriID = 1 },
                new YiyecekYemekKategori { YiyecekID = 2, YemekKategorileriID = 1 },
                new YiyecekYemekKategori { YiyecekID = 3, YemekKategorileriID = 1 },
                new YiyecekYemekKategori { YiyecekID = 4, YemekKategorileriID = 1 },
                new YiyecekYemekKategori { YiyecekID = 5, YemekKategorileriID = 1 },
                new YiyecekYemekKategori { YiyecekID = 6, YemekKategorileriID = 1 },
                new YiyecekYemekKategori { YiyecekID = 7, YemekKategorileriID = 1 },
                new YiyecekYemekKategori { YiyecekID = 8, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 9, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 10, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 11, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 12, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 13, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 14, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 15, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 16, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 17, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 18, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 19, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 20, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 21, YemekKategorileriID = 2 },
                new YiyecekYemekKategori { YiyecekID = 22, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 23, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 24, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 25, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 26, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 27, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 28, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 29, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 30, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 31, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 32, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 33, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 34, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 35, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 36, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 37, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 38, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 39, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 40, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 41, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 42, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 43, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 44, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 45, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 46, YemekKategorileriID = 3 },
                new YiyecekYemekKategori { YiyecekID = 47, YemekKategorileriID = 4 },
                new YiyecekYemekKategori { YiyecekID = 48, YemekKategorileriID = 4 },
                new YiyecekYemekKategori { YiyecekID = 49, YemekKategorileriID = 4 },
                new YiyecekYemekKategori { YiyecekID = 50, YemekKategorileriID = 4 }
                
            );
        }
    }
}
