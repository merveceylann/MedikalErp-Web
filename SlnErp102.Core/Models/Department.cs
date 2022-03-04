using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Companies;
using SlnErp102.Core.Models.Infos.Employees;
using SlnErp102.Core.Models.Infos.Hospitals;

namespace SlnErp102.Core.Models
{
    public sealed class Department
    {
        public int Id { get; set; }
        public string? Name { get; init; }
        public string? Type { get; init; }//hastane mi customer yada baska yerde kullanicaksam farki burada belirtmeliyim

        public IEnumerable<HospitalDetail>? HospitalDetails { get; set; } = new List<HospitalDetail>();
        public IEnumerable<EmployeeDetail>? EmployeeDetails { get; set; }=new List<EmployeeDetail>();
        public IEnumerable<CompanyDetail>? CompanyDetails { get; set; }

    }
}
