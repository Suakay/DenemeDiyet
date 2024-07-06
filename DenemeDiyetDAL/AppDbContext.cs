
using DenemeDiyetDAL.AlçnanBesinGruplarç;
using DenemeDiyetDAL.Mappings;
using DenemeDiyetDAL.SeedData;
using Diyet_Deneme_DaLL.Entities;
using Diyet_Deneme_DaLL.Seed;
using DiyetDenemeDATA.TemelOgeler;
using DiyetDenemeDATA.TemelOgeler.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekKategorileri = Diyet_Deneme_DaLL.Entities.YemekKategorileri;

namespace DenemeDiyetDAL
{
    public class AppDbContext : DbContext
    {

        public DbSet<YemekKategorileri> YemekKategorileris { get; set; }
        public DbSet<Yiyecek> Yiyeceks { get; set; }
        public DbSet<Yemek> Yemeks { get; set; }
       // public DbSet<KullaniciYonetimi> KullaniciYonetimis { get; set; }
        public DbSet<YiyecekYemekKategori> YiyecekYemekKategoris { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<YemekTarihi> YemekTarihis { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-MIJ2PSH;Initial Catalog=Yemek9;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            new YiyecekMappings().Configure(modelBuilder.Entity<Yiyecek>());
            new YiyecekYemekKategoriMappings().Configure(modelBuilder.Entity<YiyecekYemekKategori>());
            new KullaniciMappings().Configure(modelBuilder.Entity<Kullanici>());
            new YemekKategorileriMappings().Configure(modelBuilder.Entity<YemekKategorileri>());     

            YemekKategorileriSeedData yemekKategorileriSeedData = new YemekKategorileriSeedData();
            yemekKategorileriSeedData.YemekKategorisiEkle(modelBuilder);

            YemekEkleSeedData yemekSeedData = new YemekEkleSeedData();
            yemekSeedData.YemekEkle(modelBuilder);

            YiyecekKalorileri yiyecekKalorileri = new YiyecekKalorileri();
            yiyecekKalorileri.YiyecekEkle(modelBuilder);

            YiyecekYemekKategorileriSeedData yiyecekYemekKategorileriSeedData = new YiyecekYemekKategorileriSeedData();
            yiyecekYemekKategorileriSeedData.YiyecekYemekKategoriEkle(modelBuilder);

            base.OnModelCreating(modelBuilder);

        }

    }
}
