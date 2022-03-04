using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Core.Models.Infos.Companies
{
    public class CompanyBranch:Branch
    {
        public int CityId { get; set; }
        public int CompanyId { get; set; }

        public virtual City? City { get; set; }
        public virtual Company? Company { get; set; }


    }
}
