using OnlineEdu.DTO.DTOs.CourseDTOs;

namespace OnlineEdu.DTO.DTOs.CategoryDTOs
{
    public class ResultCategoryDTO
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsHome { get; set; }
        public bool Status { get; set; }
        public List<ResultCourseDTO> Courses { get; set; }
    }
}