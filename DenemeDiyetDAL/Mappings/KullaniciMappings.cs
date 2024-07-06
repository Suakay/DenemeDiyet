using Diyet_Deneme_DaLL.Entities;
using DiyetDenemeDATA.TemelOgeler.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.Mappings
{
    public class KullaniciMappings : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            //builder.HasOne(x => x.YemekTarihi)
            //.WithOne(fk => fk.Kullanici);

            //kullanici.YemekTarihi = yemekTarihi; yemekTarihi.Kullanici = kullanici; // Veritabanına kaydetusing (KutuphaneContext db = new KutuphaneContext()) {     db.Kullanicilar.Add(kullanici);     db.SaveChanges(); }
            //bağlam menüsü var




            builder.Property(k => k.ID)            
            .UseIdentityColumn(1, 1);

            builder.Property(k => k.Ad)
                .HasMaxLength(50);
            builder.Property(k => k.Soyad)
                .HasMaxLength(50);
            builder.HasIndex(k => k.EMail)
                .IsUnique();
            builder.Property(k => k.EMail)
                .HasMaxLength(50).IsRequired();
            builder.Property(k=>k.Password).IsRequired();

        }
    }
}
