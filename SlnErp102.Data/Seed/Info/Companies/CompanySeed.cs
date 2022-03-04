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
    public class CompanySeed:IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company{Id = 1,Name = "Ortek",CompanyTypeId = 1,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new Company{Id = 2,Name = "Syntex",CompanyTypeId = 2,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new Company{Id = 3,Name = "Kayacan",CompanyTypeId = 3,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"}
            );
        }
    }
}
