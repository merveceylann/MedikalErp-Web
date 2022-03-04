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
    public class DoctorSeed : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(
                
                new Doctor{Id = 1,Name = "Omer Taser",ClinicAddress = "Fulya/Besiktas",CityId = 1,BirthDay = DateTime.Now,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new Doctor{Id = 2,Name = "Mehmet Demirhan",ClinicAddress = "Tesvikiye/Sisli",CityId = 1,BirthDay = DateTime.Now,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new Doctor{Id = 3,Name = "Azmi Hamzaoglu",ClinicAddress = "Abide-i Hürriyet Cd No:166, 34381 Şişli/İstanbul", CityId = 1,BirthDay = DateTime.Now,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"}
                
                );
        }
    }
}
