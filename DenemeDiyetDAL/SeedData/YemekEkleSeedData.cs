using DiyetDenemeDATA.TemelOgeler.Base;
using DiyetDenemeDATA.TemelOgeler.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.SeedData
{
    public class YemekEkleSeedData
    {
        public void YemekEkle(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Yemek>().HasData(
                new Yemek { ID = 1, YemekAdı = Ogunler.Kahvaltı },
                new Yemek { ID = 2, YemekAdı = Ogunler.OglenYemegi },
                new Yemek { ID = 3, YemekAdı = Ogunler.AksamYemegi },
                new Yemek { ID = 4, YemekAdı = Ogunler.AraOgun }
                );

        }
    }
}
