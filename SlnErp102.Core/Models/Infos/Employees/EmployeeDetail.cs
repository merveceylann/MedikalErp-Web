using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Core.Models.Infos.Employees
{
    public class EmployeeDetail:Detail
    {
        public int DepartmentId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual Employee? Employee { get; set; }

    }
}
