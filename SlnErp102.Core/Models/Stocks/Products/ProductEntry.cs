using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Companies;

namespace SlnErp102.Core.Models.Stocks.Products
{
    public class ProductEntry:BaseEntity
    {
        public int CompanyId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime EntryDate { get; set; }
        public int ProductId { get; set; }
        public string LotSerial { get; set; }
        public int Quantity { get; set; }
        public int EntryTypeId { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public virtual  Company? Company { get; set; }
        public virtual  Product? Product { get; set; }
    }
}
