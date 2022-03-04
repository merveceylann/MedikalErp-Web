using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Companies;

namespace SlnErp102.Core.Models.Stocks.Products
{
    public class Product:BaseEntity
    {
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public DateTime EntryDate { get; set; }
        public int BranchNoId { get; set; }
        public string Picture { get; set; }
        public string SutCode { get; set; }
        public decimal SutPrice { get; set; }
        public string SutDescription { get; set; }
        public int CompanyId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual IEnumerable<ProductEntry>? ProductEntries { get; set; }
        
    }
}
