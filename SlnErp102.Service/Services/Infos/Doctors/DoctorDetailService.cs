using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Doctors;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Service.Infos.Doctors;
using SlnErp102.Core.UnitOfWork;

namespace SlnErp102.Service.Services.Infos.Doctors
{
    public class DoctorDetailService:Service<DoctorDetail>,IDoctorDetailService
    {
        public DoctorDetailService(IUnitOfWork unitOfWork, IRepository<DoctorDetail> repository) : base(unitOfWork, repository)
        {
        }
    }
}
