namespace SlnErp102.Api.DTOs.Info.Employees
{
    public class EmployeeDto
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime WorkEnd { get; set; }
        public DateTime BirthDay { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        
    }
}
