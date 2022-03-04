using SlnErp102.Core.Models.Infos.Doctors;

namespace SlnErp102.Core.Models.Infos.Hospitals
{
    public class HospitalBranch : Branch
    {
        public int HospitalId { get; set; }
        public int CityId { get; set; }

        public City? City { get; set; }
        public Hospital? Hospital { get; set; }
        public IEnumerable<HospitalDetail>? HospitalDetails { get; set; }
        //public virtual IEnumerable<DoctorDetail>? DoctorDetails { get; set; }
        
    }
}
