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
    public class EmployeeSeed:IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee{Id = 1,Name = "Serdar",CityId = 1,WorkStart = DateTime.Now,WorkEnd = DateTime.Now,BirthDay = DateTime.Now,Picture = "user1.png",Description = "Aciklama1",CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new Employee{Id = 2,Name = "Recep",CityId = 1,WorkStart = DateTime.Now,WorkEnd = DateTime.Now,BirthDay = DateTime.Now,Picture = "user2.png",Description = "Aciklama2",CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new Employee{Id = 3,Name = "Melek",CityId = 1,WorkStart = DateTime.Now,WorkEnd = DateTime.Now,BirthDay = DateTime.Now,Picture = "user3.png",Description = "Aciklama3",CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"}
            );
        }
    }
}
