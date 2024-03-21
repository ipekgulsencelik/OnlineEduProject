namespace OnlineEdu.Entity.Entities
{
    public class Banner
    {
        public int BannerID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }
        public bool IsHome { get; set; }
    }
}