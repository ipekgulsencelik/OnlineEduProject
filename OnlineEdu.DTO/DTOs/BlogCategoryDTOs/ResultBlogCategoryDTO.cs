using OnlineEdu.DTO.DTOs.BlogDTOs;

namespace OnlineEdu.DTO.DTOs.BlogCategoryDTOs
{
    public class ResultBlogCategoryDTO
    {
        public int BlogCategoryID { get; set; }
        public string Name { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
        public List<ResultBlogDTO> Blogs { get; set; }
    }
}