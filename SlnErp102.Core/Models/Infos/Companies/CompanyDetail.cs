using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Core.Models.Infos.Companies
{
    public class CompanyDetail:Detail
    {
        public string? Officer { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Department? Department { get; set; }
        
    }
}
