namespace OnlineEdu.DTO.DTOs.BannerDTOs
{
    public class UpdateBannerDTO
    {
        public int BannerID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }
        public bool IsHome { get; set; }
    }
}