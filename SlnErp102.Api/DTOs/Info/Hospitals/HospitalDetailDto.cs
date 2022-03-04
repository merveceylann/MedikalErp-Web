namespace SlnErp102.Api.DTOs.Info.Hospitals
{
    public class HospitalDetailDto
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Gsm { get; set; }
        public string? Fax { get; set; }
        public int HospitalBranchId { get; set; }
        public int DepartmentId { get; set; }
        public string Officer { get; set; }
    }
}
