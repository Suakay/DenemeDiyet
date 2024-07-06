using Diyet_Deneme_DaLL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeDiyetDAL.Mappings
{
    public class YiyecekMappings : IEntityTypeConfiguration<Yiyecek>
    {
        public void Configure(EntityTypeBuilder<Yiyecek> builder)
        {
            builder.Property(y => y.ID).UseIdentityColumn(1,1);
            builder.Property(y =>y.Adı).HasMaxLength(50);
        }
    }
}
