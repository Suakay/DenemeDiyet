using DiyetDenemeDATA.TemelOgeler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.Mappings
{
    public class YiyecekYemekKategoriMappings : IEntityTypeConfiguration<YiyecekYemekKategori>
    {
        public void Configure(EntityTypeBuilder<YiyecekYemekKategori> builder)
        {
            builder.HasKey(x => new { x.YiyecekID, x.YemekKategorileriID });
        }
    }
}
