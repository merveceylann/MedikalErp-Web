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
    public class DepartmentSeed : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department{Id = 1,Name = "Satin Alma",Type = "H"},
                new Department{Id = 2,Name = "Finans",Type = "H"},
                new Department{Id = 3,Name = "Ameliyathane",Type = "H"},
                new Department{Id = 4,Name = "Rektorluk",Type = "H"},
                new Department{Id = 5,Name = "IK",Type = "H"},
                new Department{Id = 6,Name = "Hasta Haklari",Type = "H"},
                new Department{Id = 7,Name = "Finans",Type = "C"},
                new Department{Id = 8,Name = "Satin Alma",Type = "C"},
                new Department{Id = 9,Name = "Depo",Type = "C"},
                new Department{Id = 10,Name = "Sahip",Type = "C"}
            );
        }
    }
}
