using System.Text.Json.Serialization;
using SlnErp102.Core.Models.Stocks.Products;

namespace SlnErp102.Api.DTOs.Stocks.Products
{
    public class ProductEntryDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("companyId")]
        public int CompanyId { get; set; }

        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        [JsonPropertyName("productProductCode")]
        public string ProductProductCode { get; set; }

        [JsonPropertyName("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonPropertyName("entryDate")]
        public DateTime EntryDate { get; set; }

        [JsonPropertyName("productId")]
        public int ProductId { get; set; }

        [JsonPropertyName("lotSerial")]
        public string LotSerial { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("entryTypeId")]
        public int EntryTypeId { get; set; }

        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("productionDate")]
        public DateTime ProductionDate { get; set; }

        [JsonPropertyName("expirationDate")]
        public DateTime ExpirationDate { get; set; }
        
    }


    public class ProductEntryDistinctDto
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime EntryDate { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
