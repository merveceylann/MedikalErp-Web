namespace SlnErp102.Api.DTOs.Info.Doctors
{
    public class DoctorDto
    {
        public int Id { get; init; }
        public string Name { get; set; }
        //public DoctorBranches BranchName { get; set; }
        public string ClinicAddress { get; set; }
        public int CityId { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
