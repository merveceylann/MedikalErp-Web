using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Companies;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Service.Infos.Companies;
using SlnErp102.Core.UnitOfWork;

namespace SlnErp102.Service.Services.Infos.Companies
{
    public class CompanyBranchService:Service<CompanyBranch>,ICompanyBranchService
    {
        public CompanyBranchService(IUnitOfWork unitOfWork, IRepository<CompanyBranch> repository) : base(unitOfWork, repository)
        {
        }
    }
}
