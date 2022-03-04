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
    public class HospitalBranchSeed : IEntityTypeConfiguration<HospitalBranch>
    {
        public void Configure(EntityTypeBuilder<HospitalBranch> builder)
        {
            builder.HasData(

                new HospitalBranch{Id = 1,HospitalId = 1,Name = "Merkez",Address = "Acibadem/Kadikoy", CityId = 1,InvoiceTitle = "Acibadem Saglik Hizmetleri A.S.",CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new HospitalBranch{Id = 2,HospitalId = 1,Name = "Ankara",Address = "Çankaya/Ankara", CityId = 1,InvoiceTitle = "Acibadem Saglik Hizmetleri A.S.",CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new HospitalBranch{Id = 3,HospitalId = 1,Name = "Eskisehir",Address = "Tepebaşı/Eskişehir", CityId = 1,InvoiceTitle = "Acibadem Saglik Hizmetleri A.S.",CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new HospitalBranch{Id = 4,HospitalId = 2,Name = "Merkez",Address = "Şişli/İstanbul", CityId = 1,InvoiceTitle = "Florence Nightingale Saglik Hizmetleri A.S.", CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new HospitalBranch{Id = 5,HospitalId = 3,Name = "Merkez",Address = "Beylikdüzü/İstanbul", CityId = 1,InvoiceTitle = "Medikana Saglik Hizmetleri A.S.", CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new HospitalBranch{Id = 6,HospitalId = 4,Name = "Merkez",Address = "Beylikdüzü/İstanbul", CityId = 1,InvoiceTitle = "Devlet Saglik Hizmetleri A.S.", CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new HospitalBranch{Id = 7,HospitalId = 5,Name = "Merkez",Address = "Gazi Osman Pasa/İstanbul", CityId = 1,InvoiceTitle = "Devlet Saglik Hizmetleri A.S.", CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new HospitalBranch{Id = 8,HospitalId = 6,Name = "Merkez",Address = "Basaksehir/İstanbul", CityId = 1,InvoiceTitle = "Devlet Saglik Hizmetleri A.S.", CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"}

            );
        }
    }
}
