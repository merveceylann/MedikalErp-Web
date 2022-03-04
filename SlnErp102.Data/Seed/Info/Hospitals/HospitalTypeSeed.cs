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
    public class HospitalTypeSeed : IEntityTypeConfiguration<HospitalType>
    {
        public void Configure(EntityTypeBuilder<HospitalType> builder)
        {
            builder.HasData(
                new HospitalType{Id = 1,Name = "Ozel"},
                new HospitalType{Id = 2,Name = "Devlet"},
                new HospitalType{Id = 3,Name = "Sehir"},
                new HospitalType{Id = 4,Name = "Universite"},
                new HospitalType{Id = 5,Name = "Vakif"},
                new HospitalType{Id = 6,Name = "Askeri"},
                new HospitalType{Id = 7,Name = "Sb"},
                new HospitalType{Id = 8,Name = "Klinik"},
                new HospitalType{Id = 9,Name = "Arastirma"}
            );
        }
    }
}

