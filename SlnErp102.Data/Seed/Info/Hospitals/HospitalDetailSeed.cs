using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Infos.Hospitals;

namespace SlnErp102.Data.Seed.Info.Hospitals
{
    public class HospitalDetailSeed : IEntityTypeConfiguration<HospitalDetail>
    {
        public void Configure(EntityTypeBuilder<HospitalDetail> builder)
        {
            builder.HasData(
                new HospitalDetail{Id = 1,HospitalBranchId = 1,DepartmentId = 1,Officer = "SatinAlmaciAhmet",Email = "sss@gmail.com",Phone = "1234",Gsm = "1234",Fax = "234"},
                new HospitalDetail{Id = 2,HospitalBranchId = 1,DepartmentId = 3,Officer = "Hatice Hemsire",Email = "hatice@gmail.com",Phone = "222",Gsm = "222",Fax = "222"},
                new HospitalDetail{Id = 3,HospitalBranchId = 1,DepartmentId = 5,Officer = "Ik-Elif Hanim",Email = "elif@gmail.com",Phone = "333",Gsm = "333",Fax = "333"}
            );
        }
    }
}
