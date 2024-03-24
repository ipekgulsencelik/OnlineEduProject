using OnlineEdu.DTO.DTOs.AboutDTOs;

namespace OnlineEdu.DTO.DTOs.FeatureDTOs
{
    public class ResultFeatureDTO
    {
        public int FeatureID { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public int AboutID { get; set; }
        public ResultAboutDTO About { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}
