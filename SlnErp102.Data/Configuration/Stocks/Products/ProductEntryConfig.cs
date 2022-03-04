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
    public class ProductEntryConfig : IEntityTypeConfiguration<ProductEntry>
    {
        public void Configure(EntityTypeBuilder<ProductEntry> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.InvoiceNumber).HasMaxLength(30);
            builder.Property(s => s.Description).HasMaxLength(350);
            builder.Property(s => s.LotSerial).IsRequired().HasMaxLength(50);
            
            builder.Property(s => s.Barcode).HasMaxLength(150);
            
            builder.Property<DateTime>(s => s.ProductionDate).HasColumnType("date");
            builder.Property<DateTime>(s => s.ExpirationDate).HasColumnType("date");
            builder.Property<DateTime>(s => s.EntryDate).HasColumnType("date");
            builder.Property<DateTime>(s => s.CreatedOn).HasColumnType("date");
            builder.Property<DateTime>(s => s.ModifiedOn).HasColumnType("date");
            builder.Property(s => s.ModifiedUser).HasMaxLength(50);
            //Yontem - 3 =>Cascade islemini degistirmek icin kullanildi.
            //builder.HasOne(s => s.Company).WithMany(s => s.ProductEntries).HasForeignKey(s => s.CompanyId)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("tblProductEntries");
        }
    }
}
