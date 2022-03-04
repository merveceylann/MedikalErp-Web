namespace SlnErp102.Api.DTOs.Stocks.Products
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public DateTime EntryDate { get; set; }
        public int BranchNoId { get; set; }
        public string Picture { get; set; }
        public string SutCode { get; set; }
        public decimal SutPrice { get; set; }
        public string SutDescription { get; set; }
        public int CompanyId { get; set; }
    }
}
