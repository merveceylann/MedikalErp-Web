using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Stocks.Products;

namespace SlnErp102.Core.Models.Infos.Companies
{
    public class Company:BaseEntity
    {
       
        public string Name { get; set; }
        public int CompanyTypeId { get; set; }

        public virtual CompanyType? CompanyType { get; set; }
        public virtual IEnumerable<CompanyBranch>? CompanyBranches { get; set; } = new List<CompanyBranch>();
        public virtual IEnumerable<CompanyDetail>? CompanyDetails { get; set; }= new List<CompanyDetail>();
        public virtual IEnumerable<Product>? Products { get; set; }= new List<Product>();
        public virtual IEnumerable<ProductEntry>? ProductEntries { get; set; }= new List<ProductEntry>();
    }
}
