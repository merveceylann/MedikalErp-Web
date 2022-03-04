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
    public class CompanyBranchSeed:IEntityTypeConfiguration<CompanyBranch>
    {
        public void Configure(EntityTypeBuilder<CompanyBranch> builder)
        {
            builder.HasData(
                new CompanyBranch{Id = 1,Address = "Esenyurt",CompanyId = 1,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system",Name = "Merkez",InvoiceTitle = "Ortek Ltd.Sti",CityId = 1},
                new CompanyBranch{Id = 2,Address = "Izmir",CompanyId = 1,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system",Name = "Izmir Sube",InvoiceTitle = "Ortek Ltd.Sti",CityId = 2},
                new CompanyBranch{Id = 3,Address = "Ankara",CompanyId = 1,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system",Name = "Ankara Sube",InvoiceTitle = "Ortek Ltd.Sti",CityId = 3},
                new CompanyBranch { Id = 4, Address = "Esenyurt", CompanyId = 2, CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now, ModifiedUser = "system", Name = "Merkez", InvoiceTitle = "Ortek Ltd.Sti", CityId = 1 },
                new CompanyBranch { Id = 5, Address = "Izmir", CompanyId = 2, CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now, ModifiedUser = "system", Name = "Izmir Sube", InvoiceTitle = "Ortek Ltd.Sti", CityId = 2 },
                new CompanyBranch { Id = 6, Address = "Ankara", CompanyId = 2, CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now, ModifiedUser = "system", Name = "Ankara Sube", InvoiceTitle = "Ortek Ltd.Sti", CityId = 3 }
            );
        }
    }
}
