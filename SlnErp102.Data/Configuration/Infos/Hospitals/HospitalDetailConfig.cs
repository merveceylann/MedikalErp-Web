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
    public class HospitalDetailConfig : IEntityTypeConfiguration<HospitalDetail>
    {
        public void Configure(EntityTypeBuilder<HospitalDetail> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.Officer).HasMaxLength(50);
            builder.Property(s => s.Email).HasMaxLength(150);
            builder.Property(s => s.Phone).HasMaxLength(50);
            builder.Property(s => s.Gsm).HasMaxLength(50);
            builder.Property(s => s.Fax).HasMaxLength(50);
            builder.ToTable("tblHospitalDetails");
        }
    }
}
