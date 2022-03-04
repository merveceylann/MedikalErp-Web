using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Repository.Stocks;
using SlnErp102.Core.Repository.Stocks.Products;

namespace SlnErp102.Data.Repository.Stocks.Products
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }
        public ProductRepository(SlnDbContext db) : base(db)
        {
        }
    }
}
