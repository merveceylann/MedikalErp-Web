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
    public class HospitalSeed : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.HasData(
                new Hospital{Id = 1,HospitalName = "AciBadem",HospitalTypeId = 1,ModifiedOn = DateTime.Now,ModifiedUser = "system",CreatedOn = DateTime.Now},
                new Hospital{Id = 2,HospitalName = "Florence Nightingale", HospitalTypeId = 1, ModifiedOn = DateTime.Now, ModifiedUser = "system", CreatedOn = DateTime.Now },
                new Hospital{Id = 3,HospitalName = "Medicana", HospitalTypeId = 1, ModifiedOn = DateTime.Now, ModifiedUser = "system", CreatedOn = DateTime.Now },
                new Hospital{Id = 4,HospitalName = "Beylikduzu Devlet",HospitalTypeId = 2, ModifiedOn = DateTime.Now, ModifiedUser = "system", CreatedOn = DateTime.Now },
                new Hospital{Id = 5,HospitalName = "KANUNİ SULTAN SÜLEYMAN", HospitalTypeId = 9, ModifiedOn = DateTime.Now, ModifiedUser = "system", CreatedOn = DateTime.Now },
                new Hospital{Id = 6,HospitalName = "Cam ve Sakura", HospitalTypeId = 3, ModifiedOn = DateTime.Now, ModifiedUser = "system", CreatedOn = DateTime.Now },
                new Hospital{Id = 7,HospitalName = "Kocaeli Üniversitesi Hastanesi", HospitalTypeId = 4, ModifiedOn = DateTime.Now, ModifiedUser = "system", CreatedOn = DateTime.Now },
                new Hospital{Id = 8,HospitalName = "Gata", HospitalTypeId = 6, ModifiedOn = DateTime.Now, ModifiedUser = "system", CreatedOn = DateTime.Now },
                new Hospital{Id = 9,HospitalName = "Bezmialem Vakıf Üni. Tıp Fakültesi Hastanesi", HospitalTypeId = 7, ModifiedOn = DateTime.Now, ModifiedUser = "system", CreatedOn = DateTime.Now }
            );
        }
    }
}
