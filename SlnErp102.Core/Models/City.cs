using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Companies;
using SlnErp102.Core.Models.Infos.Doctors;
using SlnErp102.Core.Models.Infos.Employees;
using SlnErp102.Core.Models.Infos.Hospitals;

namespace SlnErp102.Core.Models
{
    public sealed class City
    {
        
        public int Id { get; set; }
        public string? Name { get; init; }
        public string? Region { get; init; }

        public IEnumerable<Doctor>? Doctors { get; set; }
        //public virtual IEnumerable<Hospital>? Hospitals { get; set; }
        public IEnumerable<HospitalBranch>? HospitalBranches { get; set; } = new List<HospitalBranch>();
        public IEnumerable<CompanyBranch>? CompanyBranches { get; set; }= new List<CompanyBranch>();
        public IEnumerable<Employee>? Employees { get; set; }=new List<Employee>();

    }
}
