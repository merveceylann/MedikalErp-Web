using System.ComponentModel.DataAnnotations;

namespace SlnErp102.Api.DTOs.Info.Hospitals
{
    public class HospitalTypeDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
