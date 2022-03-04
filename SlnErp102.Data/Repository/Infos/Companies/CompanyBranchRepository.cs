using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Companies;
using SlnErp102.Core.Repository.Infos.Companies;

namespace SlnErp102.Data.Repository.Infos.Companies
{
    public class CompanyBranchRepository:Repository<CompanyBranch>,ICompanyBranchRepository
    {
        private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }
        public CompanyBranchRepository(SlnDbContext db) : base(db)
        {
        }
    }
}
