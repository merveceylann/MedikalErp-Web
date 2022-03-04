using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Service;
using SlnErp102.Core.UnitOfWork;

namespace SlnErp102.Service.Services
{
    public class CityService:Service<City>,ICityService
    {
        public CityService(IUnitOfWork unitOfWork, IRepository<City> repository) : base(unitOfWork, repository)
        {
        }
    }
}
