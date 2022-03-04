using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Infos.Companies;

namespace SlnErp102.Data.Seed.Info.Companies
{
    public class CompanyTypeSeed : IEntityTypeConfiguration<CompanyType>
    {
        public void Configure(EntityTypeBuilder<CompanyType> builder)
        {
            builder.HasData(
                new CompanyType { Id = 1, Name = "Musteri" },
            new CompanyType { Id = 2, Name = "Tedarikci" },
            new CompanyType { Id = 3, Name = "Ana Satici" },
            new CompanyType { Id = 4, Name = "Distributor" }
            );

        }
    }
}
