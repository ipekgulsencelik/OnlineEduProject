namespace OnlineEdu.DTO.DTOs.BlogDTOs
{
    public class UpdateBlogDTO
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public DateTime BlogDate { get; set; }
        public int BlogCategoryID { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}