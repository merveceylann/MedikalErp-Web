using SlnErp102.Core.Models.Infos.Doctors;

namespace SlnErp102.Core.Models.Infos.Hospitals
{
    public class Hospital : BaseEntity
    {
        public int HospitalTypeId { get; set; }
        public string HospitalName { get; set; }

        public virtual HospitalType? HospitalType { get; set; }
        public virtual IEnumerable<HospitalBranch>? HospitalBranch { get; set; }
        public virtual IEnumerable<DoctorDetail>? DoctorDetails{ get; set; }
        
    }
}
