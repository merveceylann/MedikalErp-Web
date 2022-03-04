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
    public class ProductEntrySeed : IEntityTypeConfiguration<ProductEntry>
    {
        public void Configure(EntityTypeBuilder<ProductEntry> builder)
        {
            builder.HasData(
                
                new ProductEntry{Barcode = "AR-1000/1",CompanyId = 1,CreatedOn = DateTime.Now,Description = "TEST1",EntryDate = DateTime.Now,EntryTypeId = 1,ExpirationDate = DateTime.Now,Id = 1,InvoiceNumber = "1234",ProductId = 1,ProductionDate = DateTime.Now,LotSerial = "1",Quantity = 100,ModifiedUser = "system"},
                new ProductEntry{Barcode = "AR-1000/2",CompanyId = 1,CreatedOn = DateTime.Now,Description = "TEST1",EntryDate = DateTime.Now,EntryTypeId = 1,ExpirationDate = DateTime.Now,Id = 2,InvoiceNumber = "1234",ProductId = 1,ProductionDate = DateTime.Now, LotSerial = "2", Quantity = 200, ModifiedUser = "system" },
                new ProductEntry{Barcode = "AR-1001/1",CompanyId = 1,CreatedOn = DateTime.Now,Description = "TEST1",EntryDate = DateTime.Now,EntryTypeId = 1,ExpirationDate = DateTime.Now,Id = 3,InvoiceNumber = "1234",ProductId = 2,ProductionDate = DateTime.Now, LotSerial = "1", Quantity = 50, ModifiedUser = "system" },
                new ProductEntry{Barcode = "AR-1002/1",CompanyId = 2,CreatedOn = DateTime.Now,Description = "TEST1",EntryDate = DateTime.Now,EntryTypeId = 1,ExpirationDate = DateTime.Now,Id = 4,InvoiceNumber = "4321",ProductId = 3,ProductionDate = DateTime.Now, LotSerial = "1", Quantity = 150, ModifiedUser = "system" }
            );
        }
    }
}
