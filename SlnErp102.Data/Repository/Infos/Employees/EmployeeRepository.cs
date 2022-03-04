using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Employees;
using SlnErp102.Core.Repository.Infos.Employees;

namespace SlnErp102.Data.Repository.Infos.Employees
{
    public class EmployeeRepository:Repository<Employee>,IEmployeeRepository
    {
        private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }
        public EmployeeRepository(SlnDbContext db) : base(db)
        {
        }
    }
}
