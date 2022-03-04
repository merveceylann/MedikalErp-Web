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
    public class EmployeeDetailService:Service<EmployeeDetail>,IEmployeeDetailService
    {
        public EmployeeDetailService(IUnitOfWork unitOfWork, IRepository<EmployeeDetail> repository) : base(unitOfWork, repository)
        {
        }
    }
}
