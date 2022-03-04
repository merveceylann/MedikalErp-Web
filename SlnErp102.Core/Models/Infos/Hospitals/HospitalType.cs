namespace SlnErp102.Core.Models.Infos.Hospitals
{
    public class HospitalType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Hospital>? Hospitals { get; set; }

    }
}
