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
    public class CompanyDetailSeed : IEntityTypeConfiguration<CompanyDetail>
    {
        public void Configure(EntityTypeBuilder<CompanyDetail> builder)
        {
            builder.HasData(
                new CompanyDetail{Id = 1,CompanyId = 1,DepartmentId =7,Email = "111@gmail.com",Fax = "111",Phone = "111",Gsm = "111",Officer = "Sinan"},
                new CompanyDetail{Id = 2,CompanyId = 1,DepartmentId =8,Email = "222@gmail.com",Fax = "222",Phone = "222",Gsm = "222",Officer = "Sukran"},
                new CompanyDetail{Id = 3,CompanyId = 1,DepartmentId =9,Email = "333@gmail.com",Fax = "333",Phone = "333",Gsm = "333",Officer = "Turgay"},
                new CompanyDetail{Id = 4,CompanyId = 1,DepartmentId =10,Email = "444@gmail.com",Fax = "444",Phone = "444",Gsm = "444",Officer = "Tahir"}
            );
        }
    }
}
