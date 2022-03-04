namespace SlnErp102.Core.Models.Infos.Hospitals
{
    public class HospitalDetail : Detail
    {
        public int HospitalBranchId { get; set; }
        public int DepartmentId { get; set; }
        public string Officer { get; set; }

        public virtual Department? Department { get; set; }
        public virtual HospitalBranch? HospitalBranches { get; set; }

    }
}
