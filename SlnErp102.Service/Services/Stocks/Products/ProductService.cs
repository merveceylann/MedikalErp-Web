using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Service.Stocks.Products;
using SlnErp102.Core.UnitOfWork;

namespace SlnErp102.Service.Services.Stocks.Products
{
    public class ProductService:Service<Product>,IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }
    }
}
