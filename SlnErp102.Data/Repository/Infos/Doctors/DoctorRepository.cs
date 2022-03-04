using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Doctors;
using SlnErp102.Core.Repository.Infos.Doctors;

namespace SlnErp102.Data.Repository.Infos.Doctors
{
    public class DoctorRepository:Repository<Doctor>,IDoctorRepository
    {
        private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }
        public DoctorRepository(SlnDbContext db) : base(db)
        {
        }
    }
}
