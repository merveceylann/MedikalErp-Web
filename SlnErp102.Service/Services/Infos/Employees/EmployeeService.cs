using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Employees;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Service.Infos.Employees;
using SlnErp102.Core.UnitOfWork;

namespace SlnErp102.Service.Services.Infos.Employees
{
    public class EmployeeService:Service<Employee>,IEmployeeService
    {
        public EmployeeService(IUnitOfWork unitOfWork, IRepository<Employee> repository) : base(unitOfWork, repository)
        {
        }
    }
}
