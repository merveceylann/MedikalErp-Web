using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models;
using SlnErp102.Core.Repository;

namespace SlnErp102.Data.Repository
{
    public class DepartmentRepository:Repository<Department>,IDepartmentRepository
    {
        private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }
        public DepartmentRepository(SlnDbContext db) : base(db)
        {
        }
    }
}
