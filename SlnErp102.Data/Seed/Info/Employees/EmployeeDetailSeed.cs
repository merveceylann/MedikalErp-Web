using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Infos.Employees;

namespace SlnErp102.Data.Seed.Info.Employees
{
    public class EmployeeDetailSeed : IEntityTypeConfiguration<EmployeeDetail>
    {
        public void Configure(EntityTypeBuilder<EmployeeDetail> builder)
        {
            builder.HasData(
                
                new EmployeeDetail{Id = 1,EmployeeId = 1,DepartmentId =1, Email = "111@gmail.com", Phone = "1234", Gsm = "1234", Fax = "234" },
                new EmployeeDetail{Id = 2,EmployeeId = 2,DepartmentId =2, Email = "222@gmail.com", Phone = "1234", Gsm = "1234", Fax = "234" },
                new EmployeeDetail{Id = 3,EmployeeId = 3,DepartmentId =3, Email = "333@gmail.com", Phone = "1234", Gsm = "1234", Fax = "234" }
                
                );
        }
    }
}
