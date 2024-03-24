namespace OnlineEdu.DTO.DTOs.BlogCategoryDTOs
{
    public class UpdateBlogCategoryDTO
    {
        public int BlogCategoryID { get; set; }
        public string Name { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}