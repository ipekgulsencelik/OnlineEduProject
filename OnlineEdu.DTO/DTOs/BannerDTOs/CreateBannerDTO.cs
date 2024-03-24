namespace OnlineEdu.DTO.DTOs.BannerDTOs
{
    public class CreateBannerDTO
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }
        public bool IsHome { get; set; }
    }
}