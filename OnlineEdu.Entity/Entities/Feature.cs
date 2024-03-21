namespace OnlineEdu.Entity.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public int AboutID { get; set; }
        public About About { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}