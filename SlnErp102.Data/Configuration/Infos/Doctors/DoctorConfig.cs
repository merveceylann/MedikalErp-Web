using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Infos.Doctors;

namespace SlnErp102.Data.Configuration.Infos.Doctors
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.Property(s => s.ClinicAddress).HasMaxLength(350);
            builder.Property<DateTime>(s => s.BirthDay).HasColumnType("date");
            builder.Property<DateTime>(s => s.CreatedOn).HasColumnType("date");
            builder.Property<DateTime>(s => s.ModifiedOn).HasColumnType("date");
            builder.Property(s => s.ModifiedUser).HasMaxLength(50);
            builder.ToTable("tblDoctors");
        }
    }
}
