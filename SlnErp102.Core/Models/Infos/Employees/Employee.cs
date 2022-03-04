using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Core.Models.Infos.Employees
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public int CityId { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime WorkEnd { get; set; }
        public DateTime BirthDay { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }

        public virtual City? City { get; set; }
        public virtual IEnumerable<EmployeeDetail>? EmployeeDetails { get; set; }


    }
}
