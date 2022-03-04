using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Infos.Doctors;

namespace SlnErp102.Data.Seed.Info.Doctors
{
    public class DoctorDetailSeed : IEntityTypeConfiguration<DoctorDetail>
    {
        public void Configure(EntityTypeBuilder<DoctorDetail> builder)
        {
            builder.HasData(
                new DoctorDetail{Id = 1,DoctorId = 1,Email = "taser@gmail.com",Fax = "111",Phone = "111",Gsm = "111",HospitalId =1 },
                new DoctorDetail{Id = 2,DoctorId = 2,Email = "demirhan@gmail.com",Fax = "222",Phone = "222",Gsm = "222",HospitalId =3 },
                new DoctorDetail{Id = 3,DoctorId = 3,Email = "hamzaoglu@gmail.com",Fax = "333",Phone = "333",Gsm = "333",HospitalId =2 },
                new DoctorDetail{Id = 4,DoctorId = 3,Email = string.Empty,Fax = string.Empty,Phone = "444",Gsm = string.Empty,HospitalId =6 }
            );
        }
    }
}
