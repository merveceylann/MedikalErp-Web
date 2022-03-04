using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SlnErp102.Core.Models.Stocks.Products;

namespace SlnErp102.Data.Configuration.Stocks.Products
{
    public class StockStateConfig : IEntityTypeConfiguration<StockState>
    {
        public void Configure(EntityTypeBuilder<StockState> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.ProductCode).HasMaxLength(50);
            builder.Property(s => s.LotSerial).IsRequired().HasMaxLength(50);
            builder.ToTable("tblStockStates");
        }
    }
}
