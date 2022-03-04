using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Stocks.Products;

namespace SlnErp102.Core.Service.Stocks.Products
{
    public interface IProductEntryService:IService<ProductEntry>
    {
        Task<IEnumerable<ProductEntry>> DistinctListByCompany();

        Task<IEnumerable<ProductEntry>> GetProductByInvoiceNumber(string ivno);
    }
}
