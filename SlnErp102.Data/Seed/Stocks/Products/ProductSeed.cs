using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Stocks.Products;

namespace SlnErp102.Data.Seed.Stocks.Products
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product{Id = 1,ProductCode = "AR-1000",Description = "Suture Passer, Transosseous",EntryDate = DateTime.Now,BranchNoId = 1,Picture = "product1.jpg",SutCode ="AE-1000",SutDescription = "DÜZ TİTANYUM",SutPrice = 125.75m,CompanyId = 1,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new Product{Id = 2,ProductCode = "AR-1001",Description = "Suture Passer, Transosseous1",EntryDate = DateTime.Now,BranchNoId = 2,Picture = "product2.jpg",SutCode ="AE-1001",SutDescription = "DÜZ TİTANYUM",SutPrice = 155.75m,CompanyId = 1,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new Product{Id = 3,ProductCode = "AR-1002",Description = "Suture Passer, Transosseous2",EntryDate = DateTime.Now,BranchNoId = 1,Picture = "product3.jpg",SutCode ="AE-1002",SutDescription = "DÜZ TİTANYUM",SutPrice = 115.75m,CompanyId = 1,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"},
                new Product{Id = 4,ProductCode = "AR-1003",Description = "Suture Passer, Transosseous3",EntryDate = DateTime.Now,BranchNoId = 1,Picture = "product4.jpg",SutCode ="AE-1003",SutDescription = "DÜZ TİTANYUM",SutPrice = 215.25m,CompanyId = 1,CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now,ModifiedUser = "system"}
            );
        }
    }
}
