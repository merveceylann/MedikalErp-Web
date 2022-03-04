namespace SlnErp102.Api.DTOs.Stocks.Products
{
    public class ProductPostDownDto
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string LotSerial { get; set; }
        public int Quantity { get; set; }
        public string Barcode { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
