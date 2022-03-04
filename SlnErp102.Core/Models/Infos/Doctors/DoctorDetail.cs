using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnErp102.Core.Models.Infos.Hospitals;

namespace SlnErp102.Core.Models.Infos.Doctors
{
    public class DoctorDetail:Detail
    {
        public int DoctorId { get; set; }
        public int HospitalId { get; set;}

        public virtual Doctor? Doctor { get; set; }
        public virtual Hospital? Hospital { get; set; }
        
    }
}
