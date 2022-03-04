using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Infos.Hospitals;

namespace SlnErp102.Data.Configuration.Infos.Hospitals
{
    public class HospitalTypeConfig : IEntityTypeConfiguration<HospitalType>
    {
        public void Configure(EntityTypeBuilder<HospitalType> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.ToTable("tblHospitalTypes");
        }
    }
}
