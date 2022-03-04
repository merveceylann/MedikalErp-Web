using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Companies;
using SlnErp102.Core.Repository.Infos.Companies;

namespace SlnErp102.Data.Repository.Infos.Companies
{
    public class CompanyRepository:Repository<Company>,ICompanyRepository
    {
        private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }
        public CompanyRepository(SlnDbContext db) : base(db)
        {
        }
    }
}
