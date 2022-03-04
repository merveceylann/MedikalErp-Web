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
    public class DoctorDetailConfig : IEntityTypeConfiguration<DoctorDetail>
    {
        public void Configure(EntityTypeBuilder<DoctorDetail> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.Email).IsRequired().HasMaxLength(150);
            builder.Property(s => s.Phone).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Gsm).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Fax).IsRequired().HasMaxLength(50);
            builder.ToTable("tblDoctorDetails");
        }
    }
}
