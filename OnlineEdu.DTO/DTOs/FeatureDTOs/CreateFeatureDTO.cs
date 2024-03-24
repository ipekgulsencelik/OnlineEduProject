namespace OnlineEdu.DTO.DTOs.FeatureDTOs
{
    public class CreateFeatureDTO
    {
        public string Icon { get; set; }
        public string Description { get; set; }
        public int AboutID { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}