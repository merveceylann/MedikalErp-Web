using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnErp102.Core.Models.Infos.Doctors
{
    public class Doctor:BaseEntity
    {
        public DoctorTitle Title { get; set; }
        public string Name { get; set; }
        //public DoctorBranches BranchName { get; set; }
        public string ClinicAddress { get; set; }
        public int CityId { get; set; }
        public DateTime BirthDay { get; set; }

        public virtual City City { get; set; }
        public virtual IEnumerable<DoctorDetail>? DoctorDetails { get; set; }


    }

    public enum DoctorTitle
    {
        Prof_Dr = 1,
        Doc_Dr = 2,
        Yrd_Doc_Dr3 = 3,
        Uzm_Dr = 4,
        Opr_Dr = 5,
        Pra_Dr = 6,
        Asistan_Dr = 7,
    }

    public enum DoctorBranches
    {
        Kardiyoloji= 0,
        Ortopedi= 1,
        Dahiliye= 2,
        KBB= 3,
        Endokrinoloji= 4,
        Norosiruji= 5,
        AgizveDis= 6,
    }
}
