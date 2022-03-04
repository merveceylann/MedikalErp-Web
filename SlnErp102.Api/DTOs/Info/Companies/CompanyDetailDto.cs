namespace SlnErp102.Api.DTOs.Info.Companies
{
    public class CompanyDetailDto
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Gsm { get; set; }
        public string? Fax { get; set; }
        public string? Officer { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
    }
}
