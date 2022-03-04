using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models;

namespace SlnErp102.Data.Seed.Info
{
    public class CitySeed : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                new City{Id=1,Name = "Istanbul",Region = "Marmara"},
                new City{Id=2,Name = "Ankara",Region = "Ic Anadolu"},
                new City{Id=3,Name = "Izmir",Region = "Ege"},
                new City{Id=4,Name = "Antalya",Region = "Akdeniz"},
                new City{Id=5,Name = "Diyarbakir",Region = "Guney Dogu Anadolu"},
                new City{Id=6,Name = "Samsun",Region = "Karadeniz"},
                new City{Id=7,Name = "Kars",Region = "Dogu Anadolu"}
            );
        }
    }
}
