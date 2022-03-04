using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SlnErp102.Core.Models.Stocks.Products;
using SlnErp102.Core.Repository;
using SlnErp102.Core.Service.Stocks.Products;
using SlnErp102.Core.UnitOfWork;
using SlnErp102.Data;

namespace SlnErp102.Service.Services.Stocks.Products
{
    public class ProductEntryService:Service<ProductEntry>,IProductEntryService
    {
        //private SlnDbContext SlnDbContext { get => _db as SlnDbContext; }
        public ProductEntryService(IUnitOfWork unitOfWork, IRepository<ProductEntry> repository) : base(unitOfWork, repository)
        {
        }


        public async Task<IEnumerable<ProductEntry>> DistinctListByCompany()
        {

            return await _unitOfWork.ProductEntryRepo.DistinctListByCompany();
        }

        public async Task<IEnumerable<ProductEntry>> GetProductByInvoiceNumber(string ivno)
        {
            return await 
            _unitOfWork.ProductEntryRepo.GetProductByInvoiceNumber(ivno);
        }
    }
}
