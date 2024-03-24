using OnlineEdu.DTO.DTOs.CategoryDTOs;

namespace OnlineEdu.DTO.DTOs.CourseDTOs
{
    public class ResultCourseDTO
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int CategoryID { get; set; }
        public ResultCategoryDTO Category { get; set; }
        public decimal Price { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
    }
}