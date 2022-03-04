namespace SlnErp102.Api.DTOs.Info.Doctors
{
    public class DoctorDetailDto
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Gsm { get; set; }
        public string? Fax { get; set; }
        public int DoctorId { get; set; }
        public int HospitalId { get; set; }
    }
}
