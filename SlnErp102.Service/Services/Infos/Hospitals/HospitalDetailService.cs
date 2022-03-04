using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Hospitals;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Service.Infos.Hospitals;
using SlnErp102.Core.UnitOfWork;

namespace SlnErp102.Service.Services.Infos.Hospitals
{
    public class HospitalDetailService:Service<HospitalDetail>,IHospitalDetailService
    {
        public HospitalDetailService(IUnitOfWork unitOfWork, IRepository<HospitalDetail> repository) : base(unitOfWork, repository)
        {
        }
    }
}
