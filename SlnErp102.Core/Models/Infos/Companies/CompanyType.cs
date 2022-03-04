using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Core.Models.Infos.Companies
{
    public class CompanyType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Company>? Companies { get; set; }

    }
}
