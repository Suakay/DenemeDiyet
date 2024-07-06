using Diyet_Deneme_DaLL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.Mappings
{
    public class YemekKategorileriMappings : IEntityTypeConfiguration<YemekKategorileri>
    {

        public void Configure(EntityTypeBuilder<YemekKategorileri> builder)
        {
            builder.Property(y => y.ID)                
                .UseIdentityColumn(1, 1);

            builder.Property(k => k.YemekAdı).HasMaxLength(50);

            //builder.HasOne(x => x.Yemek)
            //    .WithMany(y => y.YemekKategorileris)
            //.HasForeignKey(k=>k.ID);


            
                






        }
    }
}
