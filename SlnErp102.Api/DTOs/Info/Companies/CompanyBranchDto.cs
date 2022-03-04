namespace SlnErp102.Api.DTOs.Info.Companies
{
    public class CompanyBranchDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? InvoiceTitle { get; set; }
        public int CityId { get; set; }
        public int CompanyId { get; set; }
    }
}
