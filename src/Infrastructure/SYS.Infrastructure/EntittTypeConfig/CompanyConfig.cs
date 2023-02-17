using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SYS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Infrastructure.EntittTypeConfig
{
    public class CompanyConfig : BaseEntityConfig<Company>
    {
        public  override void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true);
            builder.ToTable(nameof(Company));

            builder.HasMany(x => x.Orders)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyID);
              

            builder.HasMany(x => x.Products)
              .WithOne(x => x.Company)
              .HasForeignKey(x => x.CompanyID);

            base.Configure(builder);
        }
    }
}
