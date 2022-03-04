namespace SlnErp102.Api.DTOs.Info.Hospitals
{
    public class HospitalBranchDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HospitalId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public string InvoiceTitle { get; set; }
    }
}
