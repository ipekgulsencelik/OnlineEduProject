namespace OnlineEdu.DTO.DTOs.SocialMediaDTOs
{
    public class UpdateSocialMediaDTO
    {
        public int SocialMediaID { get; set; }
        public string Icon { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}